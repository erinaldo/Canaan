using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPanel.Relatorios.Meta
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

        #region METODOS

        private void InitForm()
        {
            //inicializa data
            filtroAno.Text = DateTime.Today.Year.ToString();
            filtroMes.SelectedValue = DateTime.Today.Month;
            
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

        private void CarregaRelatorio()
        {
            //inicializa variaveis
            var filiais = new List<Dados.filiais>();
            var meta = new List<CPanel.Lib.Meta>();

            if (filtroTipoRede.Checked)
            {
                //relatorio da rede
                filiais = CPanel.Lib.Filiais.GetByRede();
                meta = CarregaMeta(filiais, true, "Meta da Rede");
            }
            else
            {
                if (filtroTipoFranquia.Checked)
                {
                    //relatorio das franquias
                    filiais = CPanel.Lib.Filiais.GetByFranquia();
                    meta = CarregaMeta(filiais, true, "Meta das Franquias");
                }
                else
                {
                    if (filtroTipoIndiv.Checked)
                    {
                        if (cbFilial.Checked)
                        {
                            //perfil individual
                            filiais.Add(CPanel.Lib.Filiais.GetById((int)filtroFilial.SelectedValue));
                            meta = CarregaMeta(filiais, false, "Meta Individual");
                        }
                        else
                        {
                            //perfil individual com todas as filiais
                            filiais = CPanel.Lib.Filiais.Get();
                            meta = CarregaMeta(filiais, false, "Meta Individual");
                        }
                    }
                    else
                    {
                        if (filtroTipoSetor.Checked)
                        {
                            //perfil por setor
                            filiais = CPanel.Lib.Filiais.GetBySetor((int)filtroSetor.SelectedValue);
                            meta = CarregaMeta(filiais, true, "Meta do Setor: " + filtroSetor.Text);
                        }
                    }
                }
            }

            //carrega o viewer
            var frm = new Viewer(meta);
            frm.Show();
        }

        private List<CPanel.Lib.Meta> CarregaMeta(List<CPanel.Dados.filiais> filiais, bool agrupado, string nome)
        {
            //inicializa variaveis
            var ano = int.Parse(filtroAno.Text);
            var mes = (int)filtroMes.SelectedValue;
            var meta = new List<CPanel.Lib.Meta>();
            var geral = new List<CPanel.Lib.Meta>();

            //retorna a lista de perfil individual ou geral
            if (agrupado == true)
            {
                geral.Add(CPanel.Lib.Meta.CalculaMetaGeral(ano, mes, filiais, nome));
                return geral;
            }
            else
            {
                //loop criando meta individual
                foreach (var filial in filiais)
                {
                    //calcula meta individual
                    var individual = CPanel.Lib.Meta.CalculaMeta(ano, mes, filial);

                    //adiciona na meta individual
                    meta.Add(individual);
                }

                return meta;
            }
        }

        #endregion

        #region EVENTOS

        private void Filtro_Load(object sender, EventArgs e)
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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        #endregion
    }
}
