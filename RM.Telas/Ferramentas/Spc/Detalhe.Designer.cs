namespace RM.Telas.Ferramentas.Spc
{
    partial class Detalhe
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
            this.listViewDetalhe = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBaixa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValorOriginal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValorBaixado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewDetalhe
            // 
            this.listViewDetalhe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnStatus,
            this.columnVencimento,
            this.columnEmissao,
            this.columnBaixa,
            this.columnValorOriginal,
            this.columnValorBaixado});
            this.listViewDetalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDetalhe.Location = new System.Drawing.Point(0, 0);
            this.listViewDetalhe.Name = "listViewDetalhe";
            this.listViewDetalhe.Size = new System.Drawing.Size(793, 457);
            this.listViewDetalhe.TabIndex = 0;
            this.listViewDetalhe.UseCompatibleStateImageBehavior = false;
            this.listViewDetalhe.View = System.Windows.Forms.View.Details;
            // 
            // columnCodigo
            // 
            this.columnCodigo.DisplayIndex = 0;
            this.columnCodigo.Text = "Codigo";
            this.columnCodigo.Width = 83;
            // 
            // columnStatus
            // 
            this.columnStatus.DisplayIndex = 1;
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 190;
            // 
            // columnVencimento
            // 
            this.columnVencimento.DisplayIndex = 2;
            this.columnVencimento.Text = "Vencimento";
            this.columnVencimento.Width = 97;
            // 
            // columnEmissao
            // 
            this.columnEmissao.DisplayIndex = 3;
            this.columnEmissao.Text = "Emissao";
            this.columnEmissao.Width = 94;
            // 
            // columnBaixa
            // 
            this.columnBaixa.DisplayIndex = 4;
            this.columnBaixa.Text = "Baixa";
            this.columnBaixa.Width = 96;
            // 
            // columnValorOriginal
            // 
            this.columnValorOriginal.DisplayIndex = 5;
            this.columnValorOriginal.Text = "Valor Original";
            this.columnValorOriginal.Width = 98;
            // 
            // columnValorBaixado
            // 
            this.columnValorBaixado.DisplayIndex = 6;
            this.columnValorBaixado.Text = "Valor Baixado";
            this.columnValorBaixado.Width = 102;
            // 
            // Detalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 457);
            this.Controls.Add(this.listViewDetalhe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.Detalhe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDetalhe;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.ColumnHeader columnEmissao;
        private System.Windows.Forms.ColumnHeader columnVencimento;
        private System.Windows.Forms.ColumnHeader columnBaixa;
        private System.Windows.Forms.ColumnHeader columnValorOriginal;
        private System.Windows.Forms.ColumnHeader columnValorBaixado;
    }
}