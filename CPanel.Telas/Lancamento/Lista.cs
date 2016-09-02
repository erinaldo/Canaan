using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Telas.Lancamento
{
    public partial class Lista : Form
    {
        #region PROPRIEDADES

        public Dados.filiais Filial { get; set; }
        public Dados.periodos Periodo { get; set; }
        public List<ListaViewModel> Lancamentos { get; set; }
        public bool IsAdmin { get; set; }
        public int Current 
        {
            get 
            {
                if (gridLancamentos.SelectedRows.Count > 0)
                {
                    return (int)gridLancamentos.SelectedRows[0].Cells["Codigo"].Value;
                }
                else
                {
                    return 0;
                }
            }
        }

        #endregion

        #region CONSTRUTORES

        public Lista(bool p_IsAdmin)
        {
            //inicializa as propriedades
            this.IsAdmin = p_IsAdmin;

            //inicializa os componentes
            InitializeComponent();
        }

        public Lista(bool p_IsAdmin, int p_IdFilial)
        {
            //inicializa as propriedades
            this.Filial = Lib.Filiais.GetById(p_IdFilial);
            this.IsAdmin = p_IsAdmin;

            //inicializa os componentes
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaLancamentos();
            CarregaGrid();
        }

        private void gridLancamentos_DoubleClick(object sender, EventArgs e)
        {
            MostraSelecionado();
        }

        #endregion

        #region METODOS

        private void InitForm() 
        {
            gridLancamentos.AutoGenerateColumns = false;
            filtroAno.Text = DateTime.Today.Year.ToString();

            CarregaFiliais();
            CarregaMeses();
            CarregaLancamentos();
            CarregaGrid();
        }

        private void CarregaFiliais()
        {
            //configura o combobox
            filtroFilial.DisplayMember = "nome";
            filtroFilial.ValueMember = "id_filial";

            //seta o datasource
            filtroFilial.DataSource = Lib.Filiais.Get();

            //verifica se tem filial selecionada
            if (Filial != null)
            {
                filtroFilial.Enabled = false;
                filtroFilial.SelectedValue = Filial.id_filial;
            }
        }

        private void CarregaMeses()
        {
            //configura o combobox
            filtroMes.DisplayMember = "descricao";
            filtroMes.ValueMember = "mes";

            //seta o datasource
            filtroMes.DataSource = Lib.Meses.Get();

            //verifica se tem filial selecionada
            filtroMes.SelectedValue = DateTime.Today.Month;
        }

        private void CarregaLancamentos() 
        {
            this.Periodo = Lib.Periodo.GetPeriodo(int.Parse(filtroAno.Text), (int)filtroMes.SelectedValue, (int)filtroFilial.SelectedValue);

            if (this.Periodo != null)
            {
                //carrega lancamentos do banco de dados
                var lancamentos = Lib.Lancamento.GetByPeriodo(this.Periodo.id_periodo);

                if (lancamentos.Count > 0)
                {
                    this.Lancamentos = ListaViewModel.Get(lancamentos);
                }
                else 
                {
                    MessageBox.Show("Nenhum lançamento encontrado");
                }
            }
            else 
            {
                MessageBox.Show("Nenhum périodo de lançamento encontrado");
            }
        }

        private void CarregaGrid() 
        {
            gridLancamentos.DataSource = this.Lancamentos;
        }

        private void MostraSelecionado() 
        {
            if (this.Current > 0)
            {
                var frm = new Edita(this.Current);
                frm.Show();
            }
            else 
            {
                MessageBox.Show("Nenhumm lançamento selecionado");
            }
        }

        #endregion       
    }
}
