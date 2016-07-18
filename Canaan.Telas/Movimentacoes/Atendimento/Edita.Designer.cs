using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Movimentacoes.Atendimento
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
            System.Windows.Forms.Label idCliForLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label dataLabel;
            this.tbControl = new DevExpress.XtraTab.XtraTabControl();
            this.tbAtendimentos = new DevExpress.XtraTab.XtraTabPage();
            this.gpClubeAmizade = new System.Windows.Forms.GroupBox();
            this.lbCountIndicacoes = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkIndicado = new System.Windows.Forms.LinkLabel();
            this.cLabel3 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCodAtendimento = new Canaan.Lib.Componentes.CLabel();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton7 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton8 = new System.Windows.Forms.ToolStripSplitButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.atendimentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpDadosComplementares = new System.Windows.Forms.GroupBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbConjuje = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPai = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbMae = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gpDadosCliente = new System.Windows.Forms.GroupBox();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.idUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkSelecionarCliente = new System.Windows.Forms.LinkLabel();
            this.idFilialLinkLabel = new System.Windows.Forms.LinkLabel();
            this.filialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCliForTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tbModelos = new DevExpress.XtraTab.XtraTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridModelos = new System.Windows.Forms.DataGridView();
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
            this.tbIndique = new DevExpress.XtraTab.XtraTabPage();
            this.dataGridIndicacoes = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btNovaIndicacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btEditarIndicacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btExcluirIndicacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.tbFichaAtendimento = new DevExpress.XtraTab.XtraTabPage();
            this.gridFichas = new System.Windows.Forms.DataGridView();
            this.Selecionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusAtendimento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnFichaAtendimento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton6 = new System.Windows.Forms.ToolStripSplitButton();
            this.atendimentoModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.indiqueEGanheEscritórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            idCliForLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tbAtendimentos.SuspendLayout();
            this.gpClubeAmizade.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).BeginInit();
            this.gpDadosComplementares.SuspendLayout();
            this.gpDadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliForTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            this.tbModelos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorModelo)).BeginInit();
            this.bNavigatorModelo.SuspendLayout();
            this.tbIndique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndicacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tbFichaAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFichas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoModeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idCliForLabel
            // 
            idCliForLabel.AutoSize = true;
            idCliForLabel.Location = new System.Drawing.Point(21, 81);
            idCliForLabel.Name = "idCliForLabel";
            idCliForLabel.Size = new System.Drawing.Size(39, 13);
            idCliForLabel.TabIndex = 6;
            idCliForLabel.Text = "Cliente";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(21, 127);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(43, 13);
            idUsuarioLabel.TabIndex = 17;
            idUsuarioLabel.Text = "Usuário";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(21, 169);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(30, 13);
            dataLabel.TabIndex = 18;
            dataLabel.Text = "Data";
            // 
            // tbControl
            // 
            this.tbControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbControl.Location = new System.Drawing.Point(12, 12);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedTabPage = this.tbAtendimentos;
            this.tbControl.Size = new System.Drawing.Size(904, 475);
            this.tbControl.TabIndex = 0;
            this.tbControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbAtendimentos,
            this.tbModelos,
            this.tbIndique,
            this.tbFichaAtendimento});
            // 
            // tbAtendimentos
            // 
            this.tbAtendimentos.AutoScroll = true;
            this.tbAtendimentos.Controls.Add(this.gpClubeAmizade);
            this.tbAtendimentos.Controls.Add(this.groupBox1);
            this.tbAtendimentos.Controls.Add(this.bindingNavigator3);
            this.tbAtendimentos.Controls.Add(this.checkEdit1);
            this.tbAtendimentos.Controls.Add(this.gpDadosComplementares);
            this.tbAtendimentos.Controls.Add(this.gpDadosCliente);
            this.tbAtendimentos.Controls.Add(dataLabel);
            this.tbAtendimentos.Controls.Add(this.dataDateEdit);
            this.tbAtendimentos.Controls.Add(idUsuarioLabel);
            this.tbAtendimentos.Controls.Add(this.idUsuarioComboBox);
            this.tbAtendimentos.Controls.Add(this.linkSelecionarCliente);
            this.tbAtendimentos.Controls.Add(this.idFilialLinkLabel);
            this.tbAtendimentos.Controls.Add(this.idCliForTextEdit);
            this.tbAtendimentos.Controls.Add(idCliForLabel);
            this.tbAtendimentos.Controls.Add(this.isAtivoCheckEdit);
            this.tbAtendimentos.Name = "tbAtendimentos";
            this.tbAtendimentos.Size = new System.Drawing.Size(898, 447);
            this.tbAtendimentos.Text = "Atendimentos";
            // 
            // gpClubeAmizade
            // 
            this.gpClubeAmizade.Controls.Add(this.lbCountIndicacoes);
            this.gpClubeAmizade.Controls.Add(this.linkLabel2);
            this.gpClubeAmizade.Controls.Add(this.linkIndicado);
            this.gpClubeAmizade.Controls.Add(this.cLabel3);
            this.gpClubeAmizade.Controls.Add(this.cLabel1);
            this.gpClubeAmizade.Enabled = false;
            this.gpClubeAmizade.Location = new System.Drawing.Point(24, 365);
            this.gpClubeAmizade.Name = "gpClubeAmizade";
            this.gpClubeAmizade.Size = new System.Drawing.Size(866, 71);
            this.gpClubeAmizade.TabIndex = 25;
            this.gpClubeAmizade.TabStop = false;
            this.gpClubeAmizade.Text = "Clube da Amizade";
            // 
            // lbCountIndicacoes
            // 
            this.lbCountIndicacoes.AutoSize = true;
            this.lbCountIndicacoes.Location = new System.Drawing.Point(547, 35);
            this.lbCountIndicacoes.Name = "lbCountIndicacoes";
            this.lbCountIndicacoes.Size = new System.Drawing.Size(33, 13);
            this.lbCountIndicacoes.TabIndex = 6;
            this.lbCountIndicacoes.Text = "lbabc";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(581, 35);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(49, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Detalhes";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkIndicado
            // 
            this.linkIndicado.AutoSize = true;
            this.linkIndicado.Location = new System.Drawing.Point(104, 35);
            this.linkIndicado.Name = "linkIndicado";
            this.linkIndicado.Size = new System.Drawing.Size(101, 13);
            this.linkIndicado.TabIndex = 4;
            this.linkIndicado.TabStop = true;
            this.linkIndicado.Text = "Selecione Indicador";
            this.linkIndicado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkIndicado_LinkClicked);
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel3.ForeColor = System.Drawing.Color.Black;
            this.cLabel3.Location = new System.Drawing.Point(391, 29);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel3.Size = new System.Drawing.Size(161, 23);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "Indcações deste cliente: ";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel1.ForeColor = System.Drawing.Color.Black;
            this.cLabel1.Location = new System.Drawing.Point(6, 29);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(92, 23);
            this.cLabel1.TabIndex = 0;
            this.cLabel1.Text = "Indicado por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCodAtendimento);
            this.groupBox1.Location = new System.Drawing.Point(24, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 86);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código do Atendimento";
            // 
            // lbCodAtendimento
            // 
            this.lbCodAtendimento.AutoSize = true;
            this.lbCodAtendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodAtendimento.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbCodAtendimento.Location = new System.Drawing.Point(17, 31);
            this.lbCodAtendimento.Name = "lbCodAtendimento";
            this.lbCodAtendimento.Padding = new System.Windows.Forms.Padding(5);
            this.lbCodAtendimento.Size = new System.Drawing.Size(10, 34);
            this.lbCodAtendimento.TabIndex = 0;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.BackColor = System.Drawing.Color.White;
            this.bindingNavigator3.CountItem = null;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripSeparator10,
            this.toolStripSplitButton7,
            this.toolStripSeparator11,
            this.toolStripSplitButton8});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator3.MoveFirstItem = null;
            this.bindingNavigator3.MoveLastItem = null;
            this.bindingNavigator3.MoveNextItem = null;
            this.bindingNavigator3.MovePreviousItem = null;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = null;
            this.bindingNavigator3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator3.Size = new System.Drawing.Size(898, 25);
            this.bindingNavigator3.TabIndex = 23;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton6.Text = "Salvar";
            this.toolStripButton6.Click += new System.EventHandler(this.saveAtendimentoButton_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton7
            // 
            this.toolStripSplitButton7.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.toolStripSplitButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton7.Name = "toolStripSplitButton7";
            this.toolStripSplitButton7.Size = new System.Drawing.Size(109, 22);
            this.toolStripSplitButton7.Text = "Outras Ações";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton8
            // 
            this.toolStripSplitButton8.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.toolStripSplitButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton8.Name = "toolStripSplitButton8";
            this.toolStripSplitButton8.Size = new System.Drawing.Size(71, 22);
            this.toolStripSplitButton8.Text = "Filtros";
            // 
            // checkEdit1
            // 
            this.checkEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.atendimentoBindingSource, "IsConfirmado", true));
            this.checkEdit1.Enabled = false;
            this.checkEdit1.Location = new System.Drawing.Point(22, 248);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Confirmado";
            this.checkEdit1.Size = new System.Drawing.Size(149, 19);
            this.checkEdit1.TabIndex = 3;
            // 
            // atendimentoBindingSource
            // 
            this.atendimentoBindingSource.DataSource = typeof(Canaan.Dados.Atendimento);
            // 
            // gpDadosComplementares
            // 
            this.gpDadosComplementares.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpDadosComplementares.Controls.Add(this.lbRG);
            this.gpDadosComplementares.Controls.Add(this.label15);
            this.gpDadosComplementares.Controls.Add(this.lbConjuje);
            this.gpDadosComplementares.Controls.Add(this.label5);
            this.gpDadosComplementares.Controls.Add(this.lbEstadoCivil);
            this.gpDadosComplementares.Controls.Add(this.label7);
            this.gpDadosComplementares.Controls.Add(this.lbCPF);
            this.gpDadosComplementares.Controls.Add(this.label9);
            this.gpDadosComplementares.Controls.Add(this.lbPai);
            this.gpDadosComplementares.Controls.Add(this.label11);
            this.gpDadosComplementares.Controls.Add(this.lbMae);
            this.gpDadosComplementares.Controls.Add(this.label13);
            this.gpDadosComplementares.Location = new System.Drawing.Point(408, 207);
            this.gpDadosComplementares.Name = "gpDadosComplementares";
            this.gpDadosComplementares.Size = new System.Drawing.Size(482, 152);
            this.gpDadosComplementares.TabIndex = 21;
            this.gpDadosComplementares.TabStop = false;
            this.gpDadosComplementares.Text = "Dados Complementares";
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(105, 85);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(31, 13);
            this.lbRG.TabIndex = 11;
            this.lbRG.Text = "lbRG";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "RG";
            // 
            // lbConjuje
            // 
            this.lbConjuje.AutoSize = true;
            this.lbConjuje.Location = new System.Drawing.Point(104, 130);
            this.lbConjuje.Name = "lbConjuje";
            this.lbConjuje.Size = new System.Drawing.Size(50, 13);
            this.lbConjuje.TabIndex = 9;
            this.lbConjuje.Text = "lbConjuje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Conjuje";
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Location = new System.Drawing.Point(104, 107);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(67, 13);
            this.lbEstadoCivil.TabIndex = 7;
            this.lbEstadoCivil.Text = "lbEstadoCivil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado Civil";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(105, 64);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(35, 13);
            this.lbCPF.TabIndex = 5;
            this.lbCPF.Text = "lbCPF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "CPF";
            // 
            // lbPai
            // 
            this.lbPai.AutoSize = true;
            this.lbPai.Location = new System.Drawing.Point(105, 42);
            this.lbPai.Name = "lbPai";
            this.lbPai.Size = new System.Drawing.Size(30, 13);
            this.lbPai.TabIndex = 3;
            this.lbPai.Text = "lbPai";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome do Pai";
            // 
            // lbMae
            // 
            this.lbMae.AutoSize = true;
            this.lbMae.Location = new System.Drawing.Point(105, 22);
            this.lbMae.Name = "lbMae";
            this.lbMae.Size = new System.Drawing.Size(36, 13);
            this.lbMae.TabIndex = 1;
            this.lbMae.Text = "lbMae";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nome da Mãe";
            // 
            // gpDadosCliente
            // 
            this.gpDadosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpDadosCliente.Controls.Add(this.lbNascimento);
            this.gpDadosCliente.Controls.Add(this.label14);
            this.gpDadosCliente.Controls.Add(this.lbCelular);
            this.gpDadosCliente.Controls.Add(this.Celular);
            this.gpDadosCliente.Controls.Add(this.lbTelefone);
            this.gpDadosCliente.Controls.Add(this.label4);
            this.gpDadosCliente.Controls.Add(this.lbEndereco);
            this.gpDadosCliente.Controls.Add(this.label20);
            this.gpDadosCliente.Controls.Add(this.lbEmail);
            this.gpDadosCliente.Controls.Add(this.label3);
            this.gpDadosCliente.Controls.Add(this.lbNomeCliente);
            this.gpDadosCliente.Controls.Add(this.label1);
            this.gpDadosCliente.Location = new System.Drawing.Point(408, 45);
            this.gpDadosCliente.Name = "gpDadosCliente";
            this.gpDadosCliente.Size = new System.Drawing.Size(482, 154);
            this.gpDadosCliente.TabIndex = 20;
            this.gpDadosCliente.TabStop = false;
            this.gpDadosCliente.Text = "Dados do Cliente";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Location = new System.Drawing.Point(104, 40);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(71, 13);
            this.lbNascimento.TabIndex = 11;
            this.lbNascimento.Text = "lbNascimento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Nascimento";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(104, 126);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(47, 13);
            this.lbCelular.TabIndex = 9;
            this.lbCelular.Text = "lbCelular";
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celular.Location = new System.Drawing.Point(7, 126);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(46, 13);
            this.Celular.TabIndex = 8;
            this.Celular.Text = "Celular";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(104, 103);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(57, 13);
            this.lbTelefone.TabIndex = 7;
            this.lbTelefone.Text = "lbTelefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(104, 82);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(61, 13);
            this.lbEndereco.TabIndex = 5;
            this.lbEndereco.Text = "lbEndereco";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Endereço";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(104, 60);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(40, 13);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "lbEmail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(104, 22);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(75, 13);
            this.lbNomeCliente.TabIndex = 1;
            this.lbNomeCliente.Text = "lbNomeCliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // dataDateEdit
            // 
            this.dataDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.atendimentoBindingSource, "Data", true));
            this.dataDateEdit.EditValue = new System.DateTime(2013, 11, 4, 11, 28, 42, 974);
            this.dataDateEdit.Enabled = false;
            this.dataDateEdit.Location = new System.Drawing.Point(24, 185);
            this.dataDateEdit.Name = "dataDateEdit";
            this.dataDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataDateEdit.Size = new System.Drawing.Size(147, 20);
            this.dataDateEdit.TabIndex = 19;
            // 
            // idUsuarioComboBox
            // 
            this.idUsuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.atendimentoBindingSource, "IdUsuario", true));
            this.idUsuarioComboBox.DataSource = this.usuarioBindingSource;
            this.idUsuarioComboBox.DisplayMember = "Nome";
            this.idUsuarioComboBox.Enabled = false;
            this.idUsuarioComboBox.FormattingEnabled = true;
            this.idUsuarioComboBox.Location = new System.Drawing.Point(24, 143);
            this.idUsuarioComboBox.Name = "idUsuarioComboBox";
            this.idUsuarioComboBox.Size = new System.Drawing.Size(147, 21);
            this.idUsuarioComboBox.TabIndex = 18;
            this.idUsuarioComboBox.ValueMember = "IdUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Canaan.Dados.Usuario);
            // 
            // linkSelecionarCliente
            // 
            this.linkSelecionarCliente.AutoSize = true;
            this.linkSelecionarCliente.Enabled = false;
            this.linkSelecionarCliente.Location = new System.Drawing.Point(177, 100);
            this.linkSelecionarCliente.Name = "linkSelecionarCliente";
            this.linkSelecionarCliente.Size = new System.Drawing.Size(92, 13);
            this.linkSelecionarCliente.TabIndex = 16;
            this.linkSelecionarCliente.TabStop = true;
            this.linkSelecionarCliente.Text = "Selecionar Cliente";
            this.linkSelecionarCliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelecionarCliente_LinkClicked);
            // 
            // idFilialLinkLabel
            // 
            this.idFilialLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "RazaoSocial", true));
            this.idFilialLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFilialLinkLabel.Location = new System.Drawing.Point(20, 45);
            this.idFilialLinkLabel.Name = "idFilialLinkLabel";
            this.idFilialLinkLabel.Size = new System.Drawing.Size(321, 23);
            this.idFilialLinkLabel.TabIndex = 15;
            this.idFilialLinkLabel.TabStop = true;
            this.idFilialLinkLabel.Text = "linkLabel1";
            // 
            // filialBindingSource
            // 
            this.filialBindingSource.DataSource = typeof(Canaan.Dados.Filial);
            // 
            // idCliForTextEdit
            // 
            this.idCliForTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.atendimentoBindingSource, "IdCliFor", true));
            this.idCliForTextEdit.Enabled = false;
            this.idCliForTextEdit.Location = new System.Drawing.Point(24, 97);
            this.idCliForTextEdit.Name = "idCliForTextEdit";
            this.idCliForTextEdit.Size = new System.Drawing.Size(147, 20);
            this.idCliForTextEdit.TabIndex = 0;
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.atendimentoBindingSource, "IsAtivo", true));
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(22, 223);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Status";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(149, 19);
            this.isAtivoCheckEdit.TabIndex = 2;
            // 
            // tbModelos
            // 
            this.tbModelos.AutoScroll = true;
            this.tbModelos.Controls.Add(this.panel1);
            this.tbModelos.Controls.Add(this.bNavigatorModelo);
            this.tbModelos.Name = "tbModelos";
            this.tbModelos.PageEnabled = false;
            this.tbModelos.Size = new System.Drawing.Size(898, 447);
            this.tbModelos.Text = "Modelos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridModelos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 422);
            this.panel1.TabIndex = 1;
            // 
            // gridModelos
            // 
            this.gridModelos.AllowUserToAddRows = false;
            this.gridModelos.AllowUserToDeleteRows = false;
            this.gridModelos.AllowUserToResizeColumns = false;
            this.gridModelos.AllowUserToResizeRows = false;
            this.gridModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridModelos.BackgroundColor = System.Drawing.Color.White;
            this.gridModelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridModelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridModelos.Location = new System.Drawing.Point(0, 0);
            this.gridModelos.MultiSelect = false;
            this.gridModelos.Name = "gridModelos";
            this.gridModelos.ReadOnly = true;
            this.gridModelos.RowHeadersVisible = false;
            this.gridModelos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridModelos.ShowCellErrors = false;
            this.gridModelos.ShowCellToolTips = false;
            this.gridModelos.ShowEditingIcon = false;
            this.gridModelos.ShowRowErrors = false;
            this.gridModelos.Size = new System.Drawing.Size(898, 422);
            this.gridModelos.TabIndex = 1;
            this.gridModelos.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
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
            this.bNavigatorModelo.Size = new System.Drawing.Size(898, 25);
            this.bNavigatorModelo.TabIndex = 0;
            this.bNavigatorModelo.Text = "bNavigatorModelo";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton2.Text = "Novo";
            this.toolStripButton2.Click += new System.EventHandler(this.novoModelo_Click);
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
            this.toolStripButton3.Click += new System.EventHandler(this.editarModelo_Click);
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
            this.toolStripButton4.Click += new System.EventHandler(this.excluirModelo_Click);
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
            // tbIndique
            // 
            this.tbIndique.Controls.Add(this.dataGridIndicacoes);
            this.tbIndique.Controls.Add(this.bindingNavigator1);
            this.tbIndique.Name = "tbIndique";
            this.tbIndique.PageEnabled = false;
            this.tbIndique.Size = new System.Drawing.Size(898, 447);
            this.tbIndique.Text = "Indique e Ganhe";
            // 
            // dataGridIndicacoes
            // 
            this.dataGridIndicacoes.AllowUserToAddRows = false;
            this.dataGridIndicacoes.AllowUserToDeleteRows = false;
            this.dataGridIndicacoes.AllowUserToResizeColumns = false;
            this.dataGridIndicacoes.AllowUserToResizeRows = false;
            this.dataGridIndicacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIndicacoes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridIndicacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridIndicacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridIndicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridIndicacoes.Location = new System.Drawing.Point(0, 25);
            this.dataGridIndicacoes.MultiSelect = false;
            this.dataGridIndicacoes.Name = "dataGridIndicacoes";
            this.dataGridIndicacoes.ReadOnly = true;
            this.dataGridIndicacoes.RowHeadersVisible = false;
            this.dataGridIndicacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridIndicacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIndicacoes.ShowCellErrors = false;
            this.dataGridIndicacoes.ShowCellToolTips = false;
            this.dataGridIndicacoes.ShowEditingIcon = false;
            this.dataGridIndicacoes.ShowRowErrors = false;
            this.dataGridIndicacoes.Size = new System.Drawing.Size(898, 422);
            this.dataGridIndicacoes.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.White;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNovaIndicacao,
            this.toolStripSeparator5,
            this.btEditarIndicacao,
            this.toolStripSeparator6,
            this.btExcluirIndicacao,
            this.toolStripSeparator7,
            this.toolStripSplitButton3,
            this.toolStripSeparator8,
            this.toolStripSplitButton4});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(898, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // btNovaIndicacao
            // 
            this.btNovaIndicacao.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.btNovaIndicacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNovaIndicacao.Name = "btNovaIndicacao";
            this.btNovaIndicacao.Size = new System.Drawing.Size(56, 22);
            this.btNovaIndicacao.Text = "Novo";
            this.btNovaIndicacao.Click += new System.EventHandler(this.btNovaIndicacao_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btEditarIndicacao
            // 
            this.btEditarIndicacao.Image = global::Canaan.Telas.Properties.Resources.folder_Open_16xLG;
            this.btEditarIndicacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEditarIndicacao.Name = "btEditarIndicacao";
            this.btEditarIndicacao.Size = new System.Drawing.Size(57, 22);
            this.btEditarIndicacao.Text = "Editar";
            this.btEditarIndicacao.Click += new System.EventHandler(this.btEditarIndicacao_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btExcluirIndicacao
            // 
            this.btExcluirIndicacao.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.btExcluirIndicacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExcluirIndicacao.Name = "btExcluirIndicacao";
            this.btExcluirIndicacao.Size = new System.Drawing.Size(61, 22);
            this.btExcluirIndicacao.Text = "Excluir";
            this.btExcluirIndicacao.Click += new System.EventHandler(this.btExcluirIndicacao_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indiqueEGanheEscritórioToolStripMenuItem});
            this.toolStripSplitButton3.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(109, 22);
            this.toolStripSplitButton3.Text = "Outras Ações";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(71, 22);
            this.toolStripSplitButton4.Text = "Filtros";
            // 
            // tbFichaAtendimento
            // 
            this.tbFichaAtendimento.Controls.Add(this.gridFichas);
            this.tbFichaAtendimento.Controls.Add(this.bindingNavigator2);
            this.tbFichaAtendimento.Name = "tbFichaAtendimento";
            this.tbFichaAtendimento.PageEnabled = false;
            this.tbFichaAtendimento.Size = new System.Drawing.Size(898, 447);
            this.tbFichaAtendimento.Text = "Ficha de Atendimento";
            // 
            // gridFichas
            // 
            this.gridFichas.AllowUserToAddRows = false;
            this.gridFichas.AllowUserToDeleteRows = false;
            this.gridFichas.AllowUserToResizeColumns = false;
            this.gridFichas.AllowUserToResizeRows = false;
            this.gridFichas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFichas.BackgroundColor = System.Drawing.Color.White;
            this.gridFichas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridFichas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionado,
            this.Codigo,
            this.Modelo,
            this.Cliente,
            this.Nascimento,
            this.Idade,
            this.StatusAtendimento});
            this.gridFichas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFichas.Location = new System.Drawing.Point(0, 25);
            this.gridFichas.MultiSelect = false;
            this.gridFichas.Name = "gridFichas";
            this.gridFichas.RowHeadersVisible = false;
            this.gridFichas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridFichas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFichas.ShowCellErrors = false;
            this.gridFichas.ShowCellToolTips = false;
            this.gridFichas.ShowEditingIcon = false;
            this.gridFichas.ShowRowErrors = false;
            this.gridFichas.Size = new System.Drawing.Size(898, 422);
            this.gridFichas.TabIndex = 5;
            // 
            // Selecionado
            // 
            this.Selecionado.DataPropertyName = "Selecionado";
            this.Selecionado.HeaderText = "Selecionado";
            this.Selecionado.Name = "Selecionado";
            this.Selecionado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selecionado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Nascimento
            // 
            this.Nascimento.DataPropertyName = "Nascimento";
            this.Nascimento.HeaderText = "Nascimento";
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // StatusAtendimento
            // 
            this.StatusAtendimento.DataPropertyName = "StatusAtendimento";
            this.StatusAtendimento.HeaderText = "Status";
            this.StatusAtendimento.Name = "StatusAtendimento";
            this.StatusAtendimento.ReadOnly = true;
            this.StatusAtendimento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusAtendimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BackColor = System.Drawing.Color.White;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripSeparator9,
            this.toolStripSplitButton5,
            this.toolStripSeparator12,
            this.toolStripSplitButton6});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator2.Size = new System.Drawing.Size(898, 25);
            this.bindingNavigator2.TabIndex = 4;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton5.Text = "Salvar";
            this.toolStripButton5.Click += new System.EventHandler(this.salvarFicha_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton5
            // 
            this.toolStripSplitButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFichaAtendimento});
            this.toolStripSplitButton5.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton5.Name = "toolStripSplitButton5";
            this.toolStripSplitButton5.Size = new System.Drawing.Size(109, 22);
            this.toolStripSplitButton5.Text = "Outras Ações";
            // 
            // btnFichaAtendimento
            // 
            this.btnFichaAtendimento.Name = "btnFichaAtendimento";
            this.btnFichaAtendimento.Size = new System.Drawing.Size(191, 22);
            this.btnFichaAtendimento.Text = "Ficha de Atendimento";
            this.btnFichaAtendimento.Click += new System.EventHandler(this.btnFichaAtendimento_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton6
            // 
            this.toolStripSplitButton6.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.toolStripSplitButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton6.Name = "toolStripSplitButton6";
            this.toolStripSplitButton6.Size = new System.Drawing.Size(71, 22);
            this.toolStripSplitButton6.Text = "Filtros";
            // 
            // atendimentoModeloBindingSource
            // 
            this.atendimentoModeloBindingSource.DataMember = "AtendimentoModelo";
            this.atendimentoModeloBindingSource.DataSource = this.atendimentoBindingSource;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(Canaan.Dados.Modelo);
            // 
            // indiqueEGanheEscritórioToolStripMenuItem
            // 
            this.indiqueEGanheEscritórioToolStripMenuItem.Name = "indiqueEGanheEscritórioToolStripMenuItem";
            this.indiqueEGanheEscritórioToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.indiqueEGanheEscritórioToolStripMenuItem.Text = "Indique e Ganhe Escritório";
            this.indiqueEGanheEscritórioToolStripMenuItem.Click += new System.EventHandler(this.indiqueEGanheEscritórioToolStripMenuItem_Click);
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 496);
            this.Controls.Add(this.tbControl);
            this.MaximizeBox = false;
            this.Name = "Edita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atendimento";
            this.Load += new System.EventHandler(this.Atendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tbAtendimentos.ResumeLayout(false);
            this.tbAtendimentos.PerformLayout();
            this.gpClubeAmizade.ResumeLayout(false);
            this.gpClubeAmizade.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoBindingSource)).EndInit();
            this.gpDadosComplementares.ResumeLayout(false);
            this.gpDadosComplementares.PerformLayout();
            this.gpDadosCliente.ResumeLayout(false);
            this.gpDadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCliForTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            this.tbModelos.ResumeLayout(false);
            this.tbModelos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridModelos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorModelo)).EndInit();
            this.bNavigatorModelo.ResumeLayout(false);
            this.bNavigatorModelo.PerformLayout();
            this.tbIndique.ResumeLayout(false);
            this.tbIndique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIndicacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tbFichaAtendimento.ResumeLayout(false);
            this.tbFichaAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFichas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentoModeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraTabControl tbControl;
        private XtraTabPage tbAtendimentos;
        private XtraTabPage tbModelos;
        private XtraTabPage tbIndique;
        private CheckEdit isAtivoCheckEdit;
        private TextEdit idCliForTextEdit;
        private LinkLabel linkSelecionarCliente;
        private ComboBox idUsuarioComboBox;
        private DateEdit dataDateEdit;
        private BindingSource atendimentoBindingSource;
        private BindingSource usuarioBindingSource;
        private BindingSource filialBindingSource;
        private GroupBox gpDadosCliente;
        private BindingSource atendimentoModeloBindingSource;
        private Label lbNomeCliente;
        private Label label1;
        private Label lbEmail;
        private Label label3;
        private Label label20;
        private Label lbEndereco;
        private Label lbTelefone;
        private Label label4;
        private Label lbCelular;
        private Label Celular;
        private GroupBox gpDadosComplementares;
        private Label lbConjuje;
        private Label label5;
        private Label lbEstadoCivil;
        private Label label7;
        private Label lbCPF;
        private Label label9;
        private Label lbPai;
        private Label label11;
        private Label lbMae;
        private Label label13;
        private Label lbNascimento;
        private Label label14;
        private Label lbRG;
        private Label label15;
        private BindingSource modeloBindingSource;
        private BindingNavigator bNavigatorModelo;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSplitButton toolStripSplitButton2;
        private Panel panel1;
        protected DataGridView gridModelos;
        private LinkLabel idFilialLinkLabel;
        protected DataGridView dataGridIndicacoes;
        private BindingNavigator bindingNavigator1;
        private ToolStripButton btNovaIndicacao;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btEditarIndicacao;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btExcluirIndicacao;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSplitButton toolStripSplitButton3;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSplitButton toolStripSplitButton4;
        private XtraTabPage tbFichaAtendimento;
        protected DataGridView gridFichas;
        private BindingNavigator bindingNavigator2;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSplitButton toolStripSplitButton5;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSplitButton toolStripSplitButton6;
        private CheckEdit checkEdit1;
        private BindingNavigator bindingNavigator3;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripSplitButton toolStripSplitButton7;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripSplitButton toolStripSplitButton8;
        private ToolStripMenuItem btnFichaAtendimento;
        private GroupBox groupBox1;
        private CLabel lbCodAtendimento;
        private GroupBox gpClubeAmizade;
        private CLabel cLabel3;
        private CLabel cLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkIndicado;
        private Label lbCountIndicacoes;
        private DataGridViewCheckBoxColumn Selecionado;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Nascimento;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewCheckBoxColumn StatusAtendimento;
        private ToolStripMenuItem indiqueEGanheEscritórioToolStripMenuItem;
    }
}