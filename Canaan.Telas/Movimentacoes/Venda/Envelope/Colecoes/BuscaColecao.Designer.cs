using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope.Colecoes
{
    partial class BuscaColecao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btFiltro = new System.Windows.Forms.Button();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cLabel5 = new Canaan.Lib.Componentes.CLabel();
            this.txtValManual = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cLabel4 = new Canaan.Lib.Componentes.CLabel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cLabel3 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel2 = new Canaan.Lib.Componentes.CLabel();
            this.txtUnitario = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 195);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resultado da Busca";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.Codigo,
            this.Nome,
            this.Tabela,
            this.Valor,
            this.Status});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
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
            this.dataGrid.Size = new System.Drawing.Size(767, 163);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            this.dataGrid.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.FillWeight = 23.47714F;
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Tabela
            // 
            this.Tabela.DataPropertyName = "Tabela";
            this.Tabela.FillWeight = 23.47714F;
            this.Tabela.HeaderText = "Tabela";
            this.Tabela.Name = "Tabela";
            this.Tabela.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.FillWeight = 23.47714F;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 23.47714F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btFiltro);
            this.groupBox1.Controls.Add(this.cLabel1);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 61);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btFiltro
            // 
            this.btFiltro.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.btFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFiltro.Location = new System.Drawing.Point(407, 21);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(66, 25);
            this.btFiltro.TabIndex = 2;
            this.btFiltro.Text = "Buscar";
            this.btFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(20, 23);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(87, 23);
            this.cLabel1.TabIndex = 1;
            this.cLabel1.Text = "Nome Coleção";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(113, 23);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(288, 20);
            this.txtFiltro.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cLabel5);
            this.groupBox2.Controls.Add(this.txtValManual);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.cLabel4);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.cLabel3);
            this.groupBox2.Controls.Add(this.cLabel2);
            this.groupBox2.Controls.Add(this.txtUnitario);
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Produto";
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.Location = new System.Drawing.Point(6, 74);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel5.Size = new System.Drawing.Size(79, 23);
            this.cLabel5.TabIndex = 8;
            this.cLabel5.Text = "Valor Manual";
            // 
            // txtValManual
            // 
            this.txtValManual.Location = new System.Drawing.Point(108, 75);
            this.txtValManual.Name = "txtValManual";
            this.txtValManual.Size = new System.Drawing.Size(100, 20);
            this.txtValManual.TabIndex = 7;
            this.txtValManual.Leave += new System.EventHandler(this.txtValManual_Leave);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(108, 49);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.Location = new System.Drawing.Point(6, 46);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel4.Size = new System.Drawing.Size(72, 23);
            this.cLabel4.TabIndex = 4;
            this.cLabel4.Text = "Quantidade";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(661, 78);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.Location = new System.Drawing.Point(559, 75);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel3.Size = new System.Drawing.Size(68, 23);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "Valor Total";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.Location = new System.Drawing.Point(559, 46);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel2.Size = new System.Drawing.Size(96, 23);
            this.cLabel2.TabIndex = 1;
            this.cLabel2.Text = "Valor do Produto";
            // 
            // txtUnitario
            // 
            this.txtUnitario.Enabled = false;
            this.txtUnitario.Location = new System.Drawing.Point(661, 49);
            this.txtUnitario.Name = "txtUnitario";
            this.txtUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtUnitario.TabIndex = 0;
            // 
            // BuscaColecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscaColecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Coleções";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscaColecao_FormClosed);
            this.Load += new System.EventHandler(this.BuscaColecao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TextBox txtFiltro;
        private CLabel cLabel1;
        private Button btFiltro;
        protected DataGridView dataGrid;
        private GroupBox groupBox2;
        private CLabel cLabel2;
        private TextBox txtUnitario;
        private CLabel cLabel4;
        private TextBox txtTotal;
        private CLabel cLabel3;
        private NumericUpDown txtQuantidade;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Tabela;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewCheckBoxColumn Status;
        private TextBox txtValManual;
        private CLabel cLabel5;
    }
}