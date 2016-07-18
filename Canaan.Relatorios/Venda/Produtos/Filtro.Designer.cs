namespace Canaan.Relatorios.Venda.Produtos
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
            this.cbProgramadas = new System.Windows.Forms.RadioButton();
            this.cbDevolvidas = new System.Windows.Forms.RadioButton();
            this.cbLiberadas = new System.Windows.Forms.RadioButton();
            this.cbTodas = new System.Windows.Forms.RadioButton();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.ckEspecifico = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckEspecifico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbProdutos);
            this.groupBox1.Controls.Add(this.dtFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtInicial);
            this.groupBox1.Controls.Add(this.cbProgramadas);
            this.groupBox1.Controls.Add(this.cbDevolvidas);
            this.groupBox1.Controls.Add(this.cbLiberadas);
            this.groupBox1.Controls.Add(this.cbTodas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // cbProgramadas
            // 
            this.cbProgramadas.AutoSize = true;
            this.cbProgramadas.Location = new System.Drawing.Point(22, 218);
            this.cbProgramadas.Name = "cbProgramadas";
            this.cbProgramadas.Size = new System.Drawing.Size(126, 17);
            this.cbProgramadas.TabIndex = 14;
            this.cbProgramadas.Text = "Vendas Programadas";
            this.cbProgramadas.UseVisualStyleBackColor = true;
            // 
            // cbDevolvidas
            // 
            this.cbDevolvidas.AutoSize = true;
            this.cbDevolvidas.Location = new System.Drawing.Point(22, 195);
            this.cbDevolvidas.Name = "cbDevolvidas";
            this.cbDevolvidas.Size = new System.Drawing.Size(117, 17);
            this.cbDevolvidas.TabIndex = 13;
            this.cbDevolvidas.Text = "Vendas Devolvidas";
            this.cbDevolvidas.UseVisualStyleBackColor = true;
            // 
            // cbLiberadas
            // 
            this.cbLiberadas.AutoSize = true;
            this.cbLiberadas.Checked = true;
            this.cbLiberadas.Location = new System.Drawing.Point(22, 172);
            this.cbLiberadas.Name = "cbLiberadas";
            this.cbLiberadas.Size = new System.Drawing.Size(110, 17);
            this.cbLiberadas.TabIndex = 12;
            this.cbLiberadas.TabStop = true;
            this.cbLiberadas.Text = "Vendas Liberadas";
            this.cbLiberadas.UseVisualStyleBackColor = true;
            // 
            // cbTodas
            // 
            this.cbTodas.AutoSize = true;
            this.cbTodas.Location = new System.Drawing.Point(22, 149);
            this.cbTodas.Name = "cbTodas";
            this.cbTodas.Size = new System.Drawing.Size(108, 17);
            this.cbTodas.TabIndex = 11;
            this.cbTodas.Text = "Todas as Vendas";
            this.cbTodas.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(233, 262);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(111, 23);
            this.btnGerar.TabIndex = 9;
            this.btnGerar.Text = "Gerar Relatorio";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(19, 116);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(142, 20);
            this.dtInicial.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Período";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(167, 116);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(142, 20);
            this.dtFinal.TabIndex = 17;
            // 
            // ckEspecifico
            // 
            this.ckEspecifico.AutoSize = true;
            this.ckEspecifico.Location = new System.Drawing.Point(17, 63);
            this.ckEspecifico.Name = "ckEspecifico";
            this.ckEspecifico.Size = new System.Drawing.Size(115, 17);
            this.ckEspecifico.TabIndex = 20;
            this.ckEspecifico.Text = "Produto Especifico";
            this.ckEspecifico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Produto";
            // 
            // cbProdutos
            // 
            this.cbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdutos.Enabled = false;
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(17, 35);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(290, 21);
            this.cbProdutos.TabIndex = 18;
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 297);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.RadioButton cbProgramadas;
        private System.Windows.Forms.RadioButton cbDevolvidas;
        private System.Windows.Forms.RadioButton cbLiberadas;
        private System.Windows.Forms.RadioButton cbTodas;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckEspecifico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProdutos;
    }
}