using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Financeiro.Retorno
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
            this.actionToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnProcessa = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.infoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.infoToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.arquivoLinkLabel = new System.Windows.Forms.LinkLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.contaCaixaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.idContaCaixaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.filialLinkLabel = new System.Windows.Forms.LinkLabel();
            this.idFilialTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.retornoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.retornoBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.actionToolStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idContaCaixaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idFilialTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // actionToolStrip
            // 
            this.actionToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.actionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProcessa});
            this.actionToolStrip.Location = new System.Drawing.Point(0, 0);
            this.actionToolStrip.Name = "actionToolStrip";
            this.actionToolStrip.Padding = new System.Windows.Forms.Padding(5);
            this.actionToolStrip.Size = new System.Drawing.Size(341, 33);
            this.actionToolStrip.TabIndex = 2;
            this.actionToolStrip.Text = "toolStrip1";
            // 
            // btnProcessa
            // 
            this.btnProcessa.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.btnProcessa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProcessa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcessa.Name = "btnProcessa";
            this.btnProcessa.Size = new System.Drawing.Size(118, 20);
            this.btnProcessa.Text = "Processa Retorno";
            this.btnProcessa.Click += new System.EventHandler(this.btnProcessa_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripLabel,
            this.infoToolStripProgressBar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 206);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(341, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // infoToolStripLabel
            // 
            this.infoToolStripLabel.Name = "infoToolStripLabel";
            this.infoToolStripLabel.Size = new System.Drawing.Size(86, 22);
            this.infoToolStripLabel.Text = "toolStripLabel1";
            // 
            // infoToolStripProgressBar
            // 
            this.infoToolStripProgressBar.Name = "infoToolStripProgressBar";
            this.infoToolStripProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(341, 173);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.arquivoLinkLabel);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.labelControl14);
            this.groupBox2.Controls.Add(this.contaCaixaLinkLabel);
            this.groupBox2.Controls.Add(this.idContaCaixaTextEdit);
            this.groupBox2.Controls.Add(this.filialLinkLabel);
            this.groupBox2.Controls.Add(this.idFilialTextEdit);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(331, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Retorno";
            // 
            // arquivoLinkLabel
            // 
            this.arquivoLinkLabel.AutoSize = true;
            this.arquivoLinkLabel.Location = new System.Drawing.Point(5, 128);
            this.arquivoLinkLabel.Name = "arquivoLinkLabel";
            this.arquivoLinkLabel.Size = new System.Drawing.Size(113, 13);
            this.arquivoLinkLabel.TabIndex = 15;
            this.arquivoLinkLabel.TabStop = true;
            this.arquivoLinkLabel.Text = "Clique para Selecionar";
            this.arquivoLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.arquivoLinkLabel_LinkClicked);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 112);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Selecione o Arquivo";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(8, 67);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(59, 13);
            this.labelControl14.TabIndex = 11;
            this.labelControl14.Text = "Conta Caixa";
            // 
            // contaCaixaLinkLabel
            // 
            this.contaCaixaLinkLabel.AutoSize = true;
            this.contaCaixaLinkLabel.Location = new System.Drawing.Point(73, 89);
            this.contaCaixaLinkLabel.Name = "contaCaixaLinkLabel";
            this.contaCaixaLinkLabel.Size = new System.Drawing.Size(123, 13);
            this.contaCaixaLinkLabel.TabIndex = 13;
            this.contaCaixaLinkLabel.TabStop = true;
            this.contaCaixaLinkLabel.Text = "Selecione a Conta Caixa";
            this.contaCaixaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contaCaixaLinkLabel_LinkClicked);
            // 
            // idContaCaixaTextEdit
            // 
            this.idContaCaixaTextEdit.Enabled = false;
            this.idContaCaixaTextEdit.Location = new System.Drawing.Point(8, 86);
            this.idContaCaixaTextEdit.Name = "idContaCaixaTextEdit";
            this.idContaCaixaTextEdit.Size = new System.Drawing.Size(59, 20);
            this.idContaCaixaTextEdit.TabIndex = 12;
            // 
            // filialLinkLabel
            // 
            this.filialLinkLabel.AutoSize = true;
            this.filialLinkLabel.Location = new System.Drawing.Point(73, 44);
            this.filialLinkLabel.Name = "filialLinkLabel";
            this.filialLinkLabel.Size = new System.Drawing.Size(84, 13);
            this.filialLinkLabel.TabIndex = 10;
            this.filialLinkLabel.TabStop = true;
            this.filialLinkLabel.Text = "Selecione a Filial";
            this.filialLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.filialLinkLabel_LinkClicked);
            // 
            // idFilialTextEdit
            // 
            this.idFilialTextEdit.Enabled = false;
            this.idFilialTextEdit.Location = new System.Drawing.Point(8, 41);
            this.idFilialTextEdit.Name = "idFilialTextEdit";
            this.idFilialTextEdit.Size = new System.Drawing.Size(59, 20);
            this.idFilialTextEdit.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 22);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(20, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Filial";
            // 
            // retornoBackgroundWorker
            // 
            this.retornoBackgroundWorker.WorkerReportsProgress = true;
            this.retornoBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.retornoBackgroundWorker_DoWork);
            this.retornoBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.retornoBackgroundWorker_ProgressChanged);
            this.retornoBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.retornoBackgroundWorker_RunWorkerCompleted);
            // 
            // Edita
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(341, 231);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.actionToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retorno de Arquivo Bancário";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.actionToolStrip.ResumeLayout(false);
            this.actionToolStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idContaCaixaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idFilialTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip actionToolStrip;
        private ToolStripButton btnProcessa;
        private ToolStrip toolStrip1;
        private ToolStripLabel infoToolStripLabel;
        private ToolStripProgressBar infoToolStripProgressBar;
        private Panel panel1;
        private GroupBox groupBox2;
        private LinkLabel filialLinkLabel;
        private TextEdit idFilialTextEdit;
        private LabelControl labelControl4;
        private LinkLabel arquivoLinkLabel;
        private LabelControl labelControl1;
        private LabelControl labelControl14;
        private LinkLabel contaCaixaLinkLabel;
        private TextEdit idContaCaixaTextEdit;
        private OpenFileDialog retornoFileDialog;
        private BackgroundWorker retornoBackgroundWorker;
    }
}