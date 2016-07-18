using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Autenticacao
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutenticar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.senhaTextBox = new DevExpress.XtraEditors.TextEdit();
            this.usernameTextBox = new DevExpress.XtraEditors.TextEdit();
            this.lbSenha = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.senhaTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(250, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Usuário";
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.Location = new System.Drawing.Point(367, 394);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.Size = new System.Drawing.Size(114, 23);
            this.btnAutenticar.TabIndex = 24;
            this.btnAutenticar.Text = "Autenticar";
            this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(299, 394);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 23);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(299, 366);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.senhaTextBox.Properties.Appearance.Options.UseFont = true;
            this.senhaTextBox.Properties.UseSystemPasswordChar = true;
            this.senhaTextBox.Size = new System.Drawing.Size(182, 22);
            this.senhaTextBox.TabIndex = 22;
            this.senhaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.senhaTextBox_KeyDown);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(299, 338);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.usernameTextBox.Properties.Appearance.Options.UseFont = true;
            this.usernameTextBox.Size = new System.Drawing.Size(182, 22);
            this.usernameTextBox.TabIndex = 21;
            // 
            // lbSenha
            // 
            this.lbSenha.Location = new System.Drawing.Point(253, 369);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(30, 13);
            this.lbSenha.TabIndex = 20;
            this.lbSenha.Text = "Senha";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Canaan.Telas.Properties.Resources.Splash;
            this.ClientSize = new System.Drawing.Size(743, 536);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutenticar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.lbSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticação de Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.senhaTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameTextBox.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private SimpleButton btnAutenticar;
        private SimpleButton btnSair;
        private TextEdit senhaTextBox;
        private TextEdit usernameTextBox;
        private LabelControl lbSenha;



    }
}