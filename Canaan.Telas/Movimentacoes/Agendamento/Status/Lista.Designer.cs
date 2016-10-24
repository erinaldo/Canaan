namespace Canaan.Telas.Movimentacoes.Agendamento.Status
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
            this.statusDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusDataGridView
            // 
            this.statusDataGridView.AllowUserToAddRows = false;
            this.statusDataGridView.AllowUserToDeleteRows = false;
            this.statusDataGridView.AllowUserToResizeColumns = false;
            this.statusDataGridView.AllowUserToResizeRows = false;
            this.statusDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.statusDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.statusDataGridView.ColumnHeadersVisible = false;
            this.statusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao});
            this.statusDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDataGridView.Location = new System.Drawing.Point(0, 0);
            this.statusDataGridView.MultiSelect = false;
            this.statusDataGridView.Name = "statusDataGridView";
            this.statusDataGridView.ReadOnly = true;
            this.statusDataGridView.RowHeadersVisible = false;
            this.statusDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.statusDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statusDataGridView.ShowCellErrors = false;
            this.statusDataGridView.ShowCellToolTips = false;
            this.statusDataGridView.ShowEditingIcon = false;
            this.statusDataGridView.ShowRowErrors = false;
            this.statusDataGridView.Size = new System.Drawing.Size(365, 194);
            this.statusDataGridView.TabIndex = 0;
            this.statusDataGridView.DoubleClick += new System.EventHandler(this.statusDataGridView_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            this.Codigo.Width = 75;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 194);
            this.Controls.Add(this.statusDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Status do Agendamento";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}