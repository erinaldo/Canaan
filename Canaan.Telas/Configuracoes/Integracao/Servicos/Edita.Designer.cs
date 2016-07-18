using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Configuracoes.Integracao.Servicos
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
            System.Windows.Forms.Label descricaoLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.isEnvioCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.isBrindeCpcCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.hasVoltagemCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.hasMolduraCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.hasAlbumCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descricaoTextEdit = new DevExpress.XtraEditors.MemoEdit();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isEnvioCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isBrindeCpcCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasVoltagemCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasMolduraCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasAlbumCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descricaoTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabControl1);
            this.panelEdit.Size = new System.Drawing.Size(401, 283);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(3, 22);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(34, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(5, 70);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(53, 13);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descricao";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.isEnvioCheckEdit);
            this.tabPage1.Controls.Add(this.isAtivoCheckEdit);
            this.tabPage1.Controls.Add(this.isBrindeCpcCheckEdit);
            this.tabPage1.Controls.Add(this.hasVoltagemCheckEdit);
            this.tabPage1.Controls.Add(this.hasMolduraCheckEdit);
            this.tabPage1.Controls.Add(this.hasAlbumCheckEdit);
            this.tabPage1.Controls.Add(descricaoLabel);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextEdit);
            this.tabPage1.Controls.Add(this.descricaoTextEdit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serviço";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // isEnvioCheckEdit
            // 
            this.isEnvioCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicoBindingSource, "IsEnvio", true));
            this.isEnvioCheckEdit.Location = new System.Drawing.Point(236, 205);
            this.isEnvioCheckEdit.Name = "isEnvioCheckEdit";
            this.isEnvioCheckEdit.Properties.Caption = "Envia CPC";
            this.isEnvioCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isEnvioCheckEdit.TabIndex = 10;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = typeof(Canaan.Dados.Servico);
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicoBindingSource, "IsAtivo", true));
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(236, 180);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Status";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isAtivoCheckEdit.TabIndex = 9;
            // 
            // isBrindeCpcCheckEdit
            // 
            this.isBrindeCpcCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicoBindingSource, "IsBrindeCpc", true));
            this.isBrindeCpcCheckEdit.Location = new System.Drawing.Point(128, 205);
            this.isBrindeCpcCheckEdit.Name = "isBrindeCpcCheckEdit";
            this.isBrindeCpcCheckEdit.Properties.Caption = "Brinde";
            this.isBrindeCpcCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isBrindeCpcCheckEdit.TabIndex = 8;
            // 
            // hasVoltagemCheckEdit
            // 
            this.hasVoltagemCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicoBindingSource, "HasVoltagem", true));
            this.hasVoltagemCheckEdit.Location = new System.Drawing.Point(128, 180);
            this.hasVoltagemCheckEdit.Name = "hasVoltagemCheckEdit";
            this.hasVoltagemCheckEdit.Properties.Caption = "Tem Voltagem";
            this.hasVoltagemCheckEdit.Size = new System.Drawing.Size(102, 19);
            this.hasVoltagemCheckEdit.TabIndex = 7;
            // 
            // hasMolduraCheckEdit
            // 
            this.hasMolduraCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicoBindingSource, "HasMoldura", true));
            this.hasMolduraCheckEdit.Location = new System.Drawing.Point(6, 205);
            this.hasMolduraCheckEdit.Name = "hasMolduraCheckEdit";
            this.hasMolduraCheckEdit.Properties.Caption = "Tem Moldura";
            this.hasMolduraCheckEdit.Size = new System.Drawing.Size(90, 19);
            this.hasMolduraCheckEdit.TabIndex = 6;
            // 
            // hasAlbumCheckEdit
            // 
            this.hasAlbumCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicoBindingSource, "HasAlbum", true));
            this.hasAlbumCheckEdit.Location = new System.Drawing.Point(6, 180);
            this.hasAlbumCheckEdit.Name = "hasAlbumCheckEdit";
            this.hasAlbumCheckEdit.Properties.Caption = "Tem Álbum";
            this.hasAlbumCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.hasAlbumCheckEdit.TabIndex = 5;
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicoBindingSource, "Nome", true));
            this.nomeTextEdit.Location = new System.Drawing.Point(6, 38);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(355, 20);
            this.nomeTextEdit.TabIndex = 1;
            // 
            // descricaoTextEdit
            // 
            this.descricaoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.servicoBindingSource, "Descricao", true));
            this.descricaoTextEdit.Location = new System.Drawing.Point(6, 86);
            this.descricaoTextEdit.Name = "descricaoTextEdit";
            this.descricaoTextEdit.Size = new System.Drawing.Size(356, 88);
            this.descricaoTextEdit.TabIndex = 3;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 316);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isEnvioCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isBrindeCpcCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasVoltagemCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasMolduraCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasAlbumCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descricaoTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextEdit nomeTextEdit;
        private BindingSource servicoBindingSource;
        private MemoEdit descricaoTextEdit;
        private CheckEdit hasAlbumCheckEdit;
        private CheckEdit hasMolduraCheckEdit;
        private CheckEdit hasVoltagemCheckEdit;
        private CheckEdit isBrindeCpcCheckEdit;
        private CheckEdit isAtivoCheckEdit;
        private CheckEdit isEnvioCheckEdit;
    }
}