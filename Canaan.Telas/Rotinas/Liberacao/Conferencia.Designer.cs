using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Rotinas.Liberacao
{
    partial class Conferencia
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.ddlTipoBusca = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.CodVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbInfo = new Canaan.Lib.Componentes.CLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.dateTimeInicial = new System.Windows.Forms.DateTimePicker();
            this.btFiltrarDevolvidas = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.datagridDevolvidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbVendasDevolvidas = new Canaan.Lib.Componentes.CLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDevolvidas)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 492);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(938, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conferência Gerente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBusca);
            this.groupBox3.Controls.Add(this.tbBusca);
            this.groupBox3.Controls.Add(this.ddlTipoBusca);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(923, 57);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtro";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(591, 17);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 16;
            this.btnBusca.Text = "Consultar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(168, 19);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(417, 20);
            this.tbBusca.TabIndex = 15;
            // 
            // ddlTipoBusca
            // 
            this.ddlTipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoBusca.FormattingEnabled = true;
            this.ddlTipoBusca.Location = new System.Drawing.Point(10, 19);
            this.ddlTipoBusca.Name = "ddlTipoBusca";
            this.ddlTipoBusca.Size = new System.Drawing.Size(152, 21);
            this.ddlTipoBusca.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGrid);
            this.groupBox2.Location = new System.Drawing.Point(6, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Pacotes";
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodVenda,
            this.CodAtendimento,
            this.Cliente,
            this.Valor,
            this.Data,
            this.Status});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 16);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowCellErrors = false;
            this.dataGrid.ShowCellToolTips = false;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.ShowRowErrors = false;
            this.dataGrid.Size = new System.Drawing.Size(920, 284);
            this.dataGrid.TabIndex = 2;
            this.dataGrid.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            // 
            // CodVenda
            // 
            this.CodVenda.DataPropertyName = "Codigo";
            this.CodVenda.HeaderText = "Cód. Venda";
            this.CodVenda.Name = "CodVenda";
            this.CodVenda.ReadOnly = true;
            // 
            // CodAtendimento
            // 
            this.CodAtendimento.DataPropertyName = "Atendimento";
            this.CodAtendimento.HeaderText = "Atendimento";
            this.CodAtendimento.Name = "CodAtendimento";
            this.CodAtendimento.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Preco";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbInfo);
            this.groupBox1.Location = new System.Drawing.Point(6, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infromações";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.Red;
            this.lbInfo.Location = new System.Drawing.Point(3, 27);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Padding = new System.Windows.Forms.Padding(5);
            this.lbInfo.Size = new System.Drawing.Size(62, 23);
            this.lbInfo.TabIndex = 0;
            this.lbInfo.Text = "cLabel1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(938, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vendas Devolvidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimeFinal);
            this.groupBox6.Controls.Add(this.cLabel1);
            this.groupBox6.Controls.Add(this.dateTimeInicial);
            this.groupBox6.Controls.Add(this.btFiltrarDevolvidas);
            this.groupBox6.Location = new System.Drawing.Point(6, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(923, 57);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Devolvidas em";
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFinal.Location = new System.Drawing.Point(138, 21);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(103, 20);
            this.dateTimeFinal.TabIndex = 19;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(113, 18);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(23, 23);
            this.cLabel1.TabIndex = 18;
            this.cLabel1.Text = "a";
            // 
            // dateTimeInicial
            // 
            this.dateTimeInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicial.Location = new System.Drawing.Point(6, 20);
            this.dateTimeInicial.Name = "dateTimeInicial";
            this.dateTimeInicial.Size = new System.Drawing.Size(103, 20);
            this.dateTimeInicial.TabIndex = 17;
            // 
            // btFiltrarDevolvidas
            // 
            this.btFiltrarDevolvidas.Location = new System.Drawing.Point(247, 20);
            this.btFiltrarDevolvidas.Name = "btFiltrarDevolvidas";
            this.btFiltrarDevolvidas.Size = new System.Drawing.Size(75, 23);
            this.btFiltrarDevolvidas.TabIndex = 16;
            this.btFiltrarDevolvidas.Text = "Consultar";
            this.btFiltrarDevolvidas.UseVisualStyleBackColor = true;
            this.btFiltrarDevolvidas.Click += new System.EventHandler(this.btFiltrarDevolvidas_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.datagridDevolvidas);
            this.groupBox4.Location = new System.Drawing.Point(6, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(926, 314);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de Pacotes Devolvidos";
            // 
            // datagridDevolvidas
            // 
            this.datagridDevolvidas.AllowUserToAddRows = false;
            this.datagridDevolvidas.AllowUserToDeleteRows = false;
            this.datagridDevolvidas.AllowUserToResizeColumns = false;
            this.datagridDevolvidas.AllowUserToResizeRows = false;
            this.datagridDevolvidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridDevolvidas.BackgroundColor = System.Drawing.Color.White;
            this.datagridDevolvidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridDevolvidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridDevolvidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.datagridDevolvidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridDevolvidas.Location = new System.Drawing.Point(3, 16);
            this.datagridDevolvidas.MultiSelect = false;
            this.datagridDevolvidas.Name = "datagridDevolvidas";
            this.datagridDevolvidas.ReadOnly = true;
            this.datagridDevolvidas.RowHeadersVisible = false;
            this.datagridDevolvidas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridDevolvidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridDevolvidas.ShowCellErrors = false;
            this.datagridDevolvidas.ShowCellToolTips = false;
            this.datagridDevolvidas.ShowEditingIcon = false;
            this.datagridDevolvidas.ShowRowErrors = false;
            this.datagridDevolvidas.Size = new System.Drawing.Size(920, 295);
            this.datagridDevolvidas.TabIndex = 2;
            this.datagridDevolvidas.DoubleClick += new System.EventHandler(this.datagridDevolvidas_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Venda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Atendimento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Atendimento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cliente";
            this.dataGridViewTextBoxColumn3.FillWeight = 300F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DataDevolucao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Devolução";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbVendasDevolvidas);
            this.groupBox5.Location = new System.Drawing.Point(6, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(921, 67);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Infromações Vendas Devolvidas";
            // 
            // lbVendasDevolvidas
            // 
            this.lbVendasDevolvidas.AutoSize = true;
            this.lbVendasDevolvidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVendasDevolvidas.ForeColor = System.Drawing.Color.Red;
            this.lbVendasDevolvidas.Location = new System.Drawing.Point(3, 27);
            this.lbVendasDevolvidas.Name = "lbVendasDevolvidas";
            this.lbVendasDevolvidas.Padding = new System.Windows.Forms.Padding(5);
            this.lbVendasDevolvidas.Size = new System.Drawing.Size(62, 23);
            this.lbVendasDevolvidas.TabIndex = 0;
            this.lbVendasDevolvidas.Text = "cLabel1";
            // 
            // Conferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "Conferencia";
            this.Text = "Conferencia";
            this.Load += new System.EventHandler(this.Liberacao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridDevolvidas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private GroupBox groupBox2;
        protected DataGridView dataGrid;
        private DataGridViewTextBoxColumn CodVenda;
        private DataGridViewTextBoxColumn CodAtendimento;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewCheckBoxColumn Status;
        private GroupBox groupBox1;
        private CLabel lbInfo;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private Button btnBusca;
        private TextBox tbBusca;
        private ComboBox ddlTipoBusca;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private CLabel lbVendasDevolvidas;
        protected DataGridView datagridDevolvidas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private GroupBox groupBox6;
        private Button btFiltrarDevolvidas;
        private CLabel cLabel1;
        private DateTimePicker dateTimeInicial;
        private DateTimePicker dateTimeFinal;

    }
}