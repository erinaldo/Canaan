using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class VendaFoto : IBase<Dados.VendaFoto>
    {
        public List<Dados.VendaFoto> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.VendaFoto> GetByNome(string nome)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaFoto.Where(a => a.Foto.Nome == nome).ToList();
            }
        }

        public Dados.VendaFoto GetByNome(string nome, int idPedido)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaFoto.FirstOrDefault(a => a.Foto.Nome == nome && a.IdPedido == idPedido);
            }
        }

        public List<Dados.VendaFoto> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.VendaFoto GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.VendaFoto.FirstOrDefault(a => a.IdVendaFoto == id);
            }
        }

        public Dados.VendaFoto Insert(Dados.VendaFoto item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.VendaFoto.Add(item);

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
                    return GetById(item.IdVendaFoto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.VendaFoto Update(Dados.VendaFoto item)
        {
            throw new NotImplementedException();
        }

        public Dados.VendaFoto Delete(int id)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.VendaFoto.FirstOrDefault(a => a.IdVendaFoto == id);

                    //salva no banco de dados
                    conn.VendaFoto.Remove(deleted);
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

        public Dados.VendaFoto Delete(int idFoto, int idVenda)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //recupera item do banco
                    var deleted = conn.VendaFoto.FirstOrDefault(a => a.IdPedido == idVenda && a.IdFoto == idFoto);

                    //salva no banco de dados
                    conn.VendaFoto.Remove(deleted);
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

        public dynamic CarregaGrid(List<Dados.VendaFoto> lista)
        {
            throw new NotImplementedException();
        }

        public bool ValidaInsercao(Dados.Foto foto, Dados.Venda venda)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return !conn.VendaFoto.Any(a => a.IdFoto == foto.IdFoto && a.IdPedido == venda.IdPedido);
            }
        }


    }
}
