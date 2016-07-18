using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Base
{
    partial class FormSelecao
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.toolStripSeleciona = new System.Windows.Forms.ToolStrip();
            this.filtroLabel = new System.Windows.Forms.ToolStripLabel();
            this.filtroTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.btnFiltro = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.toolStripSeleciona.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 33);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowCellErrors = false;
            this.dataGrid.ShowCellToolTips = false;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.ShowRowErrors = false;
            this.dataGrid.Size = new System.Drawing.Size(372, 233);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGrid_DataBindingComplete);
            this.dataGrid.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            // 
            // toolStripSeleciona
            // 
            this.toolStripSeleciona.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSeleciona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtroLabel,
            this.filtroTextBox,
            this.btnFiltro});
            this.toolStripSeleciona.Location = new System.Drawing.Point(0, 0);
            this.toolStripSeleciona.Name = "toolStripSeleciona";
            this.toolStripSeleciona.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripSeleciona.Size = new System.Drawing.Size(372, 33);
            this.toolStripSeleciona.TabIndex = 2;
            this.toolStripSeleciona.Text = "toolStrip1";
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
            // FormSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 266);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.toolStripSeleciona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSelecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelecao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.toolStripSeleciona.ResumeLayout(false);
            this.toolStripSeleciona.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DataGridView dataGrid;
        protected ToolStripLabel filtroLabel;
        protected ToolStripTextBox filtroTextBox;
        protected ToolStripButton btnFiltro;
        protected ToolStrip toolStripSeleciona;
    }
}