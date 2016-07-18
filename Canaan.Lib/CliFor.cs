using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Dynamic;
using System.Reflection;

namespace Canaan.Lib
{
    public class CliFor : IBase<Dados.CliFor>
    {
        public List<Dados.CliFor> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor.Include(a => a.Cidade)
                                  .Include(a => a.CliForReferencia)
                                  .ToList();
            }
        }

        public List<Dados.CliFor> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor
                           .Include(a => a.Cidade)
                           .Include(a => a.CliForReferencia)
                           .Where(a => a.Nome.Contains(nome))
                           .ToList();
            }
        }

        public List<Dados.CliFor> GetByDoc(string documento)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor
                           .Include(a => a.Cidade)
                           .Include(a => a.CliForReferencia)
                           .Where(a => a.Documento.Contains(documento))
                           .ToList();
            }
        }

        public Dados.CliFor GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor
                           .Include(a => a.Atendimento)
                           .Include(a => a.Cidade)
                           .Include(a => a.Cidade.Estado)
                           .Include(a => a.CliForReferencia)
                           .FirstOrDefault(a => a.IdCliFor == id);
            }
        }

        public Dados.CliFor Insert(Dados.CliFor item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.CliFor.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        //salva no banco de dados
                        conn.SaveChanges();

                        //atualiza lista de referencias
                        UpdateReferencias(item.CliForReferencia.ToList(), item.IdCliFor);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdCliFor);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.CliFor Update(Dados.CliFor item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.CliFor
                                      .FirstOrDefault(a => a.IdCliFor == item.IdCliFor);

                    //atualiza dados pessoa fisica
                    if (updated is Dados.PessoaFisica)
                    {
                        updated.Nome = item.Nome;
                        (updated as Dados.PessoaFisica).Nascimento = (item as Dados.PessoaFisica).Nascimento;
                        updated.Documento = Utilitarios.Comum.RemoveEspeciais(item.Documento);
                        (updated as Dados.PessoaFisica).Rg = (item as Dados.PessoaFisica).Rg;
                        (updated as Dados.PessoaFisica).NomePai = (item as Dados.PessoaFisica).NomePai;
                        (updated as Dados.PessoaFisica).NomeMae = (item as Dados.PessoaFisica).NomeMae;
                        (updated as Dados.PessoaFisica).Sexo = (item as Dados.PessoaFisica).Sexo;
                        (updated as Dados.PessoaFisica).EstadoCivil = (item as Dados.PessoaFisica).EstadoCivil;
                        (updated as Dados.PessoaFisica).Conjuge = (item as Dados.PessoaFisica).Conjuge;
                        (updated as Dados.PessoaFisica).IsEmancipado = (item as Dados.PessoaFisica).IsEmancipado;
                    }

                    //atualiza dados pessoa juridica
                    if (updated is Dados.PessoaJuridica)
                    {
                        (updated as Dados.PessoaJuridica).RazaoSocial = (item as Dados.PessoaJuridica).RazaoSocial;
                        updated.Nome = item.Nome;
                        updated.Documento = Utilitarios.Comum.RemoveEspeciais(item.Documento);
                        (updated as Dados.PessoaJuridica).InscSocial = (item as Dados.PessoaJuridica).InscSocial;
                    }

                    //endereco
                    updated.IdCidade = item.IdCidade;
                    updated.Endereco = item.Endereco;
                    updated.Numero = item.Numero;
                    updated.Complemento = item.Complemento;
                    updated.Bairro = item.Bairro;
                    updated.Cep = item.Cep;

                    //contato
                    updated.Email = item.Email;
                    updated.Telefone = item.Telefone;
                    updated.Telefone2 = item.Telefone2;
                    updated.Telefone3 = item.Telefone3;
                    updated.Celular = item.Celular;
                    updated.Celular2 = item.Celular2;
                    updated.Celular3 = item.Celular3;
                    updated.Fax = item.Fax;

                    //geral
                    updated.Tipo = item.Tipo;
                    updated.IsAtivo = item.IsAtivo;

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        //salva dados no banco de dados
                        conn.SaveChanges();

                        //atualiza lista de referencias
                        UpdateReferencias(item.CliForReferencia.ToList(), item.IdCliFor);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(updated.IdCliFor);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateReferencias(List<Dados.CliForReferencia> lista, int idCliFor)
        {
            CliForReferencia refLib = new CliForReferencia();
            foreach (var item in lista)
            {
                //seta o id do cliente fornecedor
                item.CliFor = null;
                item.IdCliFor = idCliFor;

                //inclui ou atualiza registro
                if (item.IdReferencia == 0)
                    refLib.Insert(item);
                else
                    refLib.Update(item);
            }

        }

        public List<Dados.CliFor> Filter(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor.Include(a => a.Cidade)
                                       .Include(a => a.CliForReferencia)
                                       .Where(filtro, parameters)
                                       .ToList();
            }
        }

        public Dados.CliFor Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.CliFor.FirstOrDefault(a => a.IdCliFor == id);

                    //deleta todas as referencias
                    CliForReferencia refLib = new CliForReferencia();
                    foreach (var item in refLib.GetByCliente(deleted.IdCliFor))
                    {
                        refLib.Delete(item.IdReferencia);
                    }

                    //deleta no banco de dados
                    conn.CliFor.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.CliFor> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.IdCliFor,
                    Nome = a.Nome,
                    Documento = a.Documento,
                    Cidade = a.Cidade.Nome,
                    Estado = new Cidade().GetById(a.IdCidade).Estado.Nome,
                    Email = a.Email,
                    Telefone1 = a.Telefone,
                    Telefone2 = a.Telefone2,
                    Celular1 = a.Celular,
                    Celular2 = a.Celular2
                }).ToList();
            }
            else
            {
                return null;
            }
        }

        public List<T> FilterHeranca<T>(string sql, object[] paramentros)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor.OfType<T>().Where(sql, paramentros).ToList();
            }
        }

        public IEnumerable<Dados.CliFor> GetCliByAtendimento(int idAtendimento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor.Include(a => a.Cidade).Where(a => a.Atendimento.Any(b => b.IdAtendimento == idAtendimento)).ToList();
            }
        }

        public List<Dados.CliFor> GetByCpf(string cpf)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor
                           .Include(a => a.Atendimento)
                           .Include(a => a.Cidade)
                           .Include(a => a.Cidade.Estado)
                           .Include(a => a.CliForReferencia)
                           .Where(a => a.Documento.Contains(cpf))
                           .ToList();
            }
        }

        public List<Dados.CliFor> GetByCodigoReduzido(int codigo)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.CliFor
                           .Include(a => a.Atendimento)
                           .Include(a => a.Cidade)
                           .Include(a => a.Cidade.Estado)
                           .Include(a => a.CliForReferencia)
                           .Where(a => a.Atendimento.Any(b => b.CodigoReduzido == codigo))
                           .ToList();
            }
        }

        public bool ValidaIdade(Dados.CliFor ObjCliente)
        {
            if (ObjCliente is Dados.PessoaFisica)
            {
                var cliente = ObjCliente as Dados.PessoaFisica;
                var idade = Utilitarios.Comum.CalculaIdade(cliente.Nascimento);

                if (idade >= 18)
                {
                    return true;
                }

                if (cliente.IsEmancipado.GetValueOrDefault())
                {
                    return true;
                }

                return false;
            }

            return true;
        }
    }
}
