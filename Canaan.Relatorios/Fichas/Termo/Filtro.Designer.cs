namespace Canaan.Relatorios.Fichas.Termo
{
    partial class Filtro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recepcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridModelos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbParentesco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.brGerar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(619, 405);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.brGerar);
            this.tabPage1.Controls.Add(this.btFiltrar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbParentesco);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Size = new System.Drawing.Size(611, 379);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód. Pacote";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(82, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(231, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(294, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridClientes);
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToAddRows = false;
            this.dataGridClientes.AllowUserToDeleteRows = false;
            this.dataGridClientes.AllowUserToResizeColumns = false;
            this.dataGridClientes.AllowUserToResizeRows = false;
            this.dataGridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.Recepcao});
            this.dataGridClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClientes.Location = new System.Drawing.Point(3, 16);
            this.dataGridClientes.MultiSelect = false;
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.ReadOnly = true;
            this.dataGridClientes.RowHeadersVisible = false;
            this.dataGridClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.ShowCellErrors = false;
            this.dataGridClientes.ShowCellToolTips = false;
            this.dataGridClientes.ShowEditingIcon = false;
            this.dataGridClientes.ShowRowErrors = false;
            this.dataGridClientes.Size = new System.Drawing.Size(579, 130);
            this.dataGridClientes.TabIndex = 1;
            this.dataGridClientes.SelectionChanged += new System.EventHandler(this.dataGridClientes_SelectionChanged);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Codigo";
            this.Código.FillWeight = 7.614212F;
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 30F;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 190;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Recepcao
            // 
            this.Recepcao.DataPropertyName = "Data";
            this.Recepcao.FillWeight = 7.614212F;
            this.Recepcao.HeaderText = "Data Recepção";
            this.Recepcao.Name = "Recepcao";
            this.Recepcao.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridModelos);
            this.groupBox2.Location = new System.Drawing.Point(13, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 110);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modelos";
            // 
            // dataGridModelos
            // 
            this.dataGridModelos.AllowUserToAddRows = false;
            this.dataGridModelos.AllowUserToDeleteRows = false;
            this.dataGridModelos.AllowUserToResizeColumns = false;
            this.dataGridModelos.AllowUserToResizeRows = false;
            this.dataGridModelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridModelos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridModelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NomeModelo,
            this.Cpf});
            this.dataGridModelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridModelos.Location = new System.Drawing.Point(3, 16);
            this.dataGridModelos.MultiSelect = false;
            this.dataGridModelos.Name = "dataGridModelos";
            this.dataGridModelos.ReadOnly = true;
            this.dataGridModelos.RowHeadersVisible = false;
            this.dataGridModelos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridModelos.ShowCellErrors = false;
            this.dataGridModelos.ShowCellToolTips = false;
            this.dataGridModelos.ShowEditingIcon = false;
            this.dataGridModelos.ShowRowErrors = false;
            this.dataGridModelos.Size = new System.Drawing.Size(579, 91);
            this.dataGridModelos.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // NomeModelo
            // 
            this.NomeModelo.DataPropertyName = "Modelo";
            this.NomeModelo.HeaderText = "Nome";
            this.NomeModelo.Name = "NomeModelo";
            this.NomeModelo.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Documento";
            this.Cpf.HeaderText = "Documento";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // cbParentesco
            // 
            this.cbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParentesco.FormattingEnabled = true;
            this.cbParentesco.Location = new System.Drawing.Point(13, 343);
            this.cbParentesco.Name = "cbParentesco";
            this.cbParentesco.Size = new System.Drawing.Size(169, 21);
            this.cbParentesco.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parentesco";
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(531, 18);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(67, 23);
            this.btFiltrar.TabIndex = 8;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // brGerar
            // 
            this.brGerar.Location = new System.Drawing.Point(523, 341);
            this.brGerar.Name = "brGerar";
            this.brGerar.Size = new System.Drawing.Size(75, 23);
            this.brGerar.TabIndex = 9;
            this.brGerar.Text = "Gerar";
            this.brGerar.UseVisualStyleBackColor = true;
            this.brGerar.Click += new System.EventHandler(this.brGerar_Click);
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 429);
            this.Name = "Filtro";
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbParentesco;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.DataGridView dataGridModelos;
        protected System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Button brGerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recepcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
    }
}