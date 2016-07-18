using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Canaan.Lib
{
    public class Cidade
    {
        public List<Dados.Cidade> Get()
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Cidade
                           .Include(a => a.Estado)
                           .Include(a => a.Estado.Pais)
                           .OrderBy(a => a.Nome)
                           .ToList();
            }
        }

        public List<Dados.Cidade> GetByNome(string cidade)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Cidade
                           .Include(a => a.Estado)
                           .Include(a => a.Estado.Pais)
                           .Where(a => a.Nome.Contains(cidade))
                           .ToList();
            }
        }

        public List<Dados.Cidade> GetByCidadeEstado(string uf, string cidade)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Cidade
                           .Include(a => a.Estado)
                           .Include(a => a.Estado.Pais)
                           .Where(a => a.Nome == cidade && a.Estado.Abreviatura == uf)
                           .ToList();
            }
        }

        public Dados.Cidade GetById(int cidade)
        {
            using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
            {
                return conn.Cidade
                           .Include(a => a.Estado)
                           .Include(a => a.Estado.Pais)
                           .FirstOrDefault(a => a.IdCidade == cidade);
            }
        }

        public dynamic CarregaGrid(List<Dados.Cidade> lista)
        {
            return lista.Select(a => new
            {
                Codigo = a.IdCidade,
                Estado = a.Estado.Nome,
                Nome = a.Nome
            }).ToList();
        }
    }
}
