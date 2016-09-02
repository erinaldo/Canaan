namespace RM.Telas.Ferramentas.Programadas
{
    partial class LancUpdateClasse
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classe1ComboBox = new System.Windows.Forms.ComboBox();
            this.classe2ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classe2ComboBox);
            this.groupBox1.Controls.Add(this.classe1ComboBox);
            this.groupBox1.Controls.Add(this.btnExecute);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(377, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Atualização";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(8, 101);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(127, 23);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Executar Atualização";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe a nova classe contábil para os lançamentos NÃO SELECIONADOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a nova classe contábil para os lançamentos SELECIONADOS";
            // 
            // classe1ComboBox
            // 
            this.classe1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classe1ComboBox.FormattingEnabled = true;
            this.classe1ComboBox.Location = new System.Drawing.Point(8, 34);
            this.classe1ComboBox.Name = "classe1ComboBox";
            this.classe1ComboBox.Size = new System.Drawing.Size(229, 21);
            this.classe1ComboBox.TabIndex = 5;
            // 
            // classe2ComboBox
            // 
            this.classe2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classe2ComboBox.FormattingEnabled = true;
            this.classe2ComboBox.Location = new System.Drawing.Point(8, 74);
            this.classe2ComboBox.Name = "classe2ComboBox";
            this.classe2ComboBox.Size = new System.Drawing.Size(229, 21);
            this.classe2ComboBox.TabIndex = 6;
            // 
            // LancUpdateClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 142);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LancUpdateClasse";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização das Classes Contabeis";
            this.Load += new System.EventHandler(this.LancUpdateClasse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classe2ComboBox;
        private System.Windows.Forms.ComboBox classe1ComboBox;
    }
}