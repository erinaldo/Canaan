using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace Canaan.Telas.Movimentacoes.Venda.Principal
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nvBar = new DevExpress.XtraNavBar.NavBarGroup();
            this.lkInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.lkSelecaoImg = new DevExpress.XtraNavBar.NavBarItem();
            this.lkMontaPedido = new DevExpress.XtraNavBar.NavBarItem();
            this.lkFinanceiro = new DevExpress.XtraNavBar.NavBarItem();
            this.lkDocumentacao = new DevExpress.XtraNavBar.NavBarItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nvBar;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvBar});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.lkInfo,
            this.lkSelecaoImg,
            this.lkMontaPedido,
            this.lkFinanceiro,
            this.lkDocumentacao});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 200;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.OptionsNavPane.ShowSplitter = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(200, 689);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // nvBar
            // 
            this.nvBar.Caption = "Vendas";
            this.nvBar.Expanded = true;
            this.nvBar.GroupClientHeight = 451;
            this.nvBar.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.lkInfo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.lkSelecaoImg),
            new DevExpress.XtraNavBar.NavBarItemLink(this.lkMontaPedido),
            new DevExpress.XtraNavBar.NavBarItemLink(this.lkFinanceiro),
            new DevExpress.XtraNavBar.NavBarItemLink(this.lkDocumentacao)});
            this.nvBar.Name = "nvBar";
            // 
            // lkInfo
            // 
            this.lkInfo.Caption = "Informações do Atendimento";
            this.lkInfo.Name = "lkInfo";
            this.lkInfo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.lkInfo_LinkClicked);
            // 
            // lkSelecaoImg
            // 
            this.lkSelecaoImg.Caption = "Seleção de Imagens";
            this.lkSelecaoImg.Name = "lkSelecaoImg";
            this.lkSelecaoImg.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.lkSelecaoImg_LinkClicked);
            // 
            // lkMontaPedido
            // 
            this.lkMontaPedido.Caption = "Montagem do Pedido";
            this.lkMontaPedido.Name = "lkMontaPedido";
            this.lkMontaPedido.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.lkMontaPedido_LinkClicked);
            // 
            // lkFinanceiro
            // 
            this.lkFinanceiro.Caption = "Lançamentos Financeiros";
            this.lkFinanceiro.Enabled = false;
            this.lkFinanceiro.Name = "lkFinanceiro";
            this.lkFinanceiro.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.lkInflizacao_LinkClicked);
            // 
            // lkDocumentacao
            // 
            this.lkDocumentacao.Caption = "Documentação / Finalização";
            this.lkDocumentacao.Enabled = false;
            this.lkDocumentacao.Name = "lkDocumentacao";
            this.lkDocumentacao.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.lkDocumentacao_LinkClicked);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1100, 689);
            this.panelContainer.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 689);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.navBarControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de venda - CMaster";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NavBarControl navBarControl1;
        private NavBarGroup nvBar;
        private NavBarItem lkInfo;
        private NavBarItem lkSelecaoImg;
        private NavBarItem lkMontaPedido;
        private Panel panelContainer;
        public NavBarItem lkDocumentacao;
        public NavBarItem lkFinanceiro;
    }
}