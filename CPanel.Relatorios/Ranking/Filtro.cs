using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Ranking
{
    public partial class Filtro : Form
    {
        #region PROPRIEDADES

        public CPanel.Dados.filiais Filial { get; set; }
        public bool ExibeValor { get; set; }

        #endregion

        #region CONSTRUTORES

        public Filtro()
        {
            //inicializa propriedades
            ExibeValor = true;

            //inicializa a tela
            InitializeComponent();

            //inicializa formaulario
            CarregaSetores();
            CarregaMeses();
            InitForm();
        }

        public Filtro(int idFilial)
        {
            //inicializa propriedades
            Filial = CPanel.Lib.Filiais.GetById(idFilial);
            ExibeValor = false;

            //inicializa a tela
            InitializeComponent();

            //inicializa formaulario
            CarregaSetores();
            CarregaMeses();
            InitForm();
        }

        #endregion

        #region METODOS

        private void InitForm()
        {
            //inicializa data
            filtroAno.Text = DateTime.Today.Year.ToString();
            filtroMes.SelectedValue = DateTime.Today.Month;
            filtroDiaInic.Text = DateTime.Today.Day > 1 ? (DateTime.Today.Day - 1).ToString() : "1";
            filtroDiaFim.Text = DateTime.Today.Day > 1 ? (DateTime.Today.Day - 1).ToString() : "1";
            filtroTipoGeral.Checked = true;
        }

        private void CarregaSetores()
        {
            filtroSetor.ValueMember = "id_setor";
            filtroSetor.DisplayMember = "nome";
            filtroSetor.DataSource = CPanel.Lib.Setores.Get();
        }

        private void CarregaMeses()
        {
            filtroMes.ValueMember = "mes";
            filtroMes.DisplayMember = "descricao";
            filtroMes.DataSource = CPanel.Lib.Meses.Get();
        }

        private void CarregaDias()
        {
            if (!String.IsNullOrEmpty(filtroAno.Text))
            {
                //limpa dias
                filtroDiaInic.Items.Clear();
                filtroDiaFim.Items.Clear();

                //pega valor maximo de dias
                var max = DateTime.DaysInMonth(int.Parse(filtroAno.Text), (int)filtroMes.SelectedValue);

                //preenche os dias
                for (int i = 1; i <= max; i++)
                {
                    filtroDiaInic.Items.Add(i);
                    filtroDiaFim.Items.Add(i);
                }

                //seleciona o dia
                filtroDiaInic.SelectedIndex = 0;
                filtroDiaFim.SelectedIndex = 0;
            }
        }

        private void CarregaRelatorio() 
        {
            //inicializa variaveis
            var tipo = "Nenhum";
            var filiais = new List<Dados.filiais>();
            var perfil = new List<CPanel.Lib.PerfilOperacional>();

            //verifica o tipo de consulta
            if (filtroTipoGeral.Checked)
            {
                //geral
                tipo = "Geral";
                filiais = CPanel.Lib.Filiais.Get();
            }
            else 
            {
                if (filtroTipoRede.Checked)
                {
                    tipo = "Rede";
                    filiais = CPanel.Lib.Filiais.GetByRede();
                }
                else 
                {
                    if (filtroTipoFranquia.Checked)
                    {
                        tipo = "Franquia";
                        filiais = CPanel.Lib.Filiais.GetByFranquia();
                    }
                    else 
                    {
                        tipo = "Setor";
                        filiais = CPanel.Lib.Filiais.GetBySetor((int)filtroSetor.SelectedValue);
                    }
                }
            }

            //carrega o perfil operacional das filiais selecionadas
            perfil = CarregaPerfil(filiais);

            //carrega relatorio do ranking
            var frm = new Viewer(perfil, tipo, ExibeValor);
            frm.Show();
        }

        private List<CPanel.Lib.PerfilOperacional> CarregaPerfil(List<CPanel.Dados.filiais> filiais)
        {
            //inicializa variaveis
            var ano = int.Parse(filtroAno.Text);
            var mes = (int)filtroMes.SelectedValue;
            var inicio = int.Parse(filtroDiaInic.Text);
            var fim = int.Parse(filtroDiaFim.Text);
            var perfil = new List<CPanel.Lib.PerfilOperacional>();
            
            //loop criando perfil individual
            foreach (var filial in filiais)
            {
                //calcula perfil individual
                var individual = CPanel.Lib.PerfilOperacional.CalculaPerfil(ano, mes, inicio, fim, filial.id_filial);

                //adiciona na lista de perfil individual
                perfil.Add(individual);
            }

            return perfil;
        }

        #endregion

        #region EVENTOS

        private void filtroTipoGeral_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxSetor.Enabled = false;
        }

        private void filtroTipoRede_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxSetor.Enabled = false;
        }

        private void filtroTipoFranquia_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxSetor.Enabled = false;
        }

        private void filtroTipoSetor_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxSetor.Enabled = true;
        }

        private void filtroAno_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(filtroAno.Text) > 2000)
            {
                CarregaDias();
            }
        }

        private void filtroMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaDias();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        #endregion
    }
}
