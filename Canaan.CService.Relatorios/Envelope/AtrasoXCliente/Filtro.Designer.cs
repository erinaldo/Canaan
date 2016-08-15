namespace Canaan.CService.Relatorios.Envelope.AtrasoXCliente
{
    partial class Filtro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReport = new System.Windows.Forms.Button();
            this.previsaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.clienteTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o Nome do Cliente";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(415, 19);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 1;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(6, 21);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(403, 20);
            this.clienteTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clienteDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione o Cliente";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AllowUserToResizeColumns = false;
            this.clienteDataGridView.AllowUserToResizeRows = false;
            this.clienteDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.clienteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente});
            this.clienteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clienteDataGridView.Location = new System.Drawing.Point(3, 16);
            this.clienteDataGridView.MultiSelect = false;
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.RowHeadersVisible = false;
            this.clienteDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDataGridView.ShowCellErrors = false;
            this.clienteDataGridView.ShowCellToolTips = false;
            this.clienteDataGridView.ShowEditingIcon = false;
            this.clienteDataGridView.ShowRowErrors = false;
            this.clienteDataGridView.Size = new System.Drawing.Size(496, 220);
            this.clienteDataGridView.TabIndex = 0;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(393, 322);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(109, 23);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Gerar Relatório";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // previsaoDateTimePicker
            // 
            this.previsaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.previsaoDateTimePicker.Location = new System.Drawing.Point(166, 324);
            this.previsaoDateTimePicker.Name = "previsaoDateTimePicker";
            this.previsaoDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.previsaoDateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe a Data para Previsão";
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previsaoDateTimePicker);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DateTimePicker previsaoDateTimePicker;
        private System.Windows.Forms.Label label1;
    }
}