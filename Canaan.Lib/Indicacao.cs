using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class Indicacao : IBase<Dados.Indicacao>
    {
        public List<Dados.Indicacao> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.Indicacao> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Indicacao> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Indicacao GetById(int id){
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Indicacao.FirstOrDefault(a => a.idIndicacao == id);
            }
        }

        public Dados.Indicacao Insert(Dados.Indicacao item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Indicacao.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.idIndicacao);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Indicacao Update(Dados.Indicacao item)
        {
            throw new NotImplementedException();
        }

        public Dados.Indicacao Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Indicacao.FirstOrDefault(a => a.idIndicacao == id);

                    //salva no banco de dados
                    conn.Indicacao.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Indicacao> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.idIndicacao,
                CupomId = a.Cupom.IdCupom,
                Nome = a.Cupom.Nome,
                Telefone = a.Cupom.Telefone,
                Celular = a.Cupom.Celular,
                Email = a.Cupom.Email,
                Promocao = a.Cupom.Parceria.Nome,
                Cupom = a.Cupom.Status
            }).OrderBy(a => a.Promocao).ToList();
        }

        public List<Dados.Indicacao> GetByAtendimento(int idIndicacao)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Indicacao.Include(a => a.Cupom)
                                     .Include(a => a.Cupom.Parceria)
                                     .Include(a => a.Cupom.Parceria.Convenio)
                                     .Where(a => a.IdAtendimento == idIndicacao)
                                     .ToList();
            }
        }

        public Dados.Indicacao GetByCupom(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Indicacao.Include(a => a.Atendimento)
                                     .Include(a => a.Atendimento.CliFor)
                                     .FirstOrDefault(a => a.IdCupom == id);
            }
        }

        public int GetIndicadosAtendidos(int idAtendimento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var result = conn.Indicacao.Include(a => a.Cupom).Where(a => a.IdAtendimento == idAtendimento && a.Cupom.Agendamento.Any(b => b.Atendimento.Count > 0)).ToList();
                return result.Count;
            }
        }
    }
}
