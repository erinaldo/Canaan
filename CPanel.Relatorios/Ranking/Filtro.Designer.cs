namespace CPanel.Relatorios.Ranking
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
            this.GroupBoxTipo = new System.Windows.Forms.GroupBox();
            this.filtroTipoSetor = new System.Windows.Forms.RadioButton();
            this.filtroTipoGeral = new System.Windows.Forms.RadioButton();
            this.filtroTipoFranquia = new System.Windows.Forms.RadioButton();
            this.filtroTipoRede = new System.Windows.Forms.RadioButton();
            this.GroupBoxSetor = new System.Windows.Forms.GroupBox();
            this.filtroSetor = new System.Windows.Forms.ComboBox();
            this.GroupBoxLancamento = new System.Windows.Forms.GroupBox();
            this.filtroDiaFim = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.filtroDiaInic = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.filtroMes = new System.Windows.Forms.ComboBox();
            this.filtroAno = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.GroupBoxTipo.SuspendLayout();
            this.GroupBoxSetor.SuspendLayout();
            this.GroupBoxLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxTipo
            // 
            this.GroupBoxTipo.Controls.Add(this.filtroTipoSetor);
            this.GroupBoxTipo.Controls.Add(this.filtroTipoGeral);
            this.GroupBoxTipo.Controls.Add(this.filtroTipoFranquia);
            this.GroupBoxTipo.Controls.Add(this.filtroTipoRede);
            this.GroupBoxTipo.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxTipo.Name = "GroupBoxTipo";
            this.GroupBoxTipo.Size = new System.Drawing.Size(295, 117);
            this.GroupBoxTipo.TabIndex = 10;
            this.GroupBoxTipo.TabStop = false;
            this.GroupBoxTipo.Text = "Selecione o Tipo ";
            // 
            // filtroTipoSetor
            // 
            this.filtroTipoSetor.AutoSize = true;
            this.filtroTipoSetor.Location = new System.Drawing.Point(7, 89);
            this.filtroTipoSetor.Name = "filtroTipoSetor";
            this.filtroTipoSetor.Size = new System.Drawing.Size(111, 17);
            this.filtroTipoSetor.TabIndex = 3;
            this.filtroTipoSetor.Text = "Ranking por Setor";
            this.filtroTipoSetor.UseVisualStyleBackColor = true;
            this.filtroTipoSetor.CheckedChanged += new System.EventHandler(this.filtroTipoSetor_CheckedChanged);
            // 
            // filtroTipoGeral
            // 
            this.filtroTipoGeral.AutoSize = true;
            this.filtroTipoGeral.Location = new System.Drawing.Point(7, 19);
            this.filtroTipoGeral.Name = "filtroTipoGeral";
            this.filtroTipoGeral.Size = new System.Drawing.Size(93, 17);
            this.filtroTipoGeral.TabIndex = 2;
            this.filtroTipoGeral.Text = "Ranking Geral";
            this.filtroTipoGeral.UseVisualStyleBackColor = true;
            this.filtroTipoGeral.CheckedChanged += new System.EventHandler(this.filtroTipoGeral_CheckedChanged);
            // 
            // filtroTipoFranquia
            // 
            this.filtroTipoFranquia.AutoSize = true;
            this.filtroTipoFranquia.Location = new System.Drawing.Point(7, 66);
            this.filtroTipoFranquia.Name = "filtroTipoFranquia";
            this.filtroTipoFranquia.Size = new System.Drawing.Size(134, 17);
            this.filtroTipoFranquia.TabIndex = 1;
            this.filtroTipoFranquia.Text = "Ranking das Franquias";
            this.filtroTipoFranquia.UseVisualStyleBackColor = true;
            this.filtroTipoFranquia.CheckedChanged += new System.EventHandler(this.filtroTipoFranquia_CheckedChanged);
            // 
            // filtroTipoRede
            // 
            this.filtroTipoRede.AutoSize = true;
            this.filtroTipoRede.Location = new System.Drawing.Point(7, 43);
            this.filtroTipoRede.Name = "filtroTipoRede";
            this.filtroTipoRede.Size = new System.Drawing.Size(109, 17);
            this.filtroTipoRede.TabIndex = 0;
            this.filtroTipoRede.Text = "Ranking da Rede";
            this.filtroTipoRede.UseVisualStyleBackColor = true;
            this.filtroTipoRede.CheckedChanged += new System.EventHandler(this.filtroTipoRede_CheckedChanged);
            // 
            // GroupBoxSetor
            // 
            this.GroupBoxSetor.Controls.Add(this.filtroSetor);
            this.GroupBoxSetor.Location = new System.Drawing.Point(12, 135);
            this.GroupBoxSetor.Name = "GroupBoxSetor";
            this.GroupBoxSetor.Size = new System.Drawing.Size(295, 53);
            this.GroupBoxSetor.TabIndex = 12;
            this.GroupBoxSetor.TabStop = false;
            this.GroupBoxSetor.Text = "Especificar um setor";
            // 
            // filtroSetor
            // 
            this.filtroSetor.DisplayMember = "nome";
            this.filtroSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroSetor.FormattingEnabled = true;
            this.filtroSetor.Location = new System.Drawing.Point(6, 19);
            this.filtroSetor.Name = "filtroSetor";
            this.filtroSetor.Size = new System.Drawing.Size(274, 21);
            this.filtroSetor.TabIndex = 1;
            this.filtroSetor.ValueMember = "id_setor";
            // 
            // GroupBoxLancamento
            // 
            this.GroupBoxLancamento.Controls.Add(this.filtroDiaFim);
            this.GroupBoxLancamento.Controls.Add(this.Label4);
            this.GroupBoxLancamento.Controls.Add(this.filtroDiaInic);
            this.GroupBoxLancamento.Controls.Add(this.Label3);
            this.GroupBoxLancamento.Controls.Add(this.filtroMes);
            this.GroupBoxLancamento.Controls.Add(this.filtroAno);
            this.GroupBoxLancamento.Controls.Add(this.Label2);
            this.GroupBoxLancamento.Controls.Add(this.Label1);
            this.GroupBoxLancamento.Location = new System.Drawing.Point(12, 194);
            this.GroupBoxLancamento.Name = "GroupBoxLancamento";
            this.GroupBoxLancamento.Size = new System.Drawing.Size(295, 104);
            this.GroupBoxLancamento.TabIndex = 13;
            this.GroupBoxLancamento.TabStop = false;
            this.GroupBoxLancamento.Text = "Período de Lançamento";
            // 
            // filtroDiaFim
            // 
            this.filtroDiaFim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroDiaFim.FormattingEnabled = true;
            this.filtroDiaFim.Location = new System.Drawing.Point(213, 72);
            this.filtroDiaFim.Name = "filtroDiaFim";
            this.filtroDiaFim.Size = new System.Drawing.Size(68, 21);
            this.filtroDiaFim.TabIndex = 11;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(194, 75);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(13, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "a";
            // 
            // filtroDiaInic
            // 
            this.filtroDiaInic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroDiaInic.FormattingEnabled = true;
            this.filtroDiaInic.Location = new System.Drawing.Point(120, 72);
            this.filtroDiaInic.Name = "filtroDiaInic";
            this.filtroDiaInic.Size = new System.Drawing.Size(68, 21);
            this.filtroDiaInic.TabIndex = 9;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 75);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(107, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Selecione o Período:";
            // 
            // filtroMes
            // 
            this.filtroMes.DisplayMember = "descricao";
            this.filtroMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroMes.FormattingEnabled = true;
            this.filtroMes.Location = new System.Drawing.Point(120, 45);
            this.filtroMes.Name = "filtroMes";
            this.filtroMes.Size = new System.Drawing.Size(161, 21);
            this.filtroMes.TabIndex = 7;
            this.filtroMes.ValueMember = "mes";
            this.filtroMes.SelectedIndexChanged += new System.EventHandler(this.filtroMes_SelectedIndexChanged);
            // 
            // filtroAno
            // 
            this.filtroAno.Location = new System.Drawing.Point(120, 19);
            this.filtroAno.Name = "filtroAno";
            this.filtroAno.Size = new System.Drawing.Size(68, 20);
            this.filtroAno.TabIndex = 6;
            this.filtroAno.TextChanged += new System.EventHandler(this.filtroAno_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Selecione o Mês:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Digite o Ano:";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(200, 304);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(107, 23);
            this.btnGerar.TabIndex = 14;
            this.btnGerar.Text = "Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 341);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.GroupBoxLancamento);
            this.Controls.Add(this.GroupBoxSetor);
            this.Controls.Add(this.GroupBoxTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking dos Estúdios";
            this.GroupBoxTipo.ResumeLayout(false);
            this.GroupBoxTipo.PerformLayout();
            this.GroupBoxSetor.ResumeLayout(false);
            this.GroupBoxLancamento.ResumeLayout(false);
            this.GroupBoxLancamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBoxTipo;
        internal System.Windows.Forms.RadioButton filtroTipoSetor;
        internal System.Windows.Forms.RadioButton filtroTipoGeral;
        internal System.Windows.Forms.RadioButton filtroTipoFranquia;
        internal System.Windows.Forms.RadioButton filtroTipoRede;
        internal System.Windows.Forms.GroupBox GroupBoxSetor;
        internal System.Windows.Forms.ComboBox filtroSetor;
        internal System.Windows.Forms.GroupBox GroupBoxLancamento;
        internal System.Windows.Forms.ComboBox filtroDiaFim;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox filtroDiaInic;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox filtroMes;
        internal System.Windows.Forms.TextBox filtroAno;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnGerar;
    }
}