using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Marketing.Parceria
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
            System.Windows.Forms.Label contatoEmailLabel;
            System.Windows.Forms.Label contatoNomeLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label contatoTelLabel;
            System.Windows.Forms.Label contatoCelLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label dataFimLabel;
            System.Windows.Forms.Label dataInicioLabel;
            System.Windows.Forms.Label dataRetiradaLabel;
            this.parceriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contatoCelMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.contatoTelMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.convenioLabel = new System.Windows.Forms.LinkLabel();
            this.idConvenioTextBox = new System.Windows.Forms.TextBox();
            this.isRetiradaCheckBox = new System.Windows.Forms.CheckBox();
            this.isAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.contatoNomeTextBox = new System.Windows.Forms.TextBox();
            this.contatoEmailTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataRetiradaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.dataInicioDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.dataFimDateEdit = new DevExpress.XtraEditors.DateEdit();
            nomeLabel = new System.Windows.Forms.Label();
            contatoEmailLabel = new System.Windows.Forms.Label();
            contatoNomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            contatoTelLabel = new System.Windows.Forms.Label();
            contatoCelLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dataFimLabel = new System.Windows.Forms.Label();
            dataInicioLabel = new System.Windows.Forms.Label();
            dataRetiradaLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parceriaBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRetiradaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRetiradaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInicioDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInicioDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFimDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFimDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabControl1);
            this.panelEdit.Size = new System.Drawing.Size(502, 354);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(6, 3);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(34, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            // 
            // contatoEmailLabel
            // 
            contatoEmailLabel.AutoSize = true;
            contatoEmailLabel.Location = new System.Drawing.Point(6, 91);
            contatoEmailLabel.Name = "contatoEmailLabel";
            contatoEmailLabel.Size = new System.Drawing.Size(73, 13);
            contatoEmailLabel.TabIndex = 2;
            contatoEmailLabel.Text = "Contato Email";
            // 
            // contatoNomeLabel
            // 
            contatoNomeLabel.AutoSize = true;
            contatoNomeLabel.Location = new System.Drawing.Point(6, 48);
            contatoNomeLabel.Name = "contatoNomeLabel";
            contatoNomeLabel.Size = new System.Drawing.Size(91, 13);
            contatoNomeLabel.TabIndex = 4;
            contatoNomeLabel.Text = "Nome do Contato";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(6, 219);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(53, 13);
            descricaoLabel.TabIndex = 6;
            descricaoLabel.Text = "Descrição";
            // 
            // contatoTelLabel
            // 
            contatoTelLabel.AutoSize = true;
            contatoTelLabel.Location = new System.Drawing.Point(6, 130);
            contatoTelLabel.Name = "contatoTelLabel";
            contatoTelLabel.Size = new System.Drawing.Size(49, 13);
            contatoTelLabel.TabIndex = 31;
            contatoTelLabel.Text = "Telefone";
            // 
            // contatoCelLabel
            // 
            contatoCelLabel.AutoSize = true;
            contatoCelLabel.Location = new System.Drawing.Point(150, 130);
            contatoCelLabel.Name = "contatoCelLabel";
            contatoCelLabel.Size = new System.Drawing.Size(68, 13);
            contatoCelLabel.TabIndex = 32;
            contatoCelLabel.Text = "Contato Cel:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 175);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 34;
            label1.Text = "Convênio";
            // 
            // dataFimLabel
            // 
            dataFimLabel.AutoSize = true;
            dataFimLabel.Location = new System.Drawing.Point(8, 61);
            dataFimLabel.Name = "dataFimLabel";
            dataFimLabel.Size = new System.Drawing.Size(49, 13);
            dataFimLabel.TabIndex = 0;
            dataFimLabel.Text = "Data Fim";
            // 
            // dataInicioLabel
            // 
            dataInicioLabel.AutoSize = true;
            dataInicioLabel.Location = new System.Drawing.Point(6, 19);
            dataInicioLabel.Name = "dataInicioLabel";
            dataInicioLabel.Size = new System.Drawing.Size(62, 13);
            dataInicioLabel.TabIndex = 2;
            dataInicioLabel.Text = "Data Inicio:";
            // 
            // dataRetiradaLabel
            // 
            dataRetiradaLabel.AutoSize = true;
            dataRetiradaLabel.Location = new System.Drawing.Point(9, 121);
            dataRetiradaLabel.Name = "dataRetiradaLabel";
            dataRetiradaLabel.Size = new System.Drawing.Size(78, 13);
            dataRetiradaLabel.TabIndex = 4;
            dataRetiradaLabel.Text = "Data Retirada:";
            // 
            // parceriaBindingSource
            // 
            this.parceriaBindingSource.DataSource = typeof(Canaan.Dados.Parceria);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(contatoCelLabel);
            this.tabPage1.Controls.Add(this.contatoCelMaskedTextBox);
            this.tabPage1.Controls.Add(contatoTelLabel);
            this.tabPage1.Controls.Add(this.contatoTelMaskedTextBox);
            this.tabPage1.Controls.Add(this.convenioLabel);
            this.tabPage1.Controls.Add(this.idConvenioTextBox);
            this.tabPage1.Controls.Add(this.isRetiradaCheckBox);
            this.tabPage1.Controls.Add(this.isAtivoCheckBox);
            this.tabPage1.Controls.Add(descricaoLabel);
            this.tabPage1.Controls.Add(this.descricaoTextBox);
            this.tabPage1.Controls.Add(contatoNomeLabel);
            this.tabPage1.Controls.Add(this.contatoNomeTextBox);
            this.tabPage1.Controls.Add(contatoEmailLabel);
            this.tabPage1.Controls.Add(this.contatoEmailTextBox);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações Gerais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contatoCelMaskedTextBox
            // 
            this.contatoCelMaskedTextBox.CausesValidation = false;
            this.contatoCelMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceriaBindingSource, "ContatoCel", true));
            this.contatoCelMaskedTextBox.Location = new System.Drawing.Point(153, 146);
            this.contatoCelMaskedTextBox.Mask = "[99] 9999-99999";
            this.contatoCelMaskedTextBox.Name = "contatoCelMaskedTextBox";
            this.contatoCelMaskedTextBox.Size = new System.Drawing.Size(136, 21);
            this.contatoCelMaskedTextBox.TabIndex = 5;
            this.contatoCelMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // contatoTelMaskedTextBox
            // 
            this.contatoTelMaskedTextBox.CausesValidation = false;
            this.contatoTelMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceriaBindingSource, "ContatoTel", true));
            this.contatoTelMaskedTextBox.Location = new System.Drawing.Point(9, 146);
            this.contatoTelMaskedTextBox.Mask = "[99] 9999-99999";
            this.contatoTelMaskedTextBox.Name = "contatoTelMaskedTextBox";
            this.contatoTelMaskedTextBox.Size = new System.Drawing.Size(131, 21);
            this.contatoTelMaskedTextBox.TabIndex = 4;
            this.contatoTelMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // convenioLabel
            // 
            this.convenioLabel.AutoSize = true;
            this.convenioLabel.Location = new System.Drawing.Point(67, 194);
            this.convenioLabel.Name = "convenioLabel";
            this.convenioLabel.Size = new System.Drawing.Size(100, 13);
            this.convenioLabel.TabIndex = 12;
            this.convenioLabel.TabStop = true;
            this.convenioLabel.Text = "Selecione Convênio";
            this.convenioLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.convenioLabel_LinkClicked);
            // 
            // idConvenioTextBox
            // 
            this.idConvenioTextBox.CausesValidation = false;
            this.idConvenioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceriaBindingSource, "IdConvenio", true));
            this.idConvenioTextBox.Enabled = false;
            this.idConvenioTextBox.Location = new System.Drawing.Point(9, 191);
            this.idConvenioTextBox.Name = "idConvenioTextBox";
            this.idConvenioTextBox.Size = new System.Drawing.Size(52, 21);
            this.idConvenioTextBox.TabIndex = 6;
            // 
            // isRetiradaCheckBox
            // 
            this.isRetiradaCheckBox.CausesValidation = false;
            this.isRetiradaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.parceriaBindingSource, "IsRetirada", true));
            this.isRetiradaCheckBox.Location = new System.Drawing.Point(304, 265);
            this.isRetiradaCheckBox.Name = "isRetiradaCheckBox";
            this.isRetiradaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isRetiradaCheckBox.TabIndex = 12;
            this.isRetiradaCheckBox.Text = "Retirada";
            this.isRetiradaCheckBox.UseVisualStyleBackColor = true;
            // 
            // isAtivoCheckBox
            // 
            this.isAtivoCheckBox.CausesValidation = false;
            this.isAtivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.parceriaBindingSource, "IsAtivo", true));
            this.isAtivoCheckBox.Location = new System.Drawing.Point(304, 241);
            this.isAtivoCheckBox.Name = "isAtivoCheckBox";
            this.isAtivoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isAtivoCheckBox.TabIndex = 11;
            this.isAtivoCheckBox.Text = "Status";
            this.isAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.CausesValidation = false;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceriaBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(9, 235);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(280, 62);
            this.descricaoTextBox.TabIndex = 7;
            // 
            // contatoNomeTextBox
            // 
            this.contatoNomeTextBox.CausesValidation = false;
            this.contatoNomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceriaBindingSource, "ContatoNome", true));
            this.contatoNomeTextBox.Location = new System.Drawing.Point(9, 64);
            this.contatoNomeTextBox.Name = "contatoNomeTextBox";
            this.contatoNomeTextBox.Size = new System.Drawing.Size(280, 21);
            this.contatoNomeTextBox.TabIndex = 2;
            // 
            // contatoEmailTextBox
            // 
            this.contatoEmailTextBox.CausesValidation = false;
            this.contatoEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceriaBindingSource, "ContatoEmail", true));
            this.contatoEmailTextBox.Location = new System.Drawing.Point(9, 107);
            this.contatoEmailTextBox.Name = "contatoEmailTextBox";
            this.contatoEmailTextBox.Size = new System.Drawing.Size(280, 21);
            this.contatoEmailTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CausesValidation = false;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.parceriaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(9, 19);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(280, 21);
            this.nomeTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(dataRetiradaLabel);
            this.groupBox1.Controls.Add(this.dataRetiradaDateEdit);
            this.groupBox1.Controls.Add(dataInicioLabel);
            this.groupBox1.Controls.Add(this.dataInicioDateEdit);
            this.groupBox1.Controls.Add(dataFimLabel);
            this.groupBox1.Controls.Add(this.dataFimDateEdit);
            this.groupBox1.Location = new System.Drawing.Point(295, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(170, 171);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vigência";
            // 
            // dataRetiradaDateEdit
            // 
            this.dataRetiradaDateEdit.CausesValidation = false;
            this.dataRetiradaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.parceriaBindingSource, "DataRetirada", true));
            this.dataRetiradaDateEdit.EditValue = null;
            this.dataRetiradaDateEdit.Location = new System.Drawing.Point(11, 137);
            this.dataRetiradaDateEdit.Name = "dataRetiradaDateEdit";
            this.dataRetiradaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataRetiradaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataRetiradaDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataRetiradaDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataRetiradaDateEdit.Size = new System.Drawing.Size(153, 20);
            this.dataRetiradaDateEdit.TabIndex = 10;
            // 
            // dataInicioDateEdit
            // 
            this.dataInicioDateEdit.CausesValidation = false;
            this.dataInicioDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.parceriaBindingSource, "DataInicio", true));
            this.dataInicioDateEdit.EditValue = null;
            this.dataInicioDateEdit.Location = new System.Drawing.Point(9, 35);
            this.dataInicioDateEdit.Name = "dataInicioDateEdit";
            this.dataInicioDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataInicioDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataInicioDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataInicioDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataInicioDateEdit.Size = new System.Drawing.Size(153, 20);
            this.dataInicioDateEdit.TabIndex = 8;
            // 
            // dataFimDateEdit
            // 
            this.dataFimDateEdit.CausesValidation = false;
            this.dataFimDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.parceriaBindingSource, "DataFim", true));
            this.dataFimDateEdit.EditValue = null;
            this.dataFimDateEdit.Location = new System.Drawing.Point(9, 82);
            this.dataFimDateEdit.Name = "dataFimDateEdit";
            this.dataFimDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataFimDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataFimDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataFimDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataFimDateEdit.Size = new System.Drawing.Size(154, 20);
            this.dataFimDateEdit.TabIndex = 9;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 387);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parceriaBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRetiradaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRetiradaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInicioDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataInicioDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFimDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataFimDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource parceriaBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox nomeTextBox;
        private TextBox contatoEmailTextBox;
        private CheckBox isRetiradaCheckBox;
        private CheckBox isAtivoCheckBox;
        private TextBox descricaoTextBox;
        private TextBox contatoNomeTextBox;
        private LinkLabel convenioLabel;
        private TextBox idConvenioTextBox;
        private GroupBox groupBox1;
        private MaskedTextBox contatoCelMaskedTextBox;
        private MaskedTextBox contatoTelMaskedTextBox;
        private DateEdit dataFimDateEdit;
        private DateEdit dataRetiradaDateEdit;
        private DateEdit dataInicioDateEdit;

    }
}