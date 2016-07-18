using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel;

namespace Canaan.Lib
{
    public class Modelo : IBase<Dados.Modelo>, IEnum<Dados.EnumCliForSexo>
    {

        public AtendimentoHist LibAtendimento
        {
            get
            {
                return new AtendimentoHist();
            }
        }

        public List<Dados.Modelo> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Modelo.Include(a => a.CliFor).ToList();
            }
        }

        public List<Dados.Modelo> GetByNome(string nome)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Modelo.Include(a => a.CliFor).Where(a => a.NomeCompleto.Contains(nome)).ToList();
            }
        }

        public List<Dados.Modelo> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Modelo GetById(int id)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Modelo.Include(a => a.CliFor).Include(a => a.Cidade).FirstOrDefault(a => a.IdModelo == id);
            }
        }

        public Dados.Modelo Insert(Dados.Modelo item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Modelo.Add(item);

                    //valida e salva
                    if (Validacao.IsValid(conn))
                    {
                        conn.SaveChanges();

                        //adiciona responsavel legal
                        var cli = (Dados.PessoaFisica)conn.CliFor.FirstOrDefault(a => a.IdCliFor == item.IdCliFor);

                        var resp = new Dados.ModeloResp();
                        resp.IdModelo = item.IdModelo;
                        resp.Tipo = Dados.EnumModeloTipoResp.Responsavel_Legal;
                        resp.Nome = cli.Nome;
                        resp.Cpf = cli.Documento;
                        resp.Rg = cli.Rg;
                        resp.Telefone = cli.Telefone;
                        resp.Celular = cli.Celular;

                        var respLib = new ModeloResp();
                        respLib.Insert(resp);
                    }
                    else
                    {
                        throw new Exception(Validacao.GetErrors(conn));
                    }

                    //retorna
                    return GetById(item.IdModelo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Modelo Update(Dados.Modelo item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var updated = conn.Modelo.Include(a => a.CliFor)
                                      .FirstOrDefault(a => a.IdModelo == item.IdModelo);

                    //atualiza dados
                    updated.IdCliFor = item.IdCliFor;
                    updated.IdCidade = item.IdCidade;
                    updated.NomeCompleto = item.NomeCompleto;
                    updated.Sexo = item.Sexo;
                    updated.Nascimento = item.Nascimento;
                    updated.Cpf = item.Cpf;
                    updated.Rg = item.Rg;
                    updated.Email = item.Email;
                    updated.Telefone = item.Telefone;
                    updated.Celular = item.Celular;
                    updated.Endereco = item.Endereco;
                    updated.Numero = item.Numero;
                    updated.Complemento = item.Complemento;
                    updated.Bairro = item.Bairro;
                    updated.Cep = item.Cep;
                    updated.IsEmancipado = item.IsEmancipado;
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
                    return GetById(updated.IdModelo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Modelo Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.Modelo.Include(a => a.CliFor).FirstOrDefault(a => a.IdModelo == id);

                    //salva no banco de dados
                    conn.Modelo.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.Modelo> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdModelo,
                Modelo = a.NomeCompleto,
                Cliente = a.CliFor.Nome,
                Nascimento = a.Nascimento.ToShortDateString(),
                Idade = Utilitarios.Comum.CalculaIdade(a.Nascimento),
                Status = a.IsAtivo
            }).ToList();
        }

        public BindingList<Ficha> CarregaGridFicha(List<Dados.Modelo> lista, int idAtendimento)
        {
            var result = lista.Select(a => new Ficha
            {
                Selecionado = a.AtendimentoModelo.Any(b => b.IdAtendimento == idAtendimento),
                Codigo = a.IdModelo,
                Modelo = a.NomeCompleto,
                Cliente = a.CliFor.Nome,
                Nascimento = a.Nascimento.ToShortDateString(),
                Idade = Utilitarios.Comum.CalculaIdade(a.Nascimento),
                Status = a.IsAtivo
            }).ToList();

            return new BindingList<Ficha>(result);

        }

        public dynamic CarregaGridSessaoWindow(List<Dados.Modelo> lista)
        {
            return lista.Select(a => new
            {
                Modelo = a.NomeCompleto,
                Idade = Utilitarios.Comum.CalculaIdade(a.Nascimento),
            }).ToList();
        }

        public List<Dados.Modelo> GetByIdCliFor(int idCliFor)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Modelo.Include(a => a.CliFor).Include(a => a.AtendimentoModelo).Where(a => a.IdCliFor == idCliFor).ToList();
            }
        }

        public Dictionary<int, string> GetValuesFromEnum()
        {
            return Enum.GetValues(typeof(Dados.EnumCliForSexo)).Cast<Dados.EnumCliForSexo>()
                                                               .ToDictionary(e => (int)e, e => e.ToString());
        }

        public Dictionary<int, string> GetValuesFromEnum(string descricao)
        {
            return Enum.GetValues(typeof(Dados.EnumCliForSexo)).Cast<Dados.EnumCliForSexo>()
                                                              .Where(a => a.ToString().ToLower().Contains(descricao.ToLower()))
                                                              .ToDictionary(e => (int)e, e => e.ToString());
        }

        public Dados.EnumCliForSexo GetEnumForKey(int key)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Modelo> GetByAtendimento(int idAtendimento)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {

                return conn.Modelo.Include(a => a.CliFor).Include(a => a.AtendimentoModelo).Where(a => a.AtendimentoModelo.Any(b => b.IdAtendimento == idAtendimento)).ToList();
            }
        }

        public List<Dados.Modelo> GetBySessao(int idSessao)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var sessao = conn.Sessao.FirstOrDefault(a => a.IdSessao == idSessao);

                if (sessao == null)
                    return new List<Dados.Modelo>();

                return conn.Modelo.Include(a => a.CliFor)
                                  .Include(a => a.AtendimentoModelo)
                                  .Where(a => a.AtendimentoModelo.Any(b => b.IdAtendimento == sessao.IdAtendimento))
                                  .ToList();
            }
        }
    }

    public class Ficha
    {
        public bool Selecionado { get; set; }
        public int Codigo { get; set; }
        public string Modelo { get; set; }
        public string Cliente { get; set; }
        public string Nascimento { get; set; }
        public int Idade { get; set; }
        public bool Status { get; set; }
    }
}
