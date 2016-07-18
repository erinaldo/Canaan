using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Financeiro.Lancamento
{
    partial class Email
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.actionsToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnEnviar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lancDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionsToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsToolStrip
            // 
            this.actionsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.actionsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEnviar});
            this.actionsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.actionsToolStrip.Name = "actionsToolStrip";
            this.actionsToolStrip.Padding = new System.Windows.Forms.Padding(5);
            this.actionsToolStrip.Size = new System.Drawing.Size(471, 33);
            this.actionsToolStrip.TabIndex = 1;
            this.actionsToolStrip.Text = "toolStrip1";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = global::Canaan.Telas.Properties.Resources.envelope_16xLG;
            this.btnEnviar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEnviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(113, 20);
            this.btnEnviar.Text = "Confirmar Envio";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(471, 84);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(471, 276);
            this.panel2.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.emailTextBox);
            this.groupControl1.Controls.Add(this.emailLabel);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(5);
            this.groupControl1.Size = new System.Drawing.Size(461, 74);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Informações do Envio";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lancDataGridView);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(5, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(5);
            this.groupControl2.Size = new System.Drawing.Size(461, 266);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Informações do Lancamento";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(10, 26);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(82, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email do Cliente";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(10, 42);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(303, 21);
            this.emailTextBox.TabIndex = 1;
            // 
            // lancDataGridView
            // 
            this.lancDataGridView.AllowUserToAddRows = false;
            this.lancDataGridView.AllowUserToDeleteRows = false;
            this.lancDataGridView.AllowUserToResizeColumns = false;
            this.lancDataGridView.AllowUserToResizeRows = false;
            this.lancDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.lancDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lancDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lancDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cliente,
            this.Vencimento,
            this.Valor});
            this.lancDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lancDataGridView.Location = new System.Drawing.Point(7, 26);
            this.lancDataGridView.MultiSelect = false;
            this.lancDataGridView.Name = "lancDataGridView";
            this.lancDataGridView.ReadOnly = true;
            this.lancDataGridView.RowHeadersVisible = false;
            this.lancDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lancDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lancDataGridView.ShowCellErrors = false;
            this.lancDataGridView.ShowCellToolTips = false;
            this.lancDataGridView.ShowEditingIcon = false;
            this.lancDataGridView.ShowRowErrors = false;
            this.lancDataGridView.Size = new System.Drawing.Size(447, 233);
            this.lancDataGridView.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "Vencimento";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Vencimento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
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
            // Email
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actionsToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            this.actionsToolStrip.ResumeLayout(false);
            this.actionsToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lancDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip actionsToolStrip;
        private ToolStripButton btnEnviar;
        private Panel panel1;
        private Panel panel2;
        private GroupControl groupControl1;
        private TextBox emailTextBox;
        private Label emailLabel;
        private GroupControl groupControl2;
        private DataGridView lancDataGridView;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Vencimento;
        private DataGridViewTextBoxColumn Valor;
    }
}