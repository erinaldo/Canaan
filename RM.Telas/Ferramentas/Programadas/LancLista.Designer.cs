namespace RM.Telas.Ferramentas.Programadas
{
    partial class LancLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAtualizaClasse = new System.Windows.Forms.ToolStripButton();
            this.lancamentoGridView = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baixado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtualizaClasse});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAtualizaClasse
            // 
            this.btnAtualizaClasse.Image = global::RM.Telas.Properties.Resources.gear_16xLG;
            this.btnAtualizaClasse.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAtualizaClasse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizaClasse.Name = "btnAtualizaClasse";
            this.btnAtualizaClasse.Size = new System.Drawing.Size(157, 22);
            this.btnAtualizaClasse.Text = "Atualiza Classe Contrabil";
            this.btnAtualizaClasse.Click += new System.EventHandler(this.btnAtualizaClasse_Click);
            // 
            // lancamentoGridView
            // 
            this.lancamentoGridView.AllowUserToAddRows = false;
            this.lancamentoGridView.AllowUserToDeleteRows = false;
            this.lancamentoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lancamentoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Codigo,
            this.Classe,
            this.Emissao,
            this.Vencimento,
            this.Baixa,
            this.Valor,
            this.Baixado});
            this.lancamentoGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lancamentoGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lancamentoGridView.Location = new System.Drawing.Point(0, 25);
            this.lancamentoGridView.Name = "lancamentoGridView";
            this.lancamentoGridView.RowHeadersVisible = false;
            this.lancamentoGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lancamentoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lancamentoGridView.ShowCellErrors = false;
            this.lancamentoGridView.ShowCellToolTips = false;
            this.lancamentoGridView.ShowEditingIcon = false;
            this.lancamentoGridView.ShowRowErrors = false;
            this.lancamentoGridView.Size = new System.Drawing.Size(818, 464);
            this.lancamentoGridView.TabIndex = 1;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Classe
            // 
            this.Classe.DataPropertyName = "Classe";
            this.Classe.HeaderText = "Classe";
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            // 
            // Emissao
            // 
            this.Emissao.DataPropertyName = "Emissao";
            dataGridViewCellStyle1.Format = "d";
            this.Emissao.DefaultCellStyle = dataGridViewCellStyle1;
            this.Emissao.HeaderText = "Emissao";
            this.Emissao.Name = "Emissao";
            this.Emissao.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "Vencimento";
            dataGridViewCellStyle2.Format = "d";
            this.Vencimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // Baixa
            // 
            this.Baixa.DataPropertyName = "Baixa";
            dataGridViewCellStyle3.Format = "d";
            this.Baixa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Baixa.HeaderText = "Baixa";
            this.Baixa.Name = "Baixa";
            this.Baixa.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle4;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Baixado
            // 
            this.Baixado.DataPropertyName = "Baixado";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Baixado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Baixado.HeaderText = "Baixado";
            this.Baixado.Name = "Baixado";
            this.Baixado.ReadOnly = true;
            // 
            // LancLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 489);
            this.Controls.Add(this.lancamentoGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LancLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LancLista";
            this.Load += new System.EventHandler(this.LancLista_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView lancamentoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baixado;
        private System.Windows.Forms.ToolStripButton btnAtualizaClasse;
    }
}