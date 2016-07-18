using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Telas.Properties;
using DevExpress.XtraEditors;
using Cupom = Canaan.Lib.Cupom;

namespace Canaan.Telas.Rotinas.Marketing.Telemarketing
{
    public partial class Lista : XtraForm
    {
        #region PROPRIEDADES

        public Cupom LibCupom
        {
            get
            {
                return new Cupom();
            }
        }

        public List<Dados.Cupom> ListCupons { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public int Id
        {
            get
            {
                if (dataGrid.SelectedRows.Count > 0)
                    return int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString());

                return 0;
            }
        }

        #endregion

        #region CONSTRUTORES

        public Lista()
        {
            //inicializa propriedades
            CarregaDados();

            //inicializa os componentes
            InitializeComponent();

            //inicializa o titulo
            Text = "Listagem de Telemarketing";
        }

        #endregion

        #region EVENTOS

        private void Lista_Load(object sender, EventArgs e)
        {
            DevolveExpirados();
            CarregaActions();

            CarregaDados();
            CarregaGrid(LibCupom.CarregaGrid(ListCupons));
            ColorirGrid();
        }

        private void dataGrid_DoubleClick(object sender, EventArgs e)
        {
            OpenCupomView();
        }

        private void btnFiliais_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                var frmParcerias = new Telas.Marketing.Parceria.Lista(Id);
                frmParcerias.ShowDialog();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
        }

        private void btLembretes_Click(object sender, EventArgs e)
        {
            var frmLembretes = new Lembrete.Lista();
            frmLembretes.ShowDialog();

            //Recarrega Dados
            CarregaDados();
            CarregaGrid(LibCupom.CarregaGrid(ListCupons));
        }

        private void agendaStripButton1_Click(object sender, EventArgs e)
        {
            OpenCupomView();
        }

        #endregion

        #region METODOS

        private void DevolveExpirados()
        {
            LibCupom.DevolveCuponsExpirados();
        }

        private void CarregaDados()
        {
            ListCupons = LibCupom.GetByUsuario(Session.Usuario.IdUsuario, Session.Contexto.IdFilial);
        }

        private void ColorirGrid()
        {
            foreach (DataGridViewRow item in dataGrid.Rows)
            {
                var dataGridViewCell = item.Cells.Cast<DataGridViewCell>().LastOrDefault();

                if (dataGridViewCell != null)
                {
                    var result = dataGridViewCell.Value.ToString();

                    if(Enum.IsDefined(typeof(EnumCupomStatus), result))
                    {
                        var status = (EnumCupomStatus)Enum.Parse(typeof(EnumCupomStatus), result);

                        switch (status)
                        {
                            case EnumCupomStatus.EmAberto:
                                break;
                            case EnumCupomStatus.Agendado:
                                break;
                            case EnumCupomStatus.Faltante:
                                break;
                            case EnumCupomStatus.Cancelado:
                                break;
                            case EnumCupomStatus.Descartado:
                                break;
                            case EnumCupomStatus.Confirmado:
                                break;
                            case EnumCupomStatus.Atendido:
                                break;
                            case EnumCupomStatus.Desligado:
                                item.DefaultCellStyle.BackColor = Color.FromArgb(255, 207, 155);
                                break;
                            case EnumCupomStatus.JaFotografou:
                                break;
                            case EnumCupomStatus.NaoQuer:
                                break;
                            case EnumCupomStatus.NumeroErrado:
                                break;
                            case EnumCupomStatus.NaoAtende:
                                item.DefaultCellStyle.BackColor = Color.FromArgb(255, 155, 164);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }

        //
        //METODOS
        protected void CarregaGrid(dynamic lista)
        {
            if (lista != null)
            {
                dataGrid.DataSource = lista;
                ColorirGrid();
            }
        }

        protected void CarregaActions()
        {
            btnActions.DropDownItems.Add(new ToolStripMenuItem("Parcerias", Resources.arrow_Sync_16xLG, new EventHandler(btnFiliais_Click)));
        }

        protected void CarregaFiltros()
        {
        }

        private void OpenCupomView()
        {
            if (Id <= 0)
            {
                MessageBoxUtilities.MessageWarning("Nenhum registro selecionado");
            }
            else
            {
                var cupomView = new CupomView(Id);
                cupomView.ShowDialog();

                //Recarrega Dados do Banco
                CarregaDados();
                CarregaGrid(LibCupom.CarregaGrid(ListCupons));
            }
        }

        #endregion


    }
}
