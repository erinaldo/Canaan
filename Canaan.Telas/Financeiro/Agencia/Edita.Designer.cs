using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Financeiro.Agencia
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.bancoComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cidadeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.idCidadeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.gerenteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.celularTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.telefoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idCidadeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.celularTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.groupControl1);
            this.panelEdit.Size = new System.Drawing.Size(328, 349);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bancoComboBox);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.cidadeLinkLabel);
            this.groupControl1.Controls.Add(this.idCidadeTextEdit);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.emailTextEdit);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.isAtivoCheckEdit);
            this.groupControl1.Controls.Add(this.gerenteTextEdit);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.celularTextEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.telefoneTextEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.nomeTextEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(10, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(5);
            this.groupControl1.Size = new System.Drawing.Size(308, 329);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Informações do Banco";
            // 
            // bancoComboBox
            // 
            this.bancoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bancoComboBox.FormattingEnabled = true;
            this.bancoComboBox.Location = new System.Drawing.Point(10, 48);
            this.bancoComboBox.Name = "bancoComboBox";
            this.bancoComboBox.Size = new System.Drawing.Size(276, 21);
            this.bancoComboBox.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 29);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Banco";
            // 
            // cidadeLinkLabel
            // 
            this.cidadeLinkLabel.AutoSize = true;
            this.cidadeLinkLabel.Location = new System.Drawing.Point(58, 97);
            this.cidadeLinkLabel.Name = "cidadeLinkLabel";
            this.cidadeLinkLabel.Size = new System.Drawing.Size(53, 13);
            this.cidadeLinkLabel.TabIndex = 13;
            this.cidadeLinkLabel.TabStop = true;
            this.cidadeLinkLabel.Text = "linkLabel1";
            this.cidadeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cidadeLinkLabel_LinkClicked);
            // 
            // idCidadeTextEdit
            // 
            this.idCidadeTextEdit.Enabled = false;
            this.idCidadeTextEdit.Location = new System.Drawing.Point(10, 94);
            this.idCidadeTextEdit.Name = "idCidadeTextEdit";
            this.idCidadeTextEdit.Properties.Mask.EditMask = "[99] 9999-9999";
            this.idCidadeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.idCidadeTextEdit.Size = new System.Drawing.Size(42, 20);
            this.idCidadeTextEdit.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Cidade";
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.Location = new System.Drawing.Point(10, 274);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(276, 20);
            this.emailTextEdit.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 255);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Email";
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(8, 300);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Status do registro é ativo";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(278, 19);
            this.isAtivoCheckEdit.TabIndex = 8;
            // 
            // gerenteTextEdit
            // 
            this.gerenteTextEdit.Location = new System.Drawing.Point(10, 229);
            this.gerenteTextEdit.Name = "gerenteTextEdit";
            this.gerenteTextEdit.Size = new System.Drawing.Size(276, 20);
            this.gerenteTextEdit.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 210);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Gerente";
            // 
            // celularTextEdit
            // 
            this.celularTextEdit.Location = new System.Drawing.Point(151, 184);
            this.celularTextEdit.Name = "celularTextEdit";
            this.celularTextEdit.Properties.Mask.EditMask = "[99] 9999-9999";
            this.celularTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.celularTextEdit.Size = new System.Drawing.Size(135, 20);
            this.celularTextEdit.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(151, 165);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Celular";
            // 
            // telefoneTextEdit
            // 
            this.telefoneTextEdit.Location = new System.Drawing.Point(10, 184);
            this.telefoneTextEdit.Name = "telefoneTextEdit";
            this.telefoneTextEdit.Properties.Mask.EditMask = "[99] 9999-9999";
            this.telefoneTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.telefoneTextEdit.Size = new System.Drawing.Size(135, 20);
            this.telefoneTextEdit.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 165);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Telefone";
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.Location = new System.Drawing.Point(10, 139);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(276, 20);
            this.nomeTextEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 120);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nome da Agência";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 382);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idCidadeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerenteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.celularTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupControl groupControl1;
        private ComboBox bancoComboBox;
        private LabelControl labelControl7;
        private LinkLabel cidadeLinkLabel;
        private TextEdit idCidadeTextEdit;
        private LabelControl labelControl6;
        private TextEdit emailTextEdit;
        private LabelControl labelControl5;
        private CheckEdit isAtivoCheckEdit;
        private TextEdit gerenteTextEdit;
        private LabelControl labelControl4;
        private TextEdit celularTextEdit;
        private LabelControl labelControl3;
        private TextEdit telefoneTextEdit;
        private LabelControl labelControl2;
        private TextEdit nomeTextEdit;
        private LabelControl labelControl1;
    }
}