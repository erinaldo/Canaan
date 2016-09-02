using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RM.Lib
{
    public class Filiais
    {
        public static List<Dados.GFILIAL> Get() 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities()) 
            {
                return conn.GFILIAL
                           .Where(a => a.CODFILIAL <= 100)
                           .OrderBy(a => a.NOMEFANTASIA)
                           .ToList();
            }
        }

        public static List<Dados.GFILIAL> GetByColigada(short CodColigada)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.GFILIAL
                           .Where(a => a.CODFILIAL <= 100 && a.CODCOLIGADA == CodColigada)
                           .OrderBy(a => a.NOMEFANTASIA)
                           .ToList();
            }
        }

        public static List<Dados.GFILIAL> GetEstudios()
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                int[] coligadas = GetColigadasEstudios();

                return conn.GFILIAL
                           .Where(a => a.CODFILIAL <= 100 &&
                                       coligadas.Contains(a.CODCOLIGADA) &&
                                       a != conn.GFILIAL.Where(b => b.CODCOLIGADA == 1 && b.CODFILIAL == 1).FirstOrDefault())
                           .OrderBy(a => a.NOMEFANTASIA)
                           .ToList();
            }
        }

        public static List<Dados.GFILIAL> GetEstudiosRede()
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                int[] coligadas = GetColigadasEstudiosRede();

                return conn.GFILIAL
                           .Where(a => a.CODFILIAL <= 100 &&
                                       coligadas.Contains(a.CODCOLIGADA) &&
                                       a != conn.GFILIAL.Where(b => b.CODCOLIGADA == 1 && b.CODFILIAL == 1).FirstOrDefault())
                           .OrderBy(a => a.NOMEFANTASIA)
                           .ToList();
            }
        }

        public static List<Dados.GFILIAL> GetEstudiosFranquia()
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                int[] coligadas = GetColigadasEstudiosFranquia();

                return conn.GFILIAL
                           .Where(a => a.CODFILIAL <= 100 &&
                                       coligadas.Contains(a.CODCOLIGADA) &&
                                       a != conn.GFILIAL.Where(b => b.CODCOLIGADA == 1 && b.CODFILIAL == 1).FirstOrDefault())
                           .OrderBy(a => a.NOMEFANTASIA)
                           .ToList();
            }
        }
        
        public static Dados.GFILIAL GetById(short CodColigada, short CodFilial)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.GFILIAL.Where(a => a.CODFILIAL == CodFilial && a.CODCOLIGADA == CodColigada).FirstOrDefault();
            }
        }

        public static Dados.GFILIAL GetByCnpj(string cnpj)
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.GFILIAL.Where(a => a.CGC == cnpj).FirstOrDefault();
            }
        }

        public static Dados.GFILIAL GetCPC() 
        {
            using (Dados.CorporeEntities conn = new Dados.CorporeEntities())
            {
                return conn.GFILIAL.Where(a => a.CODFILIAL == 1 && a.CODCOLIGADA == 1).FirstOrDefault();
            }
        }
        
        private static int[] GetColigadasEstudios() 
        {
            return new int[] { 1, 2, 3, 4, 5, 6, 8, 9};
        }

        private static int[] GetColigadasEstudiosRede()
        {
            return new int[] { 1, 2, 3, 4, 6 };
        }

        private static int[] GetColigadasEstudiosFranquia()
        {
            return new int[] { 5, 8, 9, 10 };
        }
    }
}
