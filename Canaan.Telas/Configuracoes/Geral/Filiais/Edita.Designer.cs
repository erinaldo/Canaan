using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Geral.Filiais
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
            System.Windows.Forms.Label idGrupoEmpresaLabel;
            System.Windows.Forms.Label razaoSocialLabel;
            System.Windows.Forms.Label nomeFantasiaLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label complementoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label idCidadeLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label faxLabel;
            this.filialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabEdita = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.isAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomeFantasiaTextBox = new System.Windows.Forms.TextBox();
            this.razaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.idGrupoEmpresaComboBox = new System.Windows.Forms.ComboBox();
            this.grupoEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.idCidadeTextBox = new System.Windows.Forms.TextBox();
            this.nomeCidadeLabel = new System.Windows.Forms.LinkLabel();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.faxMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            idGrupoEmpresaLabel = new System.Windows.Forms.Label();
            razaoSocialLabel = new System.Windows.Forms.Label();
            nomeFantasiaLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            complementoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            idCidadeLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).BeginInit();
            this.tabEdita.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoEmpresaBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabEdita);
            this.panelEdit.Size = new System.Drawing.Size(371, 239);
            // 
            // idGrupoEmpresaLabel
            // 
            idGrupoEmpresaLabel.AutoSize = true;
            idGrupoEmpresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idGrupoEmpresaLabel.Location = new System.Drawing.Point(8, 5);
            idGrupoEmpresaLabel.Name = "idGrupoEmpresaLabel";
            idGrupoEmpresaLabel.Size = new System.Drawing.Size(95, 13);
            idGrupoEmpresaLabel.TabIndex = 0;
            idGrupoEmpresaLabel.Text = "Grupo de Empresa";
            // 
            // razaoSocialLabel
            // 
            razaoSocialLabel.AutoSize = true;
            razaoSocialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            razaoSocialLabel.Location = new System.Drawing.Point(8, 45);
            razaoSocialLabel.Name = "razaoSocialLabel";
            razaoSocialLabel.Size = new System.Drawing.Size(70, 13);
            razaoSocialLabel.TabIndex = 2;
            razaoSocialLabel.Text = "Razão Social";
            // 
            // nomeFantasiaLabel
            // 
            nomeFantasiaLabel.AutoSize = true;
            nomeFantasiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeFantasiaLabel.Location = new System.Drawing.Point(8, 84);
            nomeFantasiaLabel.Name = "nomeFantasiaLabel";
            nomeFantasiaLabel.Size = new System.Drawing.Size(78, 13);
            nomeFantasiaLabel.TabIndex = 4;
            nomeFantasiaLabel.Text = "Nome Fantasia";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(8, 123);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(32, 13);
            cnpjLabel.TabIndex = 6;
            cnpjLabel.Text = "CNPJ";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(8, 5);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(52, 13);
            enderecoLabel.TabIndex = 0;
            enderecoLabel.Text = "Endereço";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(8, 44);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(48, 13);
            numeroLabel.TabIndex = 2;
            numeroLabel.Text = "Numero:";
            // 
            // complementoLabel
            // 
            complementoLabel.AutoSize = true;
            complementoLabel.Location = new System.Drawing.Point(159, 44);
            complementoLabel.Name = "complementoLabel";
            complementoLabel.Size = new System.Drawing.Size(76, 13);
            complementoLabel.TabIndex = 4;
            complementoLabel.Text = "Complemento:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(8, 83);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(39, 13);
            bairroLabel.TabIndex = 6;
            bairroLabel.Text = "Bairro:";
            // 
            // idCidadeLabel
            // 
            idCidadeLabel.AutoSize = true;
            idCidadeLabel.Location = new System.Drawing.Point(8, 122);
            idCidadeLabel.Name = "idCidadeLabel";
            idCidadeLabel.Size = new System.Drawing.Size(40, 13);
            idCidadeLabel.TabIndex = 8;
            idCidadeLabel.Text = "Cidade";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(159, 83);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(30, 13);
            cepLabel.TabIndex = 10;
            cepLabel.Text = "Cep:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(8, 5);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(8, 44);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(53, 13);
            telefoneLabel.TabIndex = 2;
            telefoneLabel.Text = "Telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(8, 83);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(44, 13);
            celularLabel.TabIndex = 4;
            celularLabel.Text = "Celular:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(8, 122);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(29, 13);
            faxLabel.TabIndex = 6;
            faxLabel.Text = "Fax:";
            // 
            // filialBindingSource
            // 
            this.filialBindingSource.DataSource = typeof(Canaan.Dados.Filial);
            // 
            // tabEdita
            // 
            this.tabEdita.Controls.Add(this.tabPage1);
            this.tabEdita.Controls.Add(this.tabPage2);
            this.tabEdita.Controls.Add(this.tabPage3);
            this.tabEdita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEdita.Location = new System.Drawing.Point(10, 10);
            this.tabEdita.Name = "tabEdita";
            this.tabEdita.SelectedIndex = 0;
            this.tabEdita.Size = new System.Drawing.Size(351, 219);
            this.tabEdita.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.isAtivoCheckBox);
            this.tabPage1.Controls.Add(cnpjLabel);
            this.tabPage1.Controls.Add(this.cnpjMaskedTextBox);
            this.tabPage1.Controls.Add(nomeFantasiaLabel);
            this.tabPage1.Controls.Add(this.nomeFantasiaTextBox);
            this.tabPage1.Controls.Add(razaoSocialLabel);
            this.tabPage1.Controls.Add(this.razaoSocialTextBox);
            this.tabPage1.Controls.Add(idGrupoEmpresaLabel);
            this.tabPage1.Controls.Add(this.idGrupoEmpresaComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(343, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações Gerais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // isAtivoCheckBox
            // 
            this.isAtivoCheckBox.AutoSize = true;
            this.isAtivoCheckBox.CausesValidation = false;
            this.isAtivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.filialBindingSource, "IsAtivo", true));
            this.isAtivoCheckBox.Location = new System.Drawing.Point(11, 165);
            this.isAtivoCheckBox.Name = "isAtivoCheckBox";
            this.isAtivoCheckBox.Size = new System.Drawing.Size(97, 17);
            this.isAtivoCheckBox.TabIndex = 9;
            this.isAtivoCheckBox.Text = "Filial está ativa";
            this.isAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // cnpjMaskedTextBox
            // 
            this.cnpjMaskedTextBox.CausesValidation = false;
            this.cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Cnpj", true));
            this.cnpjMaskedTextBox.Location = new System.Drawing.Point(8, 139);
            this.cnpjMaskedTextBox.Mask = "99,999,999/9999-99";
            this.cnpjMaskedTextBox.Name = "cnpjMaskedTextBox";
            this.cnpjMaskedTextBox.Size = new System.Drawing.Size(131, 21);
            this.cnpjMaskedTextBox.TabIndex = 7;
            this.cnpjMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // nomeFantasiaTextBox
            // 
            this.nomeFantasiaTextBox.CausesValidation = false;
            this.nomeFantasiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "NomeFantasia", true));
            this.nomeFantasiaTextBox.Location = new System.Drawing.Point(8, 100);
            this.nomeFantasiaTextBox.Name = "nomeFantasiaTextBox";
            this.nomeFantasiaTextBox.Size = new System.Drawing.Size(314, 21);
            this.nomeFantasiaTextBox.TabIndex = 5;
            // 
            // razaoSocialTextBox
            // 
            this.razaoSocialTextBox.CausesValidation = false;
            this.razaoSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "RazaoSocial", true));
            this.razaoSocialTextBox.Location = new System.Drawing.Point(8, 61);
            this.razaoSocialTextBox.Name = "razaoSocialTextBox";
            this.razaoSocialTextBox.Size = new System.Drawing.Size(314, 21);
            this.razaoSocialTextBox.TabIndex = 3;
            // 
            // idGrupoEmpresaComboBox
            // 
            this.idGrupoEmpresaComboBox.CausesValidation = false;
            this.idGrupoEmpresaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.filialBindingSource, "IdGrupoEmpresa", true));
            this.idGrupoEmpresaComboBox.DataSource = this.grupoEmpresaBindingSource;
            this.idGrupoEmpresaComboBox.DisplayMember = "Nome";
            this.idGrupoEmpresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idGrupoEmpresaComboBox.FormattingEnabled = true;
            this.idGrupoEmpresaComboBox.Location = new System.Drawing.Point(8, 21);
            this.idGrupoEmpresaComboBox.Name = "idGrupoEmpresaComboBox";
            this.idGrupoEmpresaComboBox.Size = new System.Drawing.Size(314, 21);
            this.idGrupoEmpresaComboBox.TabIndex = 1;
            this.idGrupoEmpresaComboBox.ValueMember = "IdGrupoEmpresa";
            // 
            // grupoEmpresaBindingSource
            // 
            this.grupoEmpresaBindingSource.DataSource = typeof(Canaan.Dados.GrupoEmpresa);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.idCidadeTextBox);
            this.tabPage2.Controls.Add(this.nomeCidadeLabel);
            this.tabPage2.Controls.Add(cepLabel);
            this.tabPage2.Controls.Add(this.cepMaskedTextBox);
            this.tabPage2.Controls.Add(idCidadeLabel);
            this.tabPage2.Controls.Add(bairroLabel);
            this.tabPage2.Controls.Add(this.bairroTextBox);
            this.tabPage2.Controls.Add(complementoLabel);
            this.tabPage2.Controls.Add(this.complementoTextBox);
            this.tabPage2.Controls.Add(numeroLabel);
            this.tabPage2.Controls.Add(this.numeroTextBox);
            this.tabPage2.Controls.Add(enderecoLabel);
            this.tabPage2.Controls.Add(this.enderecoTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(454, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Endereço";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // idCidadeTextBox
            // 
            this.idCidadeTextBox.CausesValidation = false;
            this.idCidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "IdCidade", true));
            this.idCidadeTextBox.Enabled = false;
            this.idCidadeTextBox.Location = new System.Drawing.Point(8, 138);
            this.idCidadeTextBox.Name = "idCidadeTextBox";
            this.idCidadeTextBox.Size = new System.Drawing.Size(53, 21);
            this.idCidadeTextBox.TabIndex = 14;
            // 
            // nomeCidadeLabel
            // 
            this.nomeCidadeLabel.AutoSize = true;
            this.nomeCidadeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Cidade.Nome", true));
            this.nomeCidadeLabel.Location = new System.Drawing.Point(67, 141);
            this.nomeCidadeLabel.Name = "nomeCidadeLabel";
            this.nomeCidadeLabel.Size = new System.Drawing.Size(53, 13);
            this.nomeCidadeLabel.TabIndex = 13;
            this.nomeCidadeLabel.TabStop = true;
            this.nomeCidadeLabel.Text = "linkLabel1";
            this.nomeCidadeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nomeCidadeLabel_LinkClicked);
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.CausesValidation = false;
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Cep", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(162, 99);
            this.cepMaskedTextBox.Mask = "99,999-999";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(158, 21);
            this.cepMaskedTextBox.TabIndex = 11;
            this.cepMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.CausesValidation = false;
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(8, 99);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(148, 21);
            this.bairroTextBox.TabIndex = 7;
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.CausesValidation = false;
            this.complementoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Complemento", true));
            this.complementoTextBox.Location = new System.Drawing.Point(162, 60);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(158, 21);
            this.complementoTextBox.TabIndex = 5;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.CausesValidation = false;
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(8, 60);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(148, 21);
            this.numeroTextBox.TabIndex = 3;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.CausesValidation = false;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(8, 21);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(312, 21);
            this.enderecoTextBox.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(faxLabel);
            this.tabPage3.Controls.Add(this.faxMaskedTextBox);
            this.tabPage3.Controls.Add(celularLabel);
            this.tabPage3.Controls.Add(this.celularMaskedTextBox);
            this.tabPage3.Controls.Add(telefoneLabel);
            this.tabPage3.Controls.Add(this.telefoneMaskedTextBox);
            this.tabPage3.Controls.Add(emailLabel);
            this.tabPage3.Controls.Add(this.emailTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage3.Size = new System.Drawing.Size(454, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contato";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // faxMaskedTextBox
            // 
            this.faxMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Fax", true));
            this.faxMaskedTextBox.Location = new System.Drawing.Point(8, 138);
            this.faxMaskedTextBox.Mask = "[99] 9999-99999";
            this.faxMaskedTextBox.Name = "faxMaskedTextBox";
            this.faxMaskedTextBox.Size = new System.Drawing.Size(103, 21);
            this.faxMaskedTextBox.TabIndex = 7;
            this.faxMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(8, 99);
            this.celularMaskedTextBox.Mask = "[99] 9999-99999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(103, 21);
            this.celularMaskedTextBox.TabIndex = 5;
            this.celularMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(8, 60);
            this.telefoneMaskedTextBox.Mask = "[99] 9999-99999";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(103, 21);
            this.telefoneMaskedTextBox.TabIndex = 3;
            this.telefoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(8, 21);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(312, 21);
            this.emailTextBox.TabIndex = 1;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 272);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).EndInit();
            this.tabEdita.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoEmpresaBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource filialBindingSource;
        private TabControl tabEdita;
        private TabPage tabPage1;
        private CheckBox isAtivoCheckBox;
        private MaskedTextBox cnpjMaskedTextBox;
        private TextBox nomeFantasiaTextBox;
        private TextBox razaoSocialTextBox;
        private ComboBox idGrupoEmpresaComboBox;
        private BindingSource grupoEmpresaBindingSource;
        private TabPage tabPage2;
        private MaskedTextBox cepMaskedTextBox;
        private TextBox bairroTextBox;
        private TextBox complementoTextBox;
        private TextBox numeroTextBox;
        private TextBox enderecoTextBox;
        private TabPage tabPage3;
        private MaskedTextBox faxMaskedTextBox;
        private MaskedTextBox celularMaskedTextBox;
        private MaskedTextBox telefoneMaskedTextBox;
        private TextBox emailTextBox;
        private LinkLabel nomeCidadeLabel;
        private TextBox idCidadeTextBox;
    }
}