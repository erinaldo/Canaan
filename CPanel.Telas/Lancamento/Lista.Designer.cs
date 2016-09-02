namespace CPanel.Telas.Lancamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.filtroFilial = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filtroMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filtroAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridLancamentos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faturamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fluxo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotografado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLancamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.filtroFilial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.filtroMes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filtroAno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um periodo e uma filial";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(373, 71);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // filtroFilial
            // 
            this.filtroFilial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroFilial.FormattingEnabled = true;
            this.filtroFilial.Location = new System.Drawing.Point(101, 72);
            this.filtroFilial.Name = "filtroFilial";
            this.filtroFilial.Size = new System.Drawing.Size(266, 21);
            this.filtroFilial.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione a Filial:";
            // 
            // filtroMes
            // 
            this.filtroMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroMes.FormattingEnabled = true;
            this.filtroMes.Location = new System.Drawing.Point(101, 45);
            this.filtroMes.Name = "filtroMes";
            this.filtroMes.Size = new System.Drawing.Size(266, 21);
            this.filtroMes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o Mês:";
            // 
            // filtroAno
            // 
            this.filtroAno.Location = new System.Drawing.Point(101, 19);
            this.filtroAno.Name = "filtroAno";
            this.filtroAno.Size = new System.Drawing.Size(100, 20);
            this.filtroAno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Ano:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridLancamentos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1009, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lançamento do período";
            // 
            // gridLancamentos
            // 
            this.gridLancamentos.AllowUserToAddRows = false;
            this.gridLancamentos.AllowUserToDeleteRows = false;
            this.gridLancamentos.AllowUserToResizeColumns = false;
            this.gridLancamentos.AllowUserToResizeRows = false;
            this.gridLancamentos.BackgroundColor = System.Drawing.Color.White;
            this.gridLancamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLancamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridLancamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Dia,
            this.Entrada,
            this.Prazo,
            this.Vista,
            this.Faturamento,
            this.Comissao,
            this.Fluxo,
            this.Fotografado});
            this.gridLancamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLancamentos.Location = new System.Drawing.Point(3, 16);
            this.gridLancamentos.Name = "gridLancamentos";
            this.gridLancamentos.ReadOnly = true;
            this.gridLancamentos.RowHeadersVisible = false;
            this.gridLancamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridLancamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLancamentos.ShowCellErrors = false;
            this.gridLancamentos.ShowCellToolTips = false;
            this.gridLancamentos.ShowEditingIcon = false;
            this.gridLancamentos.ShowRowErrors = false;
            this.gridLancamentos.Size = new System.Drawing.Size(1003, 354);
            this.gridLancamentos.TabIndex = 0;
            this.gridLancamentos.DoubleClick += new System.EventHandler(this.gridLancamentos_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Cod.";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Dia
            // 
            this.Dia.DataPropertyName = "Dia";
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            this.Dia.Width = 70;
            // 
            // Entrada
            // 
            this.Entrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Entrada.DataPropertyName = "Entrada";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Entrada.DefaultCellStyle = dataGridViewCellStyle1;
            this.Entrada.HeaderText = "R$ Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.ReadOnly = true;
            // 
            // Prazo
            // 
            this.Prazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prazo.DataPropertyName = "Prazo";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Prazo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Prazo.HeaderText = "R$ Prazo";
            this.Prazo.Name = "Prazo";
            this.Prazo.ReadOnly = true;
            // 
            // Vista
            // 
            this.Vista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vista.DataPropertyName = "Vista";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Vista.DefaultCellStyle = dataGridViewCellStyle3;
            this.Vista.HeaderText = "R$ Vista";
            this.Vista.Name = "Vista";
            this.Vista.ReadOnly = true;
            // 
            // Faturamento
            // 
            this.Faturamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Faturamento.DataPropertyName = "Faturamento";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Faturamento.DefaultCellStyle = dataGridViewCellStyle4;
            this.Faturamento.HeaderText = "R$ Faturamento";
            this.Faturamento.Name = "Faturamento";
            this.Faturamento.ReadOnly = true;
            // 
            // Comissao
            // 
            this.Comissao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comissao.DataPropertyName = "Comissao";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Comissao.DefaultCellStyle = dataGridViewCellStyle5;
            this.Comissao.HeaderText = "R$ Comissão";
            this.Comissao.Name = "Comissao";
            this.Comissao.ReadOnly = true;
            // 
            // Fluxo
            // 
            this.Fluxo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fluxo.DataPropertyName = "Fluxo";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Fluxo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Fluxo.HeaderText = "R$ Fluxo";
            this.Fluxo.Name = "Fluxo";
            this.Fluxo.ReadOnly = true;
            // 
            // Fotografado
            // 
            this.Fotografado.DataPropertyName = "Fotografado";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.Fotografado.DefaultCellStyle = dataGridViewCellStyle7;
            this.Fotografado.HeaderText = "Fotog";
            this.Fotografado.Name = "Fotografado";
            this.Fotografado.ReadOnly = true;
            this.Fotografado.Width = 70;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Lista";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLancamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox filtroMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filtroAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox filtroFilial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridLancamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faturamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fluxo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fotografado;
    }
}