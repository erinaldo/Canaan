using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Financeiro.Conta
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
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.convenioDigitoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.convenioNumeroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.cedenteCnpjTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cedenteNomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cedenteDigitoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cedenteNumeroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.carteiraDigitoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.carteiraNumeriTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tipoCobrancaComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tipoContaComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.contaDigitoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.contaNumeriTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.agenciaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.idAgenciaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convenioDigitoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convenioNumeroTextEdit.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cedenteCnpjTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedenteNomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedenteDigitoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedenteNumeroTextEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carteiraDigitoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carteiraNumeriTextEdit.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaDigitoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaNumeriTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idAgenciaTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.xtraTabControl1);
            this.panelEdit.Size = new System.Drawing.Size(429, 391);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(10, 10);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(409, 371);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupBox3);
            this.xtraTabPage2.Controls.Add(this.groupBox2);
            this.xtraTabPage2.Controls.Add(this.groupBox1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.xtraTabPage2.Size = new System.Drawing.Size(403, 343);
            this.xtraTabPage2.Text = "Integração Bancária";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labelControl9);
            this.groupBox3.Controls.Add(this.labelControl10);
            this.groupBox3.Controls.Add(this.convenioDigitoTextEdit);
            this.groupBox3.Controls.Add(this.convenioNumeroTextEdit);
            this.groupBox3.Location = new System.Drawing.Point(8, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(387, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Convênio";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(143, 22);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(27, 13);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Digito";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(8, 22);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(100, 13);
            this.labelControl10.TabIndex = 15;
            this.labelControl10.Text = "Número da Convênio";
            // 
            // convenioDigitoTextEdit
            // 
            this.convenioDigitoTextEdit.Location = new System.Drawing.Point(143, 41);
            this.convenioDigitoTextEdit.Name = "convenioDigitoTextEdit";
            this.convenioDigitoTextEdit.Size = new System.Drawing.Size(62, 20);
            this.convenioDigitoTextEdit.TabIndex = 14;
            // 
            // convenioNumeroTextEdit
            // 
            this.convenioNumeroTextEdit.Location = new System.Drawing.Point(8, 41);
            this.convenioNumeroTextEdit.Name = "convenioNumeroTextEdit";
            this.convenioNumeroTextEdit.Size = new System.Drawing.Size(129, 20);
            this.convenioNumeroTextEdit.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelControl14);
            this.groupBox2.Controls.Add(this.cedenteCnpjTextEdit);
            this.groupBox2.Controls.Add(this.labelControl12);
            this.groupBox2.Controls.Add(this.labelControl11);
            this.groupBox2.Controls.Add(this.labelControl13);
            this.groupBox2.Controls.Add(this.cedenteNomeTextEdit);
            this.groupBox2.Controls.Add(this.cedenteDigitoTextEdit);
            this.groupBox2.Controls.Add(this.cedenteNumeroTextEdit);
            this.groupBox2.Location = new System.Drawing.Point(8, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(387, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cedente";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(8, 67);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(25, 13);
            this.labelControl14.TabIndex = 18;
            this.labelControl14.Text = "CNPJ";
            // 
            // cedenteCnpjTextEdit
            // 
            this.cedenteCnpjTextEdit.Location = new System.Drawing.Point(8, 86);
            this.cedenteCnpjTextEdit.Name = "cedenteCnpjTextEdit";
            this.cedenteCnpjTextEdit.Properties.Mask.EditMask = "99.999.999/9999-99";
            this.cedenteCnpjTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.cedenteCnpjTextEdit.Size = new System.Drawing.Size(129, 20);
            this.cedenteCnpjTextEdit.TabIndex = 17;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(143, 112);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(27, 13);
            this.labelControl12.TabIndex = 16;
            this.labelControl12.Text = "Digito";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(8, 22);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(86, 13);
            this.labelControl11.TabIndex = 14;
            this.labelControl11.Text = "Nome do Cedente";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(8, 112);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(96, 13);
            this.labelControl13.TabIndex = 15;
            this.labelControl13.Text = "Número do Cedente";
            // 
            // cedenteNomeTextEdit
            // 
            this.cedenteNomeTextEdit.Location = new System.Drawing.Point(8, 41);
            this.cedenteNomeTextEdit.Name = "cedenteNomeTextEdit";
            this.cedenteNomeTextEdit.Size = new System.Drawing.Size(371, 20);
            this.cedenteNomeTextEdit.TabIndex = 13;
            // 
            // cedenteDigitoTextEdit
            // 
            this.cedenteDigitoTextEdit.Location = new System.Drawing.Point(143, 131);
            this.cedenteDigitoTextEdit.Name = "cedenteDigitoTextEdit";
            this.cedenteDigitoTextEdit.Size = new System.Drawing.Size(62, 20);
            this.cedenteDigitoTextEdit.TabIndex = 14;
            // 
            // cedenteNumeroTextEdit
            // 
            this.cedenteNumeroTextEdit.Location = new System.Drawing.Point(8, 131);
            this.cedenteNumeroTextEdit.Name = "cedenteNumeroTextEdit";
            this.cedenteNumeroTextEdit.Size = new System.Drawing.Size(129, 20);
            this.cedenteNumeroTextEdit.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.carteiraDigitoTextEdit);
            this.groupBox1.Controls.Add(this.carteiraNumeriTextEdit);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(387, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carteira";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(143, 22);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Digito";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(8, 22);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(94, 13);
            this.labelControl8.TabIndex = 11;
            this.labelControl8.Text = "Número da Carteira";
            // 
            // carteiraDigitoTextEdit
            // 
            this.carteiraDigitoTextEdit.Location = new System.Drawing.Point(143, 41);
            this.carteiraDigitoTextEdit.Name = "carteiraDigitoTextEdit";
            this.carteiraDigitoTextEdit.Size = new System.Drawing.Size(62, 20);
            this.carteiraDigitoTextEdit.TabIndex = 10;
            // 
            // carteiraNumeriTextEdit
            // 
            this.carteiraNumeriTextEdit.Location = new System.Drawing.Point(8, 41);
            this.carteiraNumeriTextEdit.Name = "carteiraNumeriTextEdit";
            this.carteiraNumeriTextEdit.Size = new System.Drawing.Size(129, 20);
            this.carteiraNumeriTextEdit.TabIndex = 9;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.isAtivoCheckEdit);
            this.xtraTabPage1.Controls.Add(this.groupBox5);
            this.xtraTabPage1.Controls.Add(this.groupBox4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.xtraTabPage1.Size = new System.Drawing.Size(403, 343);
            this.xtraTabPage1.Text = "Informações da Conta";
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(6, 315);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Registro ativo";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(389, 19);
            this.isAtivoCheckEdit.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tipoCobrancaComboBox);
            this.groupBox5.Controls.Add(this.labelControl6);
            this.groupBox5.Controls.Add(this.tipoContaComboBox);
            this.groupBox5.Controls.Add(this.labelControl5);
            this.groupBox5.Location = new System.Drawing.Point(8, 183);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(387, 126);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informações do Tipo de Conta";
            // 
            // tipoCobrancaComboBox
            // 
            this.tipoCobrancaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCobrancaComboBox.FormattingEnabled = true;
            this.tipoCobrancaComboBox.Location = new System.Drawing.Point(8, 87);
            this.tipoCobrancaComboBox.Name = "tipoCobrancaComboBox";
            this.tipoCobrancaComboBox.Size = new System.Drawing.Size(285, 21);
            this.tipoCobrancaComboBox.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 68);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Tipo de Cobrança";
            // 
            // tipoContaComboBox
            // 
            this.tipoContaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoContaComboBox.FormattingEnabled = true;
            this.tipoContaComboBox.Location = new System.Drawing.Point(8, 41);
            this.tipoContaComboBox.Name = "tipoContaComboBox";
            this.tipoContaComboBox.Size = new System.Drawing.Size(285, 21);
            this.tipoContaComboBox.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Tipo de Conta";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelControl4);
            this.groupBox4.Controls.Add(this.labelControl3);
            this.groupBox4.Controls.Add(this.contaDigitoTextEdit);
            this.groupBox4.Controls.Add(this.contaNumeriTextEdit);
            this.groupBox4.Controls.Add(this.nomeTextEdit);
            this.groupBox4.Controls.Add(this.labelControl2);
            this.groupBox4.Controls.Add(this.agenciaLinkLabel);
            this.groupBox4.Controls.Add(this.labelControl1);
            this.groupBox4.Controls.Add(this.idAgenciaTextEdit);
            this.groupBox4.Location = new System.Drawing.Point(8, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(387, 169);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações Gerais";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(143, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Digito";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(8, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Número da Conta";
            // 
            // contaDigitoTextEdit
            // 
            this.contaDigitoTextEdit.Location = new System.Drawing.Point(143, 131);
            this.contaDigitoTextEdit.Name = "contaDigitoTextEdit";
            this.contaDigitoTextEdit.Size = new System.Drawing.Size(62, 20);
            this.contaDigitoTextEdit.TabIndex = 6;
            // 
            // contaNumeriTextEdit
            // 
            this.contaNumeriTextEdit.Location = new System.Drawing.Point(8, 131);
            this.contaNumeriTextEdit.Name = "contaNumeriTextEdit";
            this.contaNumeriTextEdit.Size = new System.Drawing.Size(129, 20);
            this.contaNumeriTextEdit.TabIndex = 5;
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.Location = new System.Drawing.Point(8, 86);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(371, 20);
            this.nomeTextEdit.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nome da Conta";
            // 
            // agenciaLinkLabel
            // 
            this.agenciaLinkLabel.AutoSize = true;
            this.agenciaLinkLabel.Location = new System.Drawing.Point(70, 44);
            this.agenciaLinkLabel.Name = "agenciaLinkLabel";
            this.agenciaLinkLabel.Size = new System.Drawing.Size(115, 13);
            this.agenciaLinkLabel.TabIndex = 2;
            this.agenciaLinkLabel.TabStop = true;
            this.agenciaLinkLabel.Text = "Selecione uma agência";
            this.agenciaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.agenciaLinkLabel_LinkClicked);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Agência";
            // 
            // idAgenciaTextEdit
            // 
            this.idAgenciaTextEdit.Enabled = false;
            this.idAgenciaTextEdit.Location = new System.Drawing.Point(8, 41);
            this.idAgenciaTextEdit.Name = "idAgenciaTextEdit";
            this.idAgenciaTextEdit.Size = new System.Drawing.Size(56, 20);
            this.idAgenciaTextEdit.TabIndex = 0;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 424);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convenioDigitoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convenioNumeroTextEdit.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cedenteCnpjTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedenteNomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedenteDigitoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedenteNumeroTextEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carteiraDigitoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carteiraNumeriTextEdit.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contaDigitoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contaNumeriTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idAgenciaTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage2;
        private XtraTabPage xtraTabPage1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private ComboBox tipoCobrancaComboBox;
        private LabelControl labelControl6;
        private ComboBox tipoContaComboBox;
        private LabelControl labelControl5;
        private GroupBox groupBox4;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private TextEdit contaDigitoTextEdit;
        private TextEdit contaNumeriTextEdit;
        private TextEdit nomeTextEdit;
        private LabelControl labelControl2;
        private LinkLabel agenciaLinkLabel;
        private LabelControl labelControl1;
        private TextEdit idAgenciaTextEdit;
        private LabelControl labelControl9;
        private LabelControl labelControl10;
        private TextEdit convenioDigitoTextEdit;
        private TextEdit convenioNumeroTextEdit;
        private LabelControl labelControl14;
        private TextEdit cedenteCnpjTextEdit;
        private LabelControl labelControl12;
        private LabelControl labelControl11;
        private LabelControl labelControl13;
        private TextEdit cedenteNomeTextEdit;
        private TextEdit cedenteDigitoTextEdit;
        private TextEdit cedenteNumeroTextEdit;
        private LabelControl labelControl7;
        private LabelControl labelControl8;
        private TextEdit carteiraDigitoTextEdit;
        private TextEdit carteiraNumeriTextEdit;
        private CheckEdit isAtivoCheckEdit;
    }
}