namespace Canaan.CService.Telas.Integracao.Produto
{
    partial class Lista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Canaan.CService.Telas.Properties.Resources.gear_16xLG;
            this.btnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 22);
            this.btnUpdate.Text = "Efetuar Atualização";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AllowUserToAddRows = false;
            this.produtosDataGridView.AllowUserToDeleteRows = false;
            this.produtosDataGridView.AllowUserToResizeColumns = false;
            this.produtosDataGridView.AllowUserToResizeRows = false;
            this.produtosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.produtosDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Valor});
            this.produtosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produtosDataGridView.Location = new System.Drawing.Point(0, 25);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.ReadOnly = true;
            this.produtosDataGridView.RowHeadersVisible = false;
            this.produtosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.produtosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtosDataGridView.ShowCellErrors = false;
            this.produtosDataGridView.ShowCellToolTips = false;
            this.produtosDataGridView.ShowEditingIcon = false;
            this.produtosDataGridView.ShowRowErrors = false;
            this.produtosDataGridView.Size = new System.Drawing.Size(657, 395);
            this.produtosDataGridView.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 420);
            this.Controls.Add(this.produtosDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integração Produtos RM";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}