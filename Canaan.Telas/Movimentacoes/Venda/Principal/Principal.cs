using System;
using System.Windows.Forms;
using Canaan.Lib;
using Canaan.Telas.Movimentacoes.Venda.Envelope;
using Canaan.Telas.Movimentacoes.Venda.Financeiro;
using DevExpress.XtraNavBar;
using PessoaFisica = Canaan.Dados.PessoaFisica;
using PessoaJuridica = Canaan.Dados.PessoaJuridica;

namespace Canaan.Telas.Movimentacoes.Venda.Principal
{
    public partial class Principal : Form
    {

        #region PROPRIEDADES

        public int IdVenda { get; set; }

        public Lib.Venda LibVenda
        {
            get
            {
                return new Lib.Venda();
            }
        }

        public Dados.Venda Venda { get; set; }

        public Lib.Atendimento LibAtendimento
        {
            get
            {
                return new Lib.Atendimento();
            }
        }

        public Dados.Atendimento Atendimento { get; set; }

        public CliFor LibCliFor
        {
            get
            {
                return new CliFor();
            }
        }

        public Dados.CliFor CliFor { get; set; }

        public PessoaFisica PessoaFisica
        {
            get
            {
                if (CliFor == null)
                    return null;

                return CliFor as PessoaFisica;

            }
        }

        public PessoaJuridica PessoaJuridica
        {
            get
            {
                if (CliFor == null)
                    return null;

                return CliFor as PessoaJuridica;
            }
        }

        #region FORMS

        public Info.Info FormInfo
        {
            get
            {
                return new Info.Info(Atendimento, Venda);
            }
        }

        public Imagem.Imagem FormImagem
        {
            get
            {
                return new Imagem.Imagem(Atendimento, Venda);
            }
        }

        public Lista FormListaEnvelope
        {
            get
            {
                return new Lista(Venda, this);
            }
        }

        public LancFinanceiro FormLancamentoFinanceiro
        {
            get
            {
                return new LancFinanceiro(Venda, this);
            }
        }

        public Documentacao.Documentacao FormDocumentacao
        {
            get
            {
                return new Documentacao.Documentacao(Venda, this);
            }
        }

        public Evento.Lista FormEvento
        {
            get
            {
                return new Evento.Lista(Venda, this);
            }
        }

        #endregion

        #endregion

        #region CONSTRUTORES

        public Principal(int idVenda)
        {
            //Identificador da Venda Criada
            IdVenda = idVenda;

            //Carrega Objetos Propriedades
            Venda = LibVenda.GetById(idVenda);
            Atendimento = LibAtendimento.GetById(Venda.IdAtendimento);
            CliFor = LibCliFor.GetById(Venda.IdCliFor);

            InitializeComponent();

            ConfiguraOpcoes();
        }

        private void ConfiguraOpcoes()
        {
            if (Venda.VendaItem.Count > 0 && /*LibVenda.ExisteOrdensServico(Venda) && */ Venda.ValorBruto != null)
            {
                lkFinanceiro.Enabled = true;
            }

            if (Venda.Lancamento.Count > 0 && /*LibVenda.ExisteOrdensServico(Venda) && */ Venda.ValorLiquido != null)
            {
                lkDocumentacao.Enabled = true;
            }
        }

        #endregion

        #region EVENTOS

        private void Principal_Load(object sender, EventArgs e)
        {
            //Default
            CarregaForm(FormInfo);
        }

        private void lkInfo_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //Atualiza venda automaticamente
            LibVenda.Update(Venda);
            CarregaForm(FormInfo);
        }

        private void lkSelecaoImg_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //Atualiza venda automaticamente
            LibVenda.Update(Venda);
            CarregaForm(FormImagem);
        }

        private void lkMontaPedido_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //Atualiza venda automaticamente
            LibVenda.Update(Venda);
            CarregaForm(FormListaEnvelope);
        }

        private void lkInflizacao_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //Atualiza venda automaticamente
            LibVenda.Update(Venda);
            CarregaForm(FormLancamentoFinanceiro);
        }

        private void lkDocumentacao_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //Atualiza venda automaticamente
            LibVenda.Update(Venda);
            CarregaForm(FormDocumentacao);
        }

        private void lkEvento_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //Atualiza venda automaticamente
            LibVenda.Update(Venda);
            CarregaForm(FormEvento);
        }



        #endregion

        #region METODOS

        private void LimpaControles()
        {
            foreach (Control item in panelContainer.Controls)
            {
                if (item as Form != null)
                {
                    ((Form)item).Close();
                }
            }

            panelContainer.Controls.Clear();
        }

        private void CarregaForm(Form frm)
        {
            //Limpa container
            LimpaControles();

            //Configura Form
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.Show();
            Focus();

        }

        #endregion

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            GC.Collect();
        }

        
    }
}
