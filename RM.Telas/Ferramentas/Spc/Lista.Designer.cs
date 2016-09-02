namespace RM.Telas.Ferramentas.Spc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFiltro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRemessa = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdLan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClasseContabil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataBaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorBaixado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFiltro,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator2,
            this.btnRemessa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(1054, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Image = global::RM.Telas.Properties.Resources.filter_16xLG;
            this.btnFiltro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(108, 20);
            this.btnFiltro.Text = "Filtrar Registros";
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::RM.Telas.Properties.Resources.action_Cancel_16xLG;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 20);
            this.btnDelete.Text = "Remove Selecionados";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnRemessa
            // 
            this.btnRemessa.Image = global::RM.Telas.Properties.Resources.gear_16xLG;
            this.btnRemessa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRemessa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemessa.Name = "btnRemessa";
            this.btnRemessa.Size = new System.Drawing.Size(161, 20);
            this.btnRemessa.Text = "Gera Arquivo de Remessa";
            this.btnRemessa.Click += new System.EventHandler(this.btnRemessa_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1054, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbInfo
            // 
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsChecked,
            this.IdLan,
            this.IdMov,
            this.ClasseContabil,
            this.CodCliente,
            this.NomeCliente,
            this.DataEmissao,
            this.DataVencimento,
            this.DataBaixa,
            this.ValorOriginal,
            this.ValorBaixado});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 33);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 433);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // IsChecked
            // 
            this.IsChecked.DataPropertyName = "IsChecked";
            this.IsChecked.HeaderText = "";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Width = 40;
            // 
            // IdLan
            // 
            this.IdLan.DataPropertyName = "IdLan";
            this.IdLan.HeaderText = "Lançamento";
            this.IdLan.Name = "IdLan";
            this.IdLan.ReadOnly = true;
            this.IdLan.Width = 80;
            // 
            // IdMov
            // 
            this.IdMov.DataPropertyName = "IdMov";
            this.IdMov.HeaderText = "Venda";
            this.IdMov.Name = "IdMov";
            this.IdMov.ReadOnly = true;
            this.IdMov.Width = 80;
            // 
            // ClasseContabil
            // 
            this.ClasseContabil.DataPropertyName = "ClasseContabil";
            this.ClasseContabil.HeaderText = "ClasseContábil";
            this.ClasseContabil.Name = "ClasseContabil";
            this.ClasseContabil.ReadOnly = true;
            this.ClasseContabil.Width = 85;
            // 
            // CodCliente
            // 
            this.CodCliente.DataPropertyName = "CodCliente";
            this.CodCliente.HeaderText = "Cliente";
            this.CodCliente.Name = "CodCliente";
            this.CodCliente.ReadOnly = true;
            this.CodCliente.Width = 80;
            // 
            // NomeCliente
            // 
            this.NomeCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Nome do Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            // 
            // DataEmissao
            // 
            this.DataEmissao.DataPropertyName = "DataEmissao";
            dataGridViewCellStyle1.Format = "d";
            this.DataEmissao.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataEmissao.HeaderText = "Emissão";
            this.DataEmissao.Name = "DataEmissao";
            this.DataEmissao.ReadOnly = true;
            this.DataEmissao.Width = 80;
            // 
            // DataVencimento
            // 
            this.DataVencimento.DataPropertyName = "DataVencimento";
            dataGridViewCellStyle2.Format = "d";
            this.DataVencimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataVencimento.HeaderText = "Vencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.ReadOnly = true;
            this.DataVencimento.Width = 80;
            // 
            // DataBaixa
            // 
            this.DataBaixa.DataPropertyName = "DataBaixa";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DataBaixa.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataBaixa.HeaderText = "Baixa";
            this.DataBaixa.Name = "DataBaixa";
            this.DataBaixa.ReadOnly = true;
            this.DataBaixa.Width = 80;
            // 
            // ValorOriginal
            // 
            this.ValorOriginal.DataPropertyName = "ValorOriginal";
            dataGridViewCellStyle4.Format = "C2";
            this.ValorOriginal.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorOriginal.HeaderText = "Valor Original";
            this.ValorOriginal.Name = "ValorOriginal";
            this.ValorOriginal.ReadOnly = true;
            this.ValorOriginal.Width = 80;
            // 
            // ValorBaixado
            // 
            this.ValorBaixado.DataPropertyName = "ValorBaixado";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.ValorBaixado.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValorBaixado.HeaderText = "Valor Baixado";
            this.ValorBaixado.Name = "ValorBaixado";
            this.ValorBaixado.ReadOnly = true;
            this.ValorBaixado.Width = 80;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 488);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnFiltro;
        private System.Windows.Forms.ToolStripStatusLabel lbInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRemessa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClasseContabil;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataBaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorBaixado;
    }
}