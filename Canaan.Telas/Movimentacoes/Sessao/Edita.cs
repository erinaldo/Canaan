using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Movimentacoes.Sessao.Telas;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;

namespace Canaan.Telas.Movimentacoes.Sessao
{
    public partial class Edita : XtraForm
    {
        #region PROPRIEDADES

        private int SelectedSessao;

        public Dados.Atendimento Atendimento { get; set; }

        public Lib.Sessao LibSessao
        {
            get
            {
                return new Lib.Sessao();
            }
        }

        public Dados.Sessao Sessao { get; set; }

        public Session Session
        {
            get
            {
                return Session.Instance;
            }
        }


        #endregion

        #region CONSTRUTOR

        /// <summary>
        /// Criar Nova Sessao
        /// </summary>
        /// <param name="Atendimento"></param>
        public Edita(Dados.Atendimento Atendimento)
        {
            this.Atendimento = Atendimento;

            NovaSessao();

            InitializeComponent();
        }

        /// <summary>
        /// Editar Sessao Existente
        /// </summary>
        /// <param name="selectedSessao"></param>
        public Edita(int selectedSessao)
        {
            SelectedSessao = selectedSessao;
            Sessao = LibSessao.GetById(SelectedSessao);

            InitializeComponent();
        }

        #endregion

        #region EVENTOS

        private void Edita_Load(object sender, EventArgs e)
        {
            CarregaInfo();
        }

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (e.Link.ItemName == "nvBtInfo")
            {
                CarregaInfo();
            }
            else
            {
                if ((int)Sessao.Genero == 0 && (int)Sessao.Tipo == 0)
                {
                    MessageBoxUtilities.MessageWarning("Antes de prosseguir você deve salvar o genero e o tipo de sessão.");
                }
                else
                {
                    CarregarImagem();
                }
            }

        }

        #endregion

        #region METODOS

        private void NovaSessao()
        {
            if (Atendimento == null)
                throw new Exception("Não existe atendimento criado este cliente.");

            var numSessao = LibSessao.GetNumSessao(Atendimento.IdAtendimento);
            //var numSessao = LibSessao.GetNumSessao()

            try
            {
                Sessao = new Dados.Sessao
                {
                    IdAtendimento = Atendimento.IdAtendimento,
                    IdUsuario = Session.Usuario.IdUsuario,
                    Data = DateTime.Now,
                    NumSessao = numSessao,
                    IsAtivo = true, 
                    IsCriptografado = new Config().GetByFilial(Session.Contexto.IdFilial).IsCriptogradado
                };

                Sessao = LibSessao.Insert(Sessao);
            }
            catch (Exception ex)
            {
                MessageBoxUtilities.MessageError(null, ex);
            }
        }

        private void CarregaInfo()
        {
            //Limpa controles
            LimpaControles();

            //verifica numero de imagens da sessao


            ///Abre tela de informações
            var frm = new Info(Sessao);
            frm.TopLevel = false;

            panelControls.Controls.Add(frm);

            frm.Show();
            Focus();
        }

        private void CarregarImagem()
        {
            //Limpa controles
            LimpaControles();

            ///Abre tela de informações
            var frm = new Imagem(Sessao);
            frm.TopLevel = false;

            panelControls.Controls.Add(frm);

            frm.Show();
            Focus();
        }

        private void LimpaControles()
        {
            foreach (Control item in panelControls.Controls)
            {
                if (item as Form != null)
                {
                    ((Form)item).Close();
                }
            }

            panelControls.Controls.Clear();
        }

        #endregion
    }
}

