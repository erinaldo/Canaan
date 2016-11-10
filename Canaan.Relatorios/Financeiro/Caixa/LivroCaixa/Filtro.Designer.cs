namespace Canaan.Relatorios.Financeiro.Caixa.LivroCaixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.contaCaixaComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gerarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fimDateTimePicker);
            this.groupBox1.Controls.Add(this.inicioDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.contaCaixaComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(275, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conta Caixa";
            // 
            // contaCaixaComboBox
            // 
            this.contaCaixaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contaCaixaComboBox.FormattingEnabled = true;
            this.contaCaixaComboBox.Location = new System.Drawing.Point(11, 34);
            this.contaCaixaComboBox.Name = "contaCaixaComboBox";
            this.contaCaixaComboBox.Size = new System.Drawing.Size(244, 21);
            this.contaCaixaComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Período";
            // 
            // inicioDateTimePicker
            // 
            this.inicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inicioDateTimePicker.Location = new System.Drawing.Point(11, 75);
            this.inicioDateTimePicker.Name = "inicioDateTimePicker";
            this.inicioDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.inicioDateTimePicker.TabIndex = 3;
            // 
            // fimDateTimePicker
            // 
            this.fimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fimDateTimePicker.Location = new System.Drawing.Point(135, 75);
            this.fimDateTimePicker.Name = "fimDateTimePicker";
            this.fimDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.fimDateTimePicker.TabIndex = 4;
            // 
            // gerarButton
            // 
            this.gerarButton.Location = new System.Drawing.Point(83, 132);
            this.gerarButton.Name = "gerarButton";
            this.gerarButton.Size = new System.Drawing.Size(125, 23);
            this.gerarButton.TabIndex = 1;
            this.gerarButton.Text = "Gerar Relatório";
            this.gerarButton.UseVisualStyleBackColor = true;
            this.gerarButton.Click += new System.EventHandler(this.gerarButton_Click);
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 171);
            this.Controls.Add(this.gerarButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livro Caixa";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker fimDateTimePicker;
        private System.Windows.Forms.DateTimePicker inicioDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox contaCaixaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gerarButton;
    }
}