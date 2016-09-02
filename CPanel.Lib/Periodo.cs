using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CPanel.Lib
{
    public class Periodo
    {
        /// <summary>
        /// Pega um periodo de meta
        /// </summary>
        /// <param name="ano">Ano do periodo de meta</param>
        /// <param name="mes">Mês do período de meta</param>
        /// <param name="idFilial">Filial do perido de meta</param>
        /// <returns>Periodo de Meta</returns>
        public static CPanel.Dados.periodos GetPeriodo(int ano, int mes, int idFilial) 
        {
            using (var conn = new CPanel.Dados.CPanelEntities()) 
            {
                return conn.periodos
                           .Include(a => a.periodos_semanas)
                           .Include(a => a.periodos_feriados)
                           .Include(a => a.periodos_objetivos)
                           .FirstOrDefault(a => a.ano == ano && a.mes == mes && a.id_filial == idFilial);
            }
        }
    }
}
