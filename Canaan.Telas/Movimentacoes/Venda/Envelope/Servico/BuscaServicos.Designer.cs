using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope.Servico
{
    partial class BuscaServicos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btFiltro = new System.Windows.Forms.Button();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.IdServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Previsao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Moldura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Voltagem = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Brinde = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btFiltro);
            this.groupBox1.Controls.Add(this.cLabel1);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 61);
            this.groupBox1.TabIndex = 3;
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
            this.cLabel1.Size = new System.Drawing.Size(84, 23);
            this.cLabel1.TabIndex = 1;
            this.cLabel1.Text = "Nome Servico";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(113, 23);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(288, 20);
            this.txtFiltro.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 286);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 260);
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
            this.IdServico,
            this.Nome,
            this.Previsao,
            this.Album,
            this.Moldura,
            this.Voltagem,
            this.Brinde,
            this.Ativo});
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
            this.dataGrid.Size = new System.Drawing.Size(806, 254);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            this.dataGrid.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            // 
            // IdServico
            // 
            this.IdServico.DataPropertyName = "IdServico";
            this.IdServico.FillWeight = 20.30457F;
            this.IdServico.HeaderText = "Código";
            this.IdServico.Name = "IdServico";
            this.IdServico.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 150F;
            this.Nome.HeaderText = "Serviço";
            this.Nome.MinimumWidth = 100;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Previsao
            // 
            this.Previsao.DataPropertyName = "Previsao";
            this.Previsao.FillWeight = 20.30457F;
            this.Previsao.HeaderText = "Previsão";
            this.Previsao.Name = "Previsao";
            this.Previsao.ReadOnly = true;
            // 
            // Album
            // 
            this.Album.DataPropertyName = "Album";
            this.Album.FillWeight = 20.30457F;
            this.Album.HeaderText = "Álbum";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Album.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Moldura
            // 
            this.Moldura.DataPropertyName = "Moldura";
            this.Moldura.FillWeight = 20.30457F;
            this.Moldura.HeaderText = "Moldura";
            this.Moldura.Name = "Moldura";
            this.Moldura.ReadOnly = true;
            this.Moldura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Moldura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Voltagem
            // 
            this.Voltagem.DataPropertyName = "Voltagem";
            this.Voltagem.FillWeight = 20.30457F;
            this.Voltagem.HeaderText = "Voltagem";
            this.Voltagem.Name = "Voltagem";
            this.Voltagem.ReadOnly = true;
            this.Voltagem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Voltagem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Brinde
            // 
            this.Brinde.DataPropertyName = "Brinde";
            this.Brinde.FillWeight = 20.30457F;
            this.Brinde.HeaderText = "Brinde";
            this.Brinde.Name = "Brinde";
            this.Brinde.ReadOnly = true;
            this.Brinde.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Brinde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Ativo
            // 
            this.Ativo.DataPropertyName = "Ativo";
            this.Ativo.FillWeight = 20.30457F;
            this.Ativo.HeaderText = "Ativo";
            this.Ativo.Name = "Ativo";
            this.Ativo.ReadOnly = true;
            this.Ativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BuscaServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscaServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicos";
            this.Load += new System.EventHandler(this.BuscaColecao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btFiltro;
        private CLabel cLabel1;
        private TextBox txtFiltro;
        private TabControl tabControl1;
        private TabPage tabPage1;
        protected DataGridView dataGrid;
        private DataGridViewTextBoxColumn IdServico;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Previsao;
        private DataGridViewCheckBoxColumn Album;
        private DataGridViewCheckBoxColumn Moldura;
        private DataGridViewCheckBoxColumn Voltagem;
        private DataGridViewCheckBoxColumn Brinde;
        private DataGridViewCheckBoxColumn Ativo;
    }
}