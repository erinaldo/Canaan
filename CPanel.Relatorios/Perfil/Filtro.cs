using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Perfil
{
    public partial class Filtro : Form
    {
        #region PROPRIEDADES

        public CPanel.Dados.filiais Filial { get; set; }

        #endregion

        #region CONSTRUTORES

        public Filtro()
        {
            //inicializa tela
            InitializeComponent();

            //inicializa formaulario
            CarregaFiliais();
            CarregaSetores();
            CarregaMeses();
            InitForm();
        }

        public Filtro(int idFilial) 
        { 
            //inicializa propriedades
            this.Filial = CPanel.Lib.Filiais.GetById(idFilial);

            //inicializa tela
            InitializeComponent();

            //inicializa formulario
            CarregaFiliais();
            CarregaSetores();
            CarregaMeses();
            InitForm();
        }

        #endregion

        #region EVENTOS

        private void frmFiltro_Load(object sender, EventArgs e)
        {

        }

        private void filtroTipoRede_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxFilial.Enabled = false;
            GroupBoxSetor.Enabled = false;

            cbFilial.Enabled = false;
        }

        private void filtroTipoFranquia_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxFilial.Enabled = false;
            GroupBoxSetor.Enabled = false;

            cbFilial.Enabled = false;
        }

        private void filtroTipoIndiv_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxFilial.Enabled = true;
            GroupBoxSetor.Enabled = false;

            cbFilial.Enabled = true;
            cbFilial.Checked = false;
        }

        private void filtroTipoSetor_CheckedChanged(object sender, EventArgs e)
        {
            GroupBoxFilial.Enabled = false;
            GroupBoxSetor.Enabled = true;

            cbFilial.Enabled = false;
            cbFilial.Checked = false;
        }

        private void cbFilial_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilial.Checked)
                filtroFilial.Enabled = true;
            else
                filtroFilial.Enabled = false;
        }

        private void filtroMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaDias();
        }

        private void filtroAno_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(filtroAno.Text) > 2000)
            {
                CarregaDias();
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
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

            //verifica se tem filial selecionada
            if (Filial != null)
            {
                //seleciona filial
                filtroTipoIndiv.Checked = true;
                cbFilial.Checked = true;
                filtroFilial.SelectedValue = Filial.id_filial;

                //desabilita opcoes
                GroupBoxTipo.Enabled = false;
                GroupBoxFilial.Enabled = false;
                GroupBoxSetor.Enabled = false;
            }
            else 
            {
                filtroTipoRede.Checked = true;
            }
        }

        private void CarregaFiliais() 
        {
            filtroFilial.ValueMember = "id_filial";
            filtroFilial.DisplayMember = "nome";
            filtroFilial.DataSource = CPanel.Lib.Filiais.Get();
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
            var filiais = new List<Dados.filiais>();
            var perfil = new List<CPanel.Lib.PerfilOperacional>();

            if (filtroTipoRede.Checked)
            {
                //relatorio da rede
                filiais = CPanel.Lib.Filiais.GetByRede();
                perfil = CarregaPerfil(filiais, true, "Perfil da Rede");
            }
            else 
            {
                if (filtroTipoFranquia.Checked)
                {
                    //relatorio das franquias
                    filiais = CPanel.Lib.Filiais.GetByFranquia();
                    perfil = CarregaPerfil(filiais, true, "Perfil das Franquias");
                }
                else 
                {
                    if (filtroTipoIndiv.Checked)
                    {
                        if (cbFilial.Checked)
                        {
                            //perfil individual
                            filiais.Add(CPanel.Lib.Filiais.GetById((int)filtroFilial.SelectedValue));
                            perfil = CarregaPerfil(filiais, false, "Perfil Individual");
                        }
                        else
                        {
                            //perfil individual com todas as filiais
                            filiais = CPanel.Lib.Filiais.Get();
                            perfil = CarregaPerfil(filiais, false, "Perfil Individual");
                        }
                    }
                    else 
                    {
                        if (filtroTipoSetor.Checked) 
                        {
                            //perfil por setor
                            filiais = CPanel.Lib.Filiais.GetBySetor((int)filtroSetor.SelectedValue);
                            perfil = CarregaPerfil(filiais, true, "Perfil do Setor: " + filtroSetor.Text);
                        }
                    }
                }
            }

            //carrega o viewer
            var frm = new Viewer(perfil);
            frm.Show();
        }

        private List<CPanel.Lib.PerfilOperacional> CarregaPerfil(List<CPanel.Dados.filiais> filiais, bool agrupado, string nome) 
        {
            //inicializa variaveis
            var ano = int.Parse(filtroAno.Text);
            var mes = (int)filtroMes.SelectedValue;
            var inicio = int.Parse(filtroDiaInic.Text);
            var fim = int.Parse(filtroDiaFim.Text);
            var perfil = new List<CPanel.Lib.PerfilOperacional>();
            var geral = new List<CPanel.Lib.PerfilOperacional>();

            //loop criando perfil individual
            foreach (var filial in filiais)
            {
                //calcula perfil individual
                var individual = CPanel.Lib.PerfilOperacional.CalculaPerfil(ano, mes, inicio, fim, filial.id_filial);

                //adiciona na lista de perfil individual
                perfil.Add(individual);
            }

            //retorna a lista de perfil individual ou geral
            if (agrupado == true)
            {
                geral.Add(CPanel.Lib.PerfilOperacional.CalculaPerfilGeral(perfil, nome));
                return geral;
            }
            else
            {
                return perfil;
            }
        }

        #endregion

    }
}
