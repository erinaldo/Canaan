namespace Canaan.Telas.Laboratorio.Pendentes
{
    partial class Lista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridVendas = new System.Windows.Forms.DataGridView();
            this.IdEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodReduzido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            this.LbCliente = new Canaan.Lib.Componentes.CLabel();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.IdEnvioPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enviado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gridVendas);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            // 
            // gridVendas
            // 
            this.gridVendas.AllowUserToAddRows = false;
            this.gridVendas.AllowUserToDeleteRows = false;
            this.gridVendas.AllowUserToResizeColumns = false;
            this.gridVendas.AllowUserToResizeRows = false;
            this.gridVendas.BackgroundColor = System.Drawing.Color.White;
            this.gridVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEnvio,
            this.IdVenda,
            this.CodReduzido,
            this.Nome,
            this.Data,
            this.Valor});
            this.gridVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVendas.Location = new System.Drawing.Point(3, 16);
            this.gridVendas.MultiSelect = false;
            this.gridVendas.Name = "gridVendas";
            this.gridVendas.ReadOnly = true;
            this.gridVendas.RowHeadersVisible = false;
            this.gridVendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVendas.ShowCellErrors = false;
            this.gridVendas.ShowCellToolTips = false;
            this.gridVendas.ShowEditingIcon = false;
            this.gridVendas.ShowRowErrors = false;
            this.gridVendas.Size = new System.Drawing.Size(797, 188);
            this.gridVendas.TabIndex = 0;
            this.gridVendas.SelectionChanged += new System.EventHandler(this.gridVendas_SelectionChanged);
            this.gridVendas.DoubleClick += new System.EventHandler(this.gridVendas_DoubleClick);
            // 
            // IdEnvio
            // 
            this.IdEnvio.DataPropertyName = "IdEnvio";
            this.IdEnvio.HeaderText = "IdPedido";
            this.IdEnvio.Name = "IdEnvio";
            this.IdEnvio.ReadOnly = true;
            this.IdEnvio.Visible = false;
            // 
            // IdVenda
            // 
            this.IdVenda.DataPropertyName = "IdPedido";
            this.IdVenda.HeaderText = "IdVenda";
            this.IdVenda.Name = "IdVenda";
            this.IdVenda.ReadOnly = true;
            this.IdVenda.Visible = false;
            // 
            // CodReduzido
            // 
            this.CodReduzido.DataPropertyName = "CodigoReduzido";
            this.CodReduzido.HeaderText = "Código";
            this.CodReduzido.Name = "CodReduzido";
            this.CodReduzido.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle5;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle6;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBuscar);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.LbCliente);
            this.groupBox2.Controls.Add(this.cLabel1);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca";
            // 
            // btBuscar
            // 
            this.btBuscar.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.Location = new System.Drawing.Point(708, 19);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 9;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(295, 20);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(407, 20);
            this.txtCliente.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(67, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridPedidos);
            this.groupBox3.Location = new System.Drawing.Point(12, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(803, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pedidos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Novo Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridPedidos
            // 
            this.gridPedidos.AllowUserToAddRows = false;
            this.gridPedidos.AllowUserToDeleteRows = false;
            this.gridPedidos.AllowUserToResizeColumns = false;
            this.gridPedidos.AllowUserToResizeRows = false;
            this.gridPedidos.BackgroundColor = System.Drawing.Color.White;
            this.gridPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEnvioPedido,
            this.Categoria,
            this.Produto,
            this.Tamanho,
            this.Enviado});
            this.gridPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPedidos.Location = new System.Drawing.Point(3, 16);
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.ReadOnly = true;
            this.gridPedidos.RowHeadersVisible = false;
            this.gridPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPedidos.ShowCellErrors = false;
            this.gridPedidos.ShowCellToolTips = false;
            this.gridPedidos.ShowEditingIcon = false;
            this.gridPedidos.ShowRowErrors = false;
            this.gridPedidos.Size = new System.Drawing.Size(797, 146);
            this.gridPedidos.TabIndex = 0;
            // 
            // LbCliente
            // 
            this.LbCliente.AutoSize = true;
            this.LbCliente.Location = new System.Drawing.Point(178, 17);
            this.LbCliente.Name = "LbCliente";
            this.LbCliente.Padding = new System.Windows.Forms.Padding(5);
            this.LbCliente.Size = new System.Drawing.Size(120, 23);
            this.LbCliente.TabIndex = 7;
            this.LbCliente.Text = "Nome Cliente/Modelo";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(6, 16);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(50, 23);
            this.cLabel1.TabIndex = 6;
            this.cLabel1.Text = "Código";
            // 
            // IdEnvioPedido
            // 
            this.IdEnvioPedido.DataPropertyName = "IdEnvioPedido";
            this.IdEnvioPedido.HeaderText = "Codigo";
            this.IdEnvioPedido.Name = "IdEnvioPedido";
            this.IdEnvioPedido.ReadOnly = true;
            this.IdEnvioPedido.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.DataPropertyName = "Produto";
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Tamanho";
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.ReadOnly = true;
            // 
            // Enviado
            // 
            this.Enviado.DataPropertyName = "IdEnviado";
            this.Enviado.HeaderText = "Enviado";
            this.Enviado.Name = "Enviado";
            this.Enviado.ReadOnly = true;
            this.Enviado.Width = 70;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integracao de Pedidos";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVendas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodReduzido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtCliente;
        private Lib.Componentes.CLabel LbCliente;
        private Lib.Componentes.CLabel cLabel1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEnvioPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enviado;
    }
}