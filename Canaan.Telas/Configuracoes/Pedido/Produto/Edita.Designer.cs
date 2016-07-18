using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Configuracoes.Pedido.Produto
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
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label custoLabel;
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.custoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.valorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lkTableName = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.isAtivoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.nomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descricaoTextEdit = new DevExpress.XtraEditors.MemoEdit();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            custoLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descricaoTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabControl1);
            this.panelEdit.Size = new System.Drawing.Size(377, 354);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(14, 13);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(34, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(14, 58);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(53, 13);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descricao";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(14, 213);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(31, 13);
            valorLabel.TabIndex = 8;
            valorLabel.Text = "Valor";
            // 
            // custoLabel
            // 
            custoLabel.AutoSize = true;
            custoLabel.Location = new System.Drawing.Point(179, 213);
            custoLabel.Name = "custoLabel";
            custoLabel.Size = new System.Drawing.Size(39, 13);
            custoLabel.TabIndex = 9;
            custoLabel.Text = "Custo:";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Canaan.Dados.Produto);
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
            this.tabControl1.Size = new System.Drawing.Size(352, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(custoLabel);
            this.tabPage1.Controls.Add(this.custoTextEdit);
            this.tabPage1.Controls.Add(valorLabel);
            this.tabPage1.Controls.Add(this.valorTextEdit);
            this.tabPage1.Controls.Add(this.lkTableName);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.isAtivoCheckEdit);
            this.tabPage1.Controls.Add(descricaoLabel);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextEdit);
            this.tabPage1.Controls.Add(this.descricaoTextEdit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // custoTextEdit
            // 
            this.custoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.produtoBindingSource, "Custo", true));
            this.custoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Custo", true));
            this.custoTextEdit.Location = new System.Drawing.Point(182, 229);
            this.custoTextEdit.Name = "custoTextEdit";
            this.custoTextEdit.Properties.Mask.EditMask = "c";
            this.custoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.custoTextEdit.Size = new System.Drawing.Size(144, 20);
            this.custoTextEdit.TabIndex = 4;
            // 
            // valorTextEdit
            // 
            this.valorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.produtoBindingSource, "Valor", true));
            this.valorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.valorTextEdit.Location = new System.Drawing.Point(17, 229);
            this.valorTextEdit.Name = "valorTextEdit";
            this.valorTextEdit.Properties.Mask.EditMask = "c";
            this.valorTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.valorTextEdit.Size = new System.Drawing.Size(144, 20);
            this.valorTextEdit.TabIndex = 3;
            // 
            // lkTableName
            // 
            this.lkTableName.AutoSize = true;
            this.lkTableName.Location = new System.Drawing.Point(73, 185);
            this.lkTableName.Name = "lkTableName";
            this.lkTableName.Size = new System.Drawing.Size(39, 13);
            this.lkTableName.TabIndex = 8;
            this.lkTableName.TabStop = true;
            this.lkTableName.Text = "Tabela";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "IdTabela", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(17, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 21);
            this.textBox1.TabIndex = 2;
            // 
            // isAtivoCheckEdit
            // 
            this.isAtivoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.produtoBindingSource, "IsAtivo", true));
            this.isAtivoCheckEdit.Location = new System.Drawing.Point(15, 267);
            this.isAtivoCheckEdit.Name = "isAtivoCheckEdit";
            this.isAtivoCheckEdit.Properties.Caption = "Status";
            this.isAtivoCheckEdit.Size = new System.Drawing.Size(75, 19);
            this.isAtivoCheckEdit.TabIndex = 5;
            // 
            // nomeTextEdit
            // 
            this.nomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.produtoBindingSource, "Nome", true));
            this.nomeTextEdit.Location = new System.Drawing.Point(17, 29);
            this.nomeTextEdit.Name = "nomeTextEdit";
            this.nomeTextEdit.Size = new System.Drawing.Size(309, 20);
            this.nomeTextEdit.TabIndex = 0;
            // 
            // descricaoTextEdit
            // 
            this.descricaoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.produtoBindingSource, "Descricao", true));
            this.descricaoTextEdit.Location = new System.Drawing.Point(17, 74);
            this.descricaoTextEdit.Name = "descricaoTextEdit";
            this.descricaoTextEdit.Size = new System.Drawing.Size(309, 97);
            this.descricaoTextEdit.TabIndex = 1;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 387);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isAtivoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descricaoTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource produtoBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextEdit nomeTextEdit;
        private MemoEdit descricaoTextEdit;
        private CheckEdit isAtivoCheckEdit;
        private TextBox textBox1;
        private LinkLabel lkTableName;
        private TextEdit valorTextEdit;
        private TextEdit custoTextEdit;
    }
}