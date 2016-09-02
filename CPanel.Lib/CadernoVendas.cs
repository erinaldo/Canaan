using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPanel.Lib
{
    public class CadernoVendas
    {
        public static List<Dados.cadernos_vendas> Get(int idCaderno) 
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities()) 
            {
                return conn.cadernos_vendas
                           .Where(a => a.id_caderno == idCaderno).ToList();
            }
        }

        public static Dados.cadernos_vendas GetById(int idVenda)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.cadernos_vendas
                           .FirstOrDefault(a => a.id_venda == idVenda);
            }
        }

        public static Dados.cadernos_vendas Insert(Dados.cadernos_vendas venda, bool isAdmin) 
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                var caderno = Caderno.GetById(venda.id_caderno);

                if (caderno.liberada_escrit == false || isAdmin == true)
                {
                    //finaliza dados iniciais
                    venda.is_autorizada = false;
                    venda.is_devolvida = false;
                    venda.entrada_depositada_data = venda.entrada_depositada > 0 ? venda.entrada_depositada_data : null;

                    //salva no banco de dados
                    conn.cadernos_vendas.Add(venda);
                    conn.SaveChanges();

                    //retorna o registro
                    return GetById(venda.id_venda);
                }
                else 
                {
                    throw new Exception(string.Format("O caderno de venda do dia {0} já esta fechado", caderno.data.ToShortDateString()));
                }
            }
        }

        public static Dados.cadernos_vendas Update(Dados.cadernos_vendas venda, bool isAdmin)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                var caderno = Caderno.GetById(venda.id_caderno);

                if (caderno.liberada_escrit == false || isAdmin == true)
                {
                    var updated = conn.cadernos_vendas.FirstOrDefault(a => a.id_venda == venda.id_venda);


                    //atualiza dados
                    updated.id_caderno = venda.id_caderno;
                    updated.cod_cmaster = venda.cod_cmaster;
                    updated.cod_venda = venda.cod_venda;
                    updated.cod_rm = venda.cod_rm;
                    updated.nome_cliente = venda.nome_cliente;
                    updated.vendedora = venda.vendedora;
                    updated.entrada_dinheiro = venda.entrada_dinheiro;
                    updated.entrada_cartao = venda.entrada_cartao;
                    updated.entrada_depositada = venda.entrada_depositada;
                    updated.entrada_depositada_data = venda.entrada_depositada > 0 ? venda.entrada_depositada_data : null;
                    updated.venda_dinheiro = venda.venda_dinheiro;
                    updated.venda_cartao = venda.venda_cartao;
                    updated.venda_prazo = venda.venda_prazo;
                    updated.venda_total = venda.venda_total;
                    updated.is_programada = venda.is_programada;
                    updated.is_autorizada = venda.is_autorizada;
                    updated.is_devolvida = venda.is_devolvida;
                    updated.is_cortesia = venda.is_cortesia;

                    //salva no banco de dados
                    conn.SaveChanges();

                    //retorna o registro
                    return GetById(venda.id_venda);
                }

                throw new Exception(string.Format("O caderno de venda do dia {0} já esta fechado", caderno.data.ToShortDateString()));
            }
        }

        public static Dados.cadernos_vendas Delete(int id, bool isAdmin)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                var updated = conn.cadernos_vendas.FirstOrDefault(a => a.id_venda == id);
                var caderno = Caderno.GetById(updated.id_caderno);

                if (caderno.liberada_escrit == false || isAdmin == true)
                {
                    //remove
                    conn.cadernos_vendas.Remove(updated);

                    //salva no banco de dados
                    conn.SaveChanges();

                    //retorna o registro
                    return updated;
                }
                else
                {
                    throw new Exception(string.Format("O caderno de venda do dia {0} já esta fechado", caderno.data.ToShortDateString()));
                }
            }
        }

        public static dynamic GetGrid(List<Dados.cadernos_vendas> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.id_venda,
                    CMaster = a.cod_cmaster,
                    RM = a.cod_rm,
                    Nome = a.nome_cliente,
                    Venda = string.Format("{0:c}", a.venda_total),
                    Autorizada = a.is_autorizada,
                    Programada = a.is_programada,
                    Devolvida = a.is_devolvida,
                    Cortesia = a.is_cortesia.GetValueOrDefault(),
                    Acompanhamento = a.is_acompanhamento.GetValueOrDefault()
                    
                }).ToList();
            }
            else
            {
                return null;
            }

        }

        public static Dados.cadernos_vendas GetByVenda(string codVenda, int idcaderno)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.cadernos_vendas.FirstOrDefault(a => a.cod_venda == codVenda && a.id_caderno == idcaderno);
            }            
        }       
    }
}
