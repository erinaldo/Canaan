using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Canaan.Relatorios.ViewModel.Base;

namespace Canaan.Relatorios.Base
{
    public partial class FiltroModelo : Form
    {
        #region PROPRIEDADES

        public BindingList<AtendimentoModel> Atendimentos { get; set; }
        public BindingList<ModeloModel> Modelos { get; set; }
        public Lib.Session Session
        {
            get
            {
                return Lib.Session.Instance;
            }
        }
        public AtendimentoModel Selected
        {
            get
            {
                if (atendimentosDataGridView.SelectedRows.Count > 0)
                {
                    var id = int.Parse(atendimentosDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    return Atendimentos.FirstOrDefault(a => a.IdAtendimento == id);
                }
                else
                {
                    return null;
                }
            }
        }
        public ModeloModel SelectedModelo
        {
            get
            {
                if (modelosDataGridView.SelectedRows.Count > 0)
                {
                    var id = int.Parse(modelosDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    return Modelos.FirstOrDefault(a => a.IdModelo == id);
                }
                else
                {
                    return null;
                }
            }
        }
        public Dados.EnumRelatorioTipo TipoRelatorio { get; set; }

        #endregion

        #region CONSTRUTORES

        public FiltroModelo(Dados.EnumRelatorioTipo pTipoRelatorio)
        {
            //inicializa as propriedades
            this.TipoRelatorio = pTipoRelatorio;

            //inicializa tela
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void FiltroModelo_Load(object sender, EventArgs e)
        {
            atendimentosDataGridView.AutoGenerateColumns = false;
            modelosDataGridView.AutoGenerateColumns = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //limpa lista
            modelosDataGridView.Rows.Clear();
            atendimentosDataGridView.Rows.Clear();

            //carrega grid
            CarregaAtendimentos();
            CarregaGridAtendimentos();
        }

        private void atendimentosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            CarregaModelos();
            CarregaGridModelos();
        }

        private void btnImpimir_Click(object sender, EventArgs e)
        {
            CarregaRelatorio();
        }

        #endregion

        #region METODOS

        private void CarregaAtendimentos()
        {
            //verifica se informou o codigo
            if (!string.IsNullOrEmpty(codigoTextBox.Text))
            {
                int codigo;

                if (int.TryParse(codigoTextBox.Text, out codigo))
                {
                    Atendimentos = new BindingList<AtendimentoModel>(AtendimentoModel.GetByAtendimento(codigo, Session.Contexto.IdFilial));
                }
                else
                {
                    //mensagem de erro
                    MessageBox.Show("Informe um atendimento valido");

                    //limpa o resultado do grid
                    atendimentosDataGridView.Rows.Clear();
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(nomeTextBox.Text))
                {
                    Atendimentos = new BindingList<AtendimentoModel>(AtendimentoModel.GetByNome(nomeTextBox.Text, Session.Contexto.IdFilial));
                }
                else
                {
                    //mensagem de erro
                    MessageBox.Show("Informe um atendimento valido");

                    //limpa o resultado do grid
                    atendimentosDataGridView.Rows.Clear();
                }
            }
        }

        private void CarregaGridAtendimentos()
        {
            atendimentosDataGridView.DataSource = Atendimentos;
        }
        
        private void CarregaModelos()
        {
            if (Selected != null)
                Modelos = new BindingList<ModeloModel>(ModeloModel.GetByAtendimento(Selected.IdAtendimento));
        }

        private void CarregaGridModelos()
        {
            modelosDataGridView.DataSource = Modelos;
        }

        private void CarregaRelatorio()
        {
            if (Selected != null && SelectedModelo != null)
            {
                switch (this.TipoRelatorio)
                {
                    case Canaan.Dados.EnumRelatorioTipo.Atendimento_Ficha:
                        var frmFicha = new Relatorios.Fichas.Atendimento.Viewer(Selected.IdAtendimento);
                        frmFicha.Show();
                        break;
                    case Canaan.Dados.EnumRelatorioTipo.Atendimento_UsoImagem:
                        var frmAuth = new Relatorios.Atendimento.UsoImagem.Viewer(Selected.IdAtendimento, SelectedModelo.IdModelo);
                        frmAuth.Show();
                        break;
                    case Canaan.Dados.EnumRelatorioTipo.Concurso_TopMirim:
                        var frmTopMirim = new Relatorios.Concurso.TopMirim.Viewer(Selected.IdAtendimento, SelectedModelo.IdModelo);
                        frmTopMirim.Show();
                        break;
                    case Canaan.Dados.EnumRelatorioTipo.Concurso_Garota:
                        var frmGarota = new Relatorios.Concurso.Garota.Viewer(Selected.IdAtendimento, SelectedModelo.IdModelo);
                        frmGarota.Show();
                        break;
                    case Canaan.Dados.EnumRelatorioTipo.Concurso_BabyShow:
                        var frmBabyShow = new Relatorios.Concurso.BabyShow.Viewer(Selected.IdAtendimento, SelectedModelo.IdModelo);
                        frmBabyShow.Show();
                        break;
                    case Canaan.Dados.EnumRelatorioTipo.Concurso_Newborn:
                        var frmNewborn = new Relatorios.Concurso.Newborn.Viewer(Selected.IdAtendimento, SelectedModelo.IdModelo);
                        frmNewborn.Show();
                        break;
                    default:
                        Lib.MessageBoxUtilities.MessageInfo("Nenhum relatorio selecionado");
                        break;
                }
            }
            else
            {
                Lib.MessageBoxUtilities.MessageError(null, new Exception("É necessário selecionar um cliente e um modelo"));
            }
        }

        #endregion
    }
}
