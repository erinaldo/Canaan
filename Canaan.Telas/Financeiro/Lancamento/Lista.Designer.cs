using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Lancamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.actionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdita = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBaixa = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnBaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelaBaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEstornar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuActions = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuRenegociacao = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRenegociacaoEfetua = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRenegociacaoCancela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRenegociacaoView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFaturas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFaturasEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFaturasPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFaturasRecibo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltro = new System.Windows.Forms.ToolStripButton();
            this.resumoStatusStrip = new System.Windows.Forms.StatusStrip();
            this.liquidoValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.liquidoDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lancamentosValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lancamentosDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.lancDataGridView = new System.Windows.Forms.DataGridView();
            this.CheckBoxLanc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewImageColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.StatusVenc = new System.Windows.Forms.DataGridViewImageColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Original = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baixado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.actionsToolStrip.SuspendLayout();
            this.resumoStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsToolStrip
            // 
            this.actionsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.actionsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator1,
            this.btnEdita,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator3,
            this.menuBaixa,
            this.toolStripSeparator5,
            this.menuActions,
            this.toolStripSeparator6,
            this.btnFiltro});
            this.actionsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.actionsToolStrip.Name = "actionsToolStrip";
            this.actionsToolStrip.Padding = new System.Windows.Forms.Padding(5);
            this.actionsToolStrip.Size = new System.Drawing.Size(972, 33);
            this.actionsToolStrip.TabIndex = 0;
            this.actionsToolStrip.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(125, 20);
            this.btnNovo.Text = "Novo Lançamento";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnEdita
            // 
            this.btnEdita.Image = global::Canaan.Telas.Properties.Resources.folder_Open_16xLG;
            this.btnEdita.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(120, 20);
            this.btnEdita.Text = "Edita Selecionado";
            this.btnEdita.Click += new System.EventHandler(this.btnEdita_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 20);
            this.btnDelete.Text = "Exclui Selecionados";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // menuBaixa
            // 
            this.menuBaixa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaixa,
            this.toolStripSeparator4,
            this.btnCancelaBaixa,
            this.toolStripMenuItem2,
            this.btnEstornar});
            this.menuBaixa.Image = global::Canaan.Telas.Properties.Resources.Money_16xLG;
            this.menuBaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuBaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuBaixa.Name = "menuBaixa";
            this.menuBaixa.Size = new System.Drawing.Size(153, 20);
            this.menuBaixa.Text = "Baixa de Lançamentos";
            // 
            // btnBaixa
            // 
            this.btnBaixa.Image = global::Canaan.Telas.Properties.Resources.StatusAnnotations_Play_16xLG_color;
            this.btnBaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBaixa.Name = "btnBaixa";
            this.btnBaixa.Size = new System.Drawing.Size(192, 22);
            this.btnBaixa.Text = "Baixar Selecionados";
            this.btnBaixa.Click += new System.EventHandler(this.btnBaixa_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(189, 6);
            // 
            // btnCancelaBaixa
            // 
            this.btnCancelaBaixa.Image = global::Canaan.Telas.Properties.Resources.StatusAnnotations_Critical_16xLG_color;
            this.btnCancelaBaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelaBaixa.Name = "btnCancelaBaixa";
            this.btnCancelaBaixa.Size = new System.Drawing.Size(192, 22);
            this.btnCancelaBaixa.Text = "Cancelar Selecionados";
            this.btnCancelaBaixa.Click += new System.EventHandler(this.btnCancelaBaixa_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 6);
            // 
            // btnEstornar
            // 
            this.btnEstornar.Image = global::Canaan.Telas.Properties.Resources.Arrow_UndoRevertRestore_16xLG;
            this.btnEstornar.Name = "btnEstornar";
            this.btnEstornar.Size = new System.Drawing.Size(192, 22);
            this.btnEstornar.Text = "Estornar Selecionados";
            this.btnEstornar.Click += new System.EventHandler(this.btnEstornar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // menuActions
            // 
            this.menuActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRenegociacao,
            this.toolStripSeparator7,
            this.menuFaturas});
            this.menuActions.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.menuActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuActions.Name = "menuActions";
            this.menuActions.Size = new System.Drawing.Size(106, 20);
            this.menuActions.Text = "Outras Ações";
            // 
            // menuRenegociacao
            // 
            this.menuRenegociacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRenegociacaoEfetua,
            this.toolStripMenuItem1,
            this.btnRenegociacaoCancela,
            this.toolStripSeparator8,
            this.btnRenegociacaoView});
            this.menuRenegociacao.Image = global::Canaan.Telas.Properties.Resources.enum_16xLG;
            this.menuRenegociacao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuRenegociacao.Name = "menuRenegociacao";
            this.menuRenegociacao.Size = new System.Drawing.Size(148, 22);
            this.menuRenegociacao.Text = "Renegociação";
            // 
            // btnRenegociacaoEfetua
            // 
            this.btnRenegociacaoEfetua.Image = global::Canaan.Telas.Properties.Resources.StatusAnnotations_Complete_and_ok_16xLG_color;
            this.btnRenegociacaoEfetua.Name = "btnRenegociacaoEfetua";
            this.btnRenegociacaoEfetua.Size = new System.Drawing.Size(200, 22);
            this.btnRenegociacaoEfetua.Text = "Efetuar Renegociação";
            this.btnRenegociacaoEfetua.Click += new System.EventHandler(this.btnRenegociacaoEfetua_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(197, 6);
            // 
            // btnRenegociacaoCancela
            // 
            this.btnRenegociacaoCancela.Image = global::Canaan.Telas.Properties.Resources.StatusAnnotations_Blocked_16xLG_color;
            this.btnRenegociacaoCancela.Name = "btnRenegociacaoCancela";
            this.btnRenegociacaoCancela.Size = new System.Drawing.Size(200, 22);
            this.btnRenegociacaoCancela.Text = "Cancelar Renegociação";
            this.btnRenegociacaoCancela.Click += new System.EventHandler(this.btnRenegociacaoCancela_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(197, 6);
            // 
            // btnRenegociacaoView
            // 
            this.btnRenegociacaoView.Image = global::Canaan.Telas.Properties.Resources.StatusAnnotations_Help_and_inconclusive_16xLG_color;
            this.btnRenegociacaoView.Name = "btnRenegociacaoView";
            this.btnRenegociacaoView.Size = new System.Drawing.Size(200, 22);
            this.btnRenegociacaoView.Text = "Visualizar Renegociação";
            this.btnRenegociacaoView.Click += new System.EventHandler(this.btnRenegociacaoView_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(145, 6);
            // 
            // menuFaturas
            // 
            this.menuFaturas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFaturasEmail,
            this.toolStripSeparator9,
            this.btnFaturasPrint,
            this.toolStripSeparator10,
            this.btnFaturasRecibo});
            this.menuFaturas.Image = global::Canaan.Telas.Properties.Resources.RSReport_16xLG;
            this.menuFaturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFaturas.Name = "menuFaturas";
            this.menuFaturas.Size = new System.Drawing.Size(148, 22);
            this.menuFaturas.Text = "Faturas";
            // 
            // btnFaturasEmail
            // 
            this.btnFaturasEmail.Image = global::Canaan.Telas.Properties.Resources.envelope_16xLG;
            this.btnFaturasEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFaturasEmail.Name = "btnFaturasEmail";
            this.btnFaturasEmail.Size = new System.Drawing.Size(200, 22);
            this.btnFaturasEmail.Text = "Enviar Faturas Por Email";
            this.btnFaturasEmail.Click += new System.EventHandler(this.btnFaturasEmail_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(197, 6);
            // 
            // btnFaturasPrint
            // 
            this.btnFaturasPrint.Image = global::Canaan.Telas.Properties.Resources.printer_16xLG;
            this.btnFaturasPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFaturasPrint.Name = "btnFaturasPrint";
            this.btnFaturasPrint.Size = new System.Drawing.Size(200, 22);
            this.btnFaturasPrint.Text = "Imprimir Faturas";
            this.btnFaturasPrint.Click += new System.EventHandler(this.btnFaturasPrint_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(197, 6);
            // 
            // btnFaturasRecibo
            // 
            this.btnFaturasRecibo.Image = global::Canaan.Telas.Properties.Resources.Money_16xLG;
            this.btnFaturasRecibo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFaturasRecibo.Name = "btnFaturasRecibo";
            this.btnFaturasRecibo.Size = new System.Drawing.Size(200, 22);
            this.btnFaturasRecibo.Text = "Imprimir Recibo";
            this.btnFaturasRecibo.Click += new System.EventHandler(this.btnFaturasRecibo_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.btnFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(131, 20);
            this.btnFiltro.Text = "Filtrar Lancamentos";
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // resumoStatusStrip
            // 
            this.resumoStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liquidoValue,
            this.liquidoDisplay,
            this.toolStripStatusLabel3,
            this.lancamentosValue,
            this.lancamentosDisplay});
            this.resumoStatusStrip.Location = new System.Drawing.Point(0, 457);
            this.resumoStatusStrip.Name = "resumoStatusStrip";
            this.resumoStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.resumoStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resumoStatusStrip.Size = new System.Drawing.Size(972, 27);
            this.resumoStatusStrip.SizingGrip = false;
            this.resumoStatusStrip.TabIndex = 1;
            this.resumoStatusStrip.Text = "statusStrip1";
            // 
            // liquidoValue
            // 
            this.liquidoValue.Name = "liquidoValue";
            this.liquidoValue.Padding = new System.Windows.Forms.Padding(3);
            this.liquidoValue.Size = new System.Drawing.Size(50, 22);
            this.liquidoValue.Text = "R$ 0,00";
            // 
            // liquidoDisplay
            // 
            this.liquidoDisplay.Image = global::Canaan.Telas.Properties.Resources.sigma_16xLG;
            this.liquidoDisplay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.liquidoDisplay.Name = "liquidoDisplay";
            this.liquidoDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.liquidoDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.liquidoDisplay.Size = new System.Drawing.Size(102, 22);
            this.liquidoDisplay.Text = "Total Líquido:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 22);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // lancamentosValue
            // 
            this.lancamentosValue.Name = "lancamentosValue";
            this.lancamentosValue.Padding = new System.Windows.Forms.Padding(3);
            this.lancamentosValue.Size = new System.Drawing.Size(50, 22);
            this.lancamentosValue.Text = "R$ 0,00";
            // 
            // lancamentosDisplay
            // 
            this.lancamentosDisplay.Image = global::Canaan.Telas.Properties.Resources.grid_Data_16xLG;
            this.lancamentosDisplay.Name = "lancamentosDisplay";
            this.lancamentosDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.lancamentosDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lancamentosDisplay.Size = new System.Drawing.Size(175, 22);
            this.lancamentosDisplay.Text = "Lançamentos Selecionados:";
            // 
            // lancDataGridView
            // 
            this.lancDataGridView.AllowUserToAddRows = false;
            this.lancDataGridView.AllowUserToDeleteRows = false;
            this.lancDataGridView.AllowUserToResizeColumns = false;
            this.lancDataGridView.AllowUserToResizeRows = false;
            this.lancDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.lancDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lancDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.lancDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lancDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxLanc,
            this.Tipo,
            this.Status,
            this.StatusVenc,
            this.Codigo,
            this.Filial,
            this.Nome,
            this.Emissao,
            this.Vencimento,
            this.Baixa,
            this.Original,
            this.Baixado,
            this.Entrada});
            this.lancDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lancDataGridView.Location = new System.Drawing.Point(0, 33);
            this.lancDataGridView.MultiSelect = false;
            this.lancDataGridView.Name = "lancDataGridView";
            this.lancDataGridView.RowHeadersVisible = false;
            this.lancDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lancDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lancDataGridView.ShowCellErrors = false;
            this.lancDataGridView.ShowCellToolTips = false;
            this.lancDataGridView.ShowEditingIcon = false;
            this.lancDataGridView.ShowRowErrors = false;
            this.lancDataGridView.Size = new System.Drawing.Size(972, 424);
            this.lancDataGridView.TabIndex = 2;
            this.lancDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lancDataGridView_CellContentClick);
            this.lancDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.lancDataGridView_CellValueChanged);
            this.lancDataGridView.DoubleClick += new System.EventHandler(this.lancDataGridView_DoubleClick);
            // 
            // CheckBoxLanc
            // 
            this.CheckBoxLanc.FalseValue = "False";
            this.CheckBoxLanc.HeaderText = "";
            this.CheckBoxLanc.IndeterminateValue = "False";
            this.CheckBoxLanc.Name = "CheckBoxLanc";
            this.CheckBoxLanc.TrueValue = "True";
            this.CheckBoxLanc.Width = 25;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tipo.Width = 25;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 25;
            // 
            // StatusVenc
            // 
            this.StatusVenc.DataPropertyName = "StatusVenc";
            this.StatusVenc.HeaderText = "";
            this.StatusVenc.Name = "StatusVenc";
            this.StatusVenc.ReadOnly = true;
            this.StatusVenc.Width = 25;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Codigo.Width = 80;
            // 
            // Filial
            // 
            this.Filial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Filial.DataPropertyName = "Filial";
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            this.Filial.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Cliente / Fornecedor";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Emissao
            // 
            this.Emissao.DataPropertyName = "Emissao";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Emissao.DefaultCellStyle = dataGridViewCellStyle1;
            this.Emissao.HeaderText = "Emissão";
            this.Emissao.Name = "Emissao";
            this.Emissao.ReadOnly = true;
            this.Emissao.Width = 75;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "Vencimento";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Vencimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            this.Vencimento.Width = 75;
            // 
            // Baixa
            // 
            this.Baixa.DataPropertyName = "Baixa";
            dataGridViewCellStyle3.Format = "d";
            this.Baixa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Baixa.HeaderText = "Baixa";
            this.Baixa.Name = "Baixa";
            this.Baixa.ReadOnly = true;
            this.Baixa.Width = 75;
            // 
            // Original
            // 
            this.Original.DataPropertyName = "Original";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Original.DefaultCellStyle = dataGridViewCellStyle4;
            this.Original.HeaderText = "Valor Original";
            this.Original.Name = "Original";
            this.Original.ReadOnly = true;
            // 
            // Baixado
            // 
            this.Baixado.DataPropertyName = "Baixado";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Baixado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Baixado.HeaderText = "Valor Baixado";
            this.Baixado.Name = "Baixado";
            this.Baixado.ReadOnly = true;
            // 
            // Entrada
            // 
            this.Entrada.DataPropertyName = "Entrada";
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            this.Entrada.Width = 50;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 484);
            this.Controls.Add(this.lancDataGridView);
            this.Controls.Add(this.resumoStatusStrip);
            this.Controls.Add(this.actionsToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.actionsToolStrip.ResumeLayout(false);
            this.actionsToolStrip.PerformLayout();
            this.resumoStatusStrip.ResumeLayout(false);
            this.resumoStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip actionsToolStrip;
        private ToolStripButton btnNovo;
        private StatusStrip resumoStatusStrip;
        private DataGridView lancDataGridView;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnEdita;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton menuBaixa;
        private ToolStripMenuItem btnBaixa;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem btnCancelaBaixa;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripDropDownButton menuActions;
        private ToolStripMenuItem menuRenegociacao;
        private ToolStripMenuItem btnRenegociacaoEfetua;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem menuFaturas;
        private ToolStripMenuItem btnFaturasEmail;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem btnRenegociacaoCancela;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem btnRenegociacaoView;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem btnFaturasPrint;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem btnFaturasRecibo;
        private ToolStripStatusLabel liquidoValue;
        private ToolStripStatusLabel liquidoDisplay;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel lancamentosValue;
        private ToolStripStatusLabel lancamentosDisplay;
        private DataGridViewCheckBoxColumn CheckBoxLanc;
        private DataGridViewImageColumn Tipo;
        private DataGridViewImageColumn Status;
        private DataGridViewImageColumn StatusVenc;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Filial;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Emissao;
        private DataGridViewTextBoxColumn Vencimento;
        private DataGridViewTextBoxColumn Baixa;
        private DataGridViewTextBoxColumn Original;
        private DataGridViewTextBoxColumn Baixado;
        private DataGridViewCheckBoxColumn Entrada;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem btnEstornar;
        private ToolStripButton btnFiltro;
    }
}