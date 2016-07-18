using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Conta
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
            this.dataGridSeleciona = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeleciona)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(709, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // filtroLabel
            // 
            this.filtroLabel.Name = "filtroLabel";
            this.filtroLabel.Size = new System.Drawing.Size(139, 20);
            this.filtroLabel.Text = "Nome da Conta Bancária";
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
            // 
            // dataGridSeleciona
            // 
            this.dataGridSeleciona.AllowUserToAddRows = false;
            this.dataGridSeleciona.AllowUserToDeleteRows = false;
            this.dataGridSeleciona.AllowUserToResizeColumns = false;
            this.dataGridSeleciona.AllowUserToResizeRows = false;
            this.dataGridSeleciona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridSeleciona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSeleciona.Location = new System.Drawing.Point(0, 33);
            this.dataGridSeleciona.MultiSelect = false;
            this.dataGridSeleciona.Name = "dataGridSeleciona";
            this.dataGridSeleciona.ReadOnly = true;
            this.dataGridSeleciona.RowHeadersVisible = false;
            this.dataGridSeleciona.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridSeleciona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSeleciona.ShowCellErrors = false;
            this.dataGridSeleciona.ShowCellToolTips = false;
            this.dataGridSeleciona.ShowEditingIcon = false;
            this.dataGridSeleciona.ShowRowErrors = false;
            this.dataGridSeleciona.Size = new System.Drawing.Size(709, 306);
            this.dataGridSeleciona.TabIndex = 4;
            this.dataGridSeleciona.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridSeleciona_DataBindingComplete);
            this.dataGridSeleciona.DoubleClick += new System.EventHandler(this.dataGridSeleciona_DoubleClick);
            // 
            // Seleciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 339);
            this.Controls.Add(this.dataGridSeleciona);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seleciona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleciona Conta Bancária";
            this.Load += new System.EventHandler(this.Seleciona_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeleciona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel filtroLabel;
        private ToolStripTextBox filtroTextBox;
        private ToolStripButton btnFiltro;
        private DataGridView dataGridSeleciona;
    }
}