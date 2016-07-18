using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Base
{
    partial class FormFilterBase
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
            this.tbPageFiltro = new System.Windows.Forms.TabPage();
            this.ckPadrao = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParametroPadrao = new System.Windows.Forms.TextBox();
            this.ckGlobal = new System.Windows.Forms.CheckBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtNomeFiltro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btExecutar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gridExpression = new System.Windows.Forms.DataGridView();
            this.cbLogicos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRelacionais = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProperties = new System.Windows.Forms.ListBox();
            this.OperadorLogico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propriedade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperadorRelacional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbPageFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpression)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbPageFiltro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPageFiltro
            // 
            this.tbPageFiltro.Controls.Add(this.ckPadrao);
            this.tbPageFiltro.Controls.Add(this.label5);
            this.tbPageFiltro.Controls.Add(this.txtParametroPadrao);
            this.tbPageFiltro.Controls.Add(this.ckGlobal);
            this.tbPageFiltro.Controls.Add(this.btSalvar);
            this.tbPageFiltro.Controls.Add(this.txtNomeFiltro);
            this.tbPageFiltro.Controls.Add(this.label4);
            this.tbPageFiltro.Controls.Add(this.btExecutar);
            this.tbPageFiltro.Controls.Add(this.btRemover);
            this.tbPageFiltro.Controls.Add(this.btAdicionar);
            this.tbPageFiltro.Controls.Add(this.gridExpression);
            this.tbPageFiltro.Controls.Add(this.cbLogicos);
            this.tbPageFiltro.Controls.Add(this.label3);
            this.tbPageFiltro.Controls.Add(this.cbRelacionais);
            this.tbPageFiltro.Controls.Add(this.label2);
            this.tbPageFiltro.Controls.Add(this.label1);
            this.tbPageFiltro.Controls.Add(this.lbProperties);
            this.tbPageFiltro.Location = new System.Drawing.Point(4, 22);
            this.tbPageFiltro.Name = "tbPageFiltro";
            this.tbPageFiltro.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageFiltro.Size = new System.Drawing.Size(445, 393);
            this.tbPageFiltro.TabIndex = 0;
            this.tbPageFiltro.Text = "Filtro";
            this.tbPageFiltro.UseVisualStyleBackColor = true;
            // 
            // ckPadrao
            // 
            this.ckPadrao.AutoSize = true;
            this.ckPadrao.Location = new System.Drawing.Point(292, 217);
            this.ckPadrao.Name = "ckPadrao";
            this.ckPadrao.Size = new System.Drawing.Size(87, 17);
            this.ckPadrao.TabIndex = 16;
            this.ckPadrao.Text = "Filtro Padrão";
            this.ckPadrao.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Valor do Parametro";
            // 
            // txtParametroPadrao
            // 
            this.txtParametroPadrao.Location = new System.Drawing.Point(231, 140);
            this.txtParametroPadrao.Name = "txtParametroPadrao";
            this.txtParametroPadrao.Size = new System.Drawing.Size(208, 21);
            this.txtParametroPadrao.TabIndex = 14;
            this.txtParametroPadrao.Visible = false;
            // 
            // ckGlobal
            // 
            this.ckGlobal.AutoSize = true;
            this.ckGlobal.Location = new System.Drawing.Point(231, 217);
            this.ckGlobal.Name = "ckGlobal";
            this.ckGlobal.Size = new System.Drawing.Size(55, 17);
            this.ckGlobal.TabIndex = 13;
            this.ckGlobal.Text = "Global";
            this.ckGlobal.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(364, 366);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtNomeFiltro
            // 
            this.txtNomeFiltro.Location = new System.Drawing.Point(228, 46);
            this.txtNomeFiltro.Name = "txtNomeFiltro";
            this.txtNomeFiltro.Size = new System.Drawing.Size(211, 21);
            this.txtNomeFiltro.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome";
            // 
            // btExecutar
            // 
            this.btExecutar.Location = new System.Drawing.Point(283, 366);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(75, 23);
            this.btExecutar.TabIndex = 9;
            this.btExecutar.Text = "Executar";
            this.btExecutar.UseVisualStyleBackColor = true;
            this.btExecutar.Click += new System.EventHandler(this.btExecutar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(6, 218);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 8;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(364, 180);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 7;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // gridExpression
            // 
            this.gridExpression.AllowUserToAddRows = false;
            this.gridExpression.AllowUserToDeleteRows = false;
            this.gridExpression.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridExpression.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExpression.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperadorLogico,
            this.Propriedade,
            this.OperadorRelacional,
            this.Valor});
            this.gridExpression.Location = new System.Drawing.Point(6, 250);
            this.gridExpression.MultiSelect = false;
            this.gridExpression.Name = "gridExpression";
            this.gridExpression.ReadOnly = true;
            this.gridExpression.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridExpression.Size = new System.Drawing.Size(433, 108);
            this.gridExpression.TabIndex = 6;
            this.gridExpression.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridExpression_DataBindingComplete);
            // 
            // cbLogicos
            // 
            this.cbLogicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogicos.FormattingEnabled = true;
            this.cbLogicos.Location = new System.Drawing.Point(231, 182);
            this.cbLogicos.Name = "cbLogicos";
            this.cbLogicos.Size = new System.Drawing.Size(99, 21);
            this.cbLogicos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operadores Lógicos";
            // 
            // cbRelacionais
            // 
            this.cbRelacionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelacionais.FormattingEnabled = true;
            this.cbRelacionais.Location = new System.Drawing.Point(231, 92);
            this.cbRelacionais.Name = "cbRelacionais";
            this.cbRelacionais.Size = new System.Drawing.Size(208, 21);
            this.cbRelacionais.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operadores Relacionais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propriedades";
            // 
            // lbProperties
            // 
            this.lbProperties.FormattingEnabled = true;
            this.lbProperties.Location = new System.Drawing.Point(6, 30);
            this.lbProperties.Name = "lbProperties";
            this.lbProperties.Size = new System.Drawing.Size(216, 173);
            this.lbProperties.TabIndex = 0;
            this.lbProperties.SelectedIndexChanged += new System.EventHandler(this.lbProperties_SelectedIndexChanged);
            // 
            // OperadorLogico
            // 
            this.OperadorLogico.DataPropertyName = "Logico";
            this.OperadorLogico.HeaderText = "Operador Lógico";
            this.OperadorLogico.Name = "OperadorLogico";
            this.OperadorLogico.ReadOnly = true;
            // 
            // Propriedade
            // 
            this.Propriedade.DataPropertyName = "Property";
            this.Propriedade.HeaderText = "Propriedade";
            this.Propriedade.Name = "Propriedade";
            this.Propriedade.ReadOnly = true;
            // 
            // OperadorRelacional
            // 
            this.OperadorRelacional.DataPropertyName = "Relacional";
            this.OperadorRelacional.HeaderText = "Operador Relacional";
            this.OperadorRelacional.Name = "OperadorRelacional";
            this.OperadorRelacional.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // FormFilterBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 443);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFilterBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Filtros";
            this.Load += new System.EventHandler(this.FormFilterBase_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbPageFiltro.ResumeLayout(false);
            this.tbPageFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridExpression)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbPageFiltro;
        private Label label1;
        private ListBox lbProperties;
        private Label label2;
        private ComboBox cbLogicos;
        private Label label3;
        private ComboBox cbRelacionais;
        private DataGridView gridExpression;
        private Button btAdicionar;
        private Button btRemover;
        private Button btExecutar;
        private Label label4;
        private TextBox txtNomeFiltro;
        private Button btSalvar;
        private CheckBox ckGlobal;
        private TextBox txtParametroPadrao;
        private Label label5;
        private CheckBox ckPadrao;
        private DataGridViewTextBoxColumn OperadorLogico;
        private DataGridViewTextBoxColumn Propriedade;
        private DataGridViewTextBoxColumn OperadorRelacional;
        private DataGridViewTextBoxColumn Valor;
    }
}