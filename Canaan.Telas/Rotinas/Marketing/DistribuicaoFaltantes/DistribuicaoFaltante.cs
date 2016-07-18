using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Rotinas.Marketing.DistribuicaoFaltantes.Parametros;
using Canaan.Telas.Rotinas.Marketing.DistribuicaoFaltantes.Redistribuicao;
using DevExpress.XtraEditors;
using Cupom = Canaan.Lib.Cupom;
using ItemCheckEventArgs = DevExpress.XtraEditors.Controls.ItemCheckEventArgs;
using Parceria = Canaan.Dados.Parceria;
using TelemarketingMov = Canaan.Lib.TelemarketingMov;
using Usuario = Canaan.Dados.Usuario;

namespace Canaan.Telas.Rotinas.Marketing.DistribuicaoFaltantes
{
    public partial class DistribuicaoFaltantes : Form
    {
        private CanaanModelContainer db = new CanaanModelContainer();

        #region PROPRIEDADES

        public List<Parceria> ListParceria { get; set; }

        public List<Usuario> ListUsuario { get; set; }

        public Lib.Usuario LibUsuario
        {
            get
            {
                return new Lib.Usuario(db);
            }
        }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }

        public Lib.Parceria LibParceria
        {
            get
            {
                return new Lib.Parceria(db);
            }
        }

        public Cupom LibCupom
        {
            get
            {
                return new Cupom(db);
            }
        }

        public TelemarketingMov LibTeleMarketingMov
        {
            get
            {
                return new TelemarketingMov();
            }
        }

        public int SelectedUserId
        {
            get
            {
                if (ckListFuncionarios.CheckedItems.Count <= 0)
                    return 0;

                var result = ckListFuncionarios.CheckedItems[0];

                if(result != null)
                    return int.Parse(result.ToString());

                return 0;
            }
        }

        public int[] ParceriasSelecionadas
        {
            get
            {
                var selecionados = ckListParcerias.CheckedItems;
                var retorno = new int[selecionados.Count];

                for (int i = 0; i < selecionados.Count; i++)
                {
                    retorno[i] = int.Parse(selecionados[i].ToString());
                }

                return retorno;
            }
        }

        public List<Dados.Cupom> Cupons { get; set; }

        #endregion

        #region CONSTRUTOR

        public DistribuicaoFaltantes()
        {
            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelecaoCupons_Load(object sender, EventArgs e)
        {
            //Devolve cupons expirados
            DevolverCuponsExpirados();
            CarregaForm();
        }

        /// <summary>
        /// Permite selecionar apenas 1 item na lista de funcionarias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBoxControl1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Permite apenas um registro selecionado por funcionario
            PermiteApenasOneChecked(sender, e);

            //Habilita ckPacerias
            HabilitaParcerias();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ckListParcerias.CheckedItems.Count > 0)
            {

                try
                {
                    //Carrega Cupons
                    CarregaCupons();

                    //Abre form para selecionar quantidade de cupons
                    var frm = new DadosDistribuicao();
                    frm.ShowDialog();

                    var numCupon = frm.NumeroDeCupons;
                    var dataLimite = frm.DataLimite;

                    //Sorteia cupom para usuario selecionado
                    SorteiaCuponUsuario(numCupon, dataLimite);

                    //Recarrega dados;
                    CarregaForm();

                }
                catch (Exception ex)
                {

                    MessageBoxUtilities.MessageError(this, ex);
                }
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhuma parceria selecionada");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTodos.Checked)
                ckListParcerias.CheckAll();
            else
                ckListParcerias.UnCheckAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void distribuirAgendadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedUserId > 0)
            {
                var frm = new Redistribuir(EnumTipoReditribuicao.Agendado, SelectedUserId);
                frm.ShowDialog();
                CarregaForm();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum Registro Selecionado");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedUserId > 0)
            {
                var frm = new Redistribuir(EnumTipoReditribuicao.Cupons, SelectedUserId);
                frm.ShowDialog();
                CarregaForm();
            }
            else
            {
                MessageBoxUtilities.MessageWarning("Nenhum Registro Selecionado");
            }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Habilita parceria
        /// </summary>
        /// <param name="e"></param>
        private void HabilitaParcerias()
        {
            if (ckListFuncionarios.CheckedItems.Count > 0)
            {
                ckTodos.Enabled = true;
                ckListParcerias.Enabled = true;
            }
            else
            {
                ckTodos.Enabled = false;
                ckListParcerias.Enabled = false;
            }
        }

        /// <summary>
        /// Permite apenas um item checado para funcionario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PermiteApenasOneChecked(object sender, ItemCheckEventArgs e)
        {
            if (e.State != CheckState.Checked)
                return;

            var lb = sender as CheckedListBoxControl;

            if(lb == null)
                throw new Exception("ChekedListBoxControl é nulo");

            for (var i = 0; i < lb.ItemCount; i++)
            {
                if (i != e.Index)
                    lb.SetItemChecked(i, false);
            }
        }

        /// <summary>
        /// Carrega Form
        /// </summary>
        private void CarregaForm()
        {
            CarregaDados();
            CarregaUsuarios();
            CarregaParcerias();
            HabilitaParcerias();
        }

        /// <summary>
        /// Carrega Parcerias
        /// </summary>
        private void CarregaParcerias()
        {

            var data = ListParceria.Select(a => new
                                    {
                                        a.IdParceria,
                                        Nome = string.Format("{0} - ({1})", a.Nome, GetCountCupons(a))
                                    }).ToList();

            ckListParcerias.ValueMember = "IdParceria";
            ckListParcerias.DisplayMember = "Nome";
            ckListParcerias.DataSource = data;
        }

        /// <summary>
        /// Retorna quantidade de cupons validos
        /// </summary>
        /// <param name="parceria"></param>
        /// <returns></returns>
        private int GetCountCupons(Parceria parceria)
        {
            return parceria.Cupom.Count(a => (a.IdStatusTele == null || a.IdStatusTele == EnumTelemarketingStatus.Faltante || a.IdStatusTele == EnumTelemarketingStatus.Expirado) && 
                                             a.Status == EnumCupomStatus.Faltante && 
                                             a.Parceria.IdFilial == Session.Contexto.IdFilial);
        }

        /// <summary>
        /// Carrega Lista de Usuarios
        /// </summary>
        private void CarregaUsuarios()
        {
            var data = ListUsuario.Select(a => new
            {
                a.IdUsuario,
                Nome = string.Format("{0} {1} - ({2})", a.Nome, a.Sobrenome, CountCuponsUsuario(a))
            }).ToList();

            ckListFuncionarios.ValueMember = "IdUsuario";
            ckListFuncionarios.DisplayMember = "Nome";
            ckListFuncionarios.DataSource = data;
        }

        /// <summary>
        /// Conta quantos cupons validos o usuario tem em sua posse
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private int CountCuponsUsuario(Usuario usuario)
        {
            //var cupons = usuario.CupomTele.Where(a => a.Status == Dados.EnumCupomStatus.Faltante &&
            //                                    a.IdStatusTele != Dados.EnumTelemarketingStatus.Faltante &&
            //                                    a.Parceria.IdFilial == Session.Contexto.IdFilial).ToList();
            

            return usuario.CupomTele.Count(a => a.Status == EnumCupomStatus.Faltante &&
                                                a.IdStatusTele != EnumTelemarketingStatus.Faltante &&
                                                a.Parceria.IdFilial == Session.Contexto.IdFilial);
        }

        /// <summary>
        /// Carrega Dados
        /// </summary>
        private void CarregaDados()
        {
            //Carrega Usuarios
            ListUsuario = LibUsuario.GetByFilialAndMktGrupoContext(Session.Contexto.IdFilial);

            //Carrega parcerias que possui cupom com faltantes
            ListParceria = LibParceria.GetParceriasSelecaoFaltantes(Session.Contexto.IdFilial);
        }

        /// <summary>
        /// Faz o sorteio entre os cupons das parcerias selecionadas
        /// </summary>
        /// <param name="numCupon"></param>
        /// <param name="dataLimite"></param>
        private void SorteiaCuponUsuario(int numCupon, DateTime dataLimite)
        {
            var sorteio = Cupons.Sortear(numCupon);

            foreach (var item in sorteio)
            {
                var update = item;

                //Atualiza Campos Cupom
                update.IdStatusTele = EnumTelemarketingStatus.Distribuido;
                update.DataTele = dataLimite;
                update.IdUsuarioTele = SelectedUserId;

                var result = LibCupom.Update(item);

                //SalvaMovimentacaoTele(result);
            }
        }

        /// <summary>
        /// Carrega os cupons das parcerias selecionadas
        /// </summary>
        private void CarregaCupons()
        {
            //Inicializa cupons
            Cupons = new List<Dados.Cupom>();

            //Carrega Cupons de todas as parcerias selecionadas
            foreach (var idParceria in ParceriasSelecionadas)
            {
                Cupons.AddRange(LibCupom.GetFaltantesByParceria(idParceria));
            }
        }

        private void DevolverCuponsExpirados()
        {

            LibCupom.DevolveCuponsExpirados();

            //var result = LibCupom.GetCuponsExpiradosContext(Session.Contexto.IdFilial);

            //foreach (var item in result)
            //{
            //    item.IdStatusTele = Dados.EnumTelemarketingStatus.Expirado;
            //    item.IdUsuarioTele = null;

            //    LibCupom.Update(item);
            //}
        }

        #endregion

        private void DistribuicaoFaltantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}
