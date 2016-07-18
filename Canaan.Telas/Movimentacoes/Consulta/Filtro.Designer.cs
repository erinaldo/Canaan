using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Movimentacoes.Consulta
{
    partial class Filtro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.VendasGP = new System.Windows.Forms.GroupBox();
            this.gridVenda = new System.Windows.Forms.DataGridView();
            this.Modelos = new System.Windows.Forms.GroupBox();
            this.gridModelos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridAtendimentos = new System.Windows.Forms.DataGridView();
            this.CodigoAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.LbCliente = new Canaan.Lib.Componentes.CLabel();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.VendasGP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenda)).BeginInit();
            this.Modelos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendimentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.VendasGP);
            this.tabPage1.Controls.Add(this.Modelos);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta de Pacote";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // VendasGP
            // 
            this.VendasGP.Controls.Add(this.gridVenda);
            this.VendasGP.Location = new System.Drawing.Point(6, 257);
            this.VendasGP.Name = "VendasGP";
            this.VendasGP.Size = new System.Drawing.Size(957, 176);
            this.VendasGP.TabIndex = 3;
            this.VendasGP.TabStop = false;
            this.VendasGP.Text = "Vendas";
            // 
            // gridVenda
            // 
            this.gridVenda.AllowUserToAddRows = false;
            this.gridVenda.AllowUserToDeleteRows = false;
            this.gridVenda.AllowUserToResizeColumns = false;
            this.gridVenda.AllowUserToResizeRows = false;
            this.gridVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVenda.BackgroundColor = System.Drawing.Color.White;
            this.gridVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVenda.Location = new System.Drawing.Point(3, 16);
            this.gridVenda.MultiSelect = false;
            this.gridVenda.Name = "gridVenda";
            this.gridVenda.ReadOnly = true;
            this.gridVenda.RowHeadersVisible = false;
            this.gridVenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVenda.ShowCellErrors = false;
            this.gridVenda.ShowCellToolTips = false;
            this.gridVenda.ShowEditingIcon = false;
            this.gridVenda.ShowRowErrors = false;
            this.gridVenda.Size = new System.Drawing.Size(951, 157);
            this.gridVenda.TabIndex = 2;
            this.gridVenda.SelectionChanged += new System.EventHandler(this.gridVenda_SelectionChanged);
            this.gridVenda.DoubleClick += new System.EventHandler(this.gridVenda_DoubleClick);
            // 
            // Modelos
            // 
            this.Modelos.Controls.Add(this.gridModelos);
            this.Modelos.Location = new System.Drawing.Point(482, 95);
            this.Modelos.Name = "Modelos";
            this.Modelos.Size = new System.Drawing.Size(481, 156);
            this.Modelos.TabIndex = 2;
            this.Modelos.TabStop = false;
            this.Modelos.Text = "Modelos";
            // 
            // gridModelos
            // 
            this.gridModelos.AllowUserToAddRows = false;
            this.gridModelos.AllowUserToDeleteRows = false;
            this.gridModelos.AllowUserToResizeColumns = false;
            this.gridModelos.AllowUserToResizeRows = false;
            this.gridModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridModelos.BackgroundColor = System.Drawing.Color.White;
            this.gridModelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Modelo,
            this.Nascimento,
            this.Idade,
            this.Status});
            this.gridModelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridModelos.Location = new System.Drawing.Point(3, 16);
            this.gridModelos.MultiSelect = false;
            this.gridModelos.Name = "gridModelos";
            this.gridModelos.ReadOnly = true;
            this.gridModelos.RowHeadersVisible = false;
            this.gridModelos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridModelos.ShowCellErrors = false;
            this.gridModelos.ShowCellToolTips = false;
            this.gridModelos.ShowEditingIcon = false;
            this.gridModelos.ShowRowErrors = false;
            this.gridModelos.Size = new System.Drawing.Size(475, 137);
            this.gridModelos.TabIndex = 2;
            this.gridModelos.DoubleClick += new System.EventHandler(this.gridModelos_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.FillWeight = 40F;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Nascimento
            // 
            this.Nascimento.DataPropertyName = "Nascimento";
            this.Nascimento.FillWeight = 10.15228F;
            this.Nascimento.HeaderText = "Nascimento";
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.FillWeight = 10.15228F;
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 10.15228F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridAtendimentos);
            this.groupBox2.Location = new System.Drawing.Point(6, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atendimentos";
            // 
            // gridAtendimentos
            // 
            this.gridAtendimentos.AllowUserToAddRows = false;
            this.gridAtendimentos.AllowUserToDeleteRows = false;
            this.gridAtendimentos.AllowUserToResizeColumns = false;
            this.gridAtendimentos.AllowUserToResizeRows = false;
            this.gridAtendimentos.BackgroundColor = System.Drawing.Color.White;
            this.gridAtendimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAtendimento,
            this.Atendimento,
            this.Cliente,
            this.Documento,
            this.Data});
            this.gridAtendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAtendimentos.Location = new System.Drawing.Point(3, 16);
            this.gridAtendimentos.MultiSelect = false;
            this.gridAtendimentos.Name = "gridAtendimentos";
            this.gridAtendimentos.ReadOnly = true;
            this.gridAtendimentos.RowHeadersVisible = false;
            this.gridAtendimentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtendimentos.ShowCellErrors = false;
            this.gridAtendimentos.ShowCellToolTips = false;
            this.gridAtendimentos.ShowEditingIcon = false;
            this.gridAtendimentos.ShowRowErrors = false;
            this.gridAtendimentos.Size = new System.Drawing.Size(467, 137);
            this.gridAtendimentos.TabIndex = 2;
            this.gridAtendimentos.SelectionChanged += new System.EventHandler(this.gridAtendimentos_SelectionChanged);
            this.gridAtendimentos.DoubleClick += new System.EventHandler(this.gridAtendimentos_DoubleClick);
            // 
            // CodigoAtendimento
            // 
            this.CodigoAtendimento.DataPropertyName = "Codigo";
            this.CodigoAtendimento.FillWeight = 30F;
            this.CodigoAtendimento.HeaderText = "ID";
            this.CodigoAtendimento.Name = "CodigoAtendimento";
            this.CodigoAtendimento.ReadOnly = true;
            this.CodigoAtendimento.Visible = false;
            // 
            // Atendimento
            // 
            this.Atendimento.DataPropertyName = "Atendimento";
            this.Atendimento.FillWeight = 90.01681F;
            this.Atendimento.HeaderText = "Código";
            this.Atendimento.Name = "Atendimento";
            this.Atendimento.ReadOnly = true;
            this.Atendimento.Width = 70;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.FillWeight = 54.57683F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.FillWeight = 149.0656F;
            this.Documento.HeaderText = "CPF";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 90;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.FillWeight = 200.7926F;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.LbCliente);
            this.groupBox1.Controls.Add(this.cLabel1);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(708, 36);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 4;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(295, 37);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(407, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // LbCliente
            // 
            this.LbCliente.AutoSize = true;
            this.LbCliente.Location = new System.Drawing.Point(178, 34);
            this.LbCliente.Name = "LbCliente";
            this.LbCliente.Padding = new System.Windows.Forms.Padding(5);
            this.LbCliente.Size = new System.Drawing.Size(120, 23);
            this.LbCliente.TabIndex = 2;
            this.LbCliente.Text = "Nome Cliente/Modelo";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(6, 33);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(50, 23);
            this.cLabel1.TabIndex = 1;
            this.cLabel1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 489);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.VendasGP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVenda)).EndInit();
            this.Modelos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridModelos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendimentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private CLabel cLabel1;
        private TextBox txtCodigo;
        private CLabel LbCliente;
        private TextBox txtCliente;
        private Button btBuscar;
        private GroupBox groupBox2;
        private GroupBox Modelos;
        private GroupBox VendasGP;
        private DataGridView gridAtendimentos;
        private DataGridView gridVenda;
        private DataGridView gridModelos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Nascimento;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewCheckBoxColumn Status;
        private DataGridViewTextBoxColumn CodigoAtendimento;
        private DataGridViewTextBoxColumn Atendimento;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Data;

    }
}