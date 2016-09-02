using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CPanel.Lib
{
    public class CadernoLiberacao
    {
        public static List<Dados.cadernos_liberacoes> Get(int idCaderno)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.cadernos_liberacoes
                           .Include(a => a.cadernos_vendas)
                           .Include(a => a.cadernos_liberacoes_tipos)
                           .Where(a => a.cadernos_vendas.id_caderno == idCaderno)
                           .ToList();
            }
        }

        public static List<Dados.cadernos_liberacoes_tipos> GetTipos()
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.cadernos_liberacoes_tipos.ToList();
            }
        }

        public static Dados.cadernos_liberacoes GetById(int id)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.cadernos_liberacoes
                           .Include(a => a.cadernos_vendas)
                           .Include(a => a.cadernos_liberacoes_tipos)
                           .FirstOrDefault(a => a.id_liberacao == id);
            }
        }

        public static Dados.cadernos_liberacoes GetByVenda(int id)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                return conn.cadernos_liberacoes
                           .Include(a => a.cadernos_vendas)
                           .Include(a => a.cadernos_liberacoes_tipos)
                           .FirstOrDefault(a => a.id_venda == id);
            }
        }

        public static Dados.cadernos_liberacoes Insert(Dados.cadernos_liberacoes liberacao, bool isAdmin)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                var venda = CadernoVendas.GetById(liberacao.id_venda);
                var caderno = Caderno.GetById(venda.id_caderno);

                if (caderno.liberada_escrit == false || isAdmin == true)
                {
                    //cria devolucao
                    conn.cadernos_liberacoes.Add(liberacao);
                    conn.SaveChanges();

                    //recupera informações da venda
                    var vendaUpdated = conn.cadernos_vendas.FirstOrDefault(a => a.id_venda == liberacao.id_venda);

                    //atualiza informações da venda
                    vendaUpdated.is_autorizada = true;
                    vendaUpdated.is_programada = false;
                    CadernoVendas.Update(vendaUpdated, isAdmin);

                    //remove devolução da venda
                    if (vendaUpdated.is_devolvida)
                    {
                        CadernoDevolucao.Delete(CadernoDevolucao.GetByVenda(vendaUpdated.id_venda).id_devolvida, isAdmin);
                    }

                    //retorna o registro
                    return GetById(liberacao.id_liberacao);
                }
                else
                {
                    throw new Exception(string.Format("O caderno de venda do dia {0} já esta fechado", caderno.data.ToShortDateString()));
                }
            }
        }

        public static Dados.cadernos_liberacoes Update(Dados.cadernos_liberacoes liberacao, bool isAdmin)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                var venda = CadernoVendas.GetById(liberacao.id_venda);
                var caderno = Caderno.GetById(venda.id_caderno);

                if (caderno.liberada_escrit == false || isAdmin)
                {
                    var updated = conn.cadernos_liberacoes.FirstOrDefault(a => a.id_liberacao == liberacao.id_liberacao);

                    //atualiza dados
                    updated.id_venda = liberacao.id_venda;
                    updated.id_tipo = liberacao.id_tipo;
                    updated.desconto = liberacao.desconto;
                    updated.observacao = liberacao.observacao;

                    //salva no banco de dados
                    conn.SaveChanges();

                    //retorna o registro
                    return GetById(liberacao.id_liberacao);
                }
                else
                {
                    throw new Exception(string.Format("O caderno de venda do dia {0} já esta fechado", caderno.data.ToShortDateString()));
                }
            }
        }

        public static Dados.cadernos_liberacoes Delete(int idLiberacao, bool isAdmin)
        {
            using (Dados.CPanelEntities conn = new Dados.CPanelEntities())
            {
                var deleted = conn.cadernos_liberacoes.FirstOrDefault(a => a.id_liberacao == idLiberacao);
                var venda = conn.cadernos_vendas.FirstOrDefault(a => a.id_venda == deleted.id_venda);
                var caderno = Caderno.GetById(venda.id_caderno);

                if (caderno.liberada_escrit == false || isAdmin)
                {

                    //remove do banco de dados
                    conn.cadernos_liberacoes.Remove(deleted);
                    conn.SaveChanges();

                    //modifica venda retirando marcação de devolvida
                    venda.is_autorizada = false;
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
    }
}
