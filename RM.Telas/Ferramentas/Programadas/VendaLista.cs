using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Telas.Ferramentas.Programadas
{
    public partial class VendaLista : Form
    {
        //
        //PROPRIEDADES
        public List<Dados.TMOV> Vendas { get; set; }

        //
        //CONSTRUTORES
        public VendaLista()
        {
            InitializeComponent();
        }

        //
        //EVENTOS
        private void VendaLista_Load(object sender, EventArgs e)
        {
            ExecutaFiltro();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ExecutaFiltro();
        }
      
        private void btnLancamentos_Click(object sender, EventArgs e)
        {
            CarregaLancamentos();
        }

        private void vendasGridView_DoubleClick(object sender, EventArgs e)
        {
            CarregaLancamentos();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            RetiraCaderno();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaCaderno();
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            UpdateVenda();
        }

        //
        //METODOS
        private void CarregaGrid() 
        {
            if (Vendas.Count > 0) 
            {
                //verifica se tem tabela complentar
                foreach (var venda in this.Vendas)
                {
                    if (venda.TMOVCOMPL == null) 
                    {
                        venda.TMOVCOMPL = Lib.Movimento.InsertCompl(venda);
                    }
                }

                //carrega o grid
                vendasGridView.DataSource = Vendas.Select(a => new { 
                    Codigo = a.IDMOV,
                    Cmaster = a.FCFO.FCFOCOMPL.CODCMASTER,
                    Movimento = a.CODTMV,
                    Status = Lib.Movimento.GetStatus(a.STATUS),
                    Cliente = string.Format("{0} - {1}", a.CODCFO, a.FCFO.NOME),
                    Classe = a.CODTB1FLX,
                    Emissao = a.DATAEMISSAO,
                    Caderno = a.TMOVCOMPL.DTLIBERACAO,
                    Valor = a.VALORLIQUIDO
                }).ToList();

                vendasGridView.ClearSelection();
            }

        }

        private void ExecutaFiltro()
        {
            //executa filtro
            var frm = new VendaFiltro();
            frm.ShowDialog();

            //atualiza lista de vendas
            if (frm.Vendas != null)
            {
                Vendas = frm.Vendas;
                CarregaGrid();
            }
        }

        private void UpdateVenda() 
        {
            if (Vendas.Count > 0)
            {
                var filial = Lib.Filiais.GetById((short)Vendas.FirstOrDefault().CODCOLIGADA, (short)Vendas.FirstOrDefault().CODFILIAL);
                var cliente = Vendas.FirstOrDefault().CODCFO;

                Vendas = Lib.Movimento.GetVendasByCliente(filial, cliente);

                CarregaGrid();
            }
        }

        private void CarregaLancamentos() 
        {
            if (vendasGridView.SelectedRows.Count > 0)
            {
                //recupera o codigo do movimento
                int idmov = (int)vendasGridView.SelectedRows[0].Cells["Codigo"].Value;

                //abre a tela com os lancamentos
                var frm = new LancLista(Vendas.FirstOrDefault(a => a.IDMOV == idmov));
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }

        private void RetiraCaderno() 
        {
            if (vendasGridView.SelectedRows.Count > 0)
            {
                //recupera o codigo do movimento
                int idmov = (int)vendasGridView.SelectedRows[0].Cells["Codigo"].Value;
                var atual = Vendas.FirstOrDefault(a => a.IDMOV == idmov);

                string msg = string.Format("Tem certeza que deseja retirar a venda {0} - {1} no valor de {2} do caderno dia dia {3}", atual.IDMOV, atual.FCFO.NOME, atual.VALORLIQUIDO, atual.TMOVCOMPL.DTLIBERACAO.GetValueOrDefault().ToShortDateString());

                if (MessageBox.Show(msg, "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) 
                {
                    try
                    {
                        //remove do caderno
                        Lib.Movimento.UpdateRetiraCaderno(atual);

                        //mensagem de sucesso
                        MessageBox.Show("Venda retira do caderno");

                        //atualiza lista
                        UpdateVenda();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }

        private void CarregaCaderno() 
        { 
            if (vendasGridView.SelectedRows.Count > 0)
            {
                //recupera o codigo do movimento
                int idmov = (int)vendasGridView.SelectedRows[0].Cells["Codigo"].Value;
                var atual = Vendas.FirstOrDefault(a => a.IDMOV == idmov);

                //abre formulario de caderno
                VendaCaderno frm = new VendaCaderno(atual);
                frm.ShowDialog();

                //atualiza lista
                UpdateVenda();
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
            
        }

        
    }
}
