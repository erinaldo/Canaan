using System.ComponentModel;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Financeiro.Banco
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.abreviacaoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.numeroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.digitoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abreviacaoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.groupControl1);
            this.panelEdit.Size = new System.Drawing.Size(327, 266);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.isAtivoCheckEdit);
            this.groupControl1.Controls.Add(this.digitoTextEdit);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.numeroTextEdit);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.abreviacaoTextEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.nomeTextEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(10, 10);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(5);
            this.groupControl1.Size = new System.Drawing.Size(307, 246);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Informações do Banco";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nome do Banco";
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.Location = new System.Drawing.Point(10, 48);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(287, 20);
            this.nomeTextEdit.TabIndex = 1;
            // 
            // abreviacaoTextEdit
            // 
            this.abreviacaoTextEdit.Location = new System.Drawing.Point(10, 93);
            this.abreviacaoTextEdit.Name = "abreviacaoTextEdit";
            this.abreviacaoTextEdit.Size = new System.Drawing.Size(103, 20);
            this.abreviacaoTextEdit.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Abreviação";
            // 
            // numeroTextEdit
            // 
            this.numeroTextEdit.Location = new System.Drawing.Point(10, 138);
            this.numeroTextEdit.Name = "numeroTextEdit";
            this.numeroTextEdit.Size = new System.Drawing.Size(103, 20);
            this.numeroTextEdit.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Número";
            // 
            // digitoTextEdit
            // 
            this.digitoTextEdit.Location = new System.Drawing.Point(10, 183);
            this.digitoTextEdit.Name = "digitoTextEdit";
            this.digitoTextEdit.Size = new System.Drawing.Size(103, 20);
            this.digitoTextEdit.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 164);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Digito";
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(10, 209);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Status do registro é ativo";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(287, 19);
            this.isAtivoCheckEdit.TabIndex = 8;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 299);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abreviacaoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupControl groupControl1;
        private CheckEdit isAtivoCheckEdit;
        private TextEdit digitoTextEdit;
        private LabelControl labelControl4;
        private TextEdit numeroTextEdit;
        private LabelControl labelControl3;
        private TextEdit abreviacaoTextEdit;
        private LabelControl labelControl2;
        private TextEdit nomeTextEdit;
        private LabelControl labelControl1;
    }
}