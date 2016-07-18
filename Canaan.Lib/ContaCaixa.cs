using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class ContaCaixa : IBase<Dados.ContaCaixa>
    {
        public List<Dados.ContaCaixa> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ContaCaixa
                           .Include(a => a.Filial)
                           .Include(a => a.Conta)
                           .ToList();
            }
        }

        public List<Dados.ContaCaixa> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ContaCaixa
                           .Include(a => a.Filial)
                           .Include(a => a.Conta)
                           .Where(a => a.Nome.Contains(nome))
                           .ToList();
            }
        }

        public List<Dados.ContaCaixa> GetByFilial(int idFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ContaCaixa
                           .Include(a => a.Filial)
                           .Include(a => a.Conta)
                           .Where(a => a.IdFilial == idFilial)
                           .ToList();
            }
        }

        public List<Dados.ContaCaixa> GetByConta(int idConta)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ContaCaixa
                           .Include(a => a.Filial)
                           .Include(a => a.Conta)
                           .Where(a => a.IdConta == idConta)
                           .ToList();
            }
        }

        public List<Dados.ContaCaixa> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ContaCaixa.Where(filtro, parameters).ToList();
            }
        }

        public Dados.ContaCaixa GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ContaCaixa
                           .Include(a => a.Filial)
                           .Include(a => a.Conta)
                           .FirstOrDefault(a => a.IdContaCaixa == id);
            }
        }

        public Dados.ContaCaixa Insert(Dados.ContaCaixa item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.ContaCaixa.Add(item);

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
                    return GetById(item.IdContaCaixa);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.ContaCaixa Update(Dados.ContaCaixa item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.ContaCaixa.FirstOrDefault(a => a.IdContaCaixa == item.IdContaCaixa);

                    //atualiza dados
                    updated.IdFilial = item.IdFilial;
                    updated.IdConta = item.IdConta;
                    updated.Nome = item.Nome;
                    updated.IsCaixa = item.IsCaixa;
                    updated.IsPadrao = item.IsPadrao;
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
                    return GetById(updated.IdContaCaixa);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.ContaCaixa Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.ContaCaixa.FirstOrDefault(a => a.IdContaCaixa == id);

                    //salva no banco de dados
                    conn.ContaCaixa.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.ContaCaixa> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.IdContaCaixa,
                    Nome = a.Nome,
                    Filial = a.Filial.NomeFantasia,
                    Conta = a.Conta.Nome,
                    Caixa = a.IsCaixa,
                    Padrao = a.IsPadrao,
                    Ativo = a.IsAtivo
                })
                .ToList();
            }
            else
            {
                return null;
            }
        }

        public Dados.ContaCaixa GetPadraoFilial(int idFilial)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ContaCaixa
                           .Include(a => a.Filial)
                           .Include(a => a.Conta)
                           .FirstOrDefault(a => a.IdFilial == idFilial && a.IsPadrao);
            }
        }
    }
}
