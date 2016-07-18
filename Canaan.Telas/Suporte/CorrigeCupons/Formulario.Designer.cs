using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Suporte.CorrigeCupons
{
    partial class Formulario
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCarrega = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExecuta = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewCupons = new System.Windows.Forms.DataGridView();
            this.IdCupom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.workerCarrega = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressInfo = new System.Windows.Forms.ToolStripProgressBar();
            this.labelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelQuantModel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workerExecuta = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCupons)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCarrega,
            this.toolStripSeparator1,
            this.btnExecuta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(860, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCarrega
            // 
            this.btnCarrega.Image = global::Canaan.Telas.Properties.Resources.database_16xLG;
            this.btnCarrega.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(174, 22);
            this.btnCarrega.Text = "Carrega Cupons Duplicados";
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExecuta
            // 
            this.btnExecuta.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.btnExecuta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(118, 22);
            this.btnExecuta.Text = "Executa Correção";
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // dataGridViewCupons
            // 
            this.dataGridViewCupons.AllowUserToAddRows = false;
            this.dataGridViewCupons.AllowUserToDeleteRows = false;
            this.dataGridViewCupons.AllowUserToResizeColumns = false;
            this.dataGridViewCupons.AllowUserToResizeRows = false;
            this.dataGridViewCupons.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCupons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCupons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCupons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCupom,
            this.Nome,
            this.Telefone,
            this.Celular,
            this.Status,
            this.Quantidade,
            this.Imagem});
            this.dataGridViewCupons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCupons.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCupons.MultiSelect = false;
            this.dataGridViewCupons.Name = "dataGridViewCupons";
            this.dataGridViewCupons.ReadOnly = true;
            this.dataGridViewCupons.RowHeadersVisible = false;
            this.dataGridViewCupons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCupons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCupons.ShowCellErrors = false;
            this.dataGridViewCupons.ShowCellToolTips = false;
            this.dataGridViewCupons.ShowEditingIcon = false;
            this.dataGridViewCupons.ShowRowErrors = false;
            this.dataGridViewCupons.Size = new System.Drawing.Size(860, 490);
            this.dataGridViewCupons.TabIndex = 1;
            this.dataGridViewCupons.TabStop = false;
            // 
            // IdCupom
            // 
            this.IdCupom.DataPropertyName = "IdCupom";
            this.IdCupom.HeaderText = "Código";
            this.IdCupom.Name = "IdCupom";
            this.IdCupom.ReadOnly = true;
            this.IdCupom.Width = 80;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quant";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 80;
            // 
            // Imagem
            // 
            this.Imagem.DataPropertyName = "Imagem";
            this.Imagem.HeaderText = "";
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Width = 50;
            // 
            // workerCarrega
            // 
            this.workerCarrega.WorkerReportsProgress = true;
            this.workerCarrega.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerCarrega_DoWork);
            this.workerCarrega.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerCarrega_ProgressChanged);
            this.workerCarrega.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerCarrega_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressInfo,
            this.labelInfo,
            this.toolStripStatusLabel1,
            this.labelQuantModel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressInfo
            // 
            this.progressInfo.Name = "progressInfo";
            this.progressInfo.Size = new System.Drawing.Size(100, 16);
            // 
            // labelInfo
            // 
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(56, 17);
            this.labelInfo.Text = "LabelInfo";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // labelQuantModel
            // 
            this.labelQuantModel.Name = "labelQuantModel";
            this.labelQuantModel.Size = new System.Drawing.Size(75, 17);
            this.labelQuantModel.Text = "TotalModelo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewCupons);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 490);
            this.panel1.TabIndex = 3;
            // 
            // workerExecuta
            // 
            this.workerExecuta.WorkerReportsProgress = true;
            this.workerExecuta.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerExecuta_DoWork);
            this.workerExecuta.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerExecuta_ProgressChanged);
            this.workerExecuta.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerExecuta_RunWorkerCompleted);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corrige Cupons Duplicados";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCupons)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCarrega;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnExecuta;
        private DataGridView dataGridViewCupons;
        private BackgroundWorker workerCarrega;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar progressInfo;
        private ToolStripStatusLabel labelInfo;
        private Panel panel1;
        private DataGridViewTextBoxColumn IdCupom;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewImageColumn Imagem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel labelQuantModel;
        private BackgroundWorker workerExecuta;
    }
}