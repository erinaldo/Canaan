namespace CPanel.Telas.Caderno
{
    partial class frmNovo
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
            this.filiaisComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cadernoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Estudio";
            // 
            // filiaisComboBox
            // 
            this.filiaisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiaisComboBox.FormattingEnabled = true;
            this.filiaisComboBox.Location = new System.Drawing.Point(13, 26);
            this.filiaisComboBox.Name = "filiaisComboBox";
            this.filiaisComboBox.Size = new System.Drawing.Size(270, 21);
            this.filiaisComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe a Data";
            // 
            // cadernoDateTimePicker
            // 
            this.cadernoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cadernoDateTimePicker.Location = new System.Drawing.Point(13, 66);
            this.cadernoDateTimePicker.Name = "cadernoDateTimePicker";
            this.cadernoDateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.cadernoDateTimePicker.TabIndex = 3;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(180, 64);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(103, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Criar Caderno";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 112);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.cadernoDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filiaisComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Caderno de Vendas";
            this.Load += new System.EventHandler(this.frmNovo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filiaisComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker cadernoDateTimePicker;
        private System.Windows.Forms.Button btnNovo;
    }
}