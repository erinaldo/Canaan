using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CPanel.Lib
{
    public class CadernoDevolucao
    {
        public static List<Dados.cadernos_devolucoes> Get(int idCaderno) 
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities()) 
            {
                return conn.cadernos_devolucoes
                           .Include(a => a.cadernos_vendas)
                           .Include(a => a.cadernos_devolucoes_motivos)
                           .Where(a => a.cadernos_vendas.id_caderno == idCaderno)
                           .ToList();
            }
        }

        public static List<Dados.cadernos_devolucoes_motivos> GetMotivos()
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.cadernos_devolucoes_motivos.ToList();
            }
        }

        public static Dados.cadernos_devolucoes GetById(int id)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.cadernos_devolucoes
                           .Include(a => a.cadernos_vendas)
                           .Include(a => a.cadernos_devolucoes_motivos)
                           .FirstOrDefault(a => a.id_devolvida == id);
            }
        }

        public static Dados.cadernos_devolucoes GetByVenda(int id)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.cadernos_devolucoes
                           .Include(a => a.cadernos_vendas)
                           .Include(a => a.cadernos_devolucoes_motivos)
                           .FirstOrDefault(a => a.id_venda == id);
            }
        }

        public static Dados.cadernos_devolucoes Insert(Dados.cadernos_devolucoes devolucao, bool isAdmin)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                var venda = CadernoVendas.GetById(devolucao.id_venda);
                var caderno = Caderno.GetById(venda.id_caderno);

                if (caderno.liberada_escrit == false || isAdmin == true)
                {
                    //cria devolucao
                    conn.cadernos_devolucoes.Add(devolucao);
                    conn.SaveChanges();

                    //recupera informacoes da venda
                    var vendaUpdate = conn.cadernos_vendas.FirstOrDefault(a => a.id_venda == devolucao.id_venda);

                    //marca venda como devolvida no caderno
                    vendaUpdate.is_programada = false;
                    vendaUpdate.is_autorizada = false;
                    vendaUpdate.is_devolvida = true;
                    CadernoVendas.Update(vendaUpdate, isAdmin);

                    //remove autorizacao da venda
                    if (vendaUpdate.is_autorizada)
                    {
                        CadernoLiberacao.Delete(CadernoLiberacao.GetByVenda(vendaUpdate.id_venda).id_liberacao, isAdmin);
                    }

                    //retorna o registro
                    return GetById(devolucao.id_devolvida);
                }
                else
                {
                    throw new Exception(string.Format("O caderno de venda do dia {0} já esta fechado", caderno.data.ToShortDateString()));
                }
            }
        }

        public static Dados.cadernos_devolucoes Update(Dados.cadernos_devolucoes devolucao, bool isAdmin)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                var venda = CadernoVendas.GetById(devolucao.id_venda);
                var caderno = Caderno.GetById(venda.id_caderno);

                if (caderno.liberada_escrit == false || isAdmin == true)
                {
                    var updated = conn.cadernos_devolucoes.FirstOrDefault(a => a.id_devolvida == devolucao.id_devolvida);

                    //atualiza dados
                    updated.id_venda = devolucao.id_venda;
                    updated.id_motivo = devolucao.id_motivo;
                    updated.observacao = devolucao.observacao;

                    //salva no banco de dados
                    conn.SaveChanges();

                    //retorna o registro
                    return GetById(devolucao.id_devolvida);
                }
                else
                {
                    throw new Exception(string.Format("O caderno de venda do dia {0} já esta fechado", caderno.data.ToShortDateString()));
                }
            }
        }

        public static Dados.cadernos_devolucoes Delete(int id, bool isAdmin)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                var deleted = conn.cadernos_devolucoes.FirstOrDefault(a => a.id_devolvida == id);
                var venda = conn.cadernos_vendas.FirstOrDefault(a => a.id_venda == deleted.id_venda);
                var caderno = Caderno.GetById(venda.id_caderno);

                if (caderno.liberada_escrit == false || isAdmin == true)
                {

                    //remove do banco de dados
                    conn.cadernos_devolucoes.Remove(deleted);
                    conn.SaveChanges();

                    //modifica venda retirando marcação de devolvida
                    venda.is_devolvida = false;
                    CadernoVendas.Update(venda, isAdmin);

                    //retorna o registro
                    return deleted;
                }
                else
                {
                    throw new Exception(string.Format("O caderno de venda do dia {0} já esta fechado", caderno.data.ToShortDateString()));
                }
            }
        }

        public static dynamic GetGrid(List<Dados.cadernos_devolucoes> lista)
        {
            if (lista != null)
            {
                return lista.Select(a => new
                {
                    Codigo = a.id_devolvida,
                    Venda = a.id_venda,
                    Motivo = a.cadernos_devolucoes_motivos.descricao,
                    Observacao = a.observacao
                }).ToList();
            }
            else
            {
                return null;
            }

        }
    }
}
