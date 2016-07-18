namespace Canaan.Relatorios.Base
{
    partial class FiltroModelo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.atendimentosDataGridView = new System.Windows.Forms.DataGridView();
            this.IdAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodReduzido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRecepcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.modelosDataGridView = new System.Windows.Forms.DataGridView();
            this.IdModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImpimir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atendimentosDataGridView)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelosDataGridView)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(753, 74);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnConsultar);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.codigoTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 48);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filtro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(652, 10);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(338, 12);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(308, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Cliente";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(105, 12);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(118, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Pacote";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(12, 90);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(753, 208);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.atendimentosDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 182);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Resultado Da Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // atendimentosDataGridView
            // 
            this.atendimentosDataGridView.AllowUserToAddRows = false;
            this.atendimentosDataGridView.AllowUserToDeleteRows = false;
            this.atendimentosDataGridView.AllowUserToResizeColumns = false;
            this.atendimentosDataGridView.AllowUserToResizeRows = false;
            this.atendimentosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.atendimentosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.atendimentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.atendimentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAtendimento,
            this.CodReduzido,
            this.Nome,
            this.DataRecepcao});
            this.atendimentosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atendimentosDataGridView.Location = new System.Drawing.Point(3, 3);
            this.atendimentosDataGridView.MultiSelect = false;
            this.atendimentosDataGridView.Name = "atendimentosDataGridView";
            this.atendimentosDataGridView.ReadOnly = true;
            this.atendimentosDataGridView.RowHeadersVisible = false;
            this.atendimentosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.atendimentosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.atendimentosDataGridView.ShowCellErrors = false;
            this.atendimentosDataGridView.ShowCellToolTips = false;
            this.atendimentosDataGridView.ShowEditingIcon = false;
            this.atendimentosDataGridView.ShowRowErrors = false;
            this.atendimentosDataGridView.Size = new System.Drawing.Size(739, 176);
            this.atendimentosDataGridView.TabIndex = 0;
            this.atendimentosDataGridView.SelectionChanged += new System.EventHandler(this.atendimentosDataGridView_SelectionChanged);
            // 
            // IdAtendimento
            // 
            this.IdAtendimento.DataPropertyName = "IdAtendimento";
            this.IdAtendimento.HeaderText = "IdAtendimento";
            this.IdAtendimento.Name = "IdAtendimento";
            this.IdAtendimento.ReadOnly = true;
            this.IdAtendimento.Visible = false;
            // 
            // CodReduzido
            // 
            this.CodReduzido.DataPropertyName = "CodReduzido";
            this.CodReduzido.HeaderText = "Cod Pacote";
            this.CodReduzido.Name = "CodReduzido";
            this.CodReduzido.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome Completo";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // DataRecepcao
            // 
            this.DataRecepcao.DataPropertyName = "DataRecepcao";
            this.DataRecepcao.HeaderText = "Data Recepcao";
            this.DataRecepcao.Name = "DataRecepcao";
            this.DataRecepcao.ReadOnly = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(12, 304);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(753, 167);
            this.tabControl3.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.modelosDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(745, 141);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Selecione o Modelo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // modelosDataGridView
            // 
            this.modelosDataGridView.AllowUserToAddRows = false;
            this.modelosDataGridView.AllowUserToDeleteRows = false;
            this.modelosDataGridView.AllowUserToResizeColumns = false;
            this.modelosDataGridView.AllowUserToResizeRows = false;
            this.modelosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.modelosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.modelosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdModelo,
            this.ModeloNome,
            this.ModeloCpf,
            this.ModeloNascimento,
            this.ModeloIdade});
            this.modelosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelosDataGridView.Location = new System.Drawing.Point(3, 3);
            this.modelosDataGridView.MultiSelect = false;
            this.modelosDataGridView.Name = "modelosDataGridView";
            this.modelosDataGridView.ReadOnly = true;
            this.modelosDataGridView.RowHeadersVisible = false;
            this.modelosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.modelosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modelosDataGridView.ShowCellErrors = false;
            this.modelosDataGridView.ShowCellToolTips = false;
            this.modelosDataGridView.ShowEditingIcon = false;
            this.modelosDataGridView.ShowRowErrors = false;
            this.modelosDataGridView.Size = new System.Drawing.Size(739, 135);
            this.modelosDataGridView.TabIndex = 0;
            // 
            // IdModelo
            // 
            this.IdModelo.DataPropertyName = "IdModelo";
            this.IdModelo.HeaderText = "IdModelo";
            this.IdModelo.Name = "IdModelo";
            this.IdModelo.ReadOnly = true;
            this.IdModelo.Visible = false;
            // 
            // ModeloNome
            // 
            this.ModeloNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ModeloNome.DataPropertyName = "Nome";
            this.ModeloNome.HeaderText = "Nome";
            this.ModeloNome.Name = "ModeloNome";
            this.ModeloNome.ReadOnly = true;
            // 
            // ModeloCpf
            // 
            this.ModeloCpf.DataPropertyName = "Cpf";
            this.ModeloCpf.HeaderText = "Cpf";
            this.ModeloCpf.Name = "ModeloCpf";
            this.ModeloCpf.ReadOnly = true;
            // 
            // ModeloNascimento
            // 
            this.ModeloNascimento.DataPropertyName = "Nascimento";
            this.ModeloNascimento.HeaderText = "Nascimento";
            this.ModeloNascimento.Name = "ModeloNascimento";
            this.ModeloNascimento.ReadOnly = true;
            // 
            // ModeloIdade
            // 
            this.ModeloIdade.DataPropertyName = "Idade";
            this.ModeloIdade.HeaderText = "Idade";
            this.ModeloIdade.Name = "ModeloIdade";
            this.ModeloIdade.ReadOnly = true;
            // 
            // btnImpimir
            // 
            this.btnImpimir.Location = new System.Drawing.Point(625, 477);
            this.btnImpimir.Name = "btnImpimir";
            this.btnImpimir.Size = new System.Drawing.Size(140, 23);
            this.btnImpimir.TabIndex = 6;
            this.btnImpimir.Text = "Imprimir Relatório";
            this.btnImpimir.UseVisualStyleBackColor = true;
            this.btnImpimir.Click += new System.EventHandler(this.btnImpimir_Click);
            // 
            // FiltroModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 509);
            this.Controls.Add(this.btnImpimir);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiltroModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Modelo";
            this.Load += new System.EventHandler(this.FiltroModelo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atendimentosDataGridView)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TabControl tabControl2;
        protected System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView atendimentosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAtendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodReduzido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataRecepcao;
        protected System.Windows.Forms.TabControl tabControl3;
        protected System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView modelosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloIdade;
        private System.Windows.Forms.Button btnImpimir;
    }
}