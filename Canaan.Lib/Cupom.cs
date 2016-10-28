using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Cupom : IBase<Dados.Cupom>, IEnum<Dados.EnumCupomStatus>
    {
        #region PROPRIEDADES

        public TelemarketingMov LibTeleMov
        {
            get
            {
                return new TelemarketingMov();
            }
        }
        private bool salvarMovimentacao = false;
        private Dados.CanaanModelContainer db;

        #endregion

        #region CONSTRUTORES

        public Cupom()
        {

        }

        public Cupom(Dados.CanaanModelContainer db)
        {
            // TODO: Complete member initialization
            this.db = db;
        }

        #endregion

        #region VERIFICACAO DE CONDICAO

        public Dados.EnumTelemarketingStatus? VerificaCondicao(Dados.Cupom cupom)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    var cupomDup = GetDuplicados(cupom);
                    Dados.EnumTelemarketingStatus? status = null;

                    foreach (var item in cupomDup)
                    {
                        if (status != Dados.EnumTelemarketingStatus.Agendado)
                        {
                            if (item.IsAgendado.GetValueOrDefault())
                                status = Dados.EnumTelemarketingStatus.Agendado;
                            if (item.IsDescartado.GetValueOrDefault())
                                status = Dados.EnumTelemarketingStatus.Descartado;
                        }
                    }

                    return status;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Cupom UpdateCondicao(Dados.Cupom cupom, Dados.EnumTelemarketingStatus Status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                //verifica o tipo de movimentacao
                var cupomDup = GetDuplicados(cupom);

                //arruma registros da lista
                foreach (var item in cupomDup)
                {
                    var alterado = conn.Cupom.FirstOrDefault(a => a.IdCupom == item.IdCupom);

                    if (Status == Dados.EnumTelemarketingStatus.Descartado)
                    {
                        //descarta o cupom
                        if (alterado != null)
                        {
                            if (!item.IsAgendado.GetValueOrDefault())
                            {
                                alterado.IsLembrete = false;
                                alterado.DataLembrete = null;

                                alterado.IsAgendado = false;
                                alterado.DataAgendado = null;

                                alterado.IsDescartado = true;
                                if (alterado.DataDescartado == null)
                                    alterado.DataDescartado = DateTime.Now;

                                //remove da lista da tele
                                alterado.IdUsuarioTele = null;

                                alterado.Status = Dados.EnumCupomStatus.Descartado;
                            }
                        }
                    }
                    else
                    {
                        if (Status == Dados.EnumTelemarketingStatus.Agendado || Status == Dados.EnumTelemarketingStatus.Finalizado)
                        {
                            if (alterado != null)
                            {
                                if (item.IsAgendado.GetValueOrDefault())
                                {
                                    alterado.IsLembrete = false;
                                    alterado.DataLembrete = null;

                                    alterado.IsAgendado = true;
                                    if (alterado.DataAgendado == null)
                                        alterado.DataAgendado = DateTime.Now;

                                    alterado.IsDescartado = false;
                                    alterado.DataDescartado = null;

                                    alterado.IdUsuarioTele = null;

                                    alterado.Status = Dados.EnumCupomStatus.Agendado;
                                }
                                else
                                {
                                    //descarta
                                    alterado.IsLembrete = false;
                                    alterado.DataLembrete = null;

                                    alterado.IsAgendado = false;
                                    alterado.DataAgendado = null;

                                    alterado.IsDescartado = true;

                                    if (alterado.DataDescartado == null)
                                        alterado.DataDescartado = DateTime.Now;

                                    //remove da lista da tele
                                    alterado.IdUsuarioTele = null;

                                    alterado.Status = Dados.EnumCupomStatus.Descartado;
                                }
                            }
                        }
                    }

                    //salva as alteracoes do cupom
                    conn.SaveChanges();
                }

                //retorna
                return cupom;
            }

        }

        public Dados.Cupom RemoveCondicao(Dados.Cupom cupom)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var cupomDup = GetDuplicados(cupom);

                    foreach (var item in cupomDup)
                    {
                        //atualiza dados
                        item.IsAgendado = false;
                        item.DataAgendado = null;

                        item.IsDescartado = false;
                        item.DataDescartado = null;

                        item.IsLembrete = false;
                        item.DataLembrete = null;


                        //valida e salva
                        if (Validacao.IsValid(conn))
                        {
                            conn.SaveChanges();
                        }
                        else
                        {
                            throw new Exception(Validacao.GetErrors(conn));
                        }
                    }



                    //retorna
                    return GetById(cupom.IdCupom);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region INSERT / UPDATE / DELETE

        public Dados.Cupom Insert(Dados.Cupom item)
        {
            try
            {
                using (var conn = new Dados.CanaanModelContainer())
                {
                    item.Data = DateTime.Now;
                    item.DataPreenchimento = DateTime.Now;
                    item.IdUsuario = Lib.Session.Instance.Usuario.IdUsuario;
                    item.IsAgendado = false;
                    item.IsDescartado = false;
                    item.IsLembrete = false;
                    item.Usuario = null;

                    //salva no banco de dados
                    conn.Cupom.Add(item);
                    conn.SaveChanges();

                    //Salva movimentação
                    //SalvaMovimentacaoTele(item, item.IdStatusTele.GetValueOrDefault());
                    var verifica = VerificaCondicao(item);
                    if (verifica != null)
                    {
                        item = UpdateCondicao(item, verifica.GetValueOrDefault());
                    }

                    //retorna
                    return GetById(item.IdCupom);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Cupom Update(Dados.Cupom item)
        {
            try
            {
                using (var conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Cupom.FirstOrDefault(a => a.IdCupom == item.IdCupom);

                    int? idUsuarioTele = null;

                    //verifica se vai salvar movimentação
                    if (updated != null && updated.IdStatusTele != item.IdStatusTele)
                    {
                        idUsuarioTele = item.IdUsuarioTele;
                        salvarMovimentacao = true;
                    }

                    //atualiza dados
                    if (updated != null)
                    {
                        updated.IdCupom = item.IdCupom;
                        updated.IdParceria = item.IdParceria;
                        updated.Nome = item.Nome;
                        updated.Email = item.Email;
                        updated.Endereco = item.Endereco;
                        updated.Telefone = item.Telefone;
                        updated.Celular = item.Celular;
                        updated.Obs = item.Obs;
                        updated.Data = item.Data;
                        updated.IdUsuario = item.IdUsuario;
                        updated.DataPreenchimento = item.DataPreenchimento;
                        updated.Status = item.Status;
                        updated.IsAtivo = item.IsAtivo;
                        updated.UltimaUtilizacao = DateTime.Now;

                        //status do cupom
                        updated.IsAgendado = item.IsAgendado == null ? false : item.IsAgendado;
                        updated.DataAgendado = item.DataAgendado;

                        updated.IsLembrete = item.IsLembrete == null ? false : item.IsLembrete;
                        updated.DataLembrete = item.DataLembrete;

                        updated.IsDescartado = item.IsDescartado == null ? false : item.IsDescartado;
                        updated.DataDescartado = item.DataDescartado;

                        //Telemarketing
                        updated.IdStatusTele = item.IdStatusTele;
                        updated.DataTele = item.DataTele;
                        updated.IdUsuarioTele = item.IdUsuarioTele;


                        //valida e salva
                        if (Validacao.IsValid(conn))
                        {
                            conn.SaveChanges();

                            //verifica condicao do telefone
                            var verifica = VerificaCondicao(item);

                            if (verifica != null)
                            {
                                item = UpdateCondicao(item, verifica.GetValueOrDefault());
                            }

                            //Salvar Movimentação
                            if (salvarMovimentacao)
                                SalvaMovimentacaoTele(updated, updated.IdStatusTele.GetValueOrDefault(), idUsuarioTele);
                        }
                        else
                        {
                            throw new Exception(Validacao.GetErrors(conn));
                        }

                        //retorna
                        return GetById(updated.IdCupom);
                    }
                    else
                    {
                        throw new Exception("O objeto a ser atualizado não foi encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Cupom Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Cupom.FirstOrDefault(a => a.IdCupom == id);

                    //salva no banco de dados
                    conn.Cupom.Remove(deleted);
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

        public void DevolveCuponsExpirados()
        {
            var filial = Session.Instance.Contexto.IdFilial;
            var hoje = DateTime.Today;


            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Cupom.Where(a => a.DataTele < hoje && a.IsAgendado == false && a.IsDescartado == false && a.IsLembrete == false && a.IdUsuarioTele != null);

                foreach (var item in result)
                {
                    //verifica se cupom ja foi distribuido mais de 10x
                    if (conn.TelemarketingMov.Count(a => a.IdCupom == item.IdCupom && a.IdStatus == Dados.EnumTelemarketingStatus.Distribuido) > 10)
                    {
                        //salva a movimentacao de telemarketing
                        SalvaMovimentacaoTele(item, Dados.EnumTelemarketingStatus.Descartado, null);

                        //descarta o cupom
                        DescartaCupom(item);
                        //item.IdUsuarioTele = null;
                        //item.IdStatusTele = Dados.EnumTelemarketingStatus.Descartado;
                        //item.Status = Dados.EnumCupomStatus.Descartado;

                        //item.IsDescartado = true;
                        //item.DataDescartado = DateTime.Now;

                        //item.IsAgendado = false;
                        //item.DataAgendado = null;

                        //item.IsLembrete = false;
                        //item.DataLembrete = null;
                        
                        //OBS: essa rotina nao devolve os cupons descartados com numero igual. 
                        //o descarte é feito somente para nao ficar com material sujo
                    }
                    else
                    {
                        //expira o cupom
                        item.IdStatusTele = Dados.EnumTelemarketingStatus.Expirado;
                        item.IdUsuarioTele = null;

                        if (item.Status != Dados.EnumCupomStatus.Faltante)
                            item.Status = Dados.EnumCupomStatus.EmAberto;
                    }
                }

                conn.SaveChanges();
            }

        }

        public Dados.Cupom DescartaCupom(Dados.Cupom item, bool descartaRepetidos = true)
        {
            item.IdUsuarioTele = null;
            item.DataTele = null;
            item.IdStatusTele = Dados.EnumTelemarketingStatus.Descartado;
            item.Status = Dados.EnumCupomStatus.Descartado;

            item.IsDescartado = true;
            item.DataDescartado = DateTime.Now;

            item.IsAgendado = false;
            item.DataAgendado = null;

            item.IsLembrete = false;
            item.DataLembrete = null;

            if (descartaRepetidos == true)
                DescartaRepetidos(item);

            return item;
        }

        public void DescartaRepetidos(Dados.Cupom item) 
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                //pega cupons com mesmo telefone que nao foram expirados ne agendados
                var repetidos = GetDuplicados(item).Where(a => a.IsDescartado == false && a.IsAgendado == false && a.IdCupom != item.IdCupom).ToList();

                //faz loop descartando
                foreach (var cupom in repetidos) 
                {
                    //descarta o cupom
                    var atual = conn.Cupom.FirstOrDefault(a => a.IdCupom == cupom.IdCupom);
                    atual = DescartaCupom(atual, false);
                    Update(atual);
                }
            }
        }

        private void SalvaMovimentacaoTele(Dados.Cupom result, Dados.EnumTelemarketingStatus status, int? idUsuarioTele)
        {
            LibTeleMov.Insert(new Dados.TelemarketingMov
            {
                IdCupom = result.IdCupom,
                IdStatus = status,
                IdUsuario = idUsuarioTele,
                Data = DateTime.Now

            });
        }

        #endregion

        #region CONSULTAS

        public List<Dados.Cupom> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Cupom.Include(a => a.Parceria)
                                 .Include(a => a.Usuario)
                                 .Include(a => a.TelemarketingMov)
                                 .ToList();
            }
        }

        public List<Dados.Cupom> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Cupom.Include(a => a.Parceria)
                                 .Include(a => a.Usuario)
                                 .Include(a => a.TelemarketingMov)
                                 .Where(a => a.Nome.Contains(nome))
                                 .ToList();
            }
        }

        public List<Dados.Cupom> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Cupom.Include(a => a.Parceria)
                                 .Include(a => a.Usuario)
                                 .Include(a => a.TelemarketingMov)
                                 .Where(filtro, parameters)
                                 .ToList();
            }
        }

        public Dados.Cupom GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Cupom.Include(a => a.Parceria)
                                 .Include(a => a.Usuario)
                                 .Include(a => a.TelemarketingMov)
                                 .FirstOrDefault(a => a.IdCupom == id);
            }
        }

        public List<Dados.Cupom> GetByParceria(int idParceria)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {

                //return conn.Cupom.Where(a => a.IdParceria == idParceria && 
                //                             a.Status == Dados.EnumCupomStatus.EmAberto && 
                //                             (a.IdStatusTele == null || a.IdStatusTele == Dados.EnumTelemarketingStatus.Expirado)).ToList();
                return conn.Cupom.Where(a => a.IdParceria == idParceria &&
                                             a.IsDescartado == false &&
                                             a.IsAgendado == false &&
                                             a.IsLembrete == false &&
                                             a.IdUsuarioTele == null)
                                 .ToList();
            }
        }

        public Dictionary<int, string> GetValuesFromEnum()
        {
            return Enum.GetValues(typeof(Dados.EnumCupomStatus))
                       .Cast<Dados.EnumCupomStatus>()
                       .ToDictionary(e => (int)e, e => e.ToString());
        }

        public Dictionary<int, string> GetValuesFromEnum(string descricao)
        {
            return Enum.GetValues(typeof(Dados.EnumCupomStatus))
                       .Cast<Dados.EnumCupomStatus>()
                       .Where(e => e.ToString().Contains("descricao"))
                       .ToDictionary(e => (int)e, e => e.ToString());
        }

        public Dados.EnumCupomStatus GetEnumForKey(int key)
        {
            return (Dados.EnumCupomStatus)key;
        }

        public List<Dados.Cupom> GetByAtivo(bool status)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Cupom.Include(a => a.Parceria)
                                 .Include(a => a.Usuario)
                                 .Include(a => a.TelemarketingMov)
                                 .Where(a => a.IsAtivo == status && a.Status != (Dados.EnumCupomStatus.Descartado | Dados.EnumCupomStatus.Cancelado | Dados.EnumCupomStatus.Faltante))
                                 .ToList();
            }
        }

        public List<Dados.Cupom> GetByAtivo(int idParceria, bool status)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Cupom.Include(a => a.Parceria)
                                     .Include(a => a.Usuario)
                                     .Include(a => a.TelemarketingMov)
                                     .Where(a => a.IsAtivo == status && a.Status != (Dados.EnumCupomStatus.Descartado | Dados.EnumCupomStatus.Cancelado | Dados.EnumCupomStatus.Faltante) && a.IdParceria == idParceria)
                                     .ToList();
            }
        }

        public List<Dados.Cupom> GetByTel(string tel)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var tamanho = tel.Length;
                if (tamanho > 8)
                {
                    var indice = tamanho - 8;
                    tel = tel.Substring(indice);
                }

                //return conn.Cupom.Include(a => a.Parceria).Where(a => (a.Telefone == tel || a.Celular == tel) && a.Status == Dados.EnumCupomStatus.EmAberto).ToList();
                return conn.Cupom.Include(a => a.Parceria).Where(a => (a.Telefone.Contains(tel) || a.Celular.Contains(tel))).ToList();
            }
        }

        public List<Dados.Cupom> GetDuplicados(Dados.Cupom cupom)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                //verifica o tipo de movimentacao
                var cupomDup = new List<Dados.Cupom>();

                //adiciona cupom atual na lista
                cupomDup.Add(cupom);

                //verifica se telefone é nulo e inclui na lista itens repetidos
                if (!string.IsNullOrEmpty(cupom.Telefone))
                {
                    foreach (var item in GetByTel(cupom.Telefone.Trim()))
                    {
                        if (cupomDup.Where(a => a.IdCupom == item.IdCupom).Count() == 0)
                            cupomDup.Add(item);
                    }
                }

                //verifica se celular é nulo e inclui na lista itens repetidos
                if (!string.IsNullOrEmpty(cupom.Celular))
                {
                    foreach (var item in GetByTel(cupom.Celular.Trim()))
                    {
                        if (cupomDup.Where(a => a.IdCupom == item.IdCupom).Count() == 0)
                            cupomDup.Add(item);
                    }
                }

                return cupomDup;
            }
        }

        public List<Dados.Cupom> GetByUsuario(int userId, int idFilial)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var hoje = DateTime.Today;

                return conn.Cupom.Include(a => a.UsuarioTele)
                                 .Include(a => a.Parceria)
                                 .Include(a => a.Usuario)
                                 .Include(a => a.TelemarketingStatus)
                                 .Include(a => a.TelemarketingMov)
                                 .Where(a => a.IdUsuarioTele == userId &&
                                            (a.Status == Dados.EnumCupomStatus.Faltante || a.Status == Dados.EnumCupomStatus.EmAberto || a.Status == Dados.EnumCupomStatus.NaoAtende || a.Status == Dados.EnumCupomStatus.Desligado) &&
                                             a.IdStatusTele == Dados.EnumTelemarketingStatus.Distribuido &&
                                             a.IsDescartado == false &&
                                             a.IsAgendado == false &&
                                             !a.TelemarketingAgenda.Any(c => c.Ativo && c.IdCupom == a.IdCupom) &&
                                              a.Parceria.IdFilial == idFilial)
                                 .ToList();
            }
        }

        public List<Dados.Cupom> GetByStatusFilial(bool status, int take, int idFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Cupom.Include(a => a.Parceria)
                                     .Include(a => a.Usuario)
                                     .Where(a => a.IsAtivo == status &&
                                                 a.Status != (Dados.EnumCupomStatus.Descartado | Dados.EnumCupomStatus.Cancelado | Dados.EnumCupomStatus.Faltante) &&
                                                 a.Parceria.IdFilial == idFilial)
                                     .Take(take)
                                     .ToList();
            }
        }

        public List<Dados.Cupom> GetCuponsExpirados(int idFilial)
        {
            var hoje = DateTime.Today;

            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Cupom.Where(a => a.DataTele < hoje && a.IsAgendado == false && a.IsDescartado == false && a.IsLembrete == false && a.IdUsuarioTele != null).ToList();
            }
        }

        public List<Dados.Cupom> GetCuponsExpiradosContext(int idFilial)
        {
            var hoje = DateTime.Today;
            return db.Cupom.Where(a => a.DataTele < hoje && a.IsAgendado == false && a.IsDescartado == false && a.IsLembrete == false && a.IdUsuarioTele != null).ToList();
        }

        public IEnumerable<Dados.Cupom> GetFaltantesByParceria(int idParceria)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Cupom
                           .Where(a => a.IdParceria == idParceria && 
                                       a.Status == Dados.EnumCupomStatus.Faltante && 
                                      (a.IdStatusTele == Dados.EnumTelemarketingStatus.Expirado || 
                                       a.IdStatusTele == Dados.EnumTelemarketingStatus.Faltante || a.IdStatusTele == null))
                           .OrderByDescending(a => a.UltimaUtilizacao)
                           .ToList();
            }
        }

        public bool ValidaCupom(string telefone, string celular)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var lista = new List<Dados.Cupom>();
                var dataLimite = DateTime.Today.AddYears(-2);

                //verifica telefone
                if (!string.IsNullOrEmpty(telefone))
                {
                    var listaTel = conn.Cupom.Include(a => a.Parceria).Where(a => (a.Telefone == telefone || a.Celular == telefone));

                    //verifica data limite dos registro encontrados
                    foreach (var tel in listaTel)
                    {
                        if (tel.Data >= dataLimite)
                            lista.Add(tel);
                    }
                }

                if (!string.IsNullOrEmpty(celular))
                {
                    var listaCel = conn.Cupom.Include(a => a.Parceria).Where(a => (a.Telefone == celular || a.Celular == celular));

                    //verifica data limite dos registro encontrados
                    foreach (var cel in listaCel)
                    {
                        if (cel.Data >= dataLimite)
                            lista.Add(cel);
                    }
                }

                //retorna validacao
                if (lista.Count == 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Retorna quem indicou este cupom
        /// </summary>
        /// <param name="idCupom"></param>
        /// <returns></returns>
        public string GetIndicador(int idCupom)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Indicacao.FirstOrDefault(a => a.IdCupom == idCupom);

                if (result != null)
                    return result.Atendimento.CliFor.Nome;
                else
                    return "Não foi indicado por nenhum cliente";
            }
        }

        #endregion
        
        public bool ValidacaoCupomTel(Dados.Cupom currentItem)
        {
            var telefone = currentItem.Telefone != null ? currentItem.Telefone.Trim() : string.Empty;
            var celular = currentItem.Celular != null ? currentItem.Celular.Trim() : string.Empty;

            if (!string.IsNullOrWhiteSpace(telefone) || !string.IsNullOrWhiteSpace(celular))
                return true;
            else
                return false;
        }

        public dynamic CarregaGrid(List<Dados.Cupom> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdCupom,
                Nome = a.Nome,
                DataPreenchimento = a.DataPreenchimento,
                Telefone = a.Telefone,
                Celular = a.Celular,
                Parceria = a.Parceria.Nome,
                Usuario = a.Usuario.Nome,
                Data = a.TelemarketingMov.OrderByDescending(b => b.IdTelemarketingMov).FirstOrDefault() == null ? DateTime.Today : a.TelemarketingMov.OrderByDescending(b => b.IdTelemarketingMov).FirstOrDefault().Data,
                Observacao = a.Obs,
                Status = (Dados.EnumCupomStatus)a.Status
            }).ToList();
        }

    }
}
