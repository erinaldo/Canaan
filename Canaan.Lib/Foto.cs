using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;
using System.IO;
using System.Drawing;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class Foto : IBase<Dados.Foto>
    {

        #region PROPRIEDADES

        public AtendimentoHist LibAtendimentoHist
        {
            get
            {
                return new AtendimentoHist();
            }
        }

        #endregion

        public List<Dados.Foto> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Foto.ToList();
            }
        }

        public List<Dados.Foto> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Foto.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.Foto> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Foto.Where(filtro, parameters).ToList();
            }
        }

        public Dados.Foto GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Foto.Include(a => a.Sessao).FirstOrDefault(a => a.IdFoto == id);
            }
        }

        public List<Dados.Foto> GetBySessao(int idSessao)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Foto.Include(a => a.Sessao).Where(a => a.IdSessao == idSessao).ToList();
            }
        }

        public Dados.Foto Insert(Dados.Foto item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Foto.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //Adiciona Historico
                        AdicionarHistorico(GetById(item.IdFoto), Utilitarios.EnumTipoMov.Insert);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdFoto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Foto Update(Dados.Foto item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Foto.FirstOrDefault(a => a.IdFoto == item.IdFoto);

                    //atualiza dados
                    updated.IdFoto = item.IdFoto;
                    updated.IdSessao = item.IdSessao;
                    updated.Nome = item.Nome;
                    updated.Url = item.Url;
                    updated.Tamanho = item.Tamanho;
                    updated.MimeType = item.MimeType;
                    updated.IsAtivo = item.IsAtivo;
                    updated.Hora = item.Hora;

                    conn.SaveChanges();

                    //Adiciona Histórico
                    AdicionarHistorico(updated, Utilitarios.EnumTipoMov.Update);

                    //retorna
                    return GetById(updated.IdFoto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Foto Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Foto.Include(a => a.Sessao).FirstOrDefault(a => a.IdFoto == id);
                    var Sessao = conn.Sessao.FirstOrDefault(a => a.IdSessao == deleted.IdSessao);

                    //salva no banco de dados
                    conn.Foto.Remove(deleted);
                    conn.SaveChanges();

                    deleted.Sessao = Sessao;

                    //Adiciona Historico
                    AdicionarHistorico(deleted, Utilitarios.EnumTipoMov.Delete);

                    //retorna
                    return deleted;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public dynamic CarregaGrid(List<Dados.Foto> lista)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Foto> GetByVenda(int idVenda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Foto.Include(a => a.Sessao)
                                .Include(a => a.Sessao.Atendimento)
                                .Where(a => a.VendaFoto.Any(b => b.IdPedido == idVenda)).ToList();
            }
        }

        public void CarregaImagensVenda(System.ComponentModel.BindingList<Dados.Foto> fotos, System.Windows.Forms.ImageList imgList, Dados.Config config, int idSessao)
        {
            try
            {
                //Limpa compenentes
                imgList.Images.Clear();

                List<MemoryStream> Fotos = new List<MemoryStream>();

                var Sessao = new Sessao().GetById(idSessao);
                var direBase = string.Format(@"\\{0}\{1}\{2}-{3}", config.ServImagem, config.Folder, Sessao.Atendimento.CodigoReduzido, Sessao.NumSessao);

                if (!Directory.Exists(direBase))
                {
                    Fotos = fotos.Select(a => new MemoryStream(Utilitarios.ImageUtility.GetBytesFromResource(Properties.Resources.no_image))).ToList();
                    imgList.Images.AddRange(Fotos.Select(a => Image.FromStream(a)).ToArray());
                }
                else
                {

                    foreach (var item in fotos)
                    {
                        var file = string.Format(@"\\{0}\{1}\{2}", config.ServImagem, config.Folder, item.Thumb);
                        var fileCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", config.ServImagem, config.Folder, item.Thumb.Split('.').FirstOrDefault());

                        if (File.Exists(file))
                        {
                            Fotos.Add(new MemoryStream(Utilitarios.ImageUtility.VerificaCriptografia(item, file)));
                        }
                        else if (File.Exists(fileCanaan))
                        {
                            Fotos.Add(new MemoryStream(Utilitarios.ImageUtility.VerificaCriptografia(item, fileCanaan)));
                        }
                        else
                        {
                            Fotos.Add(new MemoryStream(Utilitarios.ImageUtility.GetBytesFromResource(Properties.Resources.no_image)));
                        }

                    }

                    imgList.Images.AddRange(Fotos.Select(a => Image.FromStream(a)).ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        public void CarregaImagensItemEnvelope(System.ComponentModel.BindingList<Dados.Foto> fotos, System.Windows.Forms.ImageList imgList, Dados.Config config)
        {
            try
            {
                //Limpa compenentes
                imgList.Images.Clear();

                List<MemoryStream> Fotos = new List<MemoryStream>();

                foreach (var item in fotos)
                {
                    var file = string.Format(@"\\{0}\{1}\{2}", config.ServImagem, config.Folder, item.Thumb);
                    var fileCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", config.ServImagem, config.Folder, item.Thumb.Split('.').FirstOrDefault());

                    if (File.Exists(file))
                    {
                        Fotos.Add(new MemoryStream(Utilitarios.ImageUtility.VerificaCriptografia(item, file)));
                    }
                    else if (File.Exists(fileCanaan))
                    {
                        Fotos.Add(new MemoryStream(Utilitarios.ImageUtility.VerificaCriptografia(item, fileCanaan)));
                    }
                    else
                    {
                        Fotos.Add(new MemoryStream(Utilitarios.ImageUtility.GetBytesFromResource(Properties.Resources.no_image)));
                    }
                }


                imgList.Images.AddRange(Fotos.Select(a => Image.FromStream(a)).ToArray());
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        public List<Dados.OrdemServicoItem> GetByOrdemServico(int idOrdemServico)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServicoItem.Include(a => a.Foto)
                           .Include(a => a.Foto.Sessao)
                           .Include(a => a.Foto.Sessao.Atendimento)
                           .Include(a => a.Foto.OrdemServicoItem)
                           .Where(a => a.IdOrdemServico == idOrdemServico)
                           .ToList();
            }
        }

        public Image GetImageById(int idFoto, Dados.Config config)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {

                var foto = conn.Foto.FirstOrDefault(a => a.IdFoto == idFoto);

                var file = string.Format(@"\\{0}\{1}\{2}", config.ServImagem, config.Folder, foto.Thumb);
                var fileCanaan = string.Format(@"\\{0}\{1}\{2}.canaan", config.ServImagem, config.Folder, foto.Thumb.Split('.').FirstOrDefault());

                if (File.Exists(file))
                {
                    return Image.FromStream(new MemoryStream(Utilitarios.ImageUtility.VerificaCriptografia(foto, file)));
                }
                else if (File.Exists(fileCanaan))
                {
                    return Image.FromStream(new MemoryStream(Utilitarios.ImageUtility.VerificaCriptografia(foto, fileCanaan)));
                }
                else
                {
                    return Image.FromStream(new MemoryStream(Utilitarios.ImageUtility.GetBytesFromResource(Properties.Resources.no_image)));
                }

                //var Foto = conn.Foto.Where(a => a.IdFoto == idFoto)
                //                    .ToList()
                //                    .Select(a => new MemoryStream(Lib.Utilitarios.ImageUtility.VerificaCriptografia(a, string.Format(@"\\{0}\{1}\{2}", config.ServImagem, config.Folder, a.Thumb))))
                //                    .FirstOrDefault();

                //return;
            }
        }

        #region UTILITARIO

        private void AdicionarHistorico(Dados.Foto item, Utilitarios.EnumTipoMov enumTipoMov)
        {
            var his = new Dados.AtendimentoHist
            {
                IdAtendimento = item.Sessao.IdAtendimento,
                IdUsuario = Session.Instance.Usuario.IdUsuario,
                Data = DateTime.Now,
            };

            switch (enumTipoMov)
            {
                case Utilitarios.EnumTipoMov.Insert:
                    his.Observacao = string.Format("Imagem {0} adicionada com sucesso à sessão {1} do atendimento {2}", item.IdFoto, item.Sessao.IdSessao, item.Sessao.IdAtendimento);
                    break;
                case Utilitarios.EnumTipoMov.Update:
                    his.Observacao = string.Format("Imagem {0} atualizada com sucesso na sessão {1} do atendimento {2}", item.IdFoto, item.Sessao.IdSessao, item.Sessao.IdAtendimento);
                    break;
                case Utilitarios.EnumTipoMov.Delete:
                    his.Observacao = string.Format("Imagem {0} removida com sucesso na sessão {1} do atendimento {2}", item.IdFoto, item.Sessao.IdSessao, item.Sessao.IdAtendimento);
                    break;
                default:
                    his.Observacao = string.Format("Imagem {0} adicionada com sucesso à sessão {1} do atendimento {2}", item.IdFoto, item.Sessao.IdSessao, item.Sessao.IdAtendimento);
                    break;
            }

            LibAtendimentoHist.Insert(his);

        }

        #endregion


    }
}
