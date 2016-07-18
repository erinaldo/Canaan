using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using DevExpress.XtraEditors;
using Cupom = Canaan.Lib.Cupom;
using ItemCheckEventArgs = DevExpress.XtraEditors.Controls.ItemCheckEventArgs;
using TelemarketingAgenda = Canaan.Lib.TelemarketingAgenda;
using Usuario = Canaan.Lib.Usuario;

namespace Canaan.Telas.Rotinas.Marketing.DistribuicaoCupons.Redistribuicao
{
    public partial class Redistribuir : Form
    {
        #region CAMPOS

        private EnumTipoReditribuicao tipo;
        private int userId;

        #endregion

        #region PROPRIEDADES


        public TelemarketingAgenda LibTeleAgenda 
        {
            get
            {
                return new TelemarketingAgenda();
            }
        }

        public Usuario LibUsuario
        {
            get
            {
                return new Usuario();
            }
        }

        public Cupom LibCupom
        {
            get
            {
                return new Cupom();
            }
        }

        public List<Dados.Usuario> ListUsuario { get; set; }

        public List<Dados.Cupom> ListCupom { get; set; }

        public List<Dados.TelemarketingAgenda> ListAgendados { get; set; }

        public List<int> ItensSelecionados
        {
            get
            {
                var result = dtGridCupons.Rows.Cast<DataGridViewRow>()
                                         .Where(a => (bool)a.Cells[0].EditedFormattedValue)
                                         .Select(a => int.Parse(a.Cells[1].Value.ToString()))
                                         .ToList();

                if (result.Count <= 0)
                    return null;

                return result;
            }
        }

        public int UsuarioSelecionado
        {
            get
            {
                return int.Parse(ckListFuncionarios.CheckedItems[0].ToString());
            }
        }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        #endregion

        #region CONSTRUTOR

        public Redistribuir(EnumTipoReditribuicao tipo, int SelectedUserId)
        {
            // TODO: Complete member initialization
            this.tipo = tipo;
            userId = SelectedUserId;

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Redistribuir_Load(object sender, EventArgs e)
        {
            ConfiguraForm();
            CarregaForm();
        }

        private void ckListFuncionarios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            PermiteApenasOneChecked(sender, e);
        }

        private void PermiteApenasOneChecked(object sender, ItemCheckEventArgs e)
        {
            if (e.State != CheckState.Checked)
                return;

            CheckedListBoxControl lb = sender as CheckedListBoxControl;

            for (int i = 0; i < lb.ItemCount; i++)
            {
                if (i != e.Index)
                    lb.SetItemChecked(i, false);
            }
        }

        private void ckListFuncionarios_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {

        }

        private void ckListFuncionarios_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            HabilitarCupons();
        }

        private void ckTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTodos.Checked)
            {
                CheckAllRows(true);
            }
            else
            {
                CheckAllRows(false);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //dtGridCupons.BeginEdit(false);

            if (ItensSelecionados == null)
            {
                MessageBoxUtilities.MessageWarning("Nenhum Registro selecionado");
            }
            else
            {

                if (tipo == EnumTipoReditribuicao.Cupons)
                {
                    foreach (var item in ItensSelecionados)
                    {
                        var cupom = LibCupom.GetById(item);
                        cupom.IdUsuarioTele = UsuarioSelecionado;
                        LibCupom.Update(cupom);
                    }

                }
                else
                {
                    foreach (var item in ItensSelecionados)
                    {
                        //Atualiza Agenda
                        var agendado = LibTeleAgenda.GetById(item);
                        agendado.IdUsuario = UsuarioSelecionado;
                        LibTeleAgenda.Update(agendado);

                        //Atualiza Cupom
                        var cupom = LibCupom.GetById(agendado.IdCupom);
                        cupom.IdUsuarioTele = UsuarioSelecionado;
                        LibCupom.Update(cupom);
                    }
                }
                MessageBoxUtilities.MessageInfo("Cupons Redistribuidos com sucesso");

                CarregaForm();
            }
        }

        #endregion

        #region METODOS

        private void CarregaDados()
        {
            //Carrega lista de usuarios
            ListUsuario = LibUsuario.GetByFilialAndMktGrupo(Session.Contexto.IdFilial);

            switch (tipo)
            {
                case EnumTipoReditribuicao.Agendado:
                    ListAgendados = LibTeleAgenda.GetByUsuarioAndFilial(userId, Session.Contexto.IdFilial);
                    break;
                case EnumTipoReditribuicao.Cupons:
                    ListCupom = LibCupom.GetByUsuario(userId, Session.Contexto.IdFilial);
                    break;
                default:
                    break;
            }

        }

        private void CarregaUsuarios()
        {
            var data = ListUsuario.Where(a => a.IdUsuario != userId).Select(a => new
            {
                a.IdUsuario,
                Nome = string.Format("{0} {1} - ({2})", a.Nome, a.Sobrenome, CountCuponsUsuario(a))
            }).ToList();

            ckListFuncionarios.ValueMember = "IdUsuario";
            ckListFuncionarios.DisplayMember = "Nome";
            ckListFuncionarios.DataSource = data;
        }

        private int CountCuponsUsuario(Dados.Usuario usuario)
        {
            return usuario.CupomTele.Where(a => a.IdStatusTele != null && a.IdStatusTele == EnumTelemarketingStatus.Distribuido).Count();
        }

        private void ConfiguraForm()
        {
            switch (tipo)
            {
                case EnumTipoReditribuicao.Agendado:
                    Text += string.Format(" - Agendados de {0}", GetUsuario());
                    break;
                case EnumTipoReditribuicao.Cupons:
                    Text += " - Distribuídos";
                    break;
                default:
                    break;
            }

            EnableRowCheck();

            userLabel.Text = GetUsuario();
        }

        private string GetUsuario()
        {
            var user = LibUsuario.GetById(userId);
            return string.Format("{0} {1}", user.Nome, user.Sobrenome);
        }

        private void CarregaCupons()
        {
            dtGridCupons.DataSource = ListCupom.Select(a => new
            {
                Codigo = a.IdCupom,
                Usuario = a.UsuarioTele.Nome,
                Cliente = a.Nome,
                Status = a.TelemarketingStatus.Nome
            }).ToList();

            //Seta valor default para as linhas 
            foreach (DataGridViewRow item in dtGridCupons.Rows)
            {
                item.Cells[0].Value = false;
            }
        }

        private void EnableRowCheck()
        {

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Redistribuir";
            chk.Name = "chk";
            chk.ReadOnly = false;

            dtGridCupons.Columns.Add(chk);
            dtGridCupons.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void HabilitarCupons()
        {
            if (ckListFuncionarios.CheckedItems.Count > 0)
            {
                ckTodos.Enabled = true;
                dtGridCupons.Enabled = true;
            }
            else
            {
                ckTodos.Enabled = false;
                dtGridCupons.Enabled = false;
            }
        }

        private void CheckAllRows(bool check)
        {
            foreach (DataGridViewRow item in dtGridCupons.Rows)
            {
                item.Cells[0].Value = check;
            }
        }

        private void CarregaForm()
        {
            CarregaDados();
            CarregaUsuarios();

            if (tipo == EnumTipoReditribuicao.Cupons)
                CarregaCupons();
            else
                CarregaAgendamento();

            HabilitarCupons();
        }

        private void CarregaAgendamento()
        {
            dtGridCupons.DataSource = ListAgendados.Select(a => new
            {
                Codigo = a.IdTelemarketingAgenda,
                Cupom  = a.IdCupom,
                Usuario = a.Usuario.Nome,
                Cliente = a.Cupom.Nome,
                Status = a.Cupom.TelemarketingStatus.Nome
            }).ToList();

            //Seta valor default para as linhas 
            foreach (DataGridViewRow item in dtGridCupons.Rows)
            {
                item.Cells[0].Value = false;
            }
        }

        #endregion
    }
}
