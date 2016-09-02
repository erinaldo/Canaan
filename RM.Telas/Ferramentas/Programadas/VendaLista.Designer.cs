namespace RM.Telas.Ferramentas.Programadas
{
    partial class VendaLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.vendasGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caderno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltro = new System.Windows.Forms.ToolStripButton();
            this.btnLancamentos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btnRetirar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAtualiza = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFiltro,
            this.toolStripSeparator1,
            this.btnLancamentos,
            this.toolStripSplitButton1,
            this.toolStripSeparator3,
            this.btnAtualiza});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(997, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // vendasGridView
            // 
            this.vendasGridView.AllowUserToAddRows = false;
            this.vendasGridView.AllowUserToDeleteRows = false;
            this.vendasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vendasGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cmaster,
            this.Movimento,
            this.Status,
            this.Cliente,
            this.Classe,
            this.Emissao,
            this.Caderno,
            this.Valor});
            this.vendasGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendasGridView.Location = new System.Drawing.Point(0, 25);
            this.vendasGridView.MultiSelect = false;
            this.vendasGridView.Name = "vendasGridView";
            this.vendasGridView.ReadOnly = true;
            this.vendasGridView.RowHeadersVisible = false;
            this.vendasGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendasGridView.ShowCellErrors = false;
            this.vendasGridView.ShowCellToolTips = false;
            this.vendasGridView.ShowEditingIcon = false;
            this.vendasGridView.ShowRowErrors = false;
            this.vendasGridView.Size = new System.Drawing.Size(997, 375);
            this.vendasGridView.TabIndex = 1;
            this.vendasGridView.DoubleClick += new System.EventHandler(this.vendasGridView_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 75;
            // 
            // Cmaster
            // 
            this.Cmaster.DataPropertyName = "Cmaster";
            this.Cmaster.HeaderText = "Cmaster";
            this.Cmaster.Name = "Cmaster";
            this.Cmaster.ReadOnly = true;
            this.Cmaster.Width = 75;
            // 
            // Movimento
            // 
            this.Movimento.DataPropertyName = "Movimento";
            this.Movimento.HeaderText = "Movimento";
            this.Movimento.Name = "Movimento";
            this.Movimento.ReadOnly = true;
            this.Movimento.Width = 70;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Classe
            // 
            this.Classe.DataPropertyName = "Classe";
            this.Classe.HeaderText = "Classe";
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            this.Classe.Width = 70;
            // 
            // Emissao
            // 
            this.Emissao.DataPropertyName = "Emissao";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Emissao.DefaultCellStyle = dataGridViewCellStyle1;
            this.Emissao.HeaderText = "Emissao";
            this.Emissao.Name = "Emissao";
            this.Emissao.ReadOnly = true;
            this.Emissao.Width = 70;
            // 
            // Caderno
            // 
            this.Caderno.DataPropertyName = "Caderno";
            dataGridViewCellStyle2.Format = "d";
            this.Caderno.DefaultCellStyle = dataGridViewCellStyle2;
            this.Caderno.HeaderText = "Caderno";
            this.Caderno.Name = "Caderno";
            this.Caderno.ReadOnly = true;
            this.Caderno.Width = 70;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Image = global::RM.Telas.Properties.Resources.filter_16xLG;
            this.btnFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(102, 22);
            this.btnFiltro.Text = "Buscar Cliente";
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnLancamentos
            // 
            this.btnLancamentos.Image = global::RM.Telas.Properties.Resources.folder_Open_16xLG;
            this.btnLancamentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLancamentos.Name = "btnLancamentos";
            this.btnLancamentos.Size = new System.Drawing.Size(129, 22);
            this.btnLancamentos.Text = "Exibir Lançamentos";
            this.btnLancamentos.Click += new System.EventHandler(this.btnLancamentos_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRetirar,
            this.toolStripSeparator2,
            this.btnAlterar});
            this.toolStripSplitButton1.Image = global::RM.Telas.Properties.Resources.gear_16xLG;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(114, 22);
            this.toolStripSplitButton1.Text = "Executa Ações";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(250, 22);
            this.btnRetirar.Text = "Retira do Caderno de Vendas";
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(250, 22);
            this.btnAlterar.Text = "Inclui / Altera Caderno de Vendas";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Image = global::RM.Telas.Properties.Resources.refresh_16xLG;
            this.btnAtualiza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(96, 22);
            this.btnAtualiza.Text = "Atualiza Lista";
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // VendaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 400);
            this.Controls.Add(this.vendasGridView);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VendaLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Vendas";
            this.Load += new System.EventHandler(this.VendaLista_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFiltro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLancamentos;
        private System.Windows.Forms.DataGridView vendasGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caderno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem btnRetirar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnAlterar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAtualiza;
    }
}