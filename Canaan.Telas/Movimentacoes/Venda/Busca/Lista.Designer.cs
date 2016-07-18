using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Venda.Busca
{
    partial class Lista
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bNavigatorModelo = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.trocaDeCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indiquePlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.serviçosContratadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosContratadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.boletpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprovanteDeEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termoDeAditamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocaDeTitularidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.CodVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAtendimentos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtendimentoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.ddlTipoBusca = new System.Windows.Forms.ComboBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorModelo)).BeginInit();
            this.bNavigatorModelo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bNavigatorModelo);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Busca";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.btExcluir,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSeparator4,
            this.toolStripSplitButton2});
            this.bNavigatorModelo.Location = new System.Drawing.Point(3, 3);
            this.bNavigatorModelo.MoveFirstItem = null;
            this.bNavigatorModelo.MoveLastItem = null;
            this.bNavigatorModelo.MoveNextItem = null;
            this.bNavigatorModelo.MovePreviousItem = null;
            this.bNavigatorModelo.Name = "bNavigatorModelo";
            this.bNavigatorModelo.PositionItem = null;
            this.bNavigatorModelo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bNavigatorModelo.Size = new System.Drawing.Size(769, 25);
            this.bNavigatorModelo.TabIndex = 3;
            this.bNavigatorModelo.Text = "bNavigatorModelo";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton2.Text = "Novo";
            this.toolStripButton2.Click += new System.EventHandler(this.novaVenda_Click);
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
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.btExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(61, 22);
            this.btExcluir.Text = "Excluir";
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocaDeCadastroToolStripMenuItem,
            this.indiquePlusToolStripMenuItem,
            this.toolStripSeparator5,
            this.serviçosContratadosToolStripMenuItem,
            this.serviçosContratadosToolStripMenuItem1,
            this.boletpToolStripMenuItem,
            this.contratoToolStripMenuItem,
            this.controleDePagamentoToolStripMenuItem,
            this.comprovanteDeEntradaToolStripMenuItem,
            this.termoDeAditamentoToolStripMenuItem,
            this.trocaDeTitularidadeToolStripMenuItem,
            this.indicaçõesToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripSplitButton1.Text = "Outras Ações";
            // 
            // trocaDeCadastroToolStripMenuItem
            // 
            this.trocaDeCadastroToolStripMenuItem.Image = global::Canaan.Telas.Properties.Resources.arrow_Sync_16xLG;
            this.trocaDeCadastroToolStripMenuItem.Name = "trocaDeCadastroToolStripMenuItem";
            this.trocaDeCadastroToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.trocaDeCadastroToolStripMenuItem.Text = "Troca de Cadastro";
            this.trocaDeCadastroToolStripMenuItem.Click += new System.EventHandler(this.trocaDeCadastroToolStripMenuItem_Click);
            // 
            // indiquePlusToolStripMenuItem
            // 
            this.indiquePlusToolStripMenuItem.Image = global::Canaan.Telas.Properties.Resources.add_list;
            this.indiquePlusToolStripMenuItem.Name = "indiquePlusToolStripMenuItem";
            this.indiquePlusToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.indiquePlusToolStripMenuItem.Text = "Indique e Ganhe Plus";
            this.indiquePlusToolStripMenuItem.Click += new System.EventHandler(this.indiquePlusToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(203, 6);
            // 
            // serviçosContratadosToolStripMenuItem
            // 
            this.serviçosContratadosToolStripMenuItem.Name = "serviçosContratadosToolStripMenuItem";
            this.serviçosContratadosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.serviçosContratadosToolStripMenuItem.Text = "Envelope de Serviços";
            this.serviçosContratadosToolStripMenuItem.Click += new System.EventHandler(this.serviçosContratadosToolStripMenuItem_Click);
            // 
            // serviçosContratadosToolStripMenuItem1
            // 
            this.serviçosContratadosToolStripMenuItem1.Name = "serviçosContratadosToolStripMenuItem1";
            this.serviçosContratadosToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.serviçosContratadosToolStripMenuItem1.Text = "Serviços Contratados";
            this.serviçosContratadosToolStripMenuItem1.Click += new System.EventHandler(this.serviçosContratadosToolStripMenuItem1_Click);
            // 
            // boletpToolStripMenuItem
            // 
            this.boletpToolStripMenuItem.Name = "boletpToolStripMenuItem";
            this.boletpToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.boletpToolStripMenuItem.Text = "Boleto";
            this.boletpToolStripMenuItem.Click += new System.EventHandler(this.boletpToolStripMenuItem_Click);
            // 
            // contratoToolStripMenuItem
            // 
            this.contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            this.contratoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.contratoToolStripMenuItem.Text = "Contrato";
            this.contratoToolStripMenuItem.Click += new System.EventHandler(this.contratoToolStripMenuItem_Click);
            // 
            // controleDePagamentoToolStripMenuItem
            // 
            this.controleDePagamentoToolStripMenuItem.Name = "controleDePagamentoToolStripMenuItem";
            this.controleDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.controleDePagamentoToolStripMenuItem.Text = "Controle de Pagamento";
            this.controleDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.controleDePagamentoToolStripMenuItem_Click);
            // 
            // comprovanteDeEntradaToolStripMenuItem
            // 
            this.comprovanteDeEntradaToolStripMenuItem.Name = "comprovanteDeEntradaToolStripMenuItem";
            this.comprovanteDeEntradaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.comprovanteDeEntradaToolStripMenuItem.Text = "Comprovante de Entrada";
            this.comprovanteDeEntradaToolStripMenuItem.Click += new System.EventHandler(this.comprovanteDeEntradaToolStripMenuItem_Click);
            // 
            // termoDeAditamentoToolStripMenuItem
            // 
            this.termoDeAditamentoToolStripMenuItem.Name = "termoDeAditamentoToolStripMenuItem";
            this.termoDeAditamentoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.termoDeAditamentoToolStripMenuItem.Text = "Termo de Aditamento";
            this.termoDeAditamentoToolStripMenuItem.Click += new System.EventHandler(this.termoDeAditamentoToolStripMenuItem_Click);
            // 
            // trocaDeTitularidadeToolStripMenuItem
            // 
            this.trocaDeTitularidadeToolStripMenuItem.Name = "trocaDeTitularidadeToolStripMenuItem";
            this.trocaDeTitularidadeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.trocaDeTitularidadeToolStripMenuItem.Text = "Troca de Titularidade";
            this.trocaDeTitularidadeToolStripMenuItem.Click += new System.EventHandler(this.trocaDeTitularidadeToolStripMenuItem_Click);
            // 
            // indicaçõesToolStripMenuItem
            // 
            this.indicaçõesToolStripMenuItem.Name = "indicaçõesToolStripMenuItem";
            this.indicaçõesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.indicaçõesToolStripMenuItem.Text = "Indicações";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvVendas);
            this.groupBox3.Location = new System.Drawing.Point(9, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendas do Cliente";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeColumns = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodVenda,
            this.CodAtendimento,
            this.Cliente,
            this.Valor,
            this.Data,
            this.Status});
            this.dgvVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendas.Location = new System.Drawing.Point(3, 16);
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.ShowCellErrors = false;
            this.dgvVendas.ShowCellToolTips = false;
            this.dgvVendas.ShowEditingIcon = false;
            this.dgvVendas.ShowRowErrors = false;
            this.dgvVendas.Size = new System.Drawing.Size(748, 145);
            this.dgvVendas.TabIndex = 2;
            this.dgvVendas.DoubleClick += new System.EventHandler(this.dgvVendas_DoubleClick);
            // 
            // CodVenda
            // 
            this.CodVenda.DataPropertyName = "Codigo";
            this.CodVenda.HeaderText = "Cód. Venda";
            this.CodVenda.Name = "CodVenda";
            this.CodVenda.ReadOnly = true;
            // 
            // CodAtendimento
            // 
            this.CodAtendimento.DataPropertyName = "Atendimento";
            this.CodAtendimento.HeaderText = "Atendimento";
            this.CodAtendimento.Name = "CodAtendimento";
            this.CodAtendimento.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Preco";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.FillWeight = 130F;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAtendimentos);
            this.groupBox2.Location = new System.Drawing.Point(9, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes Encontrados";
            // 
            // dgvAtendimentos
            // 
            this.dgvAtendimentos.AllowUserToAddRows = false;
            this.dgvAtendimentos.AllowUserToDeleteRows = false;
            this.dgvAtendimentos.AllowUserToResizeColumns = false;
            this.dgvAtendimentos.AllowUserToResizeRows = false;
            this.dgvAtendimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtendimentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAtendimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.AtendimentoGrid,
            this.Nome,
            this.Documento});
            this.dgvAtendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtendimentos.Location = new System.Drawing.Point(3, 16);
            this.dgvAtendimentos.MultiSelect = false;
            this.dgvAtendimentos.Name = "dgvAtendimentos";
            this.dgvAtendimentos.ReadOnly = true;
            this.dgvAtendimentos.RowHeadersVisible = false;
            this.dgvAtendimentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtendimentos.ShowCellErrors = false;
            this.dgvAtendimentos.ShowCellToolTips = false;
            this.dgvAtendimentos.ShowEditingIcon = false;
            this.dgvAtendimentos.ShowRowErrors = false;
            this.dgvAtendimentos.Size = new System.Drawing.Size(751, 114);
            this.dgvAtendimentos.TabIndex = 1;
            this.dgvAtendimentos.SelectionChanged += new System.EventHandler(this.dgvAtendimentos_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // AtendimentoGrid
            // 
            this.AtendimentoGrid.DataPropertyName = "Atendimento";
            this.AtendimentoGrid.FillWeight = 40F;
            this.AtendimentoGrid.HeaderText = "Atendimento";
            this.AtendimentoGrid.Name = "AtendimentoGrid";
            this.AtendimentoGrid.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Cliente";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Data";
            this.Documento.FillWeight = 40F;
            this.Documento.HeaderText = "Data";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBusca);
            this.groupBox1.Controls.Add(this.tbBusca);
            this.groupBox1.Controls.Add(this.ddlTipoBusca);
            this.groupBox1.Controls.Add(this.labelValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de Busca";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(595, 52);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 14;
            this.btnBusca.Text = "Consultar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(172, 54);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(417, 20);
            this.tbBusca.TabIndex = 13;
            // 
            // ddlTipoBusca
            // 
            this.ddlTipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoBusca.FormattingEnabled = true;
            this.ddlTipoBusca.Location = new System.Drawing.Point(172, 27);
            this.ddlTipoBusca.Name = "ddlTipoBusca";
            this.ddlTipoBusca.Size = new System.Drawing.Size(152, 21);
            this.ddlTipoBusca.TabIndex = 12;
            this.ddlTipoBusca.SelectedIndexChanged += new System.EventHandler(this.ddlTipoBusca_SelectedIndexChanged);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(15, 57);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(126, 13);
            this.labelValor.TabIndex = 11;
            this.labelValor.Text = "Informe o Valor da Busca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione o Tipo de Busca";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 521);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Busca";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorModelo)).EndInit();
            this.bNavigatorModelo.ResumeLayout(false);
            this.bNavigatorModelo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Button btnBusca;
        private TextBox tbBusca;
        private ComboBox ddlTipoBusca;
        private Label labelValor;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvAtendimentos;
        private GroupBox groupBox3;
        private BindingNavigator bNavigatorModelo;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btExcluir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripMenuItem trocaDeCadastroToolStripMenuItem;
        private ToolStripMenuItem serviçosContratadosToolStripMenuItem;
        private ToolStripMenuItem serviçosContratadosToolStripMenuItem1;
        private ToolStripMenuItem boletpToolStripMenuItem;
        private ToolStripMenuItem contratoToolStripMenuItem;
        private ToolStripMenuItem termoDeAditamentoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        protected DataGridView dgvVendas;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn AtendimentoGrid;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Documento;
        private ToolStripMenuItem trocaDeTitularidadeToolStripMenuItem;
        private DataGridViewTextBoxColumn CodVenda;
        private DataGridViewTextBoxColumn CodAtendimento;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Status;
        private ToolStripMenuItem controleDePagamentoToolStripMenuItem;
        private ToolStripMenuItem comprovanteDeEntradaToolStripMenuItem;
        private ToolStripMenuItem indiquePlusToolStripMenuItem;
        private ToolStripMenuItem indicaçõesToolStripMenuItem;
    }
}