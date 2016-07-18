using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class AtendimentoModelo : IBase<Dados.AtendimentoModelo>
    {
        public AtendimentoHist LibAtendimentoHist 
        {
            get
            {
                return new AtendimentoHist();
            }
        }

        public Modelo LibModelo 
        {
            get
            {
                return new Modelo();
            }
        }

        public List<Dados.AtendimentoModelo> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.AtendimentoModelo> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.AtendimentoModelo> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.AtendimentoModelo GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.AtendimentoModelo.FirstOrDefault(a => a.IdAtendimentoModelo == id);
            }
        }

        public List<Dados.AtendimentoModelo> GetByAtendimento(int idAtendimento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.AtendimentoModelo.Where(a => a.IdAtendimento == idAtendimento).ToList();
            }
        }

        public List<Dados.AtendimentoModelo> GetByCodigoReduzido(int codigoReduzido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.AtendimentoModelo.Include(a => a.Modelo).Where(a => a.Atendimento.CodigoReduzido == codigoReduzido).ToList();
            }
        }

        public Dados.AtendimentoModelo Insert(Dados.AtendimentoModelo item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.AtendimentoModelo.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //Adiciona Historico
                        AdicionarHistorico(item, Utilitarios.EnumTipoMov.Insert);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdAtendimento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.AtendimentoModelo Update(Dados.AtendimentoModelo item)
        {
            throw new NotImplementedException();
        }

        public Dados.AtendimentoModelo Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.AtendimentoModelo> lista)
        {
           throw new NotImplementedException();
        }

        public void DeleteAllModelosAtendimento(int idAtendimento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.AtendimentoModelo.Where(a => a.IdAtendimento == idAtendimento).ToList();

                foreach (var item in result)
                {
                    conn.AtendimentoModelo.Remove(item);
                }

                conn.SaveChanges();

                //Adiciona historico
                foreach (var item in result)
                {
                    AdicionarHistorico(item, Utilitarios.EnumTipoMov.Delete);    
                }
            }
        }

        #region UTILITARIO

        private void AdicionarHistorico(Dados.AtendimentoModelo item, Utilitarios.EnumTipoMov enumTipoMov)
        {
            var his = new Dados.AtendimentoHist
            {
                IdAtendimento = item.IdAtendimento,
                IdUsuario = Session.Instance.Usuario.IdUsuario,
                Data = DateTime.Now,
            };

            var modelo = LibModelo.GetById(item.IdModelo);
            var nomeModelo = modelo.NomeCompleto;

            switch (enumTipoMov)
            {
                case Utilitarios.EnumTipoMov.Insert:
                    his.Observacao = string.Format("Modelo adicionado com sucesso ao atendimento {0}: Modelo -> {1} ", item.IdAtendimento, nomeModelo);
                    break;
                case Utilitarios.EnumTipoMov.Update:
                    his.Observacao = string.Format("Modelo do atendimento {0} atualizado com sucesso: Modelo -> {1} ", item.IdAtendimento, nomeModelo);
                    break;
                case Utilitarios.EnumTipoMov.Delete:
                    his.Observacao = string.Format("Modelo do atendimento {0} deletado com sucesso: Modelo -> {1}", item.IdAtendimento, nomeModelo);
                    break;
                default:
                    his.Observacao = string.Format("Modelo adicionado com sucesso ao atendimento {0}: Modelo -> {1} ", item.IdAtendimento, nomeModelo);
                    break;
            }

            LibAtendimentoHist.Insert(his);
        }

        #endregion

    }
}
