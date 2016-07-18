namespace Canaan.Relatorios.Venda.Liberacao
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
            this.rbGerencial = new System.Windows.Forms.RadioButton();
            this.rbEscritorio = new System.Windows.Forms.RadioButton();
            this.rbProgramada = new System.Windows.Forms.RadioButton();
            this.btnGerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbProgramada);
            this.groupBox1.Controls.Add(this.rbEscritorio);
            this.groupBox1.Controls.Add(this.rbGerencial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(265, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Relatório";
            // 
            // rbGerencial
            // 
            this.rbGerencial.AutoSize = true;
            this.rbGerencial.Location = new System.Drawing.Point(8, 21);
            this.rbGerencial.Name = "rbGerencial";
            this.rbGerencial.Size = new System.Drawing.Size(130, 17);
            this.rbGerencial.TabIndex = 0;
            this.rbGerencial.TabStop = true;
            this.rbGerencial.Text = "Conferência Gerencial";
            this.rbGerencial.UseVisualStyleBackColor = true;
            // 
            // rbEscritorio
            // 
            this.rbEscritorio.AutoSize = true;
            this.rbEscritorio.Location = new System.Drawing.Point(8, 44);
            this.rbEscritorio.Name = "rbEscritorio";
            this.rbEscritorio.Size = new System.Drawing.Size(133, 17);
            this.rbEscritorio.TabIndex = 1;
            this.rbEscritorio.TabStop = true;
            this.rbEscritorio.Text = "Liberação do Escritório";
            this.rbEscritorio.UseVisualStyleBackColor = true;
            // 
            // rbProgramada
            // 
            this.rbProgramada.AutoSize = true;
            this.rbProgramada.Location = new System.Drawing.Point(8, 67);
            this.rbProgramada.Name = "rbProgramada";
            this.rbProgramada.Size = new System.Drawing.Size(126, 17);
            this.rbProgramada.TabIndex = 2;
            this.rbProgramada.TabStop = true;
            this.rbProgramada.Text = "Vendas Programadas";
            this.rbProgramada.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerar.Location = new System.Drawing.Point(182, 118);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(95, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 152);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacotes para Liberacão";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGerencial;
        private System.Windows.Forms.RadioButton rbProgramada;
        private System.Windows.Forms.RadioButton rbEscritorio;
        private System.Windows.Forms.Button btnGerar;
    }
}