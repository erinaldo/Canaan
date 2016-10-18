using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Suporte.DevolveVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExecuta = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vendasDataGridView = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLiberado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsConfirmado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExecuta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(736, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExecuta
            // 
            this.btnExecuta.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.btnExecuta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExecuta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(140, 22);
            this.btnExecuta.Text = "Efetua Cancelamento";
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o Código do Atendimento";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(241, 17);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(6, 19);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(229, 20);
            this.codigoTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vendasDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 243);
            this.panel1.TabIndex = 2;
            // 
            // vendasDataGridView
            // 
            this.vendasDataGridView.AllowUserToAddRows = false;
            this.vendasDataGridView.AllowUserToDeleteRows = false;
            this.vendasDataGridView.AllowUserToResizeColumns = false;
            this.vendasDataGridView.AllowUserToResizeRows = false;
            this.vendasDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.vendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.vendasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.Data,
            this.Valor,
            this.IsLiberado,
            this.IsConfirmado,
            this.Status});
            this.vendasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.vendasDataGridView.Name = "vendasDataGridView";
            this.vendasDataGridView.ReadOnly = true;
            this.vendasDataGridView.RowHeadersVisible = false;
            this.vendasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.vendasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendasDataGridView.ShowCellErrors = false;
            this.vendasDataGridView.ShowCellToolTips = false;
            this.vendasDataGridView.ShowEditingIcon = false;
            this.vendasDataGridView.ShowRowErrors = false;
            this.vendasDataGridView.Size = new System.Drawing.Size(712, 243);
            this.vendasDataGridView.TabIndex = 0;
            this.vendasDataGridView.DoubleClick += new System.EventHandler(this.vendasDataGridView_DoubleClick);
            // 
            // IdPedido
            // 
            this.IdPedido.DataPropertyName = "IdPedido";
            this.IdPedido.HeaderText = "Cód Venda";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
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
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // IsLiberado
            // 
            this.IsLiberado.DataPropertyName = "IsLiberado";
            this.IsLiberado.HeaderText = "Liberado";
            this.IsLiberado.Name = "IsLiberado";
            this.IsLiberado.ReadOnly = true;
            this.IsLiberado.Width = 80;
            // 
            // IsConfirmado
            // 
            this.IsConfirmado.DataPropertyName = "IsConfirmado";
            this.IsConfirmado.HeaderText = "Confirmado";
            this.IsConfirmado.Name = "IsConfirmado";
            this.IsConfirmado.ReadOnly = true;
            this.IsConfirmado.Width = 80;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelamento de Venda";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnExecuta;
        private GroupBox groupBox1;
        private Button btnConsultar;
        private TextBox codigoTextBox;
        private Panel panel1;
        private DataGridView vendasDataGridView;
        private DataGridViewTextBoxColumn IdPedido;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewCheckBoxColumn IsLiberado;
        private DataGridViewCheckBoxColumn IsConfirmado;
        private DataGridViewTextBoxColumn Status;
    }
}