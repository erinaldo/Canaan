using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPanel.Lib
{
    public class Filiais
    {
        public static List<Dados.filiais> Get() 
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities()) 
            {
                return conn.filiais.Where(a => a.ativo == true).OrderBy(a => a.nome).ToList();
            }
        }

        public static List<Dados.filiais> GetAll()
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.filiais.OrderBy(a => a.nome).ToList();
            }
        }

        public static List<Dados.filiais> GetByRede()
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.filiais.Where(a => a.id_filial_natureza == 1 && a.ativo == true).OrderBy(a => a.nome).ToList();
            }
        }

        public static List<Dados.filiais> GetByFranquia()
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.filiais.Where(a => a.id_filial_natureza == 2 && a.ativo == true).OrderBy(a => a.nome).ToList();
            }
        }

        public static List<Dados.filiais> GetBySetor(int idSetor)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.filiais.Where(a => a.id_setor == idSetor && a.ativo == true).OrderBy(a => a.nome).ToList();
            }
        }


        public static Dados.filiais GetById(int id) 
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities()) 
            {
                return conn.filiais.FirstOrDefault(a => a.id_filial == id);
            }
        }

        public static Dados.filiais GetByRM(int codcoligada, int codfilial)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.filiais.FirstOrDefault(a => a.rm_coligada == codcoligada && a.rm_filial == codfilial);
            }
        }
    }
}
