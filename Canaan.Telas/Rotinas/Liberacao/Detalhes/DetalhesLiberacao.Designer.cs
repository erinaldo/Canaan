using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Rotinas.Liberacao.Detalhes
{
    partial class DetalhesLiberacao
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
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridEnvelope = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serviço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moldura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.IdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEmancipado = new Canaan.Lib.Componentes.CLabel();
            this.lbStatusLabel = new Canaan.Lib.Componentes.CLabel();
            this.lbVendedora = new System.Windows.Forms.Label();
            this.lbDataVenda = new System.Windows.Forms.Label();
            this.lbCodVenda = new System.Windows.Forms.Label();
            this.lbCodAtendimento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridReferencia = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbConjuje = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbRG = new System.Windows.Forms.Label();
            this.lbDataNasc = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbFiliacao = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCep = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbClienteFinanceiro = new System.Windows.Forms.Label();
            this.lbClienteComercial = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridLanc = new System.Windows.Forms.DataGridView();
            this.TipoLancamento = new System.Windows.Forms.DataGridViewImageColumn();
            this.ClienteLanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbDataEntrada = new System.Windows.Forms.Label();
            this.lbFormaEntrada = new System.Windows.Forms.Label();
            this.lbFormaPagamento = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbValorRestante = new System.Windows.Forms.Label();
            this.lbValorEntrada = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.lbPorcentagemDesconto = new System.Windows.Forms.Label();
            this.lbValorDesconto = new System.Windows.Forms.Label();
            this.lbPorcentagemJuros = new System.Windows.Forms.Label();
            this.lbValorJuro = new System.Windows.Forms.Label();
            this.lbValorProduto = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.datagridMotivos = new System.Windows.Forms.DataGridView();
            this.IdMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridDevolucoes = new System.Windows.Forms.DataGridView();
            this.IdMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodAtend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btLiberar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnvelope)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReferencia)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanc)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMotivos)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucoes)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bindingNavigator2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Infromações do Pedido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator7,
            this.toolStripButton5});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 374);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator2.Size = new System.Drawing.Size(899, 25);
            this.bindingNavigator2.TabIndex = 4;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Canaan.Telas.Properties.Resources.Security_Shields_Critical_16xLG;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(182, 22);
            this.toolStripButton4.Text = "Não possui itens no envelope";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Canaan.Telas.Properties.Resources.Security_Shields_Complete_and_ok_16xLG_color;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(157, 22);
            this.toolStripButton5.Text = "Possui itens no envelope";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridEnvelope);
            this.groupBox3.Location = new System.Drawing.Point(8, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(889, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Envelopes";
            // 
            // dataGridEnvelope
            // 
            this.dataGridEnvelope.AllowUserToAddRows = false;
            this.dataGridEnvelope.AllowUserToDeleteRows = false;
            this.dataGridEnvelope.AllowUserToResizeColumns = false;
            this.dataGridEnvelope.AllowUserToResizeRows = false;
            this.dataGridEnvelope.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEnvelope.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEnvelope.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEnvelope.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEnvelope.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Serviço,
            this.Album,
            this.Moldura,
            this.Fotos,
            this.Status});
            this.dataGridEnvelope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEnvelope.Location = new System.Drawing.Point(3, 16);
            this.dataGridEnvelope.MultiSelect = false;
            this.dataGridEnvelope.Name = "dataGridEnvelope";
            this.dataGridEnvelope.ReadOnly = true;
            this.dataGridEnvelope.RowHeadersVisible = false;
            this.dataGridEnvelope.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridEnvelope.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEnvelope.ShowCellErrors = false;
            this.dataGridEnvelope.ShowCellToolTips = false;
            this.dataGridEnvelope.ShowEditingIcon = false;
            this.dataGridEnvelope.ShowRowErrors = false;
            this.dataGridEnvelope.Size = new System.Drawing.Size(883, 160);
            this.dataGridEnvelope.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.FillWeight = 35F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Serviço
            // 
            this.Serviço.DataPropertyName = "Servico";
            this.Serviço.FillWeight = 284.7716F;
            this.Serviço.HeaderText = "Servico";
            this.Serviço.Name = "Serviço";
            this.Serviço.ReadOnly = true;
            // 
            // Album
            // 
            this.Album.DataPropertyName = "Album";
            this.Album.HeaderText = "Álbum";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            // 
            // Moldura
            // 
            this.Moldura.DataPropertyName = "Moldura";
            this.Moldura.HeaderText = "Moldura";
            this.Moldura.Name = "Moldura";
            this.Moldura.ReadOnly = true;
            // 
            // Fotos
            // 
            this.Fotos.DataPropertyName = "Fotos";
            this.Fotos.HeaderText = "Fotos";
            this.Fotos.Name = "Fotos";
            this.Fotos.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 35F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGrid);
            this.groupBox2.Location = new System.Drawing.Point(327, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Produtos";
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
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdItem,
            this.Produto,
            this.Quantidade,
            this.Valor});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 16);
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
            this.dataGrid.Size = new System.Drawing.Size(564, 154);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // IdItem
            // 
            this.IdItem.DataPropertyName = "Codigo";
            this.IdItem.FillWeight = 41.80634F;
            this.IdItem.HeaderText = "Código ";
            this.IdItem.Name = "IdItem";
            this.IdItem.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Produto";
            this.Produto.FillWeight = 203.0457F;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.FillWeight = 77.57399F;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.FillWeight = 77.57399F;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbEmancipado);
            this.groupBox1.Controls.Add(this.lbStatusLabel);
            this.groupBox1.Controls.Add(this.lbVendedora);
            this.groupBox1.Controls.Add(this.lbDataVenda);
            this.groupBox1.Controls.Add(this.lbCodVenda);
            this.groupBox1.Controls.Add(this.lbCodAtendimento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerais";
            // 
            // lbEmancipado
            // 
            this.lbEmancipado.AutoSize = true;
            this.lbEmancipado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmancipado.ForeColor = System.Drawing.Color.Red;
            this.lbEmancipado.Location = new System.Drawing.Point(8, 147);
            this.lbEmancipado.Name = "lbEmancipado";
            this.lbEmancipado.Padding = new System.Windows.Forms.Padding(5);
            this.lbEmancipado.Size = new System.Drawing.Size(86, 23);
            this.lbEmancipado.TabIndex = 10;
            this.lbEmancipado.Text = "Emancipado";
            // 
            // lbStatusLabel
            // 
            this.lbStatusLabel.AutoSize = true;
            this.lbStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbStatusLabel.Location = new System.Drawing.Point(8, 117);
            this.lbStatusLabel.Name = "lbStatusLabel";
            this.lbStatusLabel.Padding = new System.Windows.Forms.Padding(5);
            this.lbStatusLabel.Size = new System.Drawing.Size(129, 32);
            this.lbStatusLabel.TabIndex = 9;
            this.lbStatusLabel.Text = "lbStatusLabel";
            // 
            // lbVendedora
            // 
            this.lbVendedora.AutoSize = true;
            this.lbVendedora.Location = new System.Drawing.Point(120, 90);
            this.lbVendedora.Name = "lbVendedora";
            this.lbVendedora.Size = new System.Drawing.Size(67, 13);
            this.lbVendedora.TabIndex = 7;
            this.lbVendedora.Text = "lbVendedora";
            // 
            // lbDataVenda
            // 
            this.lbDataVenda.AutoSize = true;
            this.lbDataVenda.Location = new System.Drawing.Point(120, 68);
            this.lbDataVenda.Name = "lbDataVenda";
            this.lbDataVenda.Size = new System.Drawing.Size(69, 13);
            this.lbDataVenda.TabIndex = 6;
            this.lbDataVenda.Text = "lbDataVenda";
            // 
            // lbCodVenda
            // 
            this.lbCodVenda.AutoSize = true;
            this.lbCodVenda.Location = new System.Drawing.Point(120, 47);
            this.lbCodVenda.Name = "lbCodVenda";
            this.lbCodVenda.Size = new System.Drawing.Size(65, 13);
            this.lbCodVenda.TabIndex = 5;
            this.lbCodVenda.Text = "lbCodVenda";
            // 
            // lbCodAtendimento
            // 
            this.lbCodAtendimento.AutoSize = true;
            this.lbCodAtendimento.Location = new System.Drawing.Point(120, 26);
            this.lbCodAtendimento.Name = "lbCodAtendimento";
            this.lbCodAtendimento.Size = new System.Drawing.Size(93, 13);
            this.lbCodAtendimento.TabIndex = 4;
            this.lbCodAtendimento.Text = "lbCodAtendimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vendedora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data da Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cód. Venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Atendimento";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Informações dos Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridReferencia);
            this.groupBox6.Location = new System.Drawing.Point(463, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(436, 173);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Referências";
            // 
            // dataGridReferencia
            // 
            this.dataGridReferencia.AllowUserToAddRows = false;
            this.dataGridReferencia.AllowUserToDeleteRows = false;
            this.dataGridReferencia.AllowUserToResizeColumns = false;
            this.dataGridReferencia.AllowUserToResizeRows = false;
            this.dataGridReferencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReferencia.BackgroundColor = System.Drawing.Color.White;
            this.dataGridReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridReferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridReferencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Tipo,
            this.Cidade,
            this.Telefone});
            this.dataGridReferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridReferencia.Location = new System.Drawing.Point(3, 16);
            this.dataGridReferencia.MultiSelect = false;
            this.dataGridReferencia.Name = "dataGridReferencia";
            this.dataGridReferencia.ReadOnly = true;
            this.dataGridReferencia.RowHeadersVisible = false;
            this.dataGridReferencia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridReferencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReferencia.ShowCellErrors = false;
            this.dataGridReferencia.ShowCellToolTips = false;
            this.dataGridReferencia.ShowEditingIcon = false;
            this.dataGridReferencia.ShowRowErrors = false;
            this.dataGridReferencia.Size = new System.Drawing.Size(430, 154);
            this.dataGridReferencia.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.DataPropertyName = "Endereco";
            this.Cidade.HeaderText = "Endereco";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Visible = false;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbConjuje);
            this.groupBox4.Controls.Add(this.lbCPF);
            this.groupBox4.Controls.Add(this.lbRG);
            this.groupBox4.Controls.Add(this.lbDataNasc);
            this.groupBox4.Controls.Add(this.lbCelular);
            this.groupBox4.Controls.Add(this.lbTelefone);
            this.groupBox4.Controls.Add(this.lbEmail);
            this.groupBox4.Controls.Add(this.lbFiliacao);
            this.groupBox4.Controls.Add(this.lbEstado);
            this.groupBox4.Controls.Add(this.lbCep);
            this.groupBox4.Controls.Add(this.lbCidade);
            this.groupBox4.Controls.Add(this.lbBairro);
            this.groupBox4.Controls.Add(this.lbEndereco);
            this.groupBox4.Controls.Add(this.lbSexo);
            this.groupBox4.Controls.Add(this.lbClienteFinanceiro);
            this.groupBox4.Controls.Add(this.lbClienteComercial);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 388);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Pessoais";
            // 
            // lbConjuje
            // 
            this.lbConjuje.AutoSize = true;
            this.lbConjuje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConjuje.Location = new System.Drawing.Point(112, 357);
            this.lbConjuje.Name = "lbConjuje";
            this.lbConjuje.Size = new System.Drawing.Size(59, 13);
            this.lbConjuje.TabIndex = 36;
            this.lbConjuje.Text = "lbConjuje";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(112, 337);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(40, 13);
            this.lbCPF.TabIndex = 35;
            this.lbCPF.Text = "lbCPF";
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRG.Location = new System.Drawing.Point(112, 317);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(35, 13);
            this.lbRG.TabIndex = 34;
            this.lbRG.Text = "lbRG";
            // 
            // lbDataNasc
            // 
            this.lbDataNasc.AutoSize = true;
            this.lbDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNasc.Location = new System.Drawing.Point(112, 297);
            this.lbDataNasc.Name = "lbDataNasc";
            this.lbDataNasc.Size = new System.Drawing.Size(73, 13);
            this.lbDataNasc.TabIndex = 33;
            this.lbDataNasc.Text = "lbDataNasc";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(112, 277);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(56, 13);
            this.lbCelular.TabIndex = 32;
            this.lbCelular.Text = "lbCelular";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(112, 257);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(67, 13);
            this.lbTelefone.TabIndex = 31;
            this.lbTelefone.Text = "lbTelefone";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(112, 237);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(40, 13);
            this.lbEmail.TabIndex = 30;
            this.lbEmail.Text = "lbEmail";
            // 
            // lbFiliacao
            // 
            this.lbFiliacao.AutoSize = true;
            this.lbFiliacao.Location = new System.Drawing.Point(112, 217);
            this.lbFiliacao.Name = "lbFiliacao";
            this.lbFiliacao.Size = new System.Drawing.Size(51, 13);
            this.lbFiliacao.TabIndex = 29;
            this.lbFiliacao.Text = "lbFiliacao";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(112, 197);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(48, 13);
            this.lbEstado.TabIndex = 28;
            this.lbEstado.Text = "lbEstado";
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(112, 176);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(34, 13);
            this.lbCep.TabIndex = 27;
            this.lbCep.Text = "lbCep";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(112, 157);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(48, 13);
            this.lbCidade.TabIndex = 26;
            this.lbCidade.Text = "lbCidade";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(112, 137);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(42, 13);
            this.lbBairro.TabIndex = 25;
            this.lbBairro.Text = "lbBairro";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(112, 117);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(61, 13);
            this.lbEndereco.TabIndex = 24;
            this.lbEndereco.Text = "lbEndereco";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(112, 97);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(39, 13);
            this.lbSexo.TabIndex = 23;
            this.lbSexo.Text = "lbSexo";
            // 
            // lbClienteFinanceiro
            // 
            this.lbClienteFinanceiro.AutoSize = true;
            this.lbClienteFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteFinanceiro.Location = new System.Drawing.Point(112, 53);
            this.lbClienteFinanceiro.Name = "lbClienteFinanceiro";
            this.lbClienteFinanceiro.Size = new System.Drawing.Size(115, 13);
            this.lbClienteFinanceiro.TabIndex = 22;
            this.lbClienteFinanceiro.Text = "lbClienteFinanceiro";
            // 
            // lbClienteComercial
            // 
            this.lbClienteComercial.AutoSize = true;
            this.lbClienteComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteComercial.Location = new System.Drawing.Point(112, 29);
            this.lbClienteComercial.Name = "lbClienteComercial";
            this.lbClienteComercial.Size = new System.Drawing.Size(111, 13);
            this.lbClienteComercial.TabIndex = 21;
            this.lbClienteComercial.Text = "lbClienteComercial";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 357);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Conjuje";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 337);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "CPF";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 317);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "RG";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Data Nasc.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Celular";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Telefone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 237);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Fialiação";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Estado / UF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "CEP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bairro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cliente Financeiro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cliente Comercial";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(905, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informações Financeiras";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.bindingNavigator1);
            this.groupBox10.Controls.Add(this.dataGridLanc);
            this.groupBox10.Location = new System.Drawing.Point(382, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(517, 375);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Parcelas";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 347);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(511, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.money2;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton1.Text = "Entrada";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.money_envelope;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton2.Text = "Parcelas";
            // 
            // dataGridLanc
            // 
            this.dataGridLanc.AllowUserToAddRows = false;
            this.dataGridLanc.AllowUserToDeleteRows = false;
            this.dataGridLanc.AllowUserToResizeColumns = false;
            this.dataGridLanc.AllowUserToResizeRows = false;
            this.dataGridLanc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLanc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridLanc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridLanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridLanc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoLancamento,
            this.ClienteLanc,
            this.Filial,
            this.dataGridViewTextBoxColumn1,
            this.ValorOriginal});
            this.dataGridLanc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLanc.Location = new System.Drawing.Point(3, 16);
            this.dataGridLanc.MultiSelect = false;
            this.dataGridLanc.Name = "dataGridLanc";
            this.dataGridLanc.ReadOnly = true;
            this.dataGridLanc.RowHeadersVisible = false;
            this.dataGridLanc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridLanc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLanc.ShowCellErrors = false;
            this.dataGridLanc.ShowCellToolTips = false;
            this.dataGridLanc.ShowEditingIcon = false;
            this.dataGridLanc.ShowRowErrors = false;
            this.dataGridLanc.Size = new System.Drawing.Size(511, 356);
            this.dataGridLanc.TabIndex = 4;
            // 
            // TipoLancamento
            // 
            this.TipoLancamento.DataPropertyName = "TipoParcela";
            this.TipoLancamento.FillWeight = 30F;
            this.TipoLancamento.HeaderText = "";
            this.TipoLancamento.MinimumWidth = 30;
            this.TipoLancamento.Name = "TipoLancamento";
            this.TipoLancamento.ReadOnly = true;
            // 
            // ClienteLanc
            // 
            this.ClienteLanc.DataPropertyName = "Cliente";
            this.ClienteLanc.HeaderText = "Cliente";
            this.ClienteLanc.Name = "ClienteLanc";
            this.ClienteLanc.ReadOnly = true;
            // 
            // Filial
            // 
            this.Filial.DataPropertyName = "Filial";
            this.Filial.FillWeight = 96.8818F;
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            this.Filial.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn1.FillWeight = 96.8818F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ValorOriginal
            // 
            this.ValorOriginal.DataPropertyName = "ValorOriginal";
            this.ValorOriginal.FillWeight = 96.8818F;
            this.ValorOriginal.HeaderText = "Valor Original";
            this.ValorOriginal.Name = "ValorOriginal";
            this.ValorOriginal.ReadOnly = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbDataEntrada);
            this.groupBox8.Controls.Add(this.lbFormaEntrada);
            this.groupBox8.Controls.Add(this.lbFormaPagamento);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Location = new System.Drawing.Point(9, 204);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(370, 86);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Forma de Pagamento";
            // 
            // lbDataEntrada
            // 
            this.lbDataEntrada.AutoSize = true;
            this.lbDataEntrada.Location = new System.Drawing.Point(126, 63);
            this.lbDataEntrada.Name = "lbDataEntrada";
            this.lbDataEntrada.Size = new System.Drawing.Size(75, 13);
            this.lbDataEntrada.TabIndex = 43;
            this.lbDataEntrada.Text = "lbDataEntrada";
            // 
            // lbFormaEntrada
            // 
            this.lbFormaEntrada.AutoSize = true;
            this.lbFormaEntrada.Location = new System.Drawing.Point(126, 43);
            this.lbFormaEntrada.Name = "lbFormaEntrada";
            this.lbFormaEntrada.Size = new System.Drawing.Size(81, 13);
            this.lbFormaEntrada.TabIndex = 42;
            this.lbFormaEntrada.Text = "lbFormaEntrada";
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Location = new System.Drawing.Point(126, 23);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Size = new System.Drawing.Size(98, 13);
            this.lbFormaPagamento.TabIndex = 41;
            this.lbFormaPagamento.Text = "lbFormaPagamento";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(9, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "Data da Entrada";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(9, 43);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "Forma da Entrada";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(9, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 13);
            this.label26.TabIndex = 38;
            this.label26.Text = "Forma de Pagamento";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbValorRestante);
            this.groupBox7.Controls.Add(this.lbValorEntrada);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.lbValorTotal);
            this.groupBox7.Controls.Add(this.lbPorcentagemDesconto);
            this.groupBox7.Controls.Add(this.lbValorDesconto);
            this.groupBox7.Controls.Add(this.lbPorcentagemJuros);
            this.groupBox7.Controls.Add(this.lbValorJuro);
            this.groupBox7.Controls.Add(this.lbValorProduto);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(373, 192);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Valores do Pedido";
            // 
            // lbValorRestante
            // 
            this.lbValorRestante.AutoSize = true;
            this.lbValorRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorRestante.Location = new System.Drawing.Point(128, 168);
            this.lbValorRestante.Name = "lbValorRestante";
            this.lbValorRestante.Size = new System.Drawing.Size(97, 13);
            this.lbValorRestante.TabIndex = 44;
            this.lbValorRestante.Text = "lbValorRestante";
            // 
            // lbValorEntrada
            // 
            this.lbValorEntrada.AutoSize = true;
            this.lbValorEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorEntrada.Location = new System.Drawing.Point(127, 148);
            this.lbValorEntrada.Name = "lbValorEntrada";
            this.lbValorEntrada.Size = new System.Drawing.Size(90, 13);
            this.lbValorEntrada.TabIndex = 43;
            this.lbValorEntrada.Text = "lbValorEntrada";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(11, 168);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(77, 13);
            this.label35.TabIndex = 42;
            this.label35.Text = "Valor Restante";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(11, 148);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(86, 13);
            this.label36.TabIndex = 41;
            this.label36.Text = "Valor da Entrada";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(128, 129);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(75, 13);
            this.lbValorTotal.TabIndex = 40;
            this.lbValorTotal.Text = "lbValorTotal";
            // 
            // lbPorcentagemDesconto
            // 
            this.lbPorcentagemDesconto.AutoSize = true;
            this.lbPorcentagemDesconto.Location = new System.Drawing.Point(128, 108);
            this.lbPorcentagemDesconto.Name = "lbPorcentagemDesconto";
            this.lbPorcentagemDesconto.Size = new System.Drawing.Size(124, 13);
            this.lbPorcentagemDesconto.TabIndex = 39;
            this.lbPorcentagemDesconto.Text = "lbPorcentagemDesconto";
            // 
            // lbValorDesconto
            // 
            this.lbValorDesconto.AutoSize = true;
            this.lbValorDesconto.Location = new System.Drawing.Point(128, 89);
            this.lbValorDesconto.Name = "lbValorDesconto";
            this.lbValorDesconto.Size = new System.Drawing.Size(85, 13);
            this.lbValorDesconto.TabIndex = 38;
            this.lbValorDesconto.Text = "lbValorDesconto";
            // 
            // lbPorcentagemJuros
            // 
            this.lbPorcentagemJuros.AutoSize = true;
            this.lbPorcentagemJuros.Location = new System.Drawing.Point(128, 69);
            this.lbPorcentagemJuros.Name = "lbPorcentagemJuros";
            this.lbPorcentagemJuros.Size = new System.Drawing.Size(103, 13);
            this.lbPorcentagemJuros.TabIndex = 37;
            this.lbPorcentagemJuros.Text = "lbPorcentagemJuros";
            // 
            // lbValorJuro
            // 
            this.lbValorJuro.AutoSize = true;
            this.lbValorJuro.Location = new System.Drawing.Point(128, 49);
            this.lbValorJuro.Name = "lbValorJuro";
            this.lbValorJuro.Size = new System.Drawing.Size(59, 13);
            this.lbValorJuro.TabIndex = 36;
            this.lbValorJuro.Text = "lbValorJuro";
            // 
            // lbValorProduto
            // 
            this.lbValorProduto.AutoSize = true;
            this.lbValorProduto.Location = new System.Drawing.Point(128, 29);
            this.lbValorProduto.Name = "lbValorProduto";
            this.lbValorProduto.Size = new System.Drawing.Size(76, 13);
            this.lbValorProduto.TabIndex = 35;
            this.lbValorProduto.Text = "lbValorProduto";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(11, 129);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 13);
            this.label27.TabIndex = 34;
            this.label27.Text = "Valor Total";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(11, 109);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 13);
            this.label28.TabIndex = 33;
            this.label28.Text = "% Desconto";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(11, 89);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(80, 13);
            this.label29.TabIndex = 32;
            this.label29.Text = "Valor Desconto";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(11, 69);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 13);
            this.label30.TabIndex = 31;
            this.label30.Text = "% Acrescimo";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(11, 49);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(98, 13);
            this.label31.TabIndex = 30;
            this.label31.Text = "Valor do Acrescimo";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(11, 29);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(107, 13);
            this.label32.TabIndex = 29;
            this.label32.Text = "Valores dos Produtos";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(905, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Informação sobre devoluções";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.datagridMotivos);
            this.groupBox9.Location = new System.Drawing.Point(3, 165);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(896, 231);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Motivos";
            // 
            // datagridMotivos
            // 
            this.datagridMotivos.AllowUserToAddRows = false;
            this.datagridMotivos.AllowUserToDeleteRows = false;
            this.datagridMotivos.AllowUserToResizeColumns = false;
            this.datagridMotivos.AllowUserToResizeRows = false;
            this.datagridMotivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridMotivos.BackgroundColor = System.Drawing.Color.White;
            this.datagridMotivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridMotivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMotivo,
            this.Qtdade,
            this.Motivo,
            this.Observacao});
            this.datagridMotivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridMotivos.Location = new System.Drawing.Point(3, 16);
            this.datagridMotivos.MultiSelect = false;
            this.datagridMotivos.Name = "datagridMotivos";
            this.datagridMotivos.ReadOnly = true;
            this.datagridMotivos.RowHeadersVisible = false;
            this.datagridMotivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridMotivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridMotivos.ShowCellErrors = false;
            this.datagridMotivos.ShowCellToolTips = false;
            this.datagridMotivos.ShowEditingIcon = false;
            this.datagridMotivos.ShowRowErrors = false;
            this.datagridMotivos.Size = new System.Drawing.Size(890, 212);
            this.datagridMotivos.TabIndex = 1;
            // 
            // IdMotivo
            // 
            this.IdMotivo.DataPropertyName = "IdMotivoDevolucao";
            this.IdMotivo.HeaderText = "Código Motivo";
            this.IdMotivo.Name = "IdMotivo";
            this.IdMotivo.ReadOnly = true;
            // 
            // Qtdade
            // 
            this.Qtdade.DataPropertyName = "Quantidade";
            this.Qtdade.HeaderText = "Quantidade";
            this.Qtdade.Name = "Qtdade";
            this.Qtdade.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // Observacao
            // 
            this.Observacao.DataPropertyName = "Observacao";
            this.Observacao.FillWeight = 300F;
            this.Observacao.HeaderText = "Observação";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridDevolucoes);
            this.groupBox5.Location = new System.Drawing.Point(3, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(896, 153);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Devoluções";
            // 
            // dataGridDevolucoes
            // 
            this.dataGridDevolucoes.AllowUserToAddRows = false;
            this.dataGridDevolucoes.AllowUserToDeleteRows = false;
            this.dataGridDevolucoes.AllowUserToResizeColumns = false;
            this.dataGridDevolucoes.AllowUserToResizeRows = false;
            this.dataGridDevolucoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDevolucoes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDevolucoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDevolucoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridDevolucoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMov,
            this.StatusDev,
            this.CodAtend,
            this.Data});
            this.dataGridDevolucoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDevolucoes.Location = new System.Drawing.Point(3, 16);
            this.dataGridDevolucoes.MultiSelect = false;
            this.dataGridDevolucoes.Name = "dataGridDevolucoes";
            this.dataGridDevolucoes.ReadOnly = true;
            this.dataGridDevolucoes.RowHeadersVisible = false;
            this.dataGridDevolucoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridDevolucoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDevolucoes.ShowCellErrors = false;
            this.dataGridDevolucoes.ShowCellToolTips = false;
            this.dataGridDevolucoes.ShowEditingIcon = false;
            this.dataGridDevolucoes.ShowRowErrors = false;
            this.dataGridDevolucoes.Size = new System.Drawing.Size(890, 134);
            this.dataGridDevolucoes.TabIndex = 1;
            this.dataGridDevolucoes.SelectionChanged += new System.EventHandler(this.dataGridDevolucoes_SelectionChanged);
            // 
            // IdMov
            // 
            this.IdMov.DataPropertyName = "IdMov";
            this.IdMov.HeaderText = "Código Mov.";
            this.IdMov.Name = "IdMov";
            this.IdMov.ReadOnly = true;
            // 
            // StatusDev
            // 
            this.StatusDev.DataPropertyName = "Status";
            this.StatusDev.HeaderText = "Status Devolução";
            this.StatusDev.Name = "StatusDev";
            this.StatusDev.ReadOnly = true;
            // 
            // CodAtend
            // 
            this.CodAtend.DataPropertyName = "Atendimento";
            this.CodAtend.HeaderText = "Cod. Atendimento";
            this.CodAtend.Name = "CodAtend";
            this.CodAtend.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data Devolução";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btLiberar);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Enabled = false;
            this.panelActions.Location = new System.Drawing.Point(0, 442);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(935, 51);
            this.panelActions.TabIndex = 1;
            // 
            // btLiberar
            // 
            this.btLiberar.Location = new System.Drawing.Point(12, 8);
            this.btLiberar.Name = "btLiberar";
            this.btLiberar.Size = new System.Drawing.Size(130, 35);
            this.btLiberar.TabIndex = 1;
            this.btLiberar.Text = "Finalizar Venda";
            this.btLiberar.UseVisualStyleBackColor = true;
            this.btLiberar.Click += new System.EventHandler(this.btLiberar_Click);
            // 
            // DetalhesLiberacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 493);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetalhesLiberacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalização da Venda";
            this.Load += new System.EventHandler(this.DetalhesLiberacao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEnvelope)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReferencia)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanc)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridMotivos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucoes)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        protected DataGridView dataGrid;
        protected DataGridView dataGridEnvelope;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox10;
        private Label lbVendedora;
        private Label lbDataVenda;
        private Label lbCodVenda;
        private Label lbCodAtendimento;
        private DataGridViewTextBoxColumn IdItem;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Serviço;
        private DataGridViewTextBoxColumn Album;
        private DataGridViewTextBoxColumn Moldura;
        private DataGridViewTextBoxColumn Fotos;
        private DataGridViewImageColumn Status;
        private BindingNavigator bindingNavigator2;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButton5;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label lbConjuje;
        private Label lbCPF;
        private Label lbRG;
        private Label lbDataNasc;
        private Label lbCelular;
        private Label lbTelefone;
        private Label lbEmail;
        private Label lbFiliacao;
        private Label lbEstado;
        private Label lbCep;
        private Label lbCidade;
        private Label lbBairro;
        private Label lbEndereco;
        private Label lbSexo;
        private Label lbClienteFinanceiro;
        private Label lbClienteComercial;
        protected DataGridView dataGridReferencia;
        private Label lbValorTotal;
        private Label lbPorcentagemDesconto;
        private Label lbValorDesconto;
        private Label lbPorcentagemJuros;
        private Label lbValorJuro;
        private Label lbValorProduto;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label lbValorRestante;
        private Label lbValorEntrada;
        private Label label35;
        private Label label36;
        private Label lbDataEntrada;
        private Label lbFormaEntrada;
        private Label lbFormaPagamento;
        private Label label24;
        private Label label25;
        private Label label26;
        protected DataGridView dataGridLanc;
        private DataGridViewImageColumn TipoLancamento;
        private DataGridViewTextBoxColumn ClienteLanc;
        private DataGridViewTextBoxColumn Filial;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ValorOriginal;
        private Button btLiberar;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Telefone;
        private CLabel lbStatusLabel;
        private BindingNavigator bindingNavigator1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private Panel panelActions;
        private TabPage tabPage4;
        private GroupBox groupBox5;
        private GroupBox groupBox9;
        protected DataGridView dataGridDevolucoes;
        protected DataGridView datagridMotivos;
        private DataGridViewTextBoxColumn IdMov;
        private DataGridViewTextBoxColumn StatusDev;
        private DataGridViewTextBoxColumn CodAtend;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn IdMotivo;
        private DataGridViewTextBoxColumn Qtdade;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn Observacao;
        private CLabel lbEmancipado;
    }
}