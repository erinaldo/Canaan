namespace CPanel.Telas.Caderno
{
    partial class frmVenda
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.is_programadaCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.venda_totalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.venda_prazoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.venda_cartaoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.venda_dinheiroTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.entrada_depositada_dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.entrada_depositadaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.entrada_cartaoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.entrada_dinheiroTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nome_clienteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cod_rmTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cod_cmasterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.vendedoraComboBox = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(388, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::CPanel.Telas.Properties.Resources.Save;
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 28);
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.is_programadaCheckBox);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(388, 407);
            this.panel1.TabIndex = 1;
            // 
            // is_programadaCheckBox
            // 
            this.is_programadaCheckBox.AutoSize = true;
            this.is_programadaCheckBox.Location = new System.Drawing.Point(12, 378);
            this.is_programadaCheckBox.Name = "is_programadaCheckBox";
            this.is_programadaCheckBox.Size = new System.Drawing.Size(116, 17);
            this.is_programadaCheckBox.TabIndex = 11;
            this.is_programadaCheckBox.Text = "Venda programada";
            this.is_programadaCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.venda_totalTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.venda_prazoTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.venda_cartaoTextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.venda_dinheiroTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(364, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendas";
            // 
            // venda_totalTextBox
            // 
            this.venda_totalTextBox.Enabled = false;
            this.venda_totalTextBox.Location = new System.Drawing.Point(147, 69);
            this.venda_totalTextBox.Name = "venda_totalTextBox";
            this.venda_totalTextBox.Size = new System.Drawing.Size(113, 20);
            this.venda_totalTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Faturamento";
            // 
            // venda_prazoTextBox
            // 
            this.venda_prazoTextBox.Location = new System.Drawing.Point(147, 32);
            this.venda_prazoTextBox.Name = "venda_prazoTextBox";
            this.venda_prazoTextBox.Size = new System.Drawing.Size(113, 20);
            this.venda_prazoTextBox.TabIndex = 7;
            this.venda_prazoTextBox.TextChanged += new System.EventHandler(this.venda_prazoTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "À prazo";
            // 
            // venda_cartaoTextBox
            // 
            this.venda_cartaoTextBox.Location = new System.Drawing.Point(6, 69);
            this.venda_cartaoTextBox.Name = "venda_cartaoTextBox";
            this.venda_cartaoTextBox.Size = new System.Drawing.Size(113, 20);
            this.venda_cartaoTextBox.TabIndex = 5;
            this.venda_cartaoTextBox.TextChanged += new System.EventHandler(this.venda_cartaoTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Á vista no cartão";
            // 
            // venda_dinheiroTextBox
            // 
            this.venda_dinheiroTextBox.Location = new System.Drawing.Point(6, 32);
            this.venda_dinheiroTextBox.Name = "venda_dinheiroTextBox";
            this.venda_dinheiroTextBox.Size = new System.Drawing.Size(113, 20);
            this.venda_dinheiroTextBox.TabIndex = 3;
            this.venda_dinheiroTextBox.TextChanged += new System.EventHandler(this.venda_dinheiroTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Á vista no dinheiro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.entrada_depositada_dataDateTimePicker);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.entrada_depositadaTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.entrada_cartaoTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.entrada_dinheiroTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(364, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entradas";
            // 
            // entrada_depositada_dataDateTimePicker
            // 
            this.entrada_depositada_dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.entrada_depositada_dataDateTimePicker.Location = new System.Drawing.Point(147, 69);
            this.entrada_depositada_dataDateTimePicker.Name = "entrada_depositada_dataDateTimePicker";
            this.entrada_depositada_dataDateTimePicker.Size = new System.Drawing.Size(113, 20);
            this.entrada_depositada_dataDateTimePicker.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Data do depósito da entrada";
            // 
            // entrada_depositadaTextBox
            // 
            this.entrada_depositadaTextBox.Location = new System.Drawing.Point(147, 32);
            this.entrada_depositadaTextBox.Name = "entrada_depositadaTextBox";
            this.entrada_depositadaTextBox.Size = new System.Drawing.Size(113, 20);
            this.entrada_depositadaTextBox.TabIndex = 7;
            this.entrada_depositadaTextBox.TextChanged += new System.EventHandler(this.entrada_depositadaTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Entrada depositada";
            // 
            // entrada_cartaoTextBox
            // 
            this.entrada_cartaoTextBox.Location = new System.Drawing.Point(6, 69);
            this.entrada_cartaoTextBox.Name = "entrada_cartaoTextBox";
            this.entrada_cartaoTextBox.Size = new System.Drawing.Size(113, 20);
            this.entrada_cartaoTextBox.TabIndex = 5;
            this.entrada_cartaoTextBox.TextChanged += new System.EventHandler(this.entrada_cartaoTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entrada no cartão";
            // 
            // entrada_dinheiroTextBox
            // 
            this.entrada_dinheiroTextBox.Location = new System.Drawing.Point(6, 32);
            this.entrada_dinheiroTextBox.Name = "entrada_dinheiroTextBox";
            this.entrada_dinheiroTextBox.Size = new System.Drawing.Size(113, 20);
            this.entrada_dinheiroTextBox.TabIndex = 3;
            this.entrada_dinheiroTextBox.TextChanged += new System.EventHandler(this.entrada_dinheiroTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Entrada em dinheiro";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.vendedoraComboBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nome_clienteTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cod_rmTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cod_cmasterTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(364, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Cadastro";
            // 
            // nome_clienteTextBox
            // 
            this.nome_clienteTextBox.Location = new System.Drawing.Point(8, 73);
            this.nome_clienteTextBox.Name = "nome_clienteTextBox";
            this.nome_clienteTextBox.Size = new System.Drawing.Size(343, 20);
            this.nome_clienteTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Cliente";
            // 
            // cod_rmTextBox
            // 
            this.cod_rmTextBox.Location = new System.Drawing.Point(147, 34);
            this.cod_rmTextBox.Name = "cod_rmTextBox";
            this.cod_rmTextBox.Size = new System.Drawing.Size(111, 20);
            this.cod_rmTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código RM";
            // 
            // cod_cmasterTextBox
            // 
            this.cod_cmasterTextBox.Location = new System.Drawing.Point(8, 34);
            this.cod_cmasterTextBox.Name = "cod_cmasterTextBox";
            this.cod_cmasterTextBox.Size = new System.Drawing.Size(111, 20);
            this.cod_cmasterTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código CMaster";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Vendedora";
            // 
            // vendedoraComboBox
            // 
            this.vendedoraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vendedoraComboBox.FormattingEnabled = true;
            this.vendedoraComboBox.Location = new System.Drawing.Point(8, 112);
            this.vendedoraComboBox.Name = "vendedoraComboBox";
            this.vendedoraComboBox.Size = new System.Drawing.Size(343, 21);
            this.vendedoraComboBox.TabIndex = 7;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVenda";
            this.Load += new System.EventHandler(this.frmVenda_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker entrada_depositada_dataDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox entrada_depositadaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox entrada_cartaoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox entrada_dinheiroTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nome_clienteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cod_rmTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cod_cmasterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox is_programadaCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox venda_totalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox venda_prazoTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox venda_cartaoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox venda_dinheiroTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox vendedoraComboBox;
        private System.Windows.Forms.Label label12;
    }
}