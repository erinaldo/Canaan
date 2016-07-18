using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class Album : IBase<Dados.Album>
    {
        public List<Dados.Album> Get()
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Album.Where(a => a.IsAtivo).ToList();
            }
        }

        public List<Dados.Album> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Album.Where(a => a.Nome.Contains(nome)).ToList();
            }
        }

        public List<Dados.Album> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Album GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Album.FirstOrDefault(a => a.IdAlbum == id);
            }
        }

        public List<Dados.Album> GetByStatus(bool status)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Album.Where(a => a.IsAtivo == status).ToList();
            }
        }

        public Dados.Album Insert(Dados.Album item)
        {
            throw new NotImplementedException();
        }

        public Dados.Album Update(Dados.Album item)
        {
            throw new NotImplementedException();
        }

        public Dados.Album Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Album> lista)
        {
            throw new NotImplementedException();
        }
    }
}
