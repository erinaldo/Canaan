namespace Canaan.CService.Telas.Integracao.Fechamento
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.emailButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.consultaButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.footerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pedidosDataGridView = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // emailButton
            // 
            this.emailButton.Image = global::Canaan.CService.Telas.Properties.Resources.envelope_16xLG;
            this.emailButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emailButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(108, 22);
            this.emailButton.Text = "Envia por Email";
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.consultaButton);
            this.groupBox1.Controls.Add(this.fimDateTimePicker);
            this.groupBox1.Controls.Add(this.inicioDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo";
            // 
            // inicioDateTimePicker
            // 
            this.inicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inicioDateTimePicker.Location = new System.Drawing.Point(6, 19);
            this.inicioDateTimePicker.Name = "inicioDateTimePicker";
            this.inicioDateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.inicioDateTimePicker.TabIndex = 0;
            // 
            // fimDateTimePicker
            // 
            this.fimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fimDateTimePicker.Location = new System.Drawing.Point(131, 19);
            this.fimDateTimePicker.Name = "fimDateTimePicker";
            this.fimDateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.fimDateTimePicker.TabIndex = 1;
            // 
            // consultaButton
            // 
            this.consultaButton.Location = new System.Drawing.Point(256, 17);
            this.consultaButton.Name = "consultaButton";
            this.consultaButton.Size = new System.Drawing.Size(75, 23);
            this.consultaButton.TabIndex = 2;
            this.consultaButton.Text = "Consulta";
            this.consultaButton.UseVisualStyleBackColor = true;
            this.consultaButton.Click += new System.EventHandler(this.consultaButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pedidosDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 374);
            this.panel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.footerLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // footerLabel
            // 
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(118, 17);
            this.footerLabel.Text = "toolStripStatusLabel1";
            // 
            // pedidosDataGridView
            // 
            this.pedidosDataGridView.AllowUserToAddRows = false;
            this.pedidosDataGridView.AllowUserToDeleteRows = false;
            this.pedidosDataGridView.AllowUserToResizeColumns = false;
            this.pedidosDataGridView.AllowUserToResizeRows = false;
            this.pedidosDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.pedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Cidade,
            this.Produto,
            this.Qtde,
            this.Valor});
            this.pedidosDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.pedidosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pedidosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pedidosDataGridView.Name = "pedidosDataGridView";
            this.pedidosDataGridView.ReadOnly = true;
            this.pedidosDataGridView.RowHeadersVisible = false;
            this.pedidosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.pedidosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pedidosDataGridView.ShowCellErrors = false;
            this.pedidosDataGridView.ShowCellToolTips = false;
            this.pedidosDataGridView.ShowEditingIcon = false;
            this.pedidosDataGridView.ShowRowErrors = false;
            this.pedidosDataGridView.Size = new System.Drawing.Size(830, 374);
            this.pedidosDataGridView.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Qtde
            // 
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            // 
            // Valor
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton emailButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button consultaButton;
        private System.Windows.Forms.DateTimePicker fimDateTimePicker;
        private System.Windows.Forms.DateTimePicker inicioDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel footerLabel;
        private System.Windows.Forms.DataGridView pedidosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}