using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CPanel.Lib
{
    public class Caderno
    {
        public static List<Dados.cadernos> Get(int IdFilial) 
        {
            using (var conn = new Dados.CPanelEntities()) 
            {
                return conn.cadernos
                           .Include(a => a.cadernos_vendas)
                           .Where(a => a.id_filial == IdFilial)
                           .OrderByDescending(a => a.data)
                           .ToList();
            }
        }

        public static List<Dados.cadernos> GetByPeriodo(int IdFilial, DateTime dtInicio, DateTime dtFim)
        {
            using (var conn = new Dados.CPanelEntities())
            {
                return conn.cadernos
                           .Include(a => a.cadernos_vendas)
                           .Where(a => a.id_filial == IdFilial && a.data >= dtInicio && a.data <= dtFim)
                           .OrderByDescending(a => a.data)
                           .ToList();
            }
        }

        public static Dados.cadernos GetById(int IdCaderno) 
        {
            using (var conn = new Dados.CPanelEntities()) 
            {
                return conn.cadernos
                           .Include(a => a.cadernos_vendas)
                           .FirstOrDefault(a => a.id_caderno == IdCaderno);
            }
        }

        /// <summary>
        /// Retorna utlumo Caderno com permissão de escrita para gerente
        /// </summary>
        /// <param name="idFilial"></param>
        /// <returns></returns>
        public static Dados.cadernos GetUltimoCadernoAberto(int idFilial)
        {
            using (var conn = new Dados.CPanelEntities())
            {
                return conn.cadernos.Where(a => a.id_filial == idFilial && !a.liberada_gerente && !a.liberada_escrit)
                    .OrderByDescending(a => a.id_caderno)
                    .FirstOrDefault();
            }
        }

        public static Dados.cadernos GetCadernoSync(int idFilial, DateTime dataCaderno)
        {
            using (var conn = new Dados.CPanelEntities())
            {
                var caderno = conn.cadernos.FirstOrDefault(a => a.id_filial == idFilial && a.data == dataCaderno);

                if (caderno == null)
                    caderno = Insert(Filiais.GetById(idFilial), dataCaderno);

                return caderno;
            }
        }

        public static Dados.cadernos Insert(Dados.filiais filial, DateTime data) 
        {
            using (var conn = new Dados.CPanelEntities())
            {
                if (VerificaExiste(filial.id_filial, data) == false)
                {
                    try
                    {
                        var insert = new Dados.cadernos();
                        insert.id_filial = filial.id_filial;
                        insert.data = data;
                        insert.entrada_dinheiro	= 0;
                        insert.entrada_cartao = 0;
                        insert.entrada_depositada = 0;
                        insert.entrada_total = 0;
                        insert.venda_prazo = 0;
                        insert.venda_dinheiro = 0;
                        insert.venda_cartao = 0;
                        insert.venda_total = 0;
                        insert.devolvida_valor = 0;
                        insert.devolvida_qtde = 0;
                        insert.programada_valor = 0;
                        insert.programada_qtde = 0;
                        insert.autorizada_valor = 0;
                        insert.autorizada_qtde = 0;
                        insert.fotografados = 0;
                        insert.brinde = 0;
                        insert.liberada_escrit = false;
                        insert.liberada_gerente = false;

                        conn.cadernos.Add(insert);
                        conn.SaveChanges();
                        return insert;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    
                }
                else 
                {
                    throw new Exception(string.Format("Já existe um caderno no dia {0} para a filial {1}", data.ToShortDateString(), filial.nome));
                }

            }
        }

        public static Dados.cadernos Update(Dados.cadernos caderno) 
        {
            using (var conn = new Dados.CPanelEntities()) 
            {
                try
                {
                    //recupera dados do banco de dados
                    var updated = conn.cadernos.FirstOrDefault(a => a.id_caderno == caderno.id_caderno);

                    //altera dados
                    updated.id_filial = caderno.id_filial;
                    updated.data = caderno.data;

                    updated.entrada_dinheiro = updated.cadernos_vendas.Sum(a => a.entrada_dinheiro);
                    updated.entrada_cartao = updated.cadernos_vendas.Sum(a => a.entrada_cartao);
                    updated.entrada_total = updated.entrada_dinheiro + updated.entrada_cartao;
                    updated.entrada_depositada = updated.cadernos_vendas.Sum(a => a.entrada_depositada);

                    updated.venda_prazo = updated.cadernos_vendas.Where(a => a.is_devolvida == false && a.is_programada == false).Sum(a => a.venda_prazo);
                    updated.venda_cartao = updated.cadernos_vendas.Where(a => a.is_devolvida == false && a.is_programada == false).Sum(a => a.venda_cartao);
                    updated.venda_dinheiro = updated.cadernos_vendas.Where(a => a.is_devolvida == false && a.is_programada == false).Sum(a => a.venda_dinheiro);
                    updated.venda_total = updated.venda_prazo + updated.venda_cartao + updated.venda_dinheiro;

                    updated.devolvida_qtde = updated.cadernos_vendas.Count(a => a.is_devolvida == true);
                    updated.devolvida_valor = updated.cadernos_vendas.Where(a => a.is_devolvida == true).Sum(a => a.venda_total);

                    updated.programada_qtde = updated.cadernos_vendas.Count(a => a.is_programada == true);
                    updated.programada_valor = updated.cadernos_vendas.Where(a => a.is_programada == true).Sum(a => a.venda_total);

                    updated.autorizada_qtde = updated.cadernos_vendas.Count(a => a.is_autorizada == true);
                    updated.autorizada_valor = updated.cadernos_vendas.Where(a => a.is_autorizada == true).Sum(a => a.venda_total);                    

                    updated.fotografados = caderno.fotografados;
                    updated.brinde = updated.cadernos_vendas.Count(a => a.is_cortesia != null && a.is_cortesia == true);
                    updated.liberada_escrit = caderno.liberada_escrit;
                    updated.liberada_gerente = caderno.liberada_gerente;

                    //salva dados no banco
                    conn.SaveChanges();

                    //retorna
                    return GetById(updated.id_caderno);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static void UpdateInfo(Dados.cadernos caderno)
        {
            using(var conn = new Dados.CPanelEntities())
            {
                var updated = conn.cadernos.FirstOrDefault(a => a.id_caderno == caderno.id_caderno);

                updated.entrada_dinheiro = updated.cadernos_vendas.Where(a => a.is_devolvida == false).Sum(a => a.entrada_dinheiro);
                updated.entrada_cartao = updated.cadernos_vendas.Where(a => a.is_devolvida == false).Sum(a => a.entrada_cartao);
                updated.entrada_depositada = updated.cadernos_vendas.Where(a => a.is_devolvida == false).Sum(a => a.entrada_depositada);
                updated.entrada_total = updated.entrada_dinheiro + updated.entrada_cartao;

                updated.venda_prazo = updated.cadernos_vendas.Where(a => a.is_devolvida == false && a.is_programada == false).Sum(a => a.venda_prazo);
                updated.venda_cartao = updated.cadernos_vendas.Where(a => a.is_devolvida == false && a.is_programada == false).Sum(a => a.venda_cartao);
                updated.venda_dinheiro = updated.cadernos_vendas.Where(a => a.is_devolvida == false && a.is_programada == false).Sum(a => a.venda_dinheiro);
                updated.venda_total = updated.venda_prazo + updated.venda_cartao + updated.venda_dinheiro;

                updated.devolvida_qtde = updated.cadernos_vendas.Where(a => a.is_devolvida == true).Count();
                updated.devolvida_valor = updated.cadernos_vendas.Where(a => a.is_devolvida == true).Sum(a => a.venda_total);

                updated.programada_qtde = updated.cadernos_vendas.Where(a => a.is_programada == true).Count();
                updated.programada_valor = updated.cadernos_vendas.Where(a => a.is_programada == true).Sum(a => a.venda_total);

                updated.autorizada_qtde = updated.cadernos_vendas.Where(a => a.is_autorizada == true).Count();
                updated.autorizada_valor = updated.cadernos_vendas.Where(a => a.is_autorizada == true).Sum(a => a.venda_total);
            }
        }

        private static bool VerificaExiste(int IdFilial, DateTime data)
        {
            using (var conn = new Dados.CPanelEntities())
            {
                var caderno = conn.cadernos.FirstOrDefault(a => a.id_filial == IdFilial && a.data == data);

                if (caderno == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        public static dynamic GetGrid(List<Dados.cadernos> lista) 
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.id_caderno,
                    Status = a.liberada_escrit == false ? "Aberto" : "Fechado",
                    Data = a.data.ToShortDateString(),
                    Faturamento = string.Format("{0:c}", a.venda_total),
                    Entrada = string.Format("{0:c}", a.entrada_total),
                    Vendas = a.cadernos_vendas.Where(b => b.is_devolvida == false && b.is_programada == false && b.is_cortesia == false).Count(),
                    Programadas = a.programada_qtde,
                    Devolvidas = a.cadernos_vendas.Where(c => c.is_devolvida == true).Count(),
                    Brindes = a.brinde,
                    Fotografados = a.fotografados
                }).ToList();
            }
            else 
            {
                return null;
            }
        
        }

    }
}
