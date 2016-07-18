namespace Canaan.Telas.Movimentacoes.Venda.Documentacao.Caderno
{
    partial class SelecionaData
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
            this.label1 = new System.Windows.Forms.Label();
            this.cadernoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salvaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a Data do Caderno";
            // 
            // cadernoDateTimePicker
            // 
            this.cadernoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadernoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cadernoDateTimePicker.Location = new System.Drawing.Point(16, 32);
            this.cadernoDateTimePicker.Name = "cadernoDateTimePicker";
            this.cadernoDateTimePicker.Size = new System.Drawing.Size(224, 26);
            this.cadernoDateTimePicker.TabIndex = 1;
            // 
            // salvaButton
            // 
            this.salvaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvaButton.Location = new System.Drawing.Point(16, 82);
            this.salvaButton.Name = "salvaButton";
            this.salvaButton.Size = new System.Drawing.Size(224, 30);
            this.salvaButton.TabIndex = 2;
            this.salvaButton.Text = "Continuar";
            this.salvaButton.UseVisualStyleBackColor = true;
            this.salvaButton.Click += new System.EventHandler(this.salvaButton_Click);
            // 
            // SelecionaData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(257, 124);
            this.ControlBox = false;
            this.Controls.Add(this.salvaButton);
            this.Controls.Add(this.cadernoDateTimePicker);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelecionaData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelecionaData";
            this.Load += new System.EventHandler(this.SelecionaData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker cadernoDateTimePicker;
        private System.Windows.Forms.Button salvaButton;
    }
}