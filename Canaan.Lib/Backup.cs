using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class Backup : IBase<Dados.Backup>
    {
        public List<Dados.Backup> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.Backup> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.Backup> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.Backup GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Backup.FirstOrDefault(a => a.IdBackup == id);
            }
        }

        public Dados.Backup Insert(Dados.Backup item)
        {
           try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.Backup.Add(item);

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
                    return GetById(item.IdBackup);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Dados.Backup Update(Dados.Backup item)
        {
            throw new NotImplementedException();
        }

        public Dados.Backup Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.Backup> lista)
        {
            throw new NotImplementedException();
        }

        public Dados.Backup GetBySessao(int idSessao)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.Backup.FirstOrDefault(a => a.BackupItem.Any(b => b.IdSessao == idSessao));
            }
        }
    }
}
