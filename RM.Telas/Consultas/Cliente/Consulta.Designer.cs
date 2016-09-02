namespace RM.Telas.Consultas.Cliente
{
    partial class Consulta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbCMaster = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(972, 95);
            this.panel1.TabIndex = 0;
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.btnConsulta);
            this.gbConsulta.Controls.Add(this.tbFiltro);
            this.gbConsulta.Controls.Add(this.rbNome);
            this.gbConsulta.Controls.Add(this.rbCPF);
            this.gbConsulta.Controls.Add(this.rbCMaster);
            this.gbConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConsulta.Location = new System.Drawing.Point(10, 10);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(952, 75);
            this.gbConsulta.TabIndex = 0;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Dados da Consulta";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(307, 40);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(98, 23);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(6, 42);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(295, 20);
            this.tbFiltro.TabIndex = 3;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Checked = true;
            this.rbNome.Location = new System.Drawing.Point(293, 19);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(118, 17);
            this.rbNome.TabIndex = 2;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Consultar por Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(177, 19);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(110, 17);
            this.rbCPF.TabIndex = 1;
            this.rbCPF.Text = "Consultar por CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            // 
            // rbCMaster
            // 
            this.rbCMaster.AutoSize = true;
            this.rbCMaster.Location = new System.Drawing.Point(6, 19);
            this.rbCMaster.Name = "rbCMaster";
            this.rbCMaster.Size = new System.Drawing.Size(165, 17);
            this.rbCMaster.TabIndex = 0;
            this.rbCMaster.Text = "Consultar por Codigo CMaster";
            this.rbCMaster.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridResult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 353);
            this.panel2.TabIndex = 1;
            // 
            // gridResult
            // 
            this.gridResult.AllowUserToAddRows = false;
            this.gridResult.AllowUserToDeleteRows = false;
            this.gridResult.AllowUserToResizeRows = false;
            this.gridResult.BackgroundColor = System.Drawing.Color.White;
            this.gridResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResult.Location = new System.Drawing.Point(0, 0);
            this.gridResult.MultiSelect = false;
            this.gridResult.Name = "gridResult";
            this.gridResult.ReadOnly = true;
            this.gridResult.RowHeadersVisible = false;
            this.gridResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResult.ShowCellErrors = false;
            this.gridResult.ShowCellToolTips = false;
            this.gridResult.ShowEditingIcon = false;
            this.gridResult.ShowRowErrors = false;
            this.gridResult.Size = new System.Drawing.Size(972, 353);
            this.gridResult.TabIndex = 0;
            this.gridResult.DoubleClick += new System.EventHandler(this.gridResult_DoubleClick);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clientes RM";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.panel1.ResumeLayout(false);
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbCMaster;
        private System.Windows.Forms.DataGridView gridResult;
    }
}