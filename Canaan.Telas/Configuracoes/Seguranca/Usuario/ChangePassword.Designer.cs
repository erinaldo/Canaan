using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Seguranca.Usuario
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.senhaGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repitaTextBox = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.senhaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // senhaGroupBox
            // 
            this.senhaGroupBox.Controls.Add(this.btnChange);
            this.senhaGroupBox.Controls.Add(this.repitaTextBox);
            this.senhaGroupBox.Controls.Add(this.label2);
            this.senhaGroupBox.Controls.Add(this.senhaTextBox);
            this.senhaGroupBox.Controls.Add(this.label1);
            this.senhaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.senhaGroupBox.Name = "senhaGroupBox";
            this.senhaGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.senhaGroupBox.Size = new System.Drawing.Size(197, 141);
            this.senhaGroupBox.TabIndex = 0;
            this.senhaGroupBox.TabStop = false;
            this.senhaGroupBox.Text = "Informe os Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a Nova Senha";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(8, 34);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(174, 20);
            this.senhaTextBox.TabIndex = 1;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repita a Senha";
            // 
            // repitaTextBox
            // 
            this.repitaTextBox.Location = new System.Drawing.Point(8, 77);
            this.repitaTextBox.Name = "repitaTextBox";
            this.repitaTextBox.Size = new System.Drawing.Size(174, 20);
            this.repitaTextBox.TabIndex = 3;
            this.repitaTextBox.UseSystemPasswordChar = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(8, 103);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(174, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Confirma Alteração";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 168);
            this.Controls.Add(this.senhaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alteração de Senha";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.senhaGroupBox.ResumeLayout(false);
            this.senhaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox senhaGroupBox;
        private Button btnChange;
        private TextBox repitaTextBox;
        private Label label2;
        private TextBox senhaTextBox;
        private Label label1;
    }
}