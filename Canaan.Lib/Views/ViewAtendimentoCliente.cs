using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class ViewAtendimentoCliente : IBase<Dados.ViewAtendimentoCliente>
    {
        public List<Dados.ViewAtendimentoCliente> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewAtendimentoCliente.ToList();
            }
        }

        public List<Dados.ViewAtendimentoCliente> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewAtendimentoCliente.Where(a => a.NomeCompleto.Contains(nome) || a.NomeFantasia.Contains(nome)).ToList();
            }
        }

        public List<Dados.ViewAtendimentoCliente> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public List<Dados.ViewAtendimentoCliente> FilterAtendimento(string filtro, object[] parameters)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewAtendimentoCliente.Where(filtro, parameters).ToList();
            }
        }

        public Dados.ViewAtendimentoCliente GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewAtendimentoCliente.FirstOrDefault(a => a.IdAtendimento == id);
            }
        }

        public List<Dados.ViewAtendimentoCliente> GetListById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewAtendimentoCliente.Where(a => a.IdAtendimento == id).ToList();
            }
        }

        public Dados.ViewAtendimentoCliente GetByCliFor(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewAtendimentoCliente.FirstOrDefault(a => a.IdCliFor == id);
            }
        }

        public List<Dados.ViewAtendimentoCliente> GetByCpf(string cpf)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewAtendimentoCliente.Where(a => a.Cpf.Contains(cpf) || a.Cnpj.Contains(cpf)).ToList();
            }
        }

        public List<Dados.ViewAtendimentoCliente> GetByIdCliente(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewAtendimentoCliente.Where(a => a.IdCliFor == id).ToList();
            }
        }

        public Dados.ViewAtendimentoCliente Insert(Dados.ViewAtendimentoCliente item)
        {
            throw new NotImplementedException();
        }

        public Dados.ViewAtendimentoCliente Update(Dados.ViewAtendimentoCliente item)
        {
            throw new NotImplementedException();
        }

        public Dados.ViewAtendimentoCliente Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dados.ViewAtendimentoCliente> AtendimentoToViewAtendimento(List<Dados.Atendimento> Atendimentos)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                var ids = Atendimentos.Select(a => a.IdAgendamento).ToArray();
                return conn.ViewAtendimentoCliente.Where(a => ids.Contains(a.IdAgendamento)).ToList();
            }
        }

        public dynamic CarregaGridByCliente(List<Dados.ViewAtendimentoCliente> lista)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                if (lista.Count == 0)
                    return new List<Dados.ViewAtendimentoCliente>();

                var idCliente = lista[0].IdCliFor;
                var cliente = conn.ViewCliFor.FirstOrDefault(a => a.IdCliFor == idCliente);

                return lista.Select(a => new
                {
                    Codigo = a.IdAtendimento,
                    Cliente = string.IsNullOrEmpty(cliente.NomeCompleto) ? cliente.NomeFantasia : cliente.NomeCompleto,
                    Data = a.Data,
                    Confirmado = a.IsConfirmado,
                    Ativo = a.IsAtivo
                }).ToList();
            }
        }

        public dynamic CarregaGrid(List<Dados.ViewAtendimentoCliente> lista)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                if (lista.Count == 0)
                    return new List<Dados.ViewAtendimentoCliente>();

                var idCliente = lista[0].IdCliFor;
                var cliente = conn.ViewCliFor.FirstOrDefault(a => a.IdCliFor == idCliente);

                return lista.Select(a => new
                {
                    Codigo = a.IdAtendimento,
                    Cliente = string.IsNullOrEmpty(cliente.NomeCompleto) ? cliente.NomeFantasia : cliente.NomeCompleto,
                    Documento = string.IsNullOrEmpty(a.Cpf) ? a.Cnpj : a.Cpf,
                    Data = a.Data
                }).ToList();
            }
        }

        public dynamic CarregaGridByConsulta(List<Dados.ViewAtendimentoCliente> lista)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                if (lista.Count == 0)
                    return new List<Dados.ViewAtendimentoCliente>();

                var idCliente = lista[0].IdCliFor;
                var cliente = conn.ViewCliFor.FirstOrDefault(a => a.IdCliFor == idCliente);

                return lista.Select(a => new
                {
                    Codigo = a.IdAtendimento,
                    Cliente = string.IsNullOrEmpty(cliente.NomeCompleto) ? cliente.NomeFantasia : cliente.NomeCompleto,
                    Data = a.Data,
                    Documento = string.IsNullOrEmpty(a.Cpf) ? a.Cnpj : a.Cpf,
                    Cidade = new Lib.Cidade().GetById(a.IdCidade.GetValueOrDefault()).Nome,
                    Estado = new Cidade().GetById(a.IdCidade.GetValueOrDefault()).Estado.Nome,
                }).ToList();
            }
        }

    }
}
