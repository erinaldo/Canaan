using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Sessao
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
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.btnInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActions = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltros = new System.Windows.Forms.ToolStripSplitButton();
            this.gridAtendimento = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtendimentoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridModelos = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridSessoes = new System.Windows.Forms.DataGridView();
            this.toolstripActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendimento)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSessoes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.toolStripSeparator1,
            this.btnEdit,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnActions,
            this.toolStripSeparator4,
            this.btnFiltros});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(838, 33);
            this.toolstripActions.TabIndex = 1;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(93, 20);
            this.btnInsert.Text = "Nova Sessão";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Canaan.Telas.Properties.Resources.folder_Open_16xLG;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 20);
            this.btnEdit.Text = "Editar Sessão";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Size = new System.Drawing.Size(99, 20);
            this.btnDelete.Text = "Excluir Sessão";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
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
            // gridAtendimento
            // 
            this.gridAtendimento.AllowUserToAddRows = false;
            this.gridAtendimento.AllowUserToDeleteRows = false;
            this.gridAtendimento.AllowUserToResizeColumns = false;
            this.gridAtendimento.AllowUserToResizeRows = false;
            this.gridAtendimento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAtendimento.BackgroundColor = System.Drawing.Color.White;
            this.gridAtendimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAtendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.AtendimentoGrid,
            this.Nome,
            this.Documento});
            this.gridAtendimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridAtendimento.Location = new System.Drawing.Point(0, 33);
            this.gridAtendimento.MultiSelect = false;
            this.gridAtendimento.Name = "gridAtendimento";
            this.gridAtendimento.ReadOnly = true;
            this.gridAtendimento.RowHeadersVisible = false;
            this.gridAtendimento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAtendimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtendimento.ShowCellErrors = false;
            this.gridAtendimento.ShowCellToolTips = false;
            this.gridAtendimento.ShowEditingIcon = false;
            this.gridAtendimento.ShowRowErrors = false;
            this.gridAtendimento.Size = new System.Drawing.Size(838, 184);
            this.gridAtendimento.TabIndex = 2;
            this.gridAtendimento.SelectionChanged += new System.EventHandler(this.gridClientes_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.FillWeight = 20F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 120;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            this.Codigo.Width = 120;
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
            this.Nome.FillWeight = 335.0254F;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 150;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Data";
            this.Documento.FillWeight = 40F;
            this.Documento.HeaderText = "Data";
            this.Documento.MinimumWidth = 100;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridModelos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modelos do Cliente";
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
            this.gridModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Idade});
            this.gridModelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridModelos.Location = new System.Drawing.Point(3, 17);
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
            this.gridModelos.Size = new System.Drawing.Size(316, 184);
            this.gridModelos.TabIndex = 4;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.FillWeight = 169.5432F;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.FillWeight = 30.45685F;
            this.Idade.HeaderText = "Idade";
            this.Idade.MinimumWidth = 30;
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridSessoes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(328, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 206);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sessões do Cliente";
            // 
            // gridSessoes
            // 
            this.gridSessoes.AllowUserToAddRows = false;
            this.gridSessoes.AllowUserToDeleteRows = false;
            this.gridSessoes.AllowUserToResizeColumns = false;
            this.gridSessoes.AllowUserToResizeRows = false;
            this.gridSessoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSessoes.BackgroundColor = System.Drawing.Color.White;
            this.gridSessoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSessoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridSessoes.Location = new System.Drawing.Point(3, 17);
            this.gridSessoes.MultiSelect = false;
            this.gridSessoes.Name = "gridSessoes";
            this.gridSessoes.ReadOnly = true;
            this.gridSessoes.RowHeadersVisible = false;
            this.gridSessoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridSessoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSessoes.ShowCellErrors = false;
            this.gridSessoes.ShowCellToolTips = false;
            this.gridSessoes.ShowEditingIcon = false;
            this.gridSessoes.ShowRowErrors = false;
            this.gridSessoes.Size = new System.Drawing.Size(504, 184);
            this.gridSessoes.TabIndex = 3;
            this.gridSessoes.SelectionChanged += new System.EventHandler(this.gridSessoes_SelectionChanged);
            this.gridSessoes.DoubleClick += new System.EventHandler(this.gridSessoes_DoubleClick);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridAtendimento);
            this.Controls.Add(this.toolstripActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendimento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridModelos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSessoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ToolStrip toolstripActions;
        private ToolStripSeparator toolStripSeparator4;
        protected ToolStripSplitButton btnFiltros;
        protected DataGridView gridAtendimento;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        protected DataGridView gridModelos;
        protected DataGridView gridSessoes;
        protected ToolStripSplitButton btnActions;
        protected ToolStripButton btnInsert;
        private ToolStripSeparator toolStripSeparator1;
        protected ToolStripButton btnEdit;
        private ToolStripSeparator toolStripSeparator2;
        protected ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator3;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn AtendimentoGrid;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Documento;
    }
}