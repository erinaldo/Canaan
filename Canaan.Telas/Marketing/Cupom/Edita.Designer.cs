using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Marketing.Cupom
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
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idParceriaLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label dataPreenchimentoLabel;
            System.Windows.Forms.Label dataLabel;
            this.cupomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.dataPreenchimentoDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.isAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.parceriaLabel = new System.Windows.Forms.LinkLabel();
            this.idParceriaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idParceriaLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            dataPreenchimentoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cupomBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreenchimentoDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabControl1);
            this.panelEdit.Size = new System.Drawing.Size(424, 479);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(4, 7);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(34, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(4, 50);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(52, 13);
            enderecoLabel.TabIndex = 2;
            enderecoLabel.Text = "Endereco";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(4, 95);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(40, 13);
            celularLabel.TabIndex = 4;
            celularLabel.Text = "Celular";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(182, 95);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(49, 13);
            telefoneLabel.TabIndex = 6;
            telefoneLabel.Text = "Telefone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(9, 147);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(31, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            // 
            // idParceriaLabel
            // 
            idParceriaLabel.AutoSize = true;
            idParceriaLabel.Location = new System.Drawing.Point(179, 235);
            idParceriaLabel.Name = "idParceriaLabel";
            idParceriaLabel.Size = new System.Drawing.Size(46, 13);
            idParceriaLabel.TabIndex = 10;
            idParceriaLabel.Text = "Parceria";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(9, 275);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(26, 13);
            obsLabel.TabIndex = 13;
            obsLabel.Text = "Obs";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(9, 235);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "Status";
            // 
            // dataPreenchimentoLabel
            // 
            dataPreenchimentoLabel.AutoSize = true;
            dataPreenchimentoLabel.Location = new System.Drawing.Point(182, 187);
            dataPreenchimentoLabel.Name = "dataPreenchimentoLabel";
            dataPreenchimentoLabel.Size = new System.Drawing.Size(108, 13);
            dataPreenchimentoLabel.TabIndex = 18;
            dataPreenchimentoLabel.Text = "Data Preenchimento:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(9, 187);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(30, 13);
            dataLabel.TabIndex = 20;
            dataLabel.Text = "Data";
            // 
            // cupomBindingSource
            // 
            this.cupomBindingSource.DataSource = typeof(Canaan.Dados.Cupom);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(403, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(dataLabel);
            this.tabPage1.Controls.Add(this.dataDateEdit);
            this.tabPage1.Controls.Add(dataPreenchimentoLabel);
            this.tabPage1.Controls.Add(this.dataPreenchimentoDateEdit);
            this.tabPage1.Controls.Add(statusLabel);
            this.tabPage1.Controls.Add(this.statusTextBox);
            this.tabPage1.Controls.Add(this.isAtivoCheckBox);
            this.tabPage1.Controls.Add(obsLabel);
            this.tabPage1.Controls.Add(this.obsTextBox);
            this.tabPage1.Controls.Add(this.parceriaLabel);
            this.tabPage1.Controls.Add(idParceriaLabel);
            this.tabPage1.Controls.Add(this.idParceriaTextBox);
            this.tabPage1.Controls.Add(emailLabel);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(telefoneLabel);
            this.tabPage1.Controls.Add(this.telefoneMaskedTextBox);
            this.tabPage1.Controls.Add(celularLabel);
            this.tabPage1.Controls.Add(this.celularMaskedTextBox);
            this.tabPage1.Controls.Add(enderecoLabel);
            this.tabPage1.Controls.Add(this.enderecoTextBox);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações do Cupom";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataDateEdit
            // 
            this.dataDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cupomBindingSource, "Data", true));
            this.dataDateEdit.EditValue = null;
            this.dataDateEdit.Enabled = false;
            this.dataDateEdit.Location = new System.Drawing.Point(12, 203);
            this.dataDateEdit.Name = "dataDateEdit";
            this.dataDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataDateEdit.Size = new System.Drawing.Size(167, 20);
            this.dataDateEdit.TabIndex = 10;
            // 
            // dataPreenchimentoDateEdit
            // 
            this.dataPreenchimentoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cupomBindingSource, "DataPreenchimento", true));
            this.dataPreenchimentoDateEdit.EditValue = null;
            this.dataPreenchimentoDateEdit.Location = new System.Drawing.Point(185, 203);
            this.dataPreenchimentoDateEdit.Name = "dataPreenchimentoDateEdit";
            this.dataPreenchimentoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataPreenchimentoDateEdit.Size = new System.Drawing.Size(170, 20);
            this.dataPreenchimentoDateEdit.TabIndex = 11;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Status", true));
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(12, 251);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(145, 21);
            this.statusTextBox.TabIndex = 13;
            // 
            // isAtivoCheckBox
            // 
            this.isAtivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cupomBindingSource, "IsAtivo", true));
            this.isAtivoCheckBox.Location = new System.Drawing.Point(6, 374);
            this.isAtivoCheckBox.Name = "isAtivoCheckBox";
            this.isAtivoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isAtivoCheckBox.TabIndex = 16;
            this.isAtivoCheckBox.Text = "Status";
            this.isAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // obsTextBox
            // 
            this.obsTextBox.CausesValidation = false;
            this.obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Obs", true));
            this.obsTextBox.Location = new System.Drawing.Point(12, 291);
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(343, 77);
            this.obsTextBox.TabIndex = 15;
            // 
            // parceriaLabel
            // 
            this.parceriaLabel.AutoSize = true;
            this.parceriaLabel.Location = new System.Drawing.Point(232, 254);
            this.parceriaLabel.Name = "parceriaLabel";
            this.parceriaLabel.Size = new System.Drawing.Size(103, 13);
            this.parceriaLabel.TabIndex = 12;
            this.parceriaLabel.TabStop = true;
            this.parceriaLabel.Text = "Selecione a Parceria";
            this.parceriaLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.convenioLabel_LinkClicked);
            // 
            // idParceriaTextBox
            // 
            this.idParceriaTextBox.CausesValidation = false;
            this.idParceriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "IdParceria", true));
            this.idParceriaTextBox.Enabled = false;
            this.idParceriaTextBox.Location = new System.Drawing.Point(182, 251);
            this.idParceriaTextBox.Name = "idParceriaTextBox";
            this.idParceriaTextBox.Size = new System.Drawing.Size(44, 21);
            this.idParceriaTextBox.TabIndex = 14;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CausesValidation = false;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(12, 163);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(343, 21);
            this.emailTextBox.TabIndex = 9;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.CausesValidation = false;
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(185, 114);
            this.telefoneMaskedTextBox.Mask = "[99] 9999-99999";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(150, 21);
            this.telefoneMaskedTextBox.TabIndex = 7;
            this.telefoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.CausesValidation = false;
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(7, 114);
            this.celularMaskedTextBox.Mask = "[99] 9999-99999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(150, 21);
            this.celularMaskedTextBox.TabIndex = 5;
            this.celularMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.CausesValidation = false;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(7, 66);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(348, 21);
            this.enderecoTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CausesValidation = false;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(7, 23);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(348, 21);
            this.nomeTextBox.TabIndex = 1;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 512);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cupomBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreenchimentoDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource cupomBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox nomeTextBox;
        private TextBox enderecoTextBox;
        private MaskedTextBox celularMaskedTextBox;
        private MaskedTextBox telefoneMaskedTextBox;
        private TextBox emailTextBox;
        private LinkLabel parceriaLabel;
        private TextBox idParceriaTextBox;
        private TextBox obsTextBox;
        private CheckBox isAtivoCheckBox;
        private TextBox statusTextBox;
        private DateEdit dataPreenchimentoDateEdit;
        private DateEdit dataDateEdit;
    }
}