using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Configuracoes.Pedido.Tabela
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
            System.Windows.Forms.Label competenciaLabel;
            this.tabelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.competenciaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            nomeLabel = new System.Windows.Forms.Label();
            competenciaLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenciaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabControl1);
            this.panelEdit.Size = new System.Drawing.Size(349, 196);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(15, 19);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(34, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            // 
            // competenciaLabel
            // 
            competenciaLabel.AutoSize = true;
            competenciaLabel.Location = new System.Drawing.Point(15, 68);
            competenciaLabel.Name = "competenciaLabel";
            competenciaLabel.Size = new System.Drawing.Size(69, 13);
            competenciaLabel.TabIndex = 2;
            competenciaLabel.Text = "Competencia";
            // 
            // tabelaBindingSource
            // 
            this.tabelaBindingSource.DataSource = typeof(Canaan.Dados.Tabela);
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
            this.tabControl1.Size = new System.Drawing.Size(323, 171);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.isAtivoCheckEdit);
            this.tabPage1.Controls.Add(this.competenciaTextEdit);
            this.tabPage1.Controls.Add(competenciaLabel);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextEdit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(315, 145);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabela";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tabelaBindingSource, "IsAtivo", true));
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(225, 93);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Ativo";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isAtivoCheckEdit.TabIndex = 2;
            // 
            // competenciaTextEdit
            // 
            this.competenciaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tabelaBindingSource, "Competencia", true));
            this.competenciaTextEdit.Location = new System.Drawing.Point(18, 93);
            this.competenciaTextEdit.Name = "competenciaTextEdit";
            this.competenciaTextEdit.Size = new System.Drawing.Size(125, 20);
            this.competenciaTextEdit.TabIndex = 1;
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tabelaBindingSource, "Nome", true));
            this.nomeTextEdit.Location = new System.Drawing.Point(18, 35);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(282, 20);
            this.nomeTextEdit.TabIndex = 0;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 229);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competenciaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource tabelaBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextEdit nomeTextEdit;
        private TextEdit competenciaTextEdit;
        private CheckEdit isAtivoCheckEdit;
    }
}