using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Ferramentas.Spc
{
    public partial class Detalhe : Form
    {
        #region PROPRIEDADES

        public Dados.GFILIAL Filial { get; set; }
        public Dados.FCFO Cliente { get; set; }
        public List<Dados.TMOV> Vendas { get; set; }

        #endregion

        #region CONSTRUTOR

        public Detalhe(string p_Cliente, Dados.GFILIAL p_Filial)
        {
            Filial = p_Filial;
            Cliente = RM.Lib.Cliente.Get(p_Cliente, Filial.CODCOLIGADA);
            Vendas = RM.Lib.Movimento.GetVendasByCliente(Filial, Cliente.CODCFO);

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Detalhe_Load(object sender, EventArgs e)
        {
            CarregaLista();
        }

        #endregion

        #region METODOS

        private void CarregaLista() 
        {
            var i = 0;
            
            foreach (var venda in Vendas)
            {
                //cria grupo
                listViewDetalhe.Groups.Add(i.ToString(), string.Format("{0} - {1:d} - {2:c}", venda.IDMOV, venda.DATAEMISSAO.GetValueOrDefault(), venda.VALORLIQUIDO));

                foreach (var lanc in venda.FLAN)
                {
                    var item = new ListViewItem(new string[] { 
                        lanc.IDLAN.ToString(),
                        Lib.Lancamento.GetStatus(lanc.STATUSLAN),
                        lanc.DATAEMISSAO.ToShortDateString(),
                        lanc.DATAVENCIMENTO.ToShortDateString(),
                        lanc.DATABAIXA == null ? "" : lanc.DATABAIXA.Value.ToShortDateString(),
                        string.Format("{0:c}", lanc.VALORORIGINAL),
                        string.Format("{0:c}", lanc.VALORBAIXADO)
                    });
                    item.Group = listViewDetalhe.Groups[i];

                    //adiciona no grupo
                    listViewDetalhe.Items.Add(item);
                }

                i++;
            }
        }

        #endregion
    }
}
