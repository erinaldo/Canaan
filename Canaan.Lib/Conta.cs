using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Conta : IBase<Dados.Conta>
    {
        public List<Dados.Conta> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Conta
                           .Include(a => a.Agencia)
                           .ToList();
            }
        }

        public List<Dados.Conta> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Conta
                           .Include(a => a.Agencia)
                           .Where(a => a.Nome.Contains(nome))
                           .ToList();
            }
        }

        public List<Dados.Conta> GetByAgencia(int idAgencia)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Conta
                           .Include(a => a.Agencia)
                           .Where(a => a.IdAgencia == idAgencia)
                           .ToList();
            }
        }

        public List<Dados.Conta> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Conta.Where(filtro, parameters).ToList();
            }
        }

        public Dados.Conta GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Conta
                           .Include(a => a.Agencia)
                           .FirstOrDefault(a => a.IdConta == id);
            }
        }

        public Dados.Conta Insert(Dados.Conta item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Conta.Add(item);

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
                    return GetById(item.IdConta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Conta Update(Dados.Conta item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Conta.FirstOrDefault(a => a.IdConta == item.IdConta);

                    //atualiza dados
                    updated.IdAgencia = item.IdAgencia;
                    updated.Nome = item.Nome;
                    updated.ContaNumero = item.ContaNumero;
                    updated.ContaDigito = item.ContaDigito;
                    updated.CarteiraNumero = item.CarteiraNumero;
                    updated.CarteiraDigito = item.CarteiraDigito;
                    updated.CedenteNome = item.CedenteNome;
                    updated.CedenteCnjp = item.CedenteCnjp;
                    updated.CedenteNumero = item.CedenteNumero;
                    updated.CedenteDigito = item.CedenteDigito;
                    updated.ConvenioNumero = item.ConvenioNumero;
                    updated.ConvenioDigito = item.ConvenioDigito;
                    updated.TipoConta = item.TipoConta;
                    updated.TipoCobranca = item.TipoCobranca;
                    updated.IsAtivo = item.IsAtivo;

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
                    return GetById(updated.IdConta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Conta Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Conta.FirstOrDefault(a => a.IdConta == id);

                    //salva no banco de dados
                    conn.Conta.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Conta> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.IdConta,
                    Nome = a.Nome,
                    Banco = new Banco().GetById(a.Agencia.IdBanco).Nome,
                    Agencia = a.Agencia.Nome,
                    Conta = string.Format("{0}-{1}", a.ContaNumero, a.ContaDigito),
                    Ativo = a.IsAtivo
                })
                .ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
