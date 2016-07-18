﻿using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraWizard;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Cadastros.ClienteFornecedor
{
    partial class Wizard
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
            this.wizardCliFor = new DevExpress.XtraWizard.WizardControl();
            this.pageTipo = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tipoPessoaRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tipoClienteRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.pageDocumento = new DevExpress.XtraWizard.WizardPage();
            this.documentoGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.btnVerificaDocumento = new DevExpress.XtraEditors.SimpleButton();
            this.documentoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.pageConfirm = new DevExpress.XtraWizard.CompletionWizardPage();
            this.confirmTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.pageCadastro = new DevExpress.XtraWizard.WizardPage();
            this.cadastroTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabPessoaFisica = new DevExpress.XtraTab.XtraTabPage();
            this.conjugeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.estadoCivilComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.nomeMaeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.nomePaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.rgTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cpfTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nascimentoDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nomeCompletoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomeCompletoLabel = new DevExpress.XtraEditors.LabelControl();
            this.tabPessoaJuridica = new DevExpress.XtraTab.XtraTabPage();
            this.inscEstadualTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cnpjTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.nomeFantasiaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.razaoSocialTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tabEndereco = new DevExpress.XtraTab.XtraTabPage();
            this.btnCidade = new DevExpress.XtraEditors.SimpleButton();
            this.cidadeLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.idCidadeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.cepTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.bairroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.complementoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.numeroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.enderecoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.tabContato = new DevExpress.XtraTab.XtraTabPage();
            this.faxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.celular3TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.celular2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.celular1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.telefone3TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telefone2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.telefone1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.TabOutras = new DevExpress.XtraTab.XtraTabPage();
            this.ckEmancipado = new DevExpress.XtraEditors.CheckEdit();
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.refDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnRefNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefEdita = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.wizardCliFor)).BeginInit();
            this.wizardCliFor.SuspendLayout();
            this.pageTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPessoaRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoClienteRadioGroup.Properties)).BeginInit();
            this.pageDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentoGroupControl)).BeginInit();
            this.documentoGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentoTextEdit.Properties)).BeginInit();
            this.pageConfirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmTextEdit.Properties)).BeginInit();
            this.pageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroTabControl)).BeginInit();
            this.cadastroTabControl.SuspendLayout();
            this.tabPessoaFisica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conjugeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeMaeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomePaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeCompletoTextEdit.Properties)).BeginInit();
            this.tabPessoaJuridica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscEstadualTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpjTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeFantasiaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaoSocialTextEdit.Properties)).BeginInit();
            this.tabEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idCidadeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complementoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoTextEdit.Properties)).BeginInit();
            this.tabContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celular3TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celular2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celular1TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefone3TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefone2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefone1TextEdit.Properties)).BeginInit();
            this.TabOutras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckEmancipado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refDataGridView)).BeginInit();
            this.refToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizardCliFor
            // 
            this.wizardCliFor.Controls.Add(this.pageTipo);
            this.wizardCliFor.Controls.Add(this.pageDocumento);
            this.wizardCliFor.Controls.Add(this.pageConfirm);
            this.wizardCliFor.Controls.Add(this.pageCadastro);
            this.wizardCliFor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardCliFor.Location = new System.Drawing.Point(0, 0);
            this.wizardCliFor.Name = "wizardCliFor";
            this.wizardCliFor.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.pageTipo,
            this.pageDocumento,
            this.pageCadastro,
            this.pageConfirm});
            this.wizardCliFor.Size = new System.Drawing.Size(508, 475);
            this.wizardCliFor.Text = "Cadastro de Clientes / Fornecedores";
            this.wizardCliFor.UseAcceptButton = false;
            this.wizardCliFor.UseCancelButton = false;
            this.wizardCliFor.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardCliFor.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardCliFor_SelectedPageChanging);
            this.wizardCliFor.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardCliFor_CancelClick);
            this.wizardCliFor.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardCliFor_FinishClick);
            this.wizardCliFor.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardCliFor_NextClick);
            // 
            // pageTipo
            // 
            this.pageTipo.Controls.Add(this.groupControl2);
            this.pageTipo.Controls.Add(this.groupControl1);
            this.pageTipo.IntroductionText = "";
            this.pageTipo.Name = "pageTipo";
            this.pageTipo.Padding = new System.Windows.Forms.Padding(5);
            this.pageTipo.ProceedText = "";
            this.pageTipo.Size = new System.Drawing.Size(448, 307);
            this.pageTipo.Text = "Selecione o Tipo de Cliente / Fornecedor";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.tipoPessoaRadioGroup);
            this.groupControl2.Location = new System.Drawing.Point(3, 102);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(440, 87);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Tipo de Pessoa";
            // 
            // tipoPessoaRadioGroup
            // 
            this.tipoPessoaRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoPessoaRadioGroup.EditValue = "PessoaFisica";
            this.tipoPessoaRadioGroup.Location = new System.Drawing.Point(2, 20);
            this.tipoPessoaRadioGroup.Name = "tipoPessoaRadioGroup";
            this.tipoPessoaRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PessoaFisica", "Pessoa Fisica"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PessoaJuridica", "Pessoa Jurídica")});
            this.tipoPessoaRadioGroup.Size = new System.Drawing.Size(436, 65);
            this.tipoPessoaRadioGroup.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tipoClienteRadioGroup);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(438, 93);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Tipo de Cadastro que Deseja ";
            // 
            // tipoClienteRadioGroup
            // 
            this.tipoClienteRadioGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoClienteRadioGroup.EditValue = "Cliente";
            this.tipoClienteRadioGroup.Location = new System.Drawing.Point(2, 20);
            this.tipoClienteRadioGroup.Name = "tipoClienteRadioGroup";
            this.tipoClienteRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Cliente", "Cliente"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Fornecedor", "Fornecedor")});
            this.tipoClienteRadioGroup.Size = new System.Drawing.Size(434, 71);
            this.tipoClienteRadioGroup.TabIndex = 0;
            // 
            // pageDocumento
            // 
            this.pageDocumento.Controls.Add(this.documentoGroupControl);
            this.pageDocumento.DescriptionText = "";
            this.pageDocumento.Name = "pageDocumento";
            this.pageDocumento.Padding = new System.Windows.Forms.Padding(5);
            this.pageDocumento.Size = new System.Drawing.Size(448, 307);
            this.pageDocumento.Text = "Verificando Documento do Cliente / Fornecedor";
            // 
            // documentoGroupControl
            // 
            this.documentoGroupControl.Controls.Add(this.btnVerificaDocumento);
            this.documentoGroupControl.Controls.Add(this.documentoTextEdit);
            this.documentoGroupControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.documentoGroupControl.Location = new System.Drawing.Point(5, 5);
            this.documentoGroupControl.Name = "documentoGroupControl";
            this.documentoGroupControl.Size = new System.Drawing.Size(438, 59);
            this.documentoGroupControl.TabIndex = 0;
            this.documentoGroupControl.Text = "Consulta Registro";
            // 
            // btnVerificaDocumento
            // 
            this.btnVerificaDocumento.Location = new System.Drawing.Point(182, 25);
            this.btnVerificaDocumento.Name = "btnVerificaDocumento";
            this.btnVerificaDocumento.Size = new System.Drawing.Size(75, 23);
            this.btnVerificaDocumento.TabIndex = 1;
            this.btnVerificaDocumento.Text = "Verificar";
            this.btnVerificaDocumento.Click += new System.EventHandler(this.btnVerificaDocumento_Click);
            // 
            // documentoTextEdit
            // 
            this.documentoTextEdit.Location = new System.Drawing.Point(5, 26);
            this.documentoTextEdit.Name = "documentoTextEdit";
            this.documentoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.documentoTextEdit.Properties.Mask.SaveLiteral = false;
            this.documentoTextEdit.Size = new System.Drawing.Size(171, 20);
            this.documentoTextEdit.TabIndex = 0;
            // 
            // pageConfirm
            // 
            this.pageConfirm.Controls.Add(this.confirmTextEdit);
            this.pageConfirm.FinishText = "";
            this.pageConfirm.Name = "pageConfirm";
            this.pageConfirm.ProceedText = "";
            this.pageConfirm.Size = new System.Drawing.Size(448, 307);
            this.pageConfirm.Text = "Confirme as informações do cadastro";
            // 
            // confirmTextEdit
            // 
            this.confirmTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmTextEdit.Location = new System.Drawing.Point(0, 0);
            this.confirmTextEdit.Name = "confirmTextEdit";
            this.confirmTextEdit.Size = new System.Drawing.Size(448, 307);
            this.confirmTextEdit.TabIndex = 0;
            // 
            // pageCadastro
            // 
            this.pageCadastro.Controls.Add(this.cadastroTabControl);
            this.pageCadastro.DescriptionText = "";
            this.pageCadastro.Name = "pageCadastro";
            this.pageCadastro.Size = new System.Drawing.Size(448, 307);
            this.pageCadastro.Text = "Cadastro";
            // 
            // cadastroTabControl
            // 
            this.cadastroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastroTabControl.Location = new System.Drawing.Point(0, 0);
            this.cadastroTabControl.Name = "cadastroTabControl";
            this.cadastroTabControl.SelectedTabPage = this.tabPessoaFisica;
            this.cadastroTabControl.Size = new System.Drawing.Size(448, 307);
            this.cadastroTabControl.TabIndex = 0;
            this.cadastroTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPessoaFisica,
            this.tabPessoaJuridica,
            this.tabEndereco,
            this.tabContato,
            this.TabOutras,
            this.xtraTabPage1});
            // 
            // tabPessoaFisica
            // 
            this.tabPessoaFisica.Controls.Add(this.conjugeTextEdit);
            this.tabPessoaFisica.Controls.Add(this.labelControl8);
            this.tabPessoaFisica.Controls.Add(this.estadoCivilComboBox);
            this.tabPessoaFisica.Controls.Add(this.labelControl7);
            this.tabPessoaFisica.Controls.Add(this.sexoComboBox);
            this.tabPessoaFisica.Controls.Add(this.labelControl6);
            this.tabPessoaFisica.Controls.Add(this.nomeMaeTextEdit);
            this.tabPessoaFisica.Controls.Add(this.labelControl5);
            this.tabPessoaFisica.Controls.Add(this.nomePaiTextEdit);
            this.tabPessoaFisica.Controls.Add(this.labelControl4);
            this.tabPessoaFisica.Controls.Add(this.rgTextEdit);
            this.tabPessoaFisica.Controls.Add(this.labelControl3);
            this.tabPessoaFisica.Controls.Add(this.cpfTextEdit);
            this.tabPessoaFisica.Controls.Add(this.labelControl2);
            this.tabPessoaFisica.Controls.Add(this.nascimentoDateEdit);
            this.tabPessoaFisica.Controls.Add(this.labelControl1);
            this.tabPessoaFisica.Controls.Add(this.nomeCompletoTextEdit);
            this.tabPessoaFisica.Controls.Add(this.nomeCompletoLabel);
            this.tabPessoaFisica.Name = "tabPessoaFisica";
            this.tabPessoaFisica.Padding = new System.Windows.Forms.Padding(5);
            this.tabPessoaFisica.Size = new System.Drawing.Size(442, 279);
            this.tabPessoaFisica.Text = "Pessoa Fisica";
            // 
            // conjugeTextEdit
            // 
            this.conjugeTextEdit.Location = new System.Drawing.Point(8, 253);
            this.conjugeTextEdit.Name = "conjugeTextEdit";
            this.conjugeTextEdit.Size = new System.Drawing.Size(420, 20);
            this.conjugeTextEdit.TabIndex = 17;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(8, 234);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(40, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Conjuge";
            // 
            // estadoCivilComboBox
            // 
            this.estadoCivilComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCivilComboBox.FormattingEnabled = true;
            this.estadoCivilComboBox.Location = new System.Drawing.Point(150, 207);
            this.estadoCivilComboBox.Name = "estadoCivilComboBox";
            this.estadoCivilComboBox.Size = new System.Drawing.Size(136, 21);
            this.estadoCivilComboBox.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(150, 188);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Estado Civil";
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(8, 207);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(136, 21);
            this.sexoComboBox.TabIndex = 13;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 188);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Sexo";
            // 
            // nomeMaeTextEdit
            // 
            this.nomeMaeTextEdit.Location = new System.Drawing.Point(8, 162);
            this.nomeMaeTextEdit.Name = "nomeMaeTextEdit";
            this.nomeMaeTextEdit.Size = new System.Drawing.Size(420, 20);
            this.nomeMaeTextEdit.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 143);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(65, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Nome da Mãe";
            // 
            // nomePaiTextEdit
            // 
            this.nomePaiTextEdit.Location = new System.Drawing.Point(8, 117);
            this.nomePaiTextEdit.Name = "nomePaiTextEdit";
            this.nomePaiTextEdit.Size = new System.Drawing.Size(420, 20);
            this.nomePaiTextEdit.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Nome do Pai";
            // 
            // rgTextEdit
            // 
            this.rgTextEdit.Location = new System.Drawing.Point(292, 72);
            this.rgTextEdit.Name = "rgTextEdit";
            this.rgTextEdit.Size = new System.Drawing.Size(136, 20);
            this.rgTextEdit.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(292, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "RG";
            // 
            // cpfTextEdit
            // 
            this.cpfTextEdit.Location = new System.Drawing.Point(150, 72);
            this.cpfTextEdit.Name = "cpfTextEdit";
            this.cpfTextEdit.Properties.Mask.EditMask = "999.999.999-99";
            this.cpfTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.cpfTextEdit.Properties.Mask.SaveLiteral = false;
            this.cpfTextEdit.Size = new System.Drawing.Size(136, 20);
            this.cpfTextEdit.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(150, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "CPF";
            // 
            // nascimentoDateEdit
            // 
            this.nascimentoDateEdit.EditValue = null;
            this.nascimentoDateEdit.Location = new System.Drawing.Point(8, 72);
            this.nascimentoDateEdit.Name = "nascimentoDateEdit";
            this.nascimentoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nascimentoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nascimentoDateEdit.Size = new System.Drawing.Size(136, 20);
            this.nascimentoDateEdit.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Data de Nascimento";
            // 
            // nomeCompletoTextEdit
            // 
            this.nomeCompletoTextEdit.Location = new System.Drawing.Point(8, 27);
            this.nomeCompletoTextEdit.Name = "nomeCompletoTextEdit";
            this.nomeCompletoTextEdit.Size = new System.Drawing.Size(420, 20);
            this.nomeCompletoTextEdit.TabIndex = 1;
            // 
            // nomeCompletoLabel
            // 
            this.nomeCompletoLabel.Location = new System.Drawing.Point(8, 8);
            this.nomeCompletoLabel.Name = "nomeCompletoLabel";
            this.nomeCompletoLabel.Size = new System.Drawing.Size(75, 13);
            this.nomeCompletoLabel.TabIndex = 0;
            this.nomeCompletoLabel.Text = "Nome Completo";
            // 
            // tabPessoaJuridica
            // 
            this.tabPessoaJuridica.Controls.Add(this.inscEstadualTextEdit);
            this.tabPessoaJuridica.Controls.Add(this.labelControl11);
            this.tabPessoaJuridica.Controls.Add(this.cnpjTextEdit);
            this.tabPessoaJuridica.Controls.Add(this.labelControl12);
            this.tabPessoaJuridica.Controls.Add(this.nomeFantasiaTextEdit);
            this.tabPessoaJuridica.Controls.Add(this.labelControl10);
            this.tabPessoaJuridica.Controls.Add(this.razaoSocialTextEdit);
            this.tabPessoaJuridica.Controls.Add(this.labelControl9);
            this.tabPessoaJuridica.Name = "tabPessoaJuridica";
            this.tabPessoaJuridica.Padding = new System.Windows.Forms.Padding(5);
            this.tabPessoaJuridica.Size = new System.Drawing.Size(442, 279);
            this.tabPessoaJuridica.Text = "Pessoa Jurídica";
            // 
            // inscEstadualTextEdit
            // 
            this.inscEstadualTextEdit.Location = new System.Drawing.Point(8, 162);
            this.inscEstadualTextEdit.Name = "inscEstadualTextEdit";
            this.inscEstadualTextEdit.Size = new System.Drawing.Size(136, 20);
            this.inscEstadualTextEdit.TabIndex = 11;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(8, 143);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(87, 13);
            this.labelControl11.TabIndex = 10;
            this.labelControl11.Text = "Inscrição Estadual";
            // 
            // cnpjTextEdit
            // 
            this.cnpjTextEdit.Location = new System.Drawing.Point(8, 117);
            this.cnpjTextEdit.Name = "cnpjTextEdit";
            this.cnpjTextEdit.Properties.Mask.EditMask = "99.999.999/9999-99";
            this.cnpjTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.cnpjTextEdit.Properties.Mask.SaveLiteral = false;
            this.cnpjTextEdit.Size = new System.Drawing.Size(136, 20);
            this.cnpjTextEdit.TabIndex = 9;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(8, 98);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(25, 13);
            this.labelControl12.TabIndex = 8;
            this.labelControl12.Text = "CNPJ";
            // 
            // nomeFantasiaTextEdit
            // 
            this.nomeFantasiaTextEdit.Location = new System.Drawing.Point(8, 72);
            this.nomeFantasiaTextEdit.Name = "nomeFantasiaTextEdit";
            this.nomeFantasiaTextEdit.Size = new System.Drawing.Size(420, 20);
            this.nomeFantasiaTextEdit.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(8, 53);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(71, 13);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Nome Fantasia";
            // 
            // razaoSocialTextEdit
            // 
            this.razaoSocialTextEdit.Location = new System.Drawing.Point(8, 27);
            this.razaoSocialTextEdit.Name = "razaoSocialTextEdit";
            this.razaoSocialTextEdit.Size = new System.Drawing.Size(420, 20);
            this.razaoSocialTextEdit.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(8, 8);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 13);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Razão Social";
            // 
            // tabEndereco
            // 
            this.tabEndereco.Controls.Add(this.btnCidade);
            this.tabEndereco.Controls.Add(this.cidadeLabelControl);
            this.tabEndereco.Controls.Add(this.idCidadeTextEdit);
            this.tabEndereco.Controls.Add(this.labelControl18);
            this.tabEndereco.Controls.Add(this.cepTextEdit);
            this.tabEndereco.Controls.Add(this.labelControl17);
            this.tabEndereco.Controls.Add(this.bairroTextEdit);
            this.tabEndereco.Controls.Add(this.labelControl16);
            this.tabEndereco.Controls.Add(this.complementoTextEdit);
            this.tabEndereco.Controls.Add(this.labelControl15);
            this.tabEndereco.Controls.Add(this.numeroTextEdit);
            this.tabEndereco.Controls.Add(this.labelControl14);
            this.tabEndereco.Controls.Add(this.enderecoTextEdit);
            this.tabEndereco.Controls.Add(this.labelControl13);
            this.tabEndereco.Name = "tabEndereco";
            this.tabEndereco.Padding = new System.Windows.Forms.Padding(5);
            this.tabEndereco.Size = new System.Drawing.Size(442, 279);
            this.tabEndereco.Text = "Endereço";
            // 
            // btnCidade
            // 
            this.btnCidade.Location = new System.Drawing.Point(8, 188);
            this.btnCidade.Name = "btnCidade";
            this.btnCidade.Size = new System.Drawing.Size(136, 23);
            this.btnCidade.TabIndex = 23;
            this.btnCidade.Text = "Selecione a Cidade";
            this.btnCidade.Click += new System.EventHandler(this.btnCidade_Click);
            // 
            // cidadeLabelControl
            // 
            this.cidadeLabelControl.Location = new System.Drawing.Point(59, 165);
            this.cidadeLabelControl.Name = "cidadeLabelControl";
            this.cidadeLabelControl.Size = new System.Drawing.Size(102, 13);
            this.cidadeLabelControl.TabIndex = 22;
            this.cidadeLabelControl.Text = "Selecione uma cidade";
            // 
            // idCidadeTextEdit
            // 
            this.idCidadeTextEdit.Enabled = false;
            this.idCidadeTextEdit.Location = new System.Drawing.Point(8, 162);
            this.idCidadeTextEdit.Name = "idCidadeTextEdit";
            this.idCidadeTextEdit.Size = new System.Drawing.Size(45, 20);
            this.idCidadeTextEdit.TabIndex = 21;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(8, 143);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(33, 13);
            this.labelControl18.TabIndex = 20;
            this.labelControl18.Text = "Cidade";
            // 
            // cepTextEdit
            // 
            this.cepTextEdit.Location = new System.Drawing.Point(150, 117);
            this.cepTextEdit.Name = "cepTextEdit";
            this.cepTextEdit.Properties.Mask.EditMask = "99.999-999";
            this.cepTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.cepTextEdit.Properties.Mask.SaveLiteral = false;
            this.cepTextEdit.Size = new System.Drawing.Size(136, 20);
            this.cepTextEdit.TabIndex = 19;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(150, 98);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(19, 13);
            this.labelControl17.TabIndex = 18;
            this.labelControl17.Text = "CEP";
            // 
            // bairroTextEdit
            // 
            this.bairroTextEdit.Location = new System.Drawing.Point(8, 117);
            this.bairroTextEdit.Name = "bairroTextEdit";
            this.bairroTextEdit.Size = new System.Drawing.Size(136, 20);
            this.bairroTextEdit.TabIndex = 17;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(8, 98);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(28, 13);
            this.labelControl16.TabIndex = 16;
            this.labelControl16.Text = "Bairro";
            // 
            // complementoTextEdit
            // 
            this.complementoTextEdit.Location = new System.Drawing.Point(150, 72);
            this.complementoTextEdit.Name = "complementoTextEdit";
            this.complementoTextEdit.Size = new System.Drawing.Size(136, 20);
            this.complementoTextEdit.TabIndex = 15;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(150, 53);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(65, 13);
            this.labelControl15.TabIndex = 14;
            this.labelControl15.Text = "Complemento";
            // 
            // numeroTextEdit
            // 
            this.numeroTextEdit.Location = new System.Drawing.Point(8, 72);
            this.numeroTextEdit.Name = "numeroTextEdit";
            this.numeroTextEdit.Size = new System.Drawing.Size(136, 20);
            this.numeroTextEdit.TabIndex = 13;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(8, 53);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(37, 13);
            this.labelControl14.TabIndex = 12;
            this.labelControl14.Text = "Número";
            // 
            // enderecoTextEdit
            // 
            this.enderecoTextEdit.Location = new System.Drawing.Point(8, 27);
            this.enderecoTextEdit.Name = "enderecoTextEdit";
            this.enderecoTextEdit.Size = new System.Drawing.Size(420, 20);
            this.enderecoTextEdit.TabIndex = 5;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(8, 8);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(45, 13);
            this.labelControl13.TabIndex = 4;
            this.labelControl13.Text = "Endereco";
            // 
            // tabContato
            // 
            this.tabContato.Controls.Add(this.faxTextEdit);
            this.tabContato.Controls.Add(this.labelControl26);
            this.tabContato.Controls.Add(this.celular3TextEdit);
            this.tabContato.Controls.Add(this.celular2TextEdit);
            this.tabContato.Controls.Add(this.celular1TextEdit);
            this.tabContato.Controls.Add(this.labelControl23);
            this.tabContato.Controls.Add(this.telefone3TextEdit);
            this.tabContato.Controls.Add(this.telefone2TextEdit);
            this.tabContato.Controls.Add(this.emailTextEdit);
            this.tabContato.Controls.Add(this.labelControl20);
            this.tabContato.Controls.Add(this.telefone1TextEdit);
            this.tabContato.Controls.Add(this.labelControl19);
            this.tabContato.Name = "tabContato";
            this.tabContato.Padding = new System.Windows.Forms.Padding(5);
            this.tabContato.Size = new System.Drawing.Size(442, 279);
            this.tabContato.Text = "Contato";
            // 
            // faxTextEdit
            // 
            this.faxTextEdit.Location = new System.Drawing.Point(8, 162);
            this.faxTextEdit.Name = "faxTextEdit";
            this.faxTextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.faxTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.faxTextEdit.Properties.Mask.SaveLiteral = false;
            this.faxTextEdit.Size = new System.Drawing.Size(136, 20);
            this.faxTextEdit.TabIndex = 29;
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(8, 143);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(18, 13);
            this.labelControl26.TabIndex = 28;
            this.labelControl26.Text = "Fax";
            // 
            // celular3TextEdit
            // 
            this.celular3TextEdit.Location = new System.Drawing.Point(292, 117);
            this.celular3TextEdit.Name = "celular3TextEdit";
            this.celular3TextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.celular3TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.celular3TextEdit.Properties.Mask.SaveLiteral = false;
            this.celular3TextEdit.Size = new System.Drawing.Size(136, 20);
            this.celular3TextEdit.TabIndex = 27;
            // 
            // celular2TextEdit
            // 
            this.celular2TextEdit.Location = new System.Drawing.Point(150, 117);
            this.celular2TextEdit.Name = "celular2TextEdit";
            this.celular2TextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.celular2TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.celular2TextEdit.Properties.Mask.SaveLiteral = false;
            this.celular2TextEdit.Size = new System.Drawing.Size(136, 20);
            this.celular2TextEdit.TabIndex = 25;
            // 
            // celular1TextEdit
            // 
            this.celular1TextEdit.Location = new System.Drawing.Point(8, 117);
            this.celular1TextEdit.Name = "celular1TextEdit";
            this.celular1TextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.celular1TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.celular1TextEdit.Properties.Mask.SaveLiteral = false;
            this.celular1TextEdit.Size = new System.Drawing.Size(136, 20);
            this.celular1TextEdit.TabIndex = 23;
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(8, 98);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(44, 13);
            this.labelControl23.TabIndex = 22;
            this.labelControl23.Text = "Celulares";
            // 
            // telefone3TextEdit
            // 
            this.telefone3TextEdit.Location = new System.Drawing.Point(292, 72);
            this.telefone3TextEdit.Name = "telefone3TextEdit";
            this.telefone3TextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.telefone3TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.telefone3TextEdit.Properties.Mask.SaveLiteral = false;
            this.telefone3TextEdit.Size = new System.Drawing.Size(136, 20);
            this.telefone3TextEdit.TabIndex = 21;
            // 
            // telefone2TextEdit
            // 
            this.telefone2TextEdit.Location = new System.Drawing.Point(150, 72);
            this.telefone2TextEdit.Name = "telefone2TextEdit";
            this.telefone2TextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.telefone2TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.telefone2TextEdit.Properties.Mask.SaveLiteral = false;
            this.telefone2TextEdit.Size = new System.Drawing.Size(136, 20);
            this.telefone2TextEdit.TabIndex = 19;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.Location = new System.Drawing.Point(8, 27);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(420, 20);
            this.emailTextEdit.TabIndex = 17;
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(8, 8);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(24, 13);
            this.labelControl20.TabIndex = 16;
            this.labelControl20.Text = "Email";
            // 
            // telefone1TextEdit
            // 
            this.telefone1TextEdit.Location = new System.Drawing.Point(8, 72);
            this.telefone1TextEdit.Name = "telefone1TextEdit";
            this.telefone1TextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.telefone1TextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.telefone1TextEdit.Properties.Mask.SaveLiteral = false;
            this.telefone1TextEdit.Size = new System.Drawing.Size(136, 20);
            this.telefone1TextEdit.TabIndex = 15;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(8, 53);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(47, 13);
            this.labelControl19.TabIndex = 14;
            this.labelControl19.Text = "Telefones";
            // 
            // TabOutras
            // 
            this.TabOutras.Controls.Add(this.ckEmancipado);
            this.TabOutras.Controls.Add(this.isAtivoCheckEdit);
            this.TabOutras.Name = "TabOutras";
            this.TabOutras.Padding = new System.Windows.Forms.Padding(5);
            this.TabOutras.Size = new System.Drawing.Size(442, 279);
            this.TabOutras.Text = "Outras Informações";
            // 
            // ckEmancipado
            // 
            this.ckEmancipado.Location = new System.Drawing.Point(8, 33);
            this.ckEmancipado.Name = "ckEmancipado";
            this.ckEmancipado.Properties.Caption = "Cliente é emancipado?";
            this.ckEmancipado.Size = new System.Drawing.Size(426, 19);
            this.ckEmancipado.TabIndex = 1;
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(8, 8);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Cliente / Fornecedor está ativo";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(426, 19);
            this.isAtivoCheckEdit.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.refDataGridView);
            this.xtraTabPage1.Controls.Add(this.refToolStrip);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(442, 279);
            this.xtraTabPage1.Text = "Referências";
            // 
            // refDataGridView
            // 
            this.refDataGridView.AllowUserToAddRows = false;
            this.refDataGridView.AllowUserToDeleteRows = false;
            this.refDataGridView.AllowUserToResizeColumns = false;
            this.refDataGridView.AllowUserToResizeRows = false;
            this.refDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.refDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.refDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.refDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Tipo,
            this.Telefone,
            this.Celular});
            this.refDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refDataGridView.Location = new System.Drawing.Point(0, 25);
            this.refDataGridView.MultiSelect = false;
            this.refDataGridView.Name = "refDataGridView";
            this.refDataGridView.ReadOnly = true;
            this.refDataGridView.RowHeadersVisible = false;
            this.refDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.refDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.refDataGridView.ShowCellErrors = false;
            this.refDataGridView.ShowCellToolTips = false;
            this.refDataGridView.ShowEditingIcon = false;
            this.refDataGridView.ShowRowErrors = false;
            this.refDataGridView.Size = new System.Drawing.Size(442, 254);
            this.refDataGridView.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // refToolStrip
            // 
            this.refToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.refToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefNovo,
            this.toolStripSeparator1,
            this.btnRefEdita,
            this.toolStripSeparator2,
            this.btnRefDelete});
            this.refToolStrip.Location = new System.Drawing.Point(0, 0);
            this.refToolStrip.Name = "refToolStrip";
            this.refToolStrip.Size = new System.Drawing.Size(442, 25);
            this.refToolStrip.TabIndex = 0;
            this.refToolStrip.Text = "toolStrip1";
            // 
            // btnRefNovo
            // 
            this.btnRefNovo.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.btnRefNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefNovo.Name = "btnRefNovo";
            this.btnRefNovo.Size = new System.Drawing.Size(102, 22);
            this.btnRefNovo.Text = "Novo Registro";
            this.btnRefNovo.Click += new System.EventHandler(this.btnRefNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefEdita
            // 
            this.btnRefEdita.Image = global::Canaan.Telas.Properties.Resources.folder_Open_16xLG;
            this.btnRefEdita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefEdita.Name = "btnRefEdita";
            this.btnRefEdita.Size = new System.Drawing.Size(124, 22);
            this.btnRefEdita.Text = "Editar Selecionado";
            this.btnRefEdita.Click += new System.EventHandler(this.btnRefEdita_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefDelete
            // 
            this.btnRefDelete.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.btnRefDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefDelete.Name = "btnRefDelete";
            this.btnRefDelete.Size = new System.Drawing.Size(141, 22);
            this.btnRefDelete.Text = "Remover Selecionado";
            // 
            // Wizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 475);
            this.Controls.Add(this.wizardCliFor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Wizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes / Fornecedores";
            this.Load += new System.EventHandler(this.Wizard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardCliFor)).EndInit();
            this.wizardCliFor.ResumeLayout(false);
            this.pageTipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoPessoaRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoClienteRadioGroup.Properties)).EndInit();
            this.pageDocumento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentoGroupControl)).EndInit();
            this.documentoGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentoTextEdit.Properties)).EndInit();
            this.pageConfirm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.confirmTextEdit.Properties)).EndInit();
            this.pageCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroTabControl)).EndInit();
            this.cadastroTabControl.ResumeLayout(false);
            this.tabPessoaFisica.ResumeLayout(false);
            this.tabPessoaFisica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conjugeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeMaeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomePaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeCompletoTextEdit.Properties)).EndInit();
            this.tabPessoaJuridica.ResumeLayout(false);
            this.tabPessoaJuridica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscEstadualTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnpjTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeFantasiaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.razaoSocialTextEdit.Properties)).EndInit();
            this.tabEndereco.ResumeLayout(false);
            this.tabEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idCidadeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complementoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoTextEdit.Properties)).EndInit();
            this.tabContato.ResumeLayout(false);
            this.tabContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celular3TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celular2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celular1TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefone3TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefone2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefone1TextEdit.Properties)).EndInit();
            this.TabOutras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckEmancipado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refDataGridView)).EndInit();
            this.refToolStrip.ResumeLayout(false);
            this.refToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WizardControl wizardCliFor;
        private WelcomeWizardPage pageTipo;
        private WizardPage pageDocumento;
        private CompletionWizardPage pageConfirm;
        private GroupControl groupControl2;
        private RadioGroup tipoPessoaRadioGroup;
        private GroupControl groupControl1;
        private RadioGroup tipoClienteRadioGroup;
        private GroupControl documentoGroupControl;
        private TextEdit documentoTextEdit;
        private SimpleButton btnVerificaDocumento;
        private WizardPage pageCadastro;
        private XtraTabControl cadastroTabControl;
        private XtraTabPage tabPessoaFisica;
        private XtraTabPage tabPessoaJuridica;
        private XtraTabPage tabEndereco;
        private XtraTabPage tabContato;
        private XtraTabPage TabOutras;
        private LabelControl nomeCompletoLabel;
        private LabelControl labelControl1;
        private TextEdit nomeCompletoTextEdit;
        private TextEdit cpfTextEdit;
        private LabelControl labelControl2;
        private DateEdit nascimentoDateEdit;
        private TextEdit rgTextEdit;
        private LabelControl labelControl3;
        private TextEdit conjugeTextEdit;
        private LabelControl labelControl8;
        private ComboBox estadoCivilComboBox;
        private LabelControl labelControl7;
        private ComboBox sexoComboBox;
        private LabelControl labelControl6;
        private TextEdit nomeMaeTextEdit;
        private LabelControl labelControl5;
        private TextEdit nomePaiTextEdit;
        private LabelControl labelControl4;
        private XtraTabPage xtraTabPage1;
        private TextEdit inscEstadualTextEdit;
        private LabelControl labelControl11;
        private TextEdit cnpjTextEdit;
        private LabelControl labelControl12;
        private TextEdit nomeFantasiaTextEdit;
        private LabelControl labelControl10;
        private TextEdit razaoSocialTextEdit;
        private LabelControl labelControl9;
        private SimpleButton btnCidade;
        private LabelControl cidadeLabelControl;
        private TextEdit idCidadeTextEdit;
        private LabelControl labelControl18;
        private TextEdit cepTextEdit;
        private LabelControl labelControl17;
        private TextEdit bairroTextEdit;
        private LabelControl labelControl16;
        private TextEdit complementoTextEdit;
        private LabelControl labelControl15;
        private TextEdit numeroTextEdit;
        private LabelControl labelControl14;
        private TextEdit enderecoTextEdit;
        private LabelControl labelControl13;
        private TextEdit faxTextEdit;
        private LabelControl labelControl26;
        private TextEdit celular3TextEdit;
        private TextEdit celular2TextEdit;
        private TextEdit celular1TextEdit;
        private LabelControl labelControl23;
        private TextEdit telefone3TextEdit;
        private TextEdit telefone2TextEdit;
        private TextEdit emailTextEdit;
        private LabelControl labelControl20;
        private TextEdit telefone1TextEdit;
        private LabelControl labelControl19;
        private CheckEdit isAtivoCheckEdit;
        private MemoEdit confirmTextEdit;
        private ToolStrip refToolStrip;
        private ToolStripButton btnRefNovo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnRefEdita;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnRefDelete;
        private DataGridView refDataGridView;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Celular;
        private CheckEdit ckEmancipado;
    }
}