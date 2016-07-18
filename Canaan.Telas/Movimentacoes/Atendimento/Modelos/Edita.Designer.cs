using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Movimentacoes.Atendimento.Modelos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label idCidadeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label nascimentoLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nomeCompletoLabel;
            System.Windows.Forms.Label idCliForLabel;
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cliForBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bairroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.nascimentoDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.isEmancipadoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.lkCidade = new System.Windows.Forms.LinkLabel();
            this.idCidadeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lkNomeCliente = new System.Windows.Forms.LinkLabel();
            this.idCliForTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cpfTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.celularTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.rgTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.numeroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telefoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.enderecoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomeCompletoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tbResponsaveis = new DevExpress.XtraTab.XtraTabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.bNavigatorModelo = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            bairroLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            idCidadeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            nascimentoLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nomeCompletoLabel = new System.Windows.Forms.Label();
            idCliForLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliForBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bairroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isEmancipadoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCidadeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliForTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celularTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeCompletoTextEdit.Properties)).BeginInit();
            this.tbResponsaveis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorModelo)).BeginInit();
            this.bNavigatorModelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.xtraTabControl1);
            this.panelEdit.Size = new System.Drawing.Size(478, 439);
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(268, 271);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(35, 13);
            bairroLabel.TabIndex = 63;
            bairroLabel.Text = "Bairro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(345, 226);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 13);
            label2.TabIndex = 61;
            label2.Text = "Complemento";
            // 
            // idCidadeLabel
            // 
            idCidadeLabel.AutoSize = true;
            idCidadeLabel.Location = new System.Drawing.Point(22, 271);
            idCidadeLabel.Name = "idCidadeLabel";
            idCidadeLabel.Size = new System.Drawing.Size(40, 13);
            idCidadeLabel.TabIndex = 56;
            idCidadeLabel.Text = "Cidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(267, 102);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 13);
            label1.TabIndex = 53;
            label1.Text = "Sexo";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(22, 103);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(24, 13);
            cpfLabel.TabIndex = 50;
            cpfLabel.Text = "Cpf";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(151, 185);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(40, 13);
            celularLabel.TabIndex = 48;
            celularLabel.Text = "Celular";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(150, 103);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(20, 13);
            rgLabel.TabIndex = 45;
            rgLabel.Text = "Rg";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(268, 226);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(44, 13);
            numeroLabel.TabIndex = 43;
            numeroLabel.Text = "Numero";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(22, 185);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(49, 13);
            telefoneLabel.TabIndex = 41;
            telefoneLabel.Text = "Telefone";
            // 
            // nascimentoLabel
            // 
            nascimentoLabel.AutoSize = true;
            nascimentoLabel.Location = new System.Drawing.Point(322, 19);
            nascimentoLabel.Name = "nascimentoLabel";
            nascimentoLabel.Size = new System.Drawing.Size(62, 13);
            nascimentoLabel.TabIndex = 40;
            nascimentoLabel.Text = "Nascimento";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(22, 226);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(52, 13);
            enderecoLabel.TabIndex = 38;
            enderecoLabel.Text = "Endereco";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(22, 145);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 36;
            emailLabel.Text = "Email:";
            // 
            // nomeCompletoLabel
            // 
            nomeCompletoLabel.AutoSize = true;
            nomeCompletoLabel.Location = new System.Drawing.Point(22, 62);
            nomeCompletoLabel.Name = "nomeCompletoLabel";
            nomeCompletoLabel.Size = new System.Drawing.Size(82, 13);
            nomeCompletoLabel.TabIndex = 34;
            nomeCompletoLabel.Text = "Nome Completo";
            // 
            // idCliForLabel
            // 
            idCliForLabel.AutoSize = true;
            idCliForLabel.Location = new System.Drawing.Point(22, 19);
            idCliForLabel.Name = "idCliForLabel";
            idCliForLabel.Size = new System.Drawing.Size(40, 13);
            idCliForLabel.TabIndex = 33;
            idCliForLabel.Text = "Cliente";
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(Canaan.Dados.Modelo);
            // 
            // cliForBindingSource
            // 
            this.cliForBindingSource.DataSource = typeof(Canaan.Dados.CliFor);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(13, 13);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(452, 414);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.tbResponsaveis});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(bairroLabel);
            this.xtraTabPage1.Controls.Add(this.bairroTextEdit);
            this.xtraTabPage1.Controls.Add(label2);
            this.xtraTabPage1.Controls.Add(this.textEdit1);
            this.xtraTabPage1.Controls.Add(this.nascimentoDateEdit);
            this.xtraTabPage1.Controls.Add(this.isEmancipadoCheckEdit);
            this.xtraTabPage1.Controls.Add(this.lkCidade);
            this.xtraTabPage1.Controls.Add(idCidadeLabel);
            this.xtraTabPage1.Controls.Add(this.idCidadeTextEdit);
            this.xtraTabPage1.Controls.Add(this.lkNomeCliente);
            this.xtraTabPage1.Controls.Add(this.idCliForTextEdit);
            this.xtraTabPage1.Controls.Add(label1);
            this.xtraTabPage1.Controls.Add(this.comboBox1);
            this.xtraTabPage1.Controls.Add(cpfLabel);
            this.xtraTabPage1.Controls.Add(this.cpfTextEdit);
            this.xtraTabPage1.Controls.Add(celularLabel);
            this.xtraTabPage1.Controls.Add(this.celularTextEdit);
            this.xtraTabPage1.Controls.Add(this.isAtivoCheckEdit);
            this.xtraTabPage1.Controls.Add(rgLabel);
            this.xtraTabPage1.Controls.Add(this.rgTextEdit);
            this.xtraTabPage1.Controls.Add(numeroLabel);
            this.xtraTabPage1.Controls.Add(this.numeroTextEdit);
            this.xtraTabPage1.Controls.Add(telefoneLabel);
            this.xtraTabPage1.Controls.Add(this.telefoneTextEdit);
            this.xtraTabPage1.Controls.Add(nascimentoLabel);
            this.xtraTabPage1.Controls.Add(enderecoLabel);
            this.xtraTabPage1.Controls.Add(this.enderecoTextEdit);
            this.xtraTabPage1.Controls.Add(emailLabel);
            this.xtraTabPage1.Controls.Add(this.emailTextEdit);
            this.xtraTabPage1.Controls.Add(nomeCompletoLabel);
            this.xtraTabPage1.Controls.Add(this.nomeCompletoTextEdit);
            this.xtraTabPage1.Controls.Add(idCliForLabel);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(446, 386);
            this.xtraTabPage1.Text = "Modelo";
            // 
            // bairroTextEdit
            // 
            this.bairroTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Bairro", true));
            this.bairroTextEdit.Location = new System.Drawing.Point(271, 287);
            this.bairroTextEdit.Name = "bairroTextEdit";
            this.bairroTextEdit.Size = new System.Drawing.Size(154, 20);
            this.bairroTextEdit.TabIndex = 13;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Complemento", true));
            this.textEdit1.Location = new System.Drawing.Point(348, 242);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(77, 20);
            this.textEdit1.TabIndex = 11;
            // 
            // nascimentoDateEdit
            // 
            this.nascimentoDateEdit.CausesValidation = false;
            this.nascimentoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Nascimento", true));
            this.nascimentoDateEdit.EditValue = null;
            this.nascimentoDateEdit.Location = new System.Drawing.Point(325, 35);
            this.nascimentoDateEdit.Name = "nascimentoDateEdit";
            this.nascimentoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nascimentoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nascimentoDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.nascimentoDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.nascimentoDateEdit.Size = new System.Drawing.Size(100, 20);
            this.nascimentoDateEdit.TabIndex = 1;
            // 
            // isEmancipadoCheckEdit
            // 
            this.isEmancipadoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "IsEmancipado", true));
            this.isEmancipadoCheckEdit.Location = new System.Drawing.Point(88, 348);
            this.isEmancipadoCheckEdit.Name = "isEmancipadoCheckEdit";
            this.isEmancipadoCheckEdit.Properties.Caption = "Emancipado";
            this.isEmancipadoCheckEdit.Size = new System.Drawing.Size(137, 19);
            this.isEmancipadoCheckEdit.TabIndex = 15;
            // 
            // lkCidade
            // 
            this.lkCidade.AutoSize = true;
            this.lkCidade.Location = new System.Drawing.Point(131, 290);
            this.lkCidade.Name = "lkCidade";
            this.lkCidade.Size = new System.Drawing.Size(47, 13);
            this.lkCidade.TabIndex = 58;
            this.lkCidade.TabStop = true;
            this.lkCidade.Text = "lkCidade";
            this.lkCidade.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkCidade_LinkClicked);
            // 
            // idCidadeTextEdit
            // 
            this.idCidadeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "IdCidade", true));
            this.idCidadeTextEdit.Enabled = false;
            this.idCidadeTextEdit.Location = new System.Drawing.Point(25, 287);
            this.idCidadeTextEdit.Name = "idCidadeTextEdit";
            this.idCidadeTextEdit.Size = new System.Drawing.Size(100, 20);
            this.idCidadeTextEdit.TabIndex = 12;
            // 
            // lkNomeCliente
            // 
            this.lkNomeCliente.AutoSize = true;
            this.lkNomeCliente.Location = new System.Drawing.Point(104, 38);
            this.lkNomeCliente.Name = "lkNomeCliente";
            this.lkNomeCliente.Size = new System.Drawing.Size(74, 13);
            this.lkNomeCliente.TabIndex = 55;
            this.lkNomeCliente.TabStop = true;
            this.lkNomeCliente.Text = "lkNomeCliente";
            // 
            // idCliForTextEdit
            // 
            this.idCliForTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "IdCliFor", true));
            this.idCliForTextEdit.Enabled = false;
            this.idCliForTextEdit.Location = new System.Drawing.Point(25, 35);
            this.idCliForTextEdit.Name = "idCliForTextEdit";
            this.idCliForTextEdit.Size = new System.Drawing.Size(73, 20);
            this.idCliForTextEdit.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modeloBindingSource, "Sexo", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // cpfTextEdit
            // 
            this.cpfTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Cpf", true));
            this.cpfTextEdit.Location = new System.Drawing.Point(25, 119);
            this.cpfTextEdit.Name = "cpfTextEdit";
            this.cpfTextEdit.Properties.Mask.EditMask = "999.999.999-99";
            this.cpfTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.cpfTextEdit.Size = new System.Drawing.Size(111, 20);
            this.cpfTextEdit.TabIndex = 3;
            // 
            // celularTextEdit
            // 
            this.celularTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Celular", true));
            this.celularTextEdit.Location = new System.Drawing.Point(153, 201);
            this.celularTextEdit.Name = "celularTextEdit";
            this.celularTextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.celularTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.celularTextEdit.Properties.Mask.SaveLiteral = false;
            this.celularTextEdit.Size = new System.Drawing.Size(100, 20);
            this.celularTextEdit.TabIndex = 8;
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "IsAtivo", true));
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(23, 348);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Ativo";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isAtivoCheckEdit.TabIndex = 14;
            // 
            // rgTextEdit
            // 
            this.rgTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Rg", true));
            this.rgTextEdit.Location = new System.Drawing.Point(153, 119);
            this.rgTextEdit.Name = "rgTextEdit";
            this.rgTextEdit.Size = new System.Drawing.Size(100, 20);
            this.rgTextEdit.TabIndex = 4;
            // 
            // numeroTextEdit
            // 
            this.numeroTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Numero", true));
            this.numeroTextEdit.Location = new System.Drawing.Point(270, 242);
            this.numeroTextEdit.Name = "numeroTextEdit";
            this.numeroTextEdit.Size = new System.Drawing.Size(60, 20);
            this.numeroTextEdit.TabIndex = 10;
            // 
            // telefoneTextEdit
            // 
            this.telefoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Telefone", true));
            this.telefoneTextEdit.Location = new System.Drawing.Point(25, 201);
            this.telefoneTextEdit.Name = "telefoneTextEdit";
            this.telefoneTextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.telefoneTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.telefoneTextEdit.Properties.Mask.SaveLiteral = false;
            this.telefoneTextEdit.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextEdit.TabIndex = 7;
            // 
            // enderecoTextEdit
            // 
            this.enderecoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Endereco", true));
            this.enderecoTextEdit.Location = new System.Drawing.Point(25, 242);
            this.enderecoTextEdit.Name = "enderecoTextEdit";
            this.enderecoTextEdit.Size = new System.Drawing.Size(228, 20);
            this.enderecoTextEdit.TabIndex = 9;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "Email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(25, 161);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(400, 20);
            this.emailTextEdit.TabIndex = 6;
            // 
            // nomeCompletoTextEdit
            // 
            this.nomeCompletoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloBindingSource, "NomeCompleto", true));
            this.nomeCompletoTextEdit.Location = new System.Drawing.Point(25, 78);
            this.nomeCompletoTextEdit.Name = "nomeCompletoTextEdit";
            this.nomeCompletoTextEdit.Size = new System.Drawing.Size(400, 20);
            this.nomeCompletoTextEdit.TabIndex = 2;
            // 
            // tbResponsaveis
            // 
            this.tbResponsaveis.Controls.Add(this.dataGrid);
            this.tbResponsaveis.Controls.Add(this.bNavigatorModelo);
            this.tbResponsaveis.Name = "tbResponsaveis";
            this.tbResponsaveis.PageEnabled = false;
            this.tbResponsaveis.Size = new System.Drawing.Size(446, 386);
            this.tbResponsaveis.Text = "Responsáveis";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 25);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowCellErrors = false;
            this.dataGrid.ShowCellToolTips = false;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.ShowRowErrors = false;
            this.dataGrid.Size = new System.Drawing.Size(446, 361);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            // 
            // bNavigatorModelo
            // 
            this.bNavigatorModelo.AddNewItem = null;
            this.bNavigatorModelo.BackColor = System.Drawing.Color.White;
            this.bNavigatorModelo.CountItem = null;
            this.bNavigatorModelo.DeleteItem = null;
            this.bNavigatorModelo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bNavigatorModelo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSeparator4,
            this.toolStripSplitButton2});
            this.bNavigatorModelo.Location = new System.Drawing.Point(0, 0);
            this.bNavigatorModelo.MoveFirstItem = null;
            this.bNavigatorModelo.MoveLastItem = null;
            this.bNavigatorModelo.MoveNextItem = null;
            this.bNavigatorModelo.MovePreviousItem = null;
            this.bNavigatorModelo.Name = "bNavigatorModelo";
            this.bNavigatorModelo.PositionItem = null;
            this.bNavigatorModelo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bNavigatorModelo.Size = new System.Drawing.Size(446, 25);
            this.bNavigatorModelo.TabIndex = 1;
            this.bNavigatorModelo.Text = "bNavigatorModelo";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton2.Text = "Novo";
            this.toolStripButton2.Click += new System.EventHandler(this.novo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Canaan.Telas.Properties.Resources.folder_Open_16xLG;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton3.Text = "Editar";
            this.toolStripButton3.Click += new System.EventHandler(this.edit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(61, 22);
            this.toolStripButton4.Text = "Excluir";
            this.toolStripButton4.Click += new System.EventHandler(this.excluir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripSplitButton1.Text = "Outras Ações";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(71, 22);
            this.toolStripSplitButton2.Text = "Filtros";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 472);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliForBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bairroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nascimentoDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isEmancipadoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCidadeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliForTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celularTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeCompletoTextEdit.Properties)).EndInit();
            this.tbResponsaveis.ResumeLayout(false);
            this.tbResponsaveis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorModelo)).EndInit();
            this.bNavigatorModelo.ResumeLayout(false);
            this.bNavigatorModelo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource modeloBindingSource;
        private BindingSource cliForBindingSource;
        private XtraTabControl xtraTabControl1;
        private XtraTabPage xtraTabPage1;
        private TextEdit bairroTextEdit;
        private TextEdit textEdit1;
        private DateEdit nascimentoDateEdit;
        private CheckEdit isEmancipadoCheckEdit;
        private LinkLabel lkCidade;
        private TextEdit idCidadeTextEdit;
        private LinkLabel lkNomeCliente;
        private TextEdit idCliForTextEdit;
        private ComboBox comboBox1;
        private TextEdit cpfTextEdit;
        private TextEdit celularTextEdit;
        private CheckEdit isAtivoCheckEdit;
        private TextEdit rgTextEdit;
        private TextEdit numeroTextEdit;
        private TextEdit telefoneTextEdit;
        private TextEdit enderecoTextEdit;
        private TextEdit emailTextEdit;
        private TextEdit nomeCompletoTextEdit;
        private XtraTabPage tbResponsaveis;
        private BindingNavigator bNavigatorModelo;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSplitButton toolStripSplitButton2;
        protected DataGridView dataGrid;
    }
}