namespace CPanel.Relatorios.Lancamentos
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
            this.groupBoxFilial = new System.Windows.Forms.GroupBox();
            this.comboBoxFilial = new System.Windows.Forms.ComboBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.checkBoxFilial = new System.Windows.Forms.CheckBox();
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.filtroMes = new System.Windows.Forms.ComboBox();
            this.filtroAno = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBoxFilial.SuspendLayout();
            this.groupBoxPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFilial
            // 
            this.groupBoxFilial.Controls.Add(this.checkBoxFilial);
            this.groupBoxFilial.Controls.Add(this.comboBoxFilial);
            this.groupBoxFilial.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilial.Name = "groupBoxFilial";
            this.groupBoxFilial.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxFilial.Size = new System.Drawing.Size(330, 74);
            this.groupBoxFilial.TabIndex = 0;
            this.groupBoxFilial.TabStop = false;
            this.groupBoxFilial.Text = "Filtro das Filiais";
            // 
            // comboBoxFilial
            // 
            this.comboBoxFilial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilial.FormattingEnabled = true;
            this.comboBoxFilial.Location = new System.Drawing.Point(11, 42);
            this.comboBoxFilial.Name = "comboBoxFilial";
            this.comboBoxFilial.Size = new System.Drawing.Size(306, 21);
            this.comboBoxFilial.TabIndex = 1;
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(106, 191);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(127, 23);
            this.btnGerarRelatorio.TabIndex = 6;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // checkBoxFilial
            // 
            this.checkBoxFilial.AutoSize = true;
            this.checkBoxFilial.Location = new System.Drawing.Point(11, 21);
            this.checkBoxFilial.Name = "checkBoxFilial";
            this.checkBoxFilial.Size = new System.Drawing.Size(160, 17);
            this.checkBoxFilial.TabIndex = 7;
            this.checkBoxFilial.Text = "Deseja Especificar uma Filial";
            this.checkBoxFilial.UseVisualStyleBackColor = true;
            this.checkBoxFilial.CheckedChanged += new System.EventHandler(this.checkBoxFilial_CheckedChanged);
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.Controls.Add(this.filtroMes);
            this.groupBoxPeriodo.Controls.Add(this.filtroAno);
            this.groupBoxPeriodo.Controls.Add(this.Label2);
            this.groupBoxPeriodo.Controls.Add(this.Label1);
            this.groupBoxPeriodo.Location = new System.Drawing.Point(12, 92);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxPeriodo.Size = new System.Drawing.Size(328, 84);
            this.groupBoxPeriodo.TabIndex = 1;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "Filtro do Período";
            // 
            // filtroMes
            // 
            this.filtroMes.DisplayMember = "descricao";
            this.filtroMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroMes.FormattingEnabled = true;
            this.filtroMes.Location = new System.Drawing.Point(122, 47);
            this.filtroMes.Name = "filtroMes";
            this.filtroMes.Size = new System.Drawing.Size(195, 21);
            this.filtroMes.TabIndex = 11;
            this.filtroMes.ValueMember = "mes";
            // 
            // filtroAno
            // 
            this.filtroAno.Location = new System.Drawing.Point(122, 21);
            this.filtroAno.Name = "filtroAno";
            this.filtroAno.Size = new System.Drawing.Size(68, 20);
            this.filtroAno.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Selecione o Mês:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Digite o Ano:";
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 226);
            this.Controls.Add(this.groupBoxPeriodo);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.groupBoxFilial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lancamentos Diários";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.groupBoxFilial.ResumeLayout(false);
            this.groupBoxFilial.PerformLayout();
            this.groupBoxPeriodo.ResumeLayout(false);
            this.groupBoxPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFilial;
        private System.Windows.Forms.CheckBox checkBoxFilial;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.ComboBox comboBoxFilial;
        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        internal System.Windows.Forms.ComboBox filtroMes;
        internal System.Windows.Forms.TextBox filtroAno;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}