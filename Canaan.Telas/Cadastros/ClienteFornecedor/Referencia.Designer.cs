using System.ComponentModel;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Cadastros.ClienteFornecedor
{
    partial class Referencia
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
            this.celularTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.telefoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.enderecoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celularTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.groupControl1);
            this.panelEdit.Size = new System.Drawing.Size(366, 280);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.celularTextEdit);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.telefoneTextEdit);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.enderecoTextEdit);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.nomeTextEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.tipoComboBox);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(10, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(5);
            this.groupControl1.Size = new System.Drawing.Size(346, 260);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Informações da Referência";
            // 
            // celularTextEdit
            // 
            this.celularTextEdit.Location = new System.Drawing.Point(10, 229);
            this.celularTextEdit.Name = "celularTextEdit";
            this.celularTextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.celularTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.celularTextEdit.Properties.Mask.SaveLiteral = false;
            this.celularTextEdit.Size = new System.Drawing.Size(103, 20);
            this.celularTextEdit.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 210);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(33, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Celular";
            // 
            // telefoneTextEdit
            // 
            this.telefoneTextEdit.Location = new System.Drawing.Point(10, 184);
            this.telefoneTextEdit.Name = "telefoneTextEdit";
            this.telefoneTextEdit.Properties.Mask.EditMask = "[99] 9999-99999";
            this.telefoneTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.telefoneTextEdit.Properties.Mask.SaveLiteral = false;
            this.telefoneTextEdit.Size = new System.Drawing.Size(103, 20);
            this.telefoneTextEdit.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 165);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Telefone";
            // 
            // enderecoTextEdit
            // 
            this.enderecoTextEdit.Location = new System.Drawing.Point(10, 139);
            this.enderecoTextEdit.Name = "enderecoTextEdit";
            this.enderecoTextEdit.Size = new System.Drawing.Size(326, 20);
            this.enderecoTextEdit.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Endereço";
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.Location = new System.Drawing.Point(10, 94);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(326, 20);
            this.nomeTextEdit.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Nome";
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(10, 48);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(189, 21);
            this.tipoComboBox.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tipo de Referência";
            // 
            // Referencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 313);
            this.Name = "Referencia";
            this.Text = "Referencia";
            this.Load += new System.EventHandler(this.Referencia_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celularTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enderecoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupControl groupControl1;
        private TextEdit celularTextEdit;
        private LabelControl labelControl6;
        private TextEdit telefoneTextEdit;
        private LabelControl labelControl5;
        private TextEdit enderecoTextEdit;
        private LabelControl labelControl4;
        private TextEdit nomeTextEdit;
        private LabelControl labelControl3;
        private ComboBox tipoComboBox;
        private LabelControl labelControl2;
    }
}