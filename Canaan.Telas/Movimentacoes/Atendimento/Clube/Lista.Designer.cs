using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Movimentacoes.Atendimento.Clube
{
    partial class Lista
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
            this.lbQtdade = new Canaan.Lib.Componentes.CLabel();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAtendimentos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtendimentoGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.tbBusca = new System.Windows.Forms.TextBox();
            this.ddlTipoBusca = new System.Windows.Forms.ComboBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Indicações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel2);
            this.groupBox3.Controls.Add(this.lbQtdade);
            this.groupBox3.Controls.Add(this.cLabel1);
            this.groupBox3.Location = new System.Drawing.Point(6, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(759, 76);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumo";
            // 
            // lbQtdade
            // 
            this.lbQtdade.AutoSize = true;
            this.lbQtdade.Location = new System.Drawing.Point(156, 30);
            this.lbQtdade.Name = "lbQtdade";
            this.lbQtdade.Padding = new System.Windows.Forms.Padding(5);
            this.lbQtdade.Size = new System.Drawing.Size(10, 23);
            this.lbQtdade.TabIndex = 1;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(20, 30);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(142, 23);
            this.cLabel1.TabIndex = 0;
            this.cLabel1.Text = "Quantidade de Indicações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAtendimentos);
            this.groupBox2.Location = new System.Drawing.Point(8, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 191);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Indicações Encontradas";
            // 
            // dgvAtendimentos
            // 
            this.dgvAtendimentos.AllowUserToAddRows = false;
            this.dgvAtendimentos.AllowUserToDeleteRows = false;
            this.dgvAtendimentos.AllowUserToResizeColumns = false;
            this.dgvAtendimentos.AllowUserToResizeRows = false;
            this.dgvAtendimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtendimentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAtendimentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.AtendimentoGrid,
            this.Nome,
            this.Documento});
            this.dgvAtendimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtendimentos.Location = new System.Drawing.Point(3, 16);
            this.dgvAtendimentos.MultiSelect = false;
            this.dgvAtendimentos.Name = "dgvAtendimentos";
            this.dgvAtendimentos.ReadOnly = true;
            this.dgvAtendimentos.RowHeadersVisible = false;
            this.dgvAtendimentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtendimentos.ShowCellErrors = false;
            this.dgvAtendimentos.ShowCellToolTips = false;
            this.dgvAtendimentos.ShowEditingIcon = false;
            this.dgvAtendimentos.ShowRowErrors = false;
            this.dgvAtendimentos.Size = new System.Drawing.Size(751, 172);
            this.dgvAtendimentos.TabIndex = 1;
            this.dgvAtendimentos.SelectionChanged += new System.EventHandler(this.dgvAtendimentos_SelectionChanged);
            this.dgvAtendimentos.DoubleClick += new System.EventHandler(this.dgvAtendimentos_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // AtendimentoGrid
            // 
            this.AtendimentoGrid.DataPropertyName = "Atendimento";
            this.AtendimentoGrid.FillWeight = 40F;
            this.AtendimentoGrid.HeaderText = "Atendimento";
            this.AtendimentoGrid.Name = "AtendimentoGrid";
            this.AtendimentoGrid.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Cliente";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Data";
            this.Documento.FillWeight = 40F;
            this.Documento.HeaderText = "Data";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnBusca);
            this.groupBox1.Controls.Add(this.tbBusca);
            this.groupBox1.Controls.Add(this.ddlTipoBusca);
            this.groupBox1.Controls.Add(this.labelValor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções de Busca";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(595, 52);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 14;
            this.btnBusca.Text = "Consultar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(172, 54);
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(417, 20);
            this.tbBusca.TabIndex = 13;
            // 
            // ddlTipoBusca
            // 
            this.ddlTipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoBusca.FormattingEnabled = true;
            this.ddlTipoBusca.Location = new System.Drawing.Point(172, 27);
            this.ddlTipoBusca.Name = "ddlTipoBusca";
            this.ddlTipoBusca.Size = new System.Drawing.Size(152, 21);
            this.ddlTipoBusca.TabIndex = 12;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(15, 57);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(126, 13);
            this.labelValor.TabIndex = 11;
            this.labelValor.Text = "Informe o Valor da Busca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione o Tipo de Busca";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(626, 40);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(49, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Detalhes";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 411);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Clube da Amizade";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Button btnBusca;
        private TextBox tbBusca;
        private ComboBox ddlTipoBusca;
        private Label labelValor;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvAtendimentos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn AtendimentoGrid;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Documento;
        private GroupBox groupBox3;
        private CLabel cLabel1;
        private CLabel lbQtdade;
        private LinkLabel linkLabel2;
    }
}