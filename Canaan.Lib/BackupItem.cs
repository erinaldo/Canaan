using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canaan.Lib
{
    public class BackupItem : IBase<Dados.BackupItem>
    {
        public List<Dados.BackupItem> Get()
        {
            throw new NotImplementedException();
        }

        public List<Dados.BackupItem> GetByNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Dados.BackupItem> Filter(string filtro, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Dados.BackupItem GetById(int id)
        {
            using (var conn = new Dados.CanaanModelContainer())
            {
                return conn.BackupItem.FirstOrDefault(a => a.IdBackupItem == id);
            }
        }

        public Dados.BackupItem Insert(Dados.BackupItem item)
        {
            try
            {
                using (Dados.CanaanModelContainer conn = new Dados.CanaanModelContainer())
                {
                    //salva no banco de dados
                    conn.BackupItem.Add(item);

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

        public Dados.BackupItem Update(Dados.BackupItem item)
        {
            throw new NotImplementedException();
        }

        public Dados.BackupItem Delete(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic CarregaGrid(List<Dados.BackupItem> lista)
        {
            throw new NotImplementedException();
        }
    }
}
