using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Seguranca.Usuario
{
    partial class Edita
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label sobrenomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label usernameLabel;
            this.usuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.isAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            sobrenomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.usuarioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.usuarioGroupBox);
            this.panelEdit.Size = new System.Drawing.Size(328, 310);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(5, 18);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome:";
            // 
            // sobrenomeLabel
            // 
            sobrenomeLabel.AutoSize = true;
            sobrenomeLabel.Location = new System.Drawing.Point(5, 57);
            sobrenomeLabel.Name = "sobrenomeLabel";
            sobrenomeLabel.Size = new System.Drawing.Size(65, 13);
            sobrenomeLabel.TabIndex = 2;
            sobrenomeLabel.Text = "Sobrenome:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(5, 96);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(5, 135);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(53, 13);
            telefoneLabel.TabIndex = 6;
            telefoneLabel.Text = "Telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(5, 174);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(44, 13);
            celularLabel.TabIndex = 8;
            celularLabel.Text = "Celular:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(5, 213);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(59, 13);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "Username:";
            // 
            // usuarioGroupBox
            // 
            this.usuarioGroupBox.Controls.Add(this.isAtivoCheckBox);
            this.usuarioGroupBox.Controls.Add(usernameLabel);
            this.usuarioGroupBox.Controls.Add(this.usernameTextBox);
            this.usuarioGroupBox.Controls.Add(celularLabel);
            this.usuarioGroupBox.Controls.Add(this.celularMaskedTextBox);
            this.usuarioGroupBox.Controls.Add(telefoneLabel);
            this.usuarioGroupBox.Controls.Add(this.telefoneMaskedTextBox);
            this.usuarioGroupBox.Controls.Add(emailLabel);
            this.usuarioGroupBox.Controls.Add(this.emailTextBox);
            this.usuarioGroupBox.Controls.Add(sobrenomeLabel);
            this.usuarioGroupBox.Controls.Add(this.sobrenomeTextBox);
            this.usuarioGroupBox.Controls.Add(nomeLabel);
            this.usuarioGroupBox.Controls.Add(this.nomeTextBox);
            this.usuarioGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuarioGroupBox.Location = new System.Drawing.Point(10, 10);
            this.usuarioGroupBox.Name = "usuarioGroupBox";
            this.usuarioGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.usuarioGroupBox.Size = new System.Drawing.Size(308, 290);
            this.usuarioGroupBox.TabIndex = 0;
            this.usuarioGroupBox.TabStop = false;
            this.usuarioGroupBox.Text = "Informações do Usuário";
            // 
            // isAtivoCheckBox
            // 
            this.isAtivoCheckBox.AutoSize = true;
            this.isAtivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioBindingSource, "IsAtivo", true));
            this.isAtivoCheckBox.Location = new System.Drawing.Point(8, 255);
            this.isAtivoCheckBox.Name = "isAtivoCheckBox";
            this.isAtivoCheckBox.Size = new System.Drawing.Size(148, 17);
            this.isAtivoCheckBox.TabIndex = 13;
            this.isAtivoCheckBox.Text = "Status do Usuário é Ativo";
            this.isAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Canaan.Dados.Usuario);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(8, 229);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(123, 21);
            this.usernameTextBox.TabIndex = 11;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(8, 190);
            this.celularMaskedTextBox.Mask = "[99] 9999-99999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(123, 21);
            this.celularMaskedTextBox.TabIndex = 9;
            this.celularMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(8, 151);
            this.telefoneMaskedTextBox.Mask = "[99] 9999-99999";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(123, 21);
            this.telefoneMaskedTextBox.TabIndex = 7;
            this.telefoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(8, 112);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(258, 21);
            this.emailTextBox.TabIndex = 5;
            // 
            // sobrenomeTextBox
            // 
            this.sobrenomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Sobrenome", true));
            this.sobrenomeTextBox.Location = new System.Drawing.Point(8, 73);
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            this.sobrenomeTextBox.Size = new System.Drawing.Size(258, 21);
            this.sobrenomeTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(8, 34);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(258, 21);
            this.nomeTextBox.TabIndex = 1;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 343);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            this.usuarioGroupBox.ResumeLayout(false);
            this.usuarioGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox usuarioGroupBox;
        private TextBox usernameTextBox;
        private BindingSource usuarioBindingSource;
        private MaskedTextBox celularMaskedTextBox;
        private MaskedTextBox telefoneMaskedTextBox;
        private TextBox emailTextBox;
        private TextBox sobrenomeTextBox;
        private TextBox nomeTextBox;
        private CheckBox isAtivoCheckBox;
    }
}