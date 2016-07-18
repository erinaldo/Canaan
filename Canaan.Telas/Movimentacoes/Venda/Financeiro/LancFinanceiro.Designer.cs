using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Movimentacoes.Venda.Financeiro
{
    partial class LancFinanceiro
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.gbFinanciamento = new System.Windows.Forms.GroupBox();
            this.cLabel3 = new Canaan.Lib.Componentes.CLabel();
            this.dtInicioEntrada = new DevExpress.XtraEditors.DateEdit();
            this.txtValAcrescimo = new System.Windows.Forms.TextBox();
            this.cLabel12 = new Canaan.Lib.Componentes.CLabel();
            this.txtPorcAcrescimo = new System.Windows.Forms.TextBox();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.cLabel11 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel10 = new Canaan.Lib.Componentes.CLabel();
            this.txtPorcDesconto = new System.Windows.Forms.TextBox();
            this.cLabel9 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel8 = new Canaan.Lib.Componentes.CLabel();
            this.txtValorLiquido = new System.Windows.Forms.TextBox();
            this.btParcelas = new System.Windows.Forms.Button();
            this.txtValorRestante = new System.Windows.Forms.TextBox();
            this.cLabel7 = new Canaan.Lib.Componentes.CLabel();
            this.txtValorBruto = new System.Windows.Forms.TextBox();
            this.cLabel4 = new Canaan.Lib.Componentes.CLabel();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.cLabel6 = new Canaan.Lib.Componentes.CLabel();
            this.txtPorcEntrada = new System.Windows.Forms.TextBox();
            this.cLabel5 = new Canaan.Lib.Componentes.CLabel();
            this.cbFormaEntrada = new System.Windows.Forms.ComboBox();
            this.cLabel2 = new Canaan.Lib.Componentes.CLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.TipoLancamento = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClasseContabil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActions = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltros = new System.Windows.Forms.ToolStripSplitButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorCrediario = new System.Windows.Forms.TextBox();
            this.cLabel14 = new Canaan.Lib.Componentes.CLabel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.gbFinanciamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioEntrada.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioEntrada.Properties)).BeginInit();
            this.gbEntrada.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.toolstripActions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolstripActions);
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(964, 577);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Size = new System.Drawing.Size(956, 551);
            this.tabPage1.Text = "Dados Financeiros da Venda";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.bindingNavigator1);
            this.panel2.Controls.Add(this.gbFinanciamento);
            this.panel2.Controls.Add(this.gbEntrada);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 545);
            this.panel2.TabIndex = 0;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 520);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(950, 25);
            this.bindingNavigator1.TabIndex = 4;
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
            // gbFinanciamento
            // 
            this.gbFinanciamento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbFinanciamento.Controls.Add(this.cLabel3);
            this.gbFinanciamento.Controls.Add(this.dtInicioEntrada);
            this.gbFinanciamento.Controls.Add(this.txtValAcrescimo);
            this.gbFinanciamento.Controls.Add(this.cLabel12);
            this.gbFinanciamento.Controls.Add(this.txtPorcAcrescimo);
            this.gbFinanciamento.Controls.Add(this.txtValorDesconto);
            this.gbFinanciamento.Controls.Add(this.cLabel11);
            this.gbFinanciamento.Controls.Add(this.cLabel10);
            this.gbFinanciamento.Controls.Add(this.txtPorcDesconto);
            this.gbFinanciamento.Controls.Add(this.cLabel9);
            this.gbFinanciamento.Controls.Add(this.cLabel8);
            this.gbFinanciamento.Controls.Add(this.txtValorLiquido);
            this.gbFinanciamento.Controls.Add(this.btParcelas);
            this.gbFinanciamento.Controls.Add(this.txtValorRestante);
            this.gbFinanciamento.Controls.Add(this.cLabel7);
            this.gbFinanciamento.Controls.Add(this.txtValorBruto);
            this.gbFinanciamento.Controls.Add(this.cLabel4);
            this.gbFinanciamento.Controls.Add(this.cbFormaPagamento);
            this.gbFinanciamento.Controls.Add(this.cLabel1);
            this.gbFinanciamento.Location = new System.Drawing.Point(8, 15);
            this.gbFinanciamento.Name = "gbFinanciamento";
            this.gbFinanciamento.Padding = new System.Windows.Forms.Padding(5);
            this.gbFinanciamento.Size = new System.Drawing.Size(460, 250);
            this.gbFinanciamento.TabIndex = 21;
            this.gbFinanciamento.TabStop = false;
            this.gbFinanciamento.Text = "Dados do Financiamento";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.Location = new System.Drawing.Point(25, 51);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel3.Size = new System.Drawing.Size(70, 23);
            this.cLabel3.TabIndex = 14;
            this.cLabel3.Text = "Data Inicial";
            // 
            // dtInicioEntrada
            // 
            this.dtInicioEntrada.EditValue = null;
            this.dtInicioEntrada.Location = new System.Drawing.Point(142, 53);
            this.dtInicioEntrada.Name = "dtInicioEntrada";
            this.dtInicioEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicioEntrada.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInicioEntrada.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dtInicioEntrada.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dtInicioEntrada.Size = new System.Drawing.Size(166, 20);
            this.dtInicioEntrada.TabIndex = 15;
            // 
            // txtValAcrescimo
            // 
            this.txtValAcrescimo.Location = new System.Drawing.Point(221, 108);
            this.txtValAcrescimo.Name = "txtValAcrescimo";
            this.txtValAcrescimo.Size = new System.Drawing.Size(86, 20);
            this.txtValAcrescimo.TabIndex = 28;
            this.txtValAcrescimo.Leave += new System.EventHandler(this.txtValAcrescimo_Leave);
            // 
            // cLabel12
            // 
            this.cLabel12.AutoSize = true;
            this.cLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel12.Location = new System.Drawing.Point(189, 107);
            this.cLabel12.Name = "cLabel12";
            this.cLabel12.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel12.Size = new System.Drawing.Size(26, 23);
            this.cLabel12.TabIndex = 27;
            this.cLabel12.Text = "%";
            // 
            // txtPorcAcrescimo
            // 
            this.txtPorcAcrescimo.Location = new System.Drawing.Point(141, 110);
            this.txtPorcAcrescimo.Name = "txtPorcAcrescimo";
            this.txtPorcAcrescimo.Size = new System.Drawing.Size(48, 20);
            this.txtPorcAcrescimo.TabIndex = 26;
            this.txtPorcAcrescimo.Leave += new System.EventHandler(this.txtPorcAcrescimo_Leave);
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(221, 83);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(86, 20);
            this.txtValorDesconto.TabIndex = 22;
            this.txtValorDesconto.Leave += new System.EventHandler(this.txtValorDesconto_Leave);
            // 
            // cLabel11
            // 
            this.cLabel11.AutoSize = true;
            this.cLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel11.Location = new System.Drawing.Point(189, 82);
            this.cLabel11.Name = "cLabel11";
            this.cLabel11.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel11.Size = new System.Drawing.Size(26, 23);
            this.cLabel11.TabIndex = 21;
            this.cLabel11.Text = "%";
            // 
            // cLabel10
            // 
            this.cLabel10.AutoSize = true;
            this.cLabel10.Location = new System.Drawing.Point(25, 110);
            this.cLabel10.Name = "cLabel10";
            this.cLabel10.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel10.Size = new System.Drawing.Size(66, 23);
            this.cLabel10.TabIndex = 25;
            this.cLabel10.Text = "Acrescimo";
            // 
            // txtPorcDesconto
            // 
            this.txtPorcDesconto.Location = new System.Drawing.Point(141, 85);
            this.txtPorcDesconto.Name = "txtPorcDesconto";
            this.txtPorcDesconto.Size = new System.Drawing.Size(48, 20);
            this.txtPorcDesconto.TabIndex = 20;
            this.txtPorcDesconto.Leave += new System.EventHandler(this.txtPorcDesconto_Leave);
            // 
            // cLabel9
            // 
            this.cLabel9.AutoSize = true;
            this.cLabel9.Location = new System.Drawing.Point(25, 82);
            this.cLabel9.Name = "cLabel9";
            this.cLabel9.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel9.Size = new System.Drawing.Size(63, 23);
            this.cLabel9.TabIndex = 24;
            this.cLabel9.Text = "Desconto";
            // 
            // cLabel8
            // 
            this.cLabel8.AutoSize = true;
            this.cLabel8.Location = new System.Drawing.Point(25, 190);
            this.cLabel8.Name = "cLabel8";
            this.cLabel8.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel8.Size = new System.Drawing.Size(78, 23);
            this.cLabel8.TabIndex = 23;
            this.cLabel8.Text = "Valor Liquido";
            // 
            // txtValorLiquido
            // 
            this.txtValorLiquido.Enabled = false;
            this.txtValorLiquido.Location = new System.Drawing.Point(141, 191);
            this.txtValorLiquido.Name = "txtValorLiquido";
            this.txtValorLiquido.Size = new System.Drawing.Size(166, 20);
            this.txtValorLiquido.TabIndex = 22;
            // 
            // btParcelas
            // 
            this.btParcelas.Location = new System.Drawing.Point(330, 220);
            this.btParcelas.Name = "btParcelas";
            this.btParcelas.Size = new System.Drawing.Size(109, 23);
            this.btParcelas.TabIndex = 21;
            this.btParcelas.Text = "Gerar Parcelas";
            this.btParcelas.UseVisualStyleBackColor = true;
            this.btParcelas.Click += new System.EventHandler(this.btParcelas_Click);
            // 
            // txtValorRestante
            // 
            this.txtValorRestante.Enabled = false;
            this.txtValorRestante.Location = new System.Drawing.Point(141, 221);
            this.txtValorRestante.Name = "txtValorRestante";
            this.txtValorRestante.Size = new System.Drawing.Size(166, 20);
            this.txtValorRestante.TabIndex = 20;
            // 
            // cLabel7
            // 
            this.cLabel7.AutoSize = true;
            this.cLabel7.Location = new System.Drawing.Point(25, 218);
            this.cLabel7.Name = "cLabel7";
            this.cLabel7.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel7.Size = new System.Drawing.Size(87, 23);
            this.cLabel7.TabIndex = 19;
            this.cLabel7.Text = "Valor Restante";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.Enabled = false;
            this.txtValorBruto.Location = new System.Drawing.Point(141, 161);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.Size = new System.Drawing.Size(166, 20);
            this.txtValorBruto.TabIndex = 18;
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.Location = new System.Drawing.Point(25, 161);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel4.Size = new System.Drawing.Size(69, 23);
            this.cLabel4.TabIndex = 17;
            this.cLabel4.Text = "Valor Bruto";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(141, 23);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(298, 21);
            this.cbFormaPagamento.TabIndex = 16;
            this.cbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbFormaPagamento_SelectedIndexChanged);
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(25, 23);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(118, 23);
            this.cLabel1.TabIndex = 15;
            this.cLabel1.Text = "Forma de Pagamento";
            // 
            // gbEntrada
            // 
            this.gbEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEntrada.Controls.Add(this.txtValorEntrada);
            this.gbEntrada.Controls.Add(this.cLabel6);
            this.gbEntrada.Controls.Add(this.txtPorcEntrada);
            this.gbEntrada.Controls.Add(this.cLabel5);
            this.gbEntrada.Controls.Add(this.cbFormaEntrada);
            this.gbEntrada.Controls.Add(this.cLabel2);
            this.gbEntrada.Location = new System.Drawing.Point(482, 15);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Padding = new System.Windows.Forms.Padding(5);
            this.gbEntrada.Size = new System.Drawing.Size(460, 133);
            this.gbEntrada.TabIndex = 20;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Dados da Entrada";
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Location = new System.Drawing.Point(210, 63);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(86, 20);
            this.txtValorEntrada.TabIndex = 19;
            this.txtValorEntrada.Leave += new System.EventHandler(this.txtValorEntrada_Leave);
            // 
            // cLabel6
            // 
            this.cLabel6.AutoSize = true;
            this.cLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel6.Location = new System.Drawing.Point(178, 63);
            this.cLabel6.Name = "cLabel6";
            this.cLabel6.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel6.Size = new System.Drawing.Size(26, 23);
            this.cLabel6.TabIndex = 18;
            this.cLabel6.Text = "%";
            // 
            // txtPorcEntrada
            // 
            this.txtPorcEntrada.Location = new System.Drawing.Point(130, 65);
            this.txtPorcEntrada.Name = "txtPorcEntrada";
            this.txtPorcEntrada.Size = new System.Drawing.Size(48, 20);
            this.txtPorcEntrada.TabIndex = 17;
            this.txtPorcEntrada.Leave += new System.EventHandler(this.txtPorcEntrada_Leave);
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.Location = new System.Drawing.Point(11, 63);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel5.Size = new System.Drawing.Size(95, 23);
            this.cLabel5.TabIndex = 16;
            this.cLabel5.Text = "Valor da entrada";
            // 
            // cbFormaEntrada
            // 
            this.cbFormaEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaEntrada.FormattingEnabled = true;
            this.cbFormaEntrada.Location = new System.Drawing.Point(130, 30);
            this.cbFormaEntrada.Name = "cbFormaEntrada";
            this.cbFormaEntrada.Size = new System.Drawing.Size(298, 21);
            this.cbFormaEntrada.TabIndex = 13;
            this.cbFormaEntrada.SelectedIndexChanged += new System.EventHandler(this.cbFormaEntrada_SelectedIndexChanged);
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.Location = new System.Drawing.Point(11, 28);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel2.Size = new System.Drawing.Size(101, 23);
            this.cLabel2.TabIndex = 12;
            this.cLabel2.Text = "Forma de Entrada";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.datagrid);
            this.groupBox2.Location = new System.Drawing.Point(8, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(944, 244);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parcelas";
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AllowUserToResizeColumns = false;
            this.datagrid.AllowUserToResizeRows = false;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = System.Drawing.Color.White;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoLancamento,
            this.Cliente,
            this.Filial,
            this.Tipo,
            this.ClasseContabil,
            this.DataEmissao,
            this.DataVencimento,
            this.ValorOriginal});
            this.datagrid.Location = new System.Drawing.Point(5, 12);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.ShowCellErrors = false;
            this.datagrid.ShowCellToolTips = false;
            this.datagrid.ShowEditingIcon = false;
            this.datagrid.ShowRowErrors = false;
            this.datagrid.Size = new System.Drawing.Size(934, 221);
            this.datagrid.TabIndex = 4;
            // 
            // TipoLancamento
            // 
            this.TipoLancamento.DataPropertyName = "TipoParcela";
            this.TipoLancamento.FillWeight = 30F;
            this.TipoLancamento.HeaderText = "";
            this.TipoLancamento.MinimumWidth = 30;
            this.TipoLancamento.Name = "TipoLancamento";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.FillWeight = 96.8818F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Filial
            // 
            this.Filial.DataPropertyName = "Filial";
            this.Filial.FillWeight = 96.8818F;
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.FillWeight = 96.8818F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // ClasseContabil
            // 
            this.ClasseContabil.DataPropertyName = "ClasseContabil";
            this.ClasseContabil.FillWeight = 96.8818F;
            this.ClasseContabil.HeaderText = "Classe Contabil";
            this.ClasseContabil.Name = "ClasseContabil";
            // 
            // DataEmissao
            // 
            this.DataEmissao.DataPropertyName = "DataEmissao";
            this.DataEmissao.FillWeight = 96.8818F;
            this.DataEmissao.HeaderText = "Data Emissão";
            this.DataEmissao.Name = "DataEmissao";
            // 
            // DataVencimento
            // 
            this.DataVencimento.DataPropertyName = "DataVencimento";
            this.DataVencimento.FillWeight = 96.8818F;
            this.DataVencimento.HeaderText = "Data de Vencimento";
            this.DataVencimento.Name = "DataVencimento";
            // 
            // ValorOriginal
            // 
            this.ValorOriginal.DataPropertyName = "ValorOriginal";
            this.ValorOriginal.FillWeight = 96.8818F;
            this.ValorOriginal.HeaderText = "Valor Original";
            this.ValorOriginal.Name = "ValorOriginal";
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripSeparator8,
            this.btnActions,
            this.toolStripSeparator4,
            this.btnFiltros});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(990, 33);
            this.toolstripActions.TabIndex = 2;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(93, 20);
            this.toolStripButton6.Text = "Salvar Venda";
            this.toolStripButton6.Click += new System.EventHandler(this.btSalvarFinanceiro_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // btnActions
            // 
            this.btnActions.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.btnActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(109, 20);
            this.btnActions.Text = "Outras Ações";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnFiltros
            // 
            this.btnFiltros.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.btnFiltros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(71, 20);
            this.btnFiltros.Text = "Filtros";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtValorCrediario);
            this.groupBox1.Controls.Add(this.cLabel14);
            this.groupBox1.Location = new System.Drawing.Point(482, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(460, 111);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Aprovação de Crédito";
            // 
            // txtValorCrediario
            // 
            this.txtValorCrediario.Location = new System.Drawing.Point(130, 22);
            this.txtValorCrediario.Name = "txtValorCrediario";
            this.txtValorCrediario.Size = new System.Drawing.Size(166, 20);
            this.txtValorCrediario.TabIndex = 19;
            this.txtValorCrediario.Leave += new System.EventHandler(this.txtValorCrediario_Leave);
            // 
            // cLabel14
            // 
            this.cLabel14.AutoSize = true;
            this.cLabel14.Location = new System.Drawing.Point(11, 22);
            this.cLabel14.Name = "cLabel14";
            this.cLabel14.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel14.Size = new System.Drawing.Size(90, 23);
            this.cLabel14.TabIndex = 16;
            this.cLabel14.Text = "Valor Aprovado";
            // 
            // LancFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 644);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LancFinanceiro";
            this.Text = "LancFinanceiro";
            this.Load += new System.EventHandler(this.LancFinanceiro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.gbFinanciamento.ResumeLayout(false);
            this.gbFinanciamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioEntrada.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInicioEntrada.Properties)).EndInit();
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel panel2;
        private TextBox txtValAcrescimo;
        private CLabel cLabel12;
        private TextBox txtPorcAcrescimo;
        private TextBox txtValorDesconto;
        private CLabel cLabel11;
        private CLabel cLabel10;
        private TextBox txtPorcDesconto;
        private CLabel cLabel9;
        private CLabel cLabel8;
        private TextBox txtValorLiquido;
        private Button btParcelas;
        private TextBox txtValorRestante;
        private CLabel cLabel7;
        private TextBox txtValorBruto;
        private CLabel cLabel4;
        private ComboBox cbFormaPagamento;
        private CLabel cLabel1;
        private TextBox txtValorEntrada;
        private CLabel cLabel6;
        private TextBox txtPorcEntrada;
        private CLabel cLabel5;
        private DateEdit dtInicioEntrada;
        private CLabel cLabel3;
        private ComboBox cbFormaEntrada;
        private CLabel cLabel2;
        private GroupBox groupBox2;
        private GroupBox gbEntrada;
        public GroupBox gbFinanciamento;
        protected ToolStrip toolstripActions;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator8;
        protected ToolStripSplitButton btnActions;
        private ToolStripSeparator toolStripSeparator4;
        protected ToolStripSplitButton btnFiltros;
        protected DataGridView datagrid;
        private DataGridViewImageColumn TipoLancamento;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Filial;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn ClasseContabil;
        private DataGridViewTextBoxColumn DataEmissao;
        private DataGridViewTextBoxColumn DataVencimento;
        private DataGridViewTextBoxColumn ValorOriginal;
        private BindingNavigator bindingNavigator1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private GroupBox groupBox1;
        private TextBox txtValorCrediario;
        private CLabel cLabel14;



    }
}