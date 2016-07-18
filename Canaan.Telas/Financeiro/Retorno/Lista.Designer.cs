using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Retorno
{
    partial class Lista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.actionToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConsulta = new System.Windows.Forms.ToolStripButton();
            this.retornoDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContaCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Erros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retornoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionToolStrip
            // 
            this.actionToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.actionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator1,
            this.btnConsulta});
            this.actionToolStrip.Location = new System.Drawing.Point(0, 0);
            this.actionToolStrip.Name = "actionToolStrip";
            this.actionToolStrip.Padding = new System.Windows.Forms.Padding(5);
            this.actionToolStrip.Size = new System.Drawing.Size(810, 33);
            this.actionToolStrip.TabIndex = 1;
            this.actionToolStrip.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(101, 20);
            this.btnNovo.Text = "Novo Retorno";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Image = global::Canaan.Telas.Properties.Resources.StatusAnnotations_Information_16xLG;
            this.btnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(177, 20);
            this.btnConsulta.Text = "Informações do Selecionado";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // retornoDataGridView
            // 
            this.retornoDataGridView.AllowUserToAddRows = false;
            this.retornoDataGridView.AllowUserToDeleteRows = false;
            this.retornoDataGridView.AllowUserToResizeColumns = false;
            this.retornoDataGridView.AllowUserToResizeRows = false;
            this.retornoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.retornoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.retornoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.retornoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Filial,
            this.ContaCaixa,
            this.Data,
            this.Registros,
            this.Erros,
            this.Usuario});
            this.retornoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.retornoDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.retornoDataGridView.Location = new System.Drawing.Point(0, 33);
            this.retornoDataGridView.MultiSelect = false;
            this.retornoDataGridView.Name = "retornoDataGridView";
            this.retornoDataGridView.ReadOnly = true;
            this.retornoDataGridView.RowHeadersVisible = false;
            this.retornoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.retornoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.retornoDataGridView.ShowCellErrors = false;
            this.retornoDataGridView.ShowCellToolTips = false;
            this.retornoDataGridView.ShowEditingIcon = false;
            this.retornoDataGridView.ShowRowErrors = false;
            this.retornoDataGridView.Size = new System.Drawing.Size(810, 405);
            this.retornoDataGridView.TabIndex = 2;
            this.retornoDataGridView.DoubleClick += new System.EventHandler(this.retornoDataGridView_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Filial
            // 
            this.Filial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Filial.DataPropertyName = "Filial";
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            this.Filial.ReadOnly = true;
            // 
            // ContaCaixa
            // 
            this.ContaCaixa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContaCaixa.DataPropertyName = "ContaCaixa";
            this.ContaCaixa.HeaderText = "Conta Caixa";
            this.ContaCaixa.Name = "ContaCaixa";
            this.ContaCaixa.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 90;
            // 
            // Registros
            // 
            this.Registros.DataPropertyName = "Registros";
            this.Registros.HeaderText = "Registros";
            this.Registros.Name = "Registros";
            this.Registros.ReadOnly = true;
            this.Registros.Width = 80;
            // 
            // Erros
            // 
            this.Erros.DataPropertyName = "Erros";
            this.Erros.HeaderText = "Erros";
            this.Erros.Name = "Erros";
            this.Erros.ReadOnly = true;
            this.Erros.Width = 80;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Lista
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 438);
            this.Controls.Add(this.retornoDataGridView);
            this.Controls.Add(this.actionToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Retornos";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.actionToolStrip.ResumeLayout(false);
            this.actionToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retornoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip actionToolStrip;
        private ToolStripButton btnNovo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnConsulta;
        private DataGridView retornoDataGridView;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Filial;
        private DataGridViewTextBoxColumn ContaCaixa;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Registros;
        private DataGridViewTextBoxColumn Erros;
        private DataGridViewTextBoxColumn Usuario;
    }
}