using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Geral.Cidade
{
    partial class Seleciona
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
            this.filtroLabel = new System.Windows.Forms.ToolStripLabel();
            this.filtroTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.btnFiltro = new System.Windows.Forms.ToolStripButton();
            this.dataGridCidade = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtroLabel,
            this.filtroTextBox,
            this.btnFiltro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(418, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // filtroLabel
            // 
            this.filtroLabel.Name = "filtroLabel";
            this.filtroLabel.Size = new System.Drawing.Size(96, 20);
            this.filtroLabel.Text = "Nome da Cidade";
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(200, 23);
            // 
            // btnFiltro
            // 
            this.btnFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFiltro.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.btnFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(23, 20);
            this.btnFiltro.Text = "toolStripButton1";
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // dataGridCidade
            // 
            this.dataGridCidade.AllowUserToAddRows = false;
            this.dataGridCidade.AllowUserToDeleteRows = false;
            this.dataGridCidade.AllowUserToResizeColumns = false;
            this.dataGridCidade.AllowUserToResizeRows = false;
            this.dataGridCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCidade.Location = new System.Drawing.Point(0, 33);
            this.dataGridCidade.MultiSelect = false;
            this.dataGridCidade.Name = "dataGridCidade";
            this.dataGridCidade.ReadOnly = true;
            this.dataGridCidade.RowHeadersVisible = false;
            this.dataGridCidade.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCidade.ShowCellErrors = false;
            this.dataGridCidade.ShowCellToolTips = false;
            this.dataGridCidade.ShowEditingIcon = false;
            this.dataGridCidade.ShowRowErrors = false;
            this.dataGridCidade.Size = new System.Drawing.Size(418, 262);
            this.dataGridCidade.TabIndex = 1;
            this.dataGridCidade.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridCidade_DataBindingComplete);
            this.dataGridCidade.DoubleClick += new System.EventHandler(this.dataGridCidade_DoubleClick);
            // 
            // Seleciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 295);
            this.Controls.Add(this.dataGridCidade);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleciona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione uma cidade";
            this.Load += new System.EventHandler(this.Seleciona_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel filtroLabel;
        private ToolStripTextBox filtroTextBox;
        private ToolStripButton btnFiltro;
        private DataGridView dataGridCidade;
    }
}