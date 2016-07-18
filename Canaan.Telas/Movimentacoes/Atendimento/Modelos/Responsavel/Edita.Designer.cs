using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Movimentacoes.Atendimento.Modelos.Responsavel
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
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label idModeloLabel1;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label telefoneLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lkTipo = new System.Windows.Forms.LinkLabel();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.modeloRespBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lkModelo = new System.Windows.Forms.LinkLabel();
            this.idModeloTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.celularTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cpfTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.rgTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telefoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            celularLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            idModeloLabel1 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloRespBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idModeloTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celularTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabControl1);
            this.panelEdit.Size = new System.Drawing.Size(335, 309);
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(16, 193);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(40, 13);
            celularLabel.TabIndex = 1;
            celularLabel.Text = "Celular";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(16, 145);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(24, 13);
            cpfLabel.TabIndex = 3;
            cpfLabel.Text = "Cpf";
            // 
            // idModeloLabel1
            // 
            idModeloLabel1.AutoSize = true;
            idModeloLabel1.Location = new System.Drawing.Point(16, 13);
            idModeloLabel1.Name = "idModeloLabel1";
            idModeloLabel1.Size = new System.Drawing.Size(41, 13);
            idModeloLabel1.TabIndex = 5;
            idModeloLabel1.Text = "Modelo";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(16, 53);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(34, 13);
            nomeLabel.TabIndex = 9;
            nomeLabel.Text = "Nome";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(157, 145);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(20, 13);
            rgLabel.TabIndex = 11;
            rgLabel.Text = "Rg";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(157, 193);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(49, 13);
            telefoneLabel.TabIndex = 13;
            telefoneLabel.Text = "Telefone";
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
            this.tabControl1.Size = new System.Drawing.Size(310, 284);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.lkTipo);
            this.tabPage1.Controls.Add(this.tipoTextBox);
            this.tabPage1.Controls.Add(this.lkModelo);
            this.tabPage1.Controls.Add(this.idModeloTextEdit);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(celularLabel);
            this.tabPage1.Controls.Add(this.celularTextEdit);
            this.tabPage1.Controls.Add(cpfLabel);
            this.tabPage1.Controls.Add(this.cpfTextEdit);
            this.tabPage1.Controls.Add(idModeloLabel1);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextEdit);
            this.tabPage1.Controls.Add(rgLabel);
            this.tabPage1.Controls.Add(this.rgTextEdit);
            this.tabPage1.Controls.Add(telefoneLabel);
            this.tabPage1.Controls.Add(this.telefoneTextEdit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(302, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Responsável";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lkTipo
            // 
            this.lkTipo.AutoSize = true;
            this.lkTipo.Location = new System.Drawing.Point(146, 115);
            this.lkTipo.Name = "lkTipo";
            this.lkTipo.Size = new System.Drawing.Size(92, 13);
            this.lkTipo.TabIndex = 20;
            this.lkTipo.TabStop = true;
            this.lkTipo.Text = "Selecione um Tipo";
            this.lkTipo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkTipo_LinkClicked);
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modeloRespBindingSource, "Tipo", true));
            this.tipoTextBox.Enabled = false;
            this.tipoTextBox.Location = new System.Drawing.Point(19, 112);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(121, 21);
            this.tipoTextBox.TabIndex = 19;
            // 
            // modeloRespBindingSource
            // 
            this.modeloRespBindingSource.DataSource = typeof(Canaan.Dados.ModeloResp);
            // 
            // lkModelo
            // 
            this.lkModelo.AutoSize = true;
            this.lkModelo.Location = new System.Drawing.Point(85, 33);
            this.lkModelo.Name = "lkModelo";
            this.lkModelo.Size = new System.Drawing.Size(53, 13);
            this.lkModelo.TabIndex = 18;
            this.lkModelo.TabStop = true;
            this.lkModelo.Text = "linkLabel1";
            // 
            // idModeloTextEdit
            // 
            this.idModeloTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloRespBindingSource, "IdModelo", true));
            this.idModeloTextEdit.Enabled = false;
            this.idModeloTextEdit.Location = new System.Drawing.Point(19, 30);
            this.idModeloTextEdit.Name = "idModeloTextEdit";
            this.idModeloTextEdit.Size = new System.Drawing.Size(59, 20);
            this.idModeloTextEdit.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo";
            // 
            // celularTextEdit
            // 
            this.celularTextEdit.CausesValidation = false;
            this.celularTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloRespBindingSource, "Celular", true));
            this.celularTextEdit.Location = new System.Drawing.Point(19, 209);
            this.celularTextEdit.Name = "celularTextEdit";
            this.celularTextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.celularTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.celularTextEdit.Properties.Mask.SaveLiteral = false;
            this.celularTextEdit.Size = new System.Drawing.Size(121, 20);
            this.celularTextEdit.TabIndex = 2;
            // 
            // cpfTextEdit
            // 
            this.cpfTextEdit.CausesValidation = false;
            this.cpfTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloRespBindingSource, "Cpf", true));
            this.cpfTextEdit.Location = new System.Drawing.Point(19, 161);
            this.cpfTextEdit.Name = "cpfTextEdit";
            this.cpfTextEdit.Properties.Mask.EditMask = "999.999.999-99";
            this.cpfTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.cpfTextEdit.Properties.Mask.SaveLiteral = false;
            this.cpfTextEdit.Size = new System.Drawing.Size(121, 20);
            this.cpfTextEdit.TabIndex = 4;
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.CausesValidation = false;
            this.nomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloRespBindingSource, "Nome", true));
            this.nomeTextEdit.Location = new System.Drawing.Point(19, 70);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(262, 20);
            this.nomeTextEdit.TabIndex = 10;
            // 
            // rgTextEdit
            // 
            this.rgTextEdit.CausesValidation = false;
            this.rgTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloRespBindingSource, "Rg", true));
            this.rgTextEdit.Location = new System.Drawing.Point(160, 161);
            this.rgTextEdit.Name = "rgTextEdit";
            this.rgTextEdit.Size = new System.Drawing.Size(121, 20);
            this.rgTextEdit.TabIndex = 12;
            // 
            // telefoneTextEdit
            // 
            this.telefoneTextEdit.CausesValidation = false;
            this.telefoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modeloRespBindingSource, "Telefone", true));
            this.telefoneTextEdit.Location = new System.Drawing.Point(160, 209);
            this.telefoneTextEdit.Name = "telefoneTextEdit";
            this.telefoneTextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.telefoneTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.telefoneTextEdit.Properties.Mask.SaveLiteral = false;
            this.telefoneTextEdit.Size = new System.Drawing.Size(121, 20);
            this.telefoneTextEdit.TabIndex = 14;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(Canaan.Dados.Modelo);
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 342);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloRespBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idModeloTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celularTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextEdit celularTextEdit;
        private BindingSource modeloRespBindingSource;
        private TextEdit cpfTextEdit;
        private TextEdit nomeTextEdit;
        private TextEdit rgTextEdit;
        private TextEdit telefoneTextEdit;
        private Label label1;
        private BindingSource modeloBindingSource;
        private TextEdit idModeloTextEdit;
        private LinkLabel lkModelo;
        private TextBox tipoTextBox;
        private LinkLabel lkTipo;
    }
}