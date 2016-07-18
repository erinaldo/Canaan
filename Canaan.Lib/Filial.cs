using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class Filial : IBase<Dados.Filial>
    {
        public List<Dados.Filial> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filial
                           .Include(a => a.Cidade)
                           .Include(a => a.Config)
                           .ToList();
            }
        }

        public List<Dados.Filial> GetByGrupo(int idgrupoempresa)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filial
                           .Include(a => a.Cidade)
                           .Include(a => a.Config)
                           .Where(a => a.IdGrupoEmpresa == idgrupoempresa)
                           .ToList();
            }
        }

        public List<Dados.Filial> GetByAtivo(bool isativo)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filial
                           .Include(a => a.Cidade)
                           .Include(a => a.Config)
                           .Where(a => a.IsAtivo == isativo)
                           .ToList();
            }
        }

        public List<Dados.Filial> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filial
                           .Include(a => a.Cidade)
                           .Include(a => a.Config)
                           .Where(a => a.NomeFantasia.Contains(nome) ||
                                       a.RazaoSocial.Contains(nome)) 
                           .ToList();
            }
        }

        public Dados.Filial GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filial
                           .Include(a => a.Cidade)
                           .Include(a => a.Config)
                           .FirstOrDefault(a => a.IdFilial == id);
            }
        }

        public List<Dados.Filial> GetByTabela(int idTabela)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filial.Where(a => a.TabelaFilial.Any(b => b.IdTabela == idTabela)).ToList();
            }
        }

        public Dados.Filial Insert(Dados.Filial item)
        {
                try
                {
                    using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                    {
                        //salva no banco de dados
                        conn.Filial.Add(item);
                        
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
                        return GetById(item.IdFilial);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }

        public Dados.Filial Update(Dados.Filial item)
        {
                try
                {
                    using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                    {
                        //recupera item do banco
                        var updated = conn.Filial
                                          .Include(a => a.Cidade)
                                          .Include(a => a.Config)
                                          .FirstOrDefault(a => a.IdFilial == item.IdFilial);

                        //atualiza dados
                        updated.IdGrupoEmpresa = item.IdGrupoEmpresa;
                        updated.IdCidade = item.IdCidade;
                        updated.RazaoSocial = item.RazaoSocial;
                        updated.NomeFantasia = item.NomeFantasia;
                        updated.Cnpj = item.Cnpj;
                        updated.Endereco = item.Endereco;
                        updated.Numero = item.Numero;
                        updated.Complemento = item.Complemento;
                        updated.Bairro = item.Bairro;
                        updated.Cep = item.Cep;
                        updated.Email = item.Email;
                        updated.Telefone = item.Telefone;
                        updated.Celular = item.Celular;
                        updated.Fax = item.Fax;
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
                        return GetById(updated.IdFilial);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }

        public Dados.Filial Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Filial
                                      .Include(a => a.Cidade)
                                      .Include(a => a.Config)
                                      .FirstOrDefault(a => a.IdFilial == id);

                    //salva no banco de dados
                    conn.Filial.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Filial> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdFilial,
                Nome = a.NomeFantasia,
                RazaoSocial = a.RazaoSocial,
                Cnpj = a.Cnpj,
                Cidade = a.Cidade.Nome,
                Ativo = a.IsAtivo
            }).ToList();
        }

        public List<Dados.Filial> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Filial
                           .Include(a => a.Cidade)
                           .Include(a => a.Config)
                           .Where(filtro, parameters).ToList();
            }
        }
    }
}
