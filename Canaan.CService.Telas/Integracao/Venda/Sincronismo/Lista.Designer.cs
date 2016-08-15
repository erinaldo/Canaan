namespace Canaan.CService.Telas.Integracao.Venda.Sincronismo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSincronizar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.vendasGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLiberar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSincronizar,
            this.toolStripSeparator1,
            this.btnLiberar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Image = global::Canaan.CService.Telas.Properties.Resources.gear_16xLG;
            this.btnSincronizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSincronizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(85, 22);
            this.btnSincronizar.Text = "Sincronizar";
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(989, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoLabel
            // 
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(118, 17);
            this.infoLabel.Text = "toolStripStatusLabel1";
            // 
            // vendasGridView
            // 
            this.vendasGridView.AllowUserToAddRows = false;
            this.vendasGridView.AllowUserToDeleteRows = false;
            this.vendasGridView.AllowUserToResizeColumns = false;
            this.vendasGridView.AllowUserToResizeRows = false;
            this.vendasGridView.BackgroundColor = System.Drawing.Color.White;
            this.vendasGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendasGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.vendasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vendasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cliente,
            this.Vendedor,
            this.Emissao,
            this.Valor,
            this.Quantidade,
            this.Status});
            this.vendasGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendasGridView.Location = new System.Drawing.Point(0, 25);
            this.vendasGridView.MultiSelect = false;
            this.vendasGridView.Name = "vendasGridView";
            this.vendasGridView.ReadOnly = true;
            this.vendasGridView.RowHeadersVisible = false;
            this.vendasGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.vendasGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendasGridView.ShowCellErrors = false;
            this.vendasGridView.ShowCellToolTips = false;
            this.vendasGridView.ShowEditingIcon = false;
            this.vendasGridView.ShowRowErrors = false;
            this.vendasGridView.Size = new System.Drawing.Size(989, 428);
            this.vendasGridView.TabIndex = 2;
            this.vendasGridView.DoubleClick += new System.EventHandler(this.vendasGridView_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IdVenda";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "NomeCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vendedor.DataPropertyName = "NomeVendedor";
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            // 
            // Emissao
            // 
            this.Emissao.DataPropertyName = "DataEmissao";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Emissao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Emissao.HeaderText = "Emissao";
            this.Emissao.Name = "Emissao";
            this.Emissao.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorLiquido";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle4;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "QtdeItem";
            this.Quantidade.HeaderText = "Qtde";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLiberar
            // 
            this.btnLiberar.Image = global::Canaan.CService.Telas.Properties.Resources.lock_16xLG;
            this.btnLiberar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLiberar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(176, 22);
            this.btnLiberar.Text = "Sincronizar com autorização";
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 475);
            this.Controls.Add(this.vendasGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSincronizar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel infoLabel;
        private System.Windows.Forms.DataGridView vendasGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLiberar;
    }
}