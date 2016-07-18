using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Canaan.Dados;
using Canaan.Lib;
using Canaan.Lib.Utilitarios;
using Canaan.Telas.Rotinas.Marketing.DistribuicaoCupons.Parametros;
using Canaan.Telas.Rotinas.Marketing.DistribuicaoCupons.Redistribuicao;
using DevExpress.XtraEditors;
using Cupom = Canaan.Lib.Cupom;
using ItemCheckEventArgs = DevExpress.XtraEditors.Controls.ItemCheckEventArgs;
using Parceria = Canaan.Dados.Parceria;
using TelemarketingMov = Canaan.Lib.TelemarketingMov;
using Usuario = Canaan.Dados.Usuario;

namespace Canaan.Telas.Rotinas.Marketing.DistribuicaoCupons
{
    public partial class DistribuicaoCupons : Form
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

                if (result != null)
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

        public DistribuicaoCupons()
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
                    var operadoras = frm.Operadoras.ToArray();

                    //Sorteia cupom para usuario selecionado
                    SorteiaCuponUsuario(numCupon, dataLimite, operadoras);

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

        private void DistribuicaoCupons_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
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

            CheckedListBoxControl lb = sender as CheckedListBoxControl;

            for (int i = 0; i < lb.ItemCount; i++)
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
            //Carrega usuarios e parcerias que possuem cupons
            CarregaDados();

            //Carrega lista de usuarios no form
            CarregaUsuarios();

            //Carrega lista de Parcerias no form
            CarregaParcerias();

            //Habilita parceias
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
            //return parceria.Cupom.Where(a => (a.IdStatusTele == null || a.IdStatusTele == Dados.EnumTelemarketingStatus.Expirado) && a.Parceria.IdFilial == Session.Contexto.IdFilial).Count();
            return parceria.Cupom.Count(a => a.IsDescartado == false && a.IsAgendado == false && a.IsLembrete == false && a.IdUsuarioTele == null);
        }

        /// <summary>
        /// Carrega Lista de Usuarios
        /// </summary>
        private void CarregaUsuarios()
        {
            var data = ListUsuario.Select(a => new
            {
                a.IdUsuario,
                Nome = string.Format("{0} {1} - ({2} Novos), ({3} Lembrete), ({4} Faltante) ", a.Nome, a.Sobrenome, CountCuponsDistribuidosUsuario(a), CountCuponsLembreteUsuario(a), CountCuponsFaltanteUsuario(a))
            }).ToList();

            ckListFuncionarios.ValueMember = "IdUsuario";
            ckListFuncionarios.DisplayMember = "Nome";
            ckListFuncionarios.DataSource = data;
        }

        private int CountCuponsFaltanteUsuario(Usuario usuario)
        {
            //return usuario.CupomTele.Where(a => a.IdStatusTele != null &&
            //                      (a.IdStatusTele == Dados.EnumTelemarketingStatus.Distribuido) &&
            //                      (a.Status == Dados.EnumCupomStatus.Faltante) &&
            //                       a.Parceria.IdFilial == Session.Contexto.IdFilial)
            //              .Count();
            return usuario.CupomTele.Where(a => a.IsAgendado == false && a.IsDescartado == false && a.IsLembrete == false && a.Status == EnumCupomStatus.Faltante).Count();
        }

        /// <summary>
        /// Conta quantos cupons o usuario possui que tem lembretes
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private int CountCuponsLembreteUsuario(Usuario usuario)
        {
            //return usuario.CupomTele.Where(a => a.IdStatusTele != null &&
            //                               (a.IdStatusTele == Dados.EnumTelemarketingStatus.Agendado) &&
            //                                a.Parceria.IdFilial == Session.Contexto.IdFilial)
            //                        .Count();
            return usuario.CupomTele.Where(a => a.IsAgendado == false && a.IsDescartado == false && a.IsLembrete == true).Count();
        }

        /// <summary>
        /// Conta quantos cupons novos validos o usuario tem em sua posse
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private int CountCuponsDistribuidosUsuario(Usuario usuario)
        {

            //var result = usuario.CupomTele.Where(a => a.IsAgendado == false && a.IsDescartado == false && a.IsLembrete == false).ToList();

            //return usuario.CupomTele.Where(a => a.IdStatusTele != null &&
            //                                    (a.IdStatusTele == Dados.EnumTelemarketingStatus.Distribuido) &&
            //                                    (a.Status != Dados.EnumCupomStatus.Faltante) &&
            //                                     a.Parceria.IdFilial == Session.Contexto.IdFilial)
            //                        .Count();

            return usuario.CupomTele.Count(a => a.IsAgendado == false && a.IsDescartado == false && a.IsLembrete == false);
        }

        /// <summary>
        /// Carrega Dados
        /// </summary>
        private void CarregaDados()
        {
            //Carrega Usuarios
            ListUsuario = LibUsuario.GetByFilialAndMktGrupoContext(Session.Contexto.IdFilial);
            //ListUsuario = LibUsuario.GetByFilialAndMktGrupo(Session.Contexto.IdFilial);

            //Carrega parcerias que possui cupom
            ListParceria = LibParceria.GetParceriasSelecaoCupomContexto(Session.Contexto.IdFilial);
        }

        /// <summary>
        /// Faz o sorteio entre os cupons das parcerias selecionadas
        /// </summary>
        /// <param name="numCupon"></param>
        /// <param name="dataLimite"></param>
        private void SorteiaCuponUsuario(int numCupon, DateTime dataLimite, String[] operadoras)
        {
            List<Dados.Cupom> sorteio = new List<Dados.Cupom>();

            sorteio = Cupons.Where(a => a.UltimaUtilizacao == null).OrderByDescending(a => a.Data).Sortear(numCupon).ToList();


            if (sorteio.Count() < numCupon)
            {
                //if (operadoras.Count() > 0)
                //    sorteio.AddRange(Cupons.Where(a => a.UltimaUtilizacao != null && (operadoras.Contains(a.OperadoraCelular) || operadoras.Contains(a.OperadoraTelefone))).OrderByDescending(a => a.Data).Sortear(numCupon - sorteio.Count));
                //else
                //    sorteio.AddRange(Cupons.Where(a => a.UltimaUtilizacao != null).OrderByDescending(a => a.Data).Sortear(numCupon - sorteio.Count));

                sorteio.AddRange(Cupons.Where(a => a.UltimaUtilizacao != null).OrderByDescending(a => a.Data).Sortear(numCupon - sorteio.Count));
            }

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
                Cupons.AddRange(LibCupom.GetByParceria(idParceria));
            }
        }

        private void DevolverCuponsExpirados()
        {
            LibCupom.DevolveCuponsExpirados();
        }

        #endregion        
    }
}
