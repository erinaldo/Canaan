using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class OrdemServico : IBase<Dados.OrdemServico>
    {
        #region PROPRIEDADES

        public OrdemServicoMov LibServicoMov
        {
            get
            {
                return new OrdemServicoMov();
            }
        }

        #endregion

        public List<Dados.OrdemServico> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServico.ToList();
            }
        }

        public List<Dados.OrdemServico> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServico.Where(a => a.Observacao.Contains(nome)).ToList();
            }
        }

        public List<Model.OrdermServico> GetModelByVenda(int idVenda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServico.Include(a => a.Moldura)
                                                 .Include(a => a.Album)
                                                 .Include(a => a.OrdemServicoItem)
                                                 .Include(a => a.OrdemServicoMov)
                .Where(a => a.IdPedido == idVenda).ToList().Select(a => new Model.OrdermServico
                {
                    Status = a.OrdemServicoItem.Count > 0 ? Properties.Resources.Security_Shields_Complete_and_ok_16xLG_color : Properties.Resources.Security_Shields_Critical_16xLG,
                    Codigo = a.IdOrdemServico,
                    IdServico = a.Servico.IdServico,
                    IdVenda = a.IdPedido,
                    Servico = a.Servico.Nome,
                    Album = a.Album == null ? "Nenhum" : a.Album.Nome,
                    Moldura = a.Moldura == null ? "Nenhum" : a.Moldura.Nome,
                    Fotos = a.OrdemServicoItem.Count,
                    StatusItem = a.OrdemServicoMov.Count == 0 ? "Não Definido" : new OrdemServicoMov().GetById(a.OrdemServicoMov.LastOrDefault().IdMov).OrdemStatus.Descricao
                }).ToList();
            }
        }

        public List<Model.OrdermServico> GetModelByVendaProdutos(int idVenda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaItemOrdemServico.Include(a => a.OrdemServico.Moldura)
                                                 .Include(a => a.OrdemServico.Album)
                                                 .Include(a => a.OrdemServico.OrdemServicoItem)
                .Where(a => a.OrdemServico.IdPedido == idVenda).ToList().Select(a => new Model.OrdermServico
                {
                    Status = a.OrdemServico.OrdemServicoItem.Count > 0 ? Properties.Resources.Security_Shields_Complete_and_ok_16xLG_color : Properties.Resources.Security_Shields_Critical_16xLG,
                    Codigo = a.IdOrdemServico,
                    IdProduto = a.VendaItem.IdProduto,
                    IdServico = a.OrdemServico.Servico.IdServico,
                    IdVenda = a.OrdemServico.IdPedido,
                    Servico = a.OrdemServico.Servico.Nome,
                    Album = a.OrdemServico.Album == null ? "Nenhum" : a.OrdemServico.Album.Nome,
                    Moldura = a.OrdemServico.Moldura == null ? "Nenhum" : a.OrdemServico.Moldura.Nome,
                    Fotos = a.OrdemServico.OrdemServicoItem.Count
                }).ToList();
            }
        }

        public List<Dados.OrdemServico> GetByVenda(int idVenda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServico
                           .Include(a => a.Album)
                           .Include(a => a.Moldura)
                           .Include(a => a.Servico)
                           .Where(a => a.IdPedido == idVenda).ToList();
            }
        }

        public List<Dados.OrdemServico> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.OrdemServico GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServico.Include(a => a.Servico).FirstOrDefault(a => a.IdOrdemServico == id);
            }
        }

        public Dados.OrdemServico Insert(Dados.OrdemServico item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.OrdemServico.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //Adicionar Movimentação
                        AdicionarMov(item);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdOrdemServico);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.OrdemServico Update(Dados.OrdemServico item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.OrdemServico
                                      .FirstOrDefault(a => a.IdOrdemServico == item.IdOrdemServico);


                    updated.IdOrdemServico = item.IdOrdemServico;
                    updated.IdPedido = item.IdPedido;
                    updated.IdServico = item.IdServico;
                    updated.IdAlbum = item.IdAlbum;
                    updated.IdMoldura = item.IdMoldura;
                    updated.NomeAbertura = item.NomeAbertura;
                    updated.Data = item.Data;
                    updated.DataPrevista = item.DataPrevista;
                    updated.Observacao = item.Observacao;
                    updated.Status = item.Status;


                    //validaupdated.imal Custo {  e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //Adiciona Movimentação
                        if (item.Status != Dados.EnumStatusServico.AguardandoLiberacao)
                            AdicionarMov(item);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(updated.IdOrdemServico);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.OrdemServico Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.OrdemServico.FirstOrDefault(a => a.IdOrdemServico == id);

                    //salva no banco de dados
                    conn.OrdemServico.Remove(deleted);
                    conn.SaveChanges();

                    //retorna
                    return deleted;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public dynamic CarregaGrid(List<Dados.OrdemServico> lista)
        {
            throw new NotImplementedException();
        }

        public List<Dados.OrdemServico> GetByVendaItem(int idVendaItem)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.OrdemServico.Where(a => a.VendaItemOrdemServico.Any(b => b.IdItem == idVendaItem))
                                              .ToList();
                return result;
            }
        }

        public List<Model.OrdermServico> GetByVendaItemInModel(int IdVenda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServico.Where(a => a.IdPedido == IdVenda).ToList().Select(a => new Model.OrdermServico
                {
                    Status = a.OrdemServicoItem.Count > 0 ? Properties.Resources.Security_Shields_Complete_and_ok_16xLG_color : Properties.Resources.Security_Shields_Critical_16xLG,
                    Codigo = a.IdOrdemServico,
                    IdServico = a.Servico.IdServico,
                    IdVenda = a.IdPedido,
                    Album = a.Album == null ? "Nenhum" : a.Album.Nome,
                    Moldura = a.Moldura == null ? "Nenhum" : a.Moldura.Nome,
                    Fotos = a.OrdemServicoItem.Count,
                    Servico = a.Servico.Nome
                }).ToList();
            }
        }

        /// <summary>
        /// Verifica se em uma lista de ordens ja existe envelopes criados
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool CanDelete(List<Dados.OrdemServico> list)
        {
            var ids = list.Select(a => a.IdOrdemServico).ToArray();

            using (var conn = new Dados.CanaanModelContainer())
            {
                if (list.Count <= 0)
                    return true;

                var boolean = conn.OrdemServico.Any(a => ids.Contains(a.IdOrdemServico) && a.OrdemServicoItem.Count <= 0);
                return boolean;
            }
        }

        /// <summary>
        /// Verifica se uma venda item especifica pode ter sua ordem de serviço deletada
        /// </summary>
        /// <param name="idItem"></param>
        /// <returns></returns>
        public bool CanDelete(int idItem)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.VendaItem.Any(a => a.Produto.ProdutoServico.Count <= 0 && a.IdItem == idItem);
                return result;
            }
        }

        /// <summary>
        /// Verifica se existe envelope criado para uma ordem de serviço
        /// </summary>
        /// <param name="ordermServico"></param>
        /// <returns></returns>
        public bool ExisteEnvelope(Model.OrdermServico ordermServico)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.OrdemServico.Any(a => a.OrdemServicoItem.Count > 0 && a.IdOrdemServico == ordermServico.Codigo);
            }
        }

        public void DeleteByVendaItem(int idVendaItem)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.OrdemServico.Where(a => a.VendaItemOrdemServico.Any(b => b.IdItem == idVendaItem)).ToList();

                    foreach (var item in deleted)
                    {
                        conn.OrdemServico.Remove(item);
                    }

                    conn.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region UTILITARIO

        private void AdicionarMov(Dados.OrdemServico item)
        {
            var mov = new Dados.OrdemServicoMov
            {
                Data = DateTime.Now,
                IdOrdemServico = item.IdOrdemServico,
                IdUsuario = Session.Instance.Usuario == null ? 19 : Session.Instance.Usuario.IdUsuario,
                Status = item.Status
            };


            LibServicoMov.Insert(mov);
        }

        #endregion

    }
}
