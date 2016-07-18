using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace Canaan.Telas.Financeiro.ContaCaixa
{
    partial class Edita
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.isPadraoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.isCaixaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.contaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.idContaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.filialLinkLabel = new System.Windows.Forms.LinkLabel();
            this.idFilialTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPadraoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCaixaCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idContaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idFilialTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.xtraTabControl1);
            this.panelEdit.Size = new System.Drawing.Size(352, 280);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(10, 10);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(332, 260);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.isAtivoCheckEdit);
            this.xtraTabPage1.Controls.Add(this.isPadraoCheckEdit);
            this.xtraTabPage1.Controls.Add(this.isCaixaCheckEdit);
            this.xtraTabPage1.Controls.Add(this.nomeTextEdit);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.contaLinkLabel);
            this.xtraTabPage1.Controls.Add(this.idContaTextEdit);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.filialLinkLabel);
            this.xtraTabPage1.Controls.Add(this.idFilialTextEdit);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.xtraTabPage1.Size = new System.Drawing.Size(326, 232);
            this.xtraTabPage1.Text = "Informações da Conta Caixa";
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(8, 193);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Conta caixa está ativa";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(310, 19);
            this.isAtivoCheckEdit.TabIndex = 10;
            // 
            // isPadraoCheckEdit
            // 
            this.isPadraoCheckEdit.Location = new System.Drawing.Point(8, 168);
            this.isPadraoCheckEdit.Name = "isPadraoCheckEdit";
            this.isPadraoCheckEdit.Properties.Caption = "É conta caixa padrão da filial";
            this.isPadraoCheckEdit.Size = new System.Drawing.Size(310, 19);
            this.isPadraoCheckEdit.TabIndex = 9;
            // 
            // isCaixaCheckEdit
            // 
            this.isCaixaCheckEdit.Location = new System.Drawing.Point(8, 143);
            this.isCaixaCheckEdit.Name = "isCaixaCheckEdit";
            this.isCaixaCheckEdit.Properties.Caption = "Permite Abertura de Caixa";
            this.isCaixaCheckEdit.Size = new System.Drawing.Size(310, 19);
            this.isCaixaCheckEdit.TabIndex = 8;
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.Location = new System.Drawing.Point(8, 117);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(310, 20);
            this.nomeTextEdit.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nome da Conta Caixa";
            // 
            // contaLinkLabel
            // 
            this.contaLinkLabel.AutoSize = true;
            this.contaLinkLabel.Location = new System.Drawing.Point(64, 75);
            this.contaLinkLabel.Name = "contaLinkLabel";
            this.contaLinkLabel.Size = new System.Drawing.Size(135, 13);
            this.contaLinkLabel.TabIndex = 5;
            this.contaLinkLabel.TabStop = true;
            this.contaLinkLabel.Text = "Selecione a conta bancária";
            this.contaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contaLinkLabel_LinkClicked);
            // 
            // idContaTextEdit
            // 
            this.idContaTextEdit.Enabled = false;
            this.idContaTextEdit.Location = new System.Drawing.Point(8, 72);
            this.idContaTextEdit.Name = "idContaTextEdit";
            this.idContaTextEdit.Size = new System.Drawing.Size(50, 20);
            this.idContaTextEdit.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Conta Bancária";
            // 
            // filialLinkLabel
            // 
            this.filialLinkLabel.AutoSize = true;
            this.filialLinkLabel.Location = new System.Drawing.Point(64, 30);
            this.filialLinkLabel.Name = "filialLinkLabel";
            this.filialLinkLabel.Size = new System.Drawing.Size(82, 13);
            this.filialLinkLabel.TabIndex = 2;
            this.filialLinkLabel.TabStop = true;
            this.filialLinkLabel.Text = "Selecione a filial";
            this.filialLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.filialLinkLabel_LinkClicked);
            // 
            // idFilialTextEdit
            // 
            this.idFilialTextEdit.Enabled = false;
            this.idFilialTextEdit.Location = new System.Drawing.Point(8, 27);
            this.idFilialTextEdit.Name = "idFilialTextEdit";
            this.idFilialTextEdit.Size = new System.Drawing.Size(50, 20);
            this.idFilialTextEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Filial";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 313);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isPadraoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCaixaCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idContaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idFilialTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private CheckEdit isAtivoCheckEdit;
        private CheckEdit isPadraoCheckEdit;
        private CheckEdit isCaixaCheckEdit;
        private TextEdit nomeTextEdit;
        private LabelControl labelControl3;
        private LinkLabel contaLinkLabel;
        private TextEdit idContaTextEdit;
        private LabelControl labelControl2;
        private LinkLabel filialLinkLabel;
        private TextEdit idFilialTextEdit;
        private LabelControl labelControl1;
    }
}