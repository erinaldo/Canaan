using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.CService.Telas.Integracao.Venda.Sincronismo
{
    public partial class Lista : Form
    {
        #region PROPRIEDADES

        public int Coligada 
        {
            get 
            {
                return Properties.Settings.Default.Coligada;
            }
        }
        public string Movimento
        {
            get
            {
                return Properties.Settings.Default.Movimento;
            }
        }
        public int Prazo 
        {
            get 
            {
                return Properties.Settings.Default.Prazo;
            }
        }

        public List<Lib.Integracao.Venda> Vendas { get; set; }

        #endregion

        #region CONSTRUTOR

        public Lista()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void vendasGridView_DoubleClick(object sender, EventArgs e)
        {
            CarregaDetalhe();
        }

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            Sincroniza();
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            Libera();
        }

        #endregion

        #region METODOS

        private void Init() 
        {
            CarregaDados();
            CarregaGrid();
        }

        private void CarregaDados() 
        {
            this.Vendas = Lib.Integracao.Venda.GetPendentes(this.Coligada, this.Movimento);
            this.infoLabel.Text = string.Format("Total de vendas para sincronizar: {0}", this.Vendas.Count);
        }

        private void CarregaGrid()
        {
            vendasGridView.AutoGenerateColumns = false;
            vendasGridView.DataSource = this.Vendas;
            vendasGridView.ClearSelection();
        }

        private void CarregaDetalhe()
        {
            if (vendasGridView.SelectedRows.Count > 0)
            {
                var id = (int)vendasGridView.SelectedRows[0].Cells["Codigo"].Value;

                var frm = new Detalhe(Vendas.FirstOrDefault(a => a.IdVenda == id));
                frm.ShowDialog();

                vendasGridView.ClearSelection();
            }
            else 
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }

        private void Sincroniza() 
        {
            var hasErros = false;
            var errorLog = string.Empty;

            foreach (var item in Vendas)
            {
                try
                {
                    Lib.Integracao.Venda.SincronizarVenda(item, Coligada, Prazo);
                }
                catch (Exception ex)
                {
                    hasErros = true;
                    errorLog = errorLog + ex.Message + "\n\n";
                }
            }

            if (hasErros) 
            {
                MessageBox.Show(errorLog);
            }

            Init();
        }

        private void Libera() 
        {
            if (vendasGridView.SelectedRows.Count > 0)
            {
                var id = (int)vendasGridView.SelectedRows[0].Cells["Codigo"].Value;

                var frm = new Libera(Vendas.FirstOrDefault(a => a.IdVenda == id));
                frm.ShowDialog();

                Init();
            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionada");
            }
        }

        #endregion
    }
}
