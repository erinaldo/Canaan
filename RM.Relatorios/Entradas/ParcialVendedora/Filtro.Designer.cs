namespace RM.Relatorios.Entradas.ParcialVendedora
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboVendedora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFilial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(201, 131);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(103, 23);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboVendedora);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboFilial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // comboVendedora
            // 
            this.comboVendedora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVendedora.FormattingEnabled = true;
            this.comboVendedora.Location = new System.Drawing.Point(9, 76);
            this.comboVendedora.Name = "comboVendedora";
            this.comboVendedora.Size = new System.Drawing.Size(265, 21);
            this.comboVendedora.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione a Gerente";
            // 
            // comboFilial
            // 
            this.comboFilial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilial.FormattingEnabled = true;
            this.comboFilial.Location = new System.Drawing.Point(9, 36);
            this.comboFilial.Name = "comboFilial";
            this.comboFilial.Size = new System.Drawing.Size(265, 21);
            this.comboFilial.TabIndex = 2;
            this.comboFilial.SelectedIndexChanged += new System.EventHandler(this.comboFilial_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a Filial";
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 169);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada Parcial Vendedora";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboVendedora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFilial;
        private System.Windows.Forms.Label label1;
    }
}