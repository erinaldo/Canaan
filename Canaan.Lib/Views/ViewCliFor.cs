using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace Canaan.Lib
{
    public class ViewCliFor : IBase<Dados.ViewCliFor>
    {
        public List<Dados.ViewCliFor> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.ViewCliFor> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewCliFor.Where(a => a.NomeCompleto.Contains(nome) || a.NomeFantasia.Contains(nome)).ToList();
            }
        }

        public List<Dados.ViewCliFor> Filter(string filtro, object[] parameters)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewCliFor.Where(filtro, parameters).ToList();
            }
        }

        public Dados.ViewCliFor GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewCliFor.FirstOrDefault(a => a.IdCliFor == id);
            }
        }

        public Dados.ViewCliFor Insert(Dados.ViewCliFor item)
        {
            throw new NotImplementedException();
        }

        public Dados.ViewCliFor Update(Dados.ViewCliFor item)
        {
            throw new NotImplementedException();
        }

        public Dados.ViewCliFor Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.ViewCliFor> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.IdCliFor,
                    Nome = string.IsNullOrEmpty(a.NomeCompleto) ? a.NomeFantasia : a.NomeCompleto,
                    Documento = string.IsNullOrEmpty(a.Cnpj) ? a.Cpf : a.Cnpj,
                    Cidade = new Cidade().GetById(a.IdCidade).Nome,
                    Estado = new Cidade().GetById(a.IdCidade).Estado.Nome
                }).ToList();
            }
            else
            {
                return null;
            }
        }

        public List<Dados.ViewCliFor> GetByCpf(string cpf)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.ViewCliFor.Where(a => a.Cpf.Contains(cpf) || a.Cnpj.Contains(cpf)).ToList();
            }
        }       
    }
}
