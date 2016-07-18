using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Retorno
{
    partial class Log
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logDataGridView = new System.Windows.Forms.DataGridView();
            this.IdLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NossoNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsErro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logDataGridView
            // 
            this.logDataGridView.AllowUserToAddRows = false;
            this.logDataGridView.AllowUserToDeleteRows = false;
            this.logDataGridView.AllowUserToResizeColumns = false;
            this.logDataGridView.AllowUserToResizeRows = false;
            this.logDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.logDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLog,
            this.StatusLog,
            this.Documento,
            this.NossoNumero,
            this.ValorPago,
            this.Informacao,
            this.IsErro});
            this.logDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logDataGridView.Location = new System.Drawing.Point(0, 0);
            this.logDataGridView.Name = "logDataGridView";
            this.logDataGridView.ReadOnly = true;
            this.logDataGridView.RowHeadersVisible = false;
            this.logDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.logDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logDataGridView.ShowCellErrors = false;
            this.logDataGridView.ShowCellToolTips = false;
            this.logDataGridView.ShowEditingIcon = false;
            this.logDataGridView.ShowRowErrors = false;
            this.logDataGridView.Size = new System.Drawing.Size(1027, 404);
            this.logDataGridView.TabIndex = 0;
            // 
            // IdLog
            // 
            this.IdLog.DataPropertyName = "IdLog";
            this.IdLog.HeaderText = "Codigo";
            this.IdLog.Name = "IdLog";
            this.IdLog.ReadOnly = true;
            this.IdLog.Width = 70;
            // 
            // StatusLog
            // 
            this.StatusLog.DataPropertyName = "StatusLog";
            this.StatusLog.HeaderText = "Status";
            this.StatusLog.Name = "StatusLog";
            this.StatusLog.ReadOnly = true;
            this.StatusLog.Width = 120;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // NossoNumero
            // 
            this.NossoNumero.DataPropertyName = "NossoNumero";
            this.NossoNumero.HeaderText = "NossoNumero";
            this.NossoNumero.Name = "NossoNumero";
            this.NossoNumero.ReadOnly = true;
            this.NossoNumero.Width = 120;
            // 
            // ValorPago
            // 
            this.ValorPago.DataPropertyName = "ValorPago";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ValorPago.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorPago.HeaderText = "ValorPago";
            this.ValorPago.Name = "ValorPago";
            this.ValorPago.ReadOnly = true;
            // 
            // Informacao
            // 
            this.Informacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Informacao.DataPropertyName = "Informacao";
            this.Informacao.HeaderText = "Informacao";
            this.Informacao.Name = "Informacao";
            this.Informacao.ReadOnly = true;
            // 
            // IsErro
            // 
            this.IsErro.DataPropertyName = "IsErro";
            this.IsErro.HeaderText = "Erro";
            this.IsErro.Name = "IsErro";
            this.IsErro.ReadOnly = true;
            this.IsErro.Width = 70;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 404);
            this.Controls.Add(this.logDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView logDataGridView;
        private DataGridViewTextBoxColumn IdLog;
        private DataGridViewTextBoxColumn StatusLog;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NossoNumero;
        private DataGridViewTextBoxColumn ValorPago;
        private DataGridViewTextBoxColumn Informacao;
        private DataGridViewTextBoxColumn IsErro;
    }
}