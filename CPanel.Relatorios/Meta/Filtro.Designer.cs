namespace CPanel.Relatorios.Meta
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.GroupBoxLancamento = new System.Windows.Forms.GroupBox();
            this.filtroMes = new System.Windows.Forms.ComboBox();
            this.filtroAno = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBoxSetor = new System.Windows.Forms.GroupBox();
            this.filtroSetor = new System.Windows.Forms.ComboBox();
            this.GroupBoxFilial = new System.Windows.Forms.GroupBox();
            this.filtroFilial = new System.Windows.Forms.ComboBox();
            this.cbFilial = new System.Windows.Forms.CheckBox();
            this.GroupBoxTipo = new System.Windows.Forms.GroupBox();
            this.filtroTipoSetor = new System.Windows.Forms.RadioButton();
            this.filtroTipoIndiv = new System.Windows.Forms.RadioButton();
            this.filtroTipoFranquia = new System.Windows.Forms.RadioButton();
            this.filtroTipoRede = new System.Windows.Forms.RadioButton();
            this.GroupBoxLancamento.SuspendLayout();
            this.GroupBoxSetor.SuspendLayout();
            this.GroupBoxFilial.SuspendLayout();
            this.GroupBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(200, 359);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(107, 23);
            this.btnGerar.TabIndex = 18;
            this.btnGerar.Text = "Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // GroupBoxLancamento
            // 
            this.GroupBoxLancamento.Controls.Add(this.filtroMes);
            this.GroupBoxLancamento.Controls.Add(this.filtroAno);
            this.GroupBoxLancamento.Controls.Add(this.Label2);
            this.GroupBoxLancamento.Controls.Add(this.Label1);
            this.GroupBoxLancamento.Location = new System.Drawing.Point(12, 275);
            this.GroupBoxLancamento.Name = "GroupBoxLancamento";
            this.GroupBoxLancamento.Size = new System.Drawing.Size(295, 78);
            this.GroupBoxLancamento.TabIndex = 17;
            this.GroupBoxLancamento.TabStop = false;
            this.GroupBoxLancamento.Text = "Período de Lançamento";
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
            // 
            // filtroAno
            // 
            this.filtroAno.Location = new System.Drawing.Point(120, 19);
            this.filtroAno.Name = "filtroAno";
            this.filtroAno.Size = new System.Drawing.Size(68, 20);
            this.filtroAno.TabIndex = 6;
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
            // GroupBoxSetor
            // 
            this.GroupBoxSetor.Controls.Add(this.filtroSetor);
            this.GroupBoxSetor.Location = new System.Drawing.Point(12, 216);
            this.GroupBoxSetor.Name = "GroupBoxSetor";
            this.GroupBoxSetor.Size = new System.Drawing.Size(295, 53);
            this.GroupBoxSetor.TabIndex = 16;
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
            // GroupBoxFilial
            // 
            this.GroupBoxFilial.Controls.Add(this.filtroFilial);
            this.GroupBoxFilial.Controls.Add(this.cbFilial);
            this.GroupBoxFilial.Location = new System.Drawing.Point(12, 135);
            this.GroupBoxFilial.Name = "GroupBoxFilial";
            this.GroupBoxFilial.Size = new System.Drawing.Size(295, 75);
            this.GroupBoxFilial.TabIndex = 15;
            this.GroupBoxFilial.TabStop = false;
            this.GroupBoxFilial.Text = "Especificar uma filial";
            // 
            // filtroFilial
            // 
            this.filtroFilial.DisplayMember = "nome";
            this.filtroFilial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroFilial.Enabled = false;
            this.filtroFilial.FormattingEnabled = true;
            this.filtroFilial.Location = new System.Drawing.Point(7, 43);
            this.filtroFilial.Name = "filtroFilial";
            this.filtroFilial.Size = new System.Drawing.Size(274, 21);
            this.filtroFilial.TabIndex = 1;
            this.filtroFilial.ValueMember = "id_filial";
            // 
            // cbFilial
            // 
            this.cbFilial.AutoSize = true;
            this.cbFilial.Location = new System.Drawing.Point(7, 20);
            this.cbFilial.Name = "cbFilial";
            this.cbFilial.Size = new System.Drawing.Size(161, 17);
            this.cbFilial.TabIndex = 0;
            this.cbFilial.Text = "Desejo especificar um studio";
            this.cbFilial.UseVisualStyleBackColor = true;
            this.cbFilial.CheckedChanged += new System.EventHandler(this.cbFilial_CheckedChanged);
            // 
            // GroupBoxTipo
            // 
            this.GroupBoxTipo.Controls.Add(this.filtroTipoSetor);
            this.GroupBoxTipo.Controls.Add(this.filtroTipoIndiv);
            this.GroupBoxTipo.Controls.Add(this.filtroTipoFranquia);
            this.GroupBoxTipo.Controls.Add(this.filtroTipoRede);
            this.GroupBoxTipo.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxTipo.Name = "GroupBoxTipo";
            this.GroupBoxTipo.Size = new System.Drawing.Size(295, 117);
            this.GroupBoxTipo.TabIndex = 14;
            this.GroupBoxTipo.TabStop = false;
            this.GroupBoxTipo.Text = "Selecione o Tipo ";
            // 
            // filtroTipoSetor
            // 
            this.filtroTipoSetor.AutoSize = true;
            this.filtroTipoSetor.Location = new System.Drawing.Point(7, 89);
            this.filtroTipoSetor.Name = "filtroTipoSetor";
            this.filtroTipoSetor.Size = new System.Drawing.Size(154, 17);
            this.filtroTipoSetor.TabIndex = 3;
            this.filtroTipoSetor.Text = "Perfil Operacional por Setor";
            this.filtroTipoSetor.UseVisualStyleBackColor = true;
            this.filtroTipoSetor.CheckedChanged += new System.EventHandler(this.filtroTipoSetor_CheckedChanged);
            // 
            // filtroTipoIndiv
            // 
            this.filtroTipoIndiv.AutoSize = true;
            this.filtroTipoIndiv.Location = new System.Drawing.Point(7, 66);
            this.filtroTipoIndiv.Name = "filtroTipoIndiv";
            this.filtroTipoIndiv.Size = new System.Drawing.Size(156, 17);
            this.filtroTipoIndiv.TabIndex = 2;
            this.filtroTipoIndiv.Text = "Perfil Operacional Individual";
            this.filtroTipoIndiv.UseVisualStyleBackColor = true;
            this.filtroTipoIndiv.CheckedChanged += new System.EventHandler(this.filtroTipoIndiv_CheckedChanged);
            // 
            // filtroTipoFranquia
            // 
            this.filtroTipoFranquia.AutoSize = true;
            this.filtroTipoFranquia.Location = new System.Drawing.Point(7, 43);
            this.filtroTipoFranquia.Name = "filtroTipoFranquia";
            this.filtroTipoFranquia.Size = new System.Drawing.Size(177, 17);
            this.filtroTipoFranquia.TabIndex = 1;
            this.filtroTipoFranquia.Text = "Perfil Operacional das Franquias";
            this.filtroTipoFranquia.UseVisualStyleBackColor = true;
            this.filtroTipoFranquia.CheckedChanged += new System.EventHandler(this.filtroTipoFranquia_CheckedChanged);
            // 
            // filtroTipoRede
            // 
            this.filtroTipoRede.AutoSize = true;
            this.filtroTipoRede.Location = new System.Drawing.Point(7, 20);
            this.filtroTipoRede.Name = "filtroTipoRede";
            this.filtroTipoRede.Size = new System.Drawing.Size(152, 17);
            this.filtroTipoRede.TabIndex = 0;
            this.filtroTipoRede.Text = "Perfil Operacional da Rede";
            this.filtroTipoRede.UseVisualStyleBackColor = true;
            this.filtroTipoRede.CheckedChanged += new System.EventHandler(this.filtroTipoRede_CheckedChanged);
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 394);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.GroupBoxLancamento);
            this.Controls.Add(this.GroupBoxSetor);
            this.Controls.Add(this.GroupBoxFilial);
            this.Controls.Add(this.GroupBoxTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Metas";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.GroupBoxLancamento.ResumeLayout(false);
            this.GroupBoxLancamento.PerformLayout();
            this.GroupBoxSetor.ResumeLayout(false);
            this.GroupBoxFilial.ResumeLayout(false);
            this.GroupBoxFilial.PerformLayout();
            this.GroupBoxTipo.ResumeLayout(false);
            this.GroupBoxTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnGerar;
        internal System.Windows.Forms.GroupBox GroupBoxLancamento;
        internal System.Windows.Forms.ComboBox filtroMes;
        internal System.Windows.Forms.TextBox filtroAno;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBoxSetor;
        internal System.Windows.Forms.ComboBox filtroSetor;
        internal System.Windows.Forms.GroupBox GroupBoxFilial;
        internal System.Windows.Forms.ComboBox filtroFilial;
        internal System.Windows.Forms.CheckBox cbFilial;
        internal System.Windows.Forms.GroupBox GroupBoxTipo;
        internal System.Windows.Forms.RadioButton filtroTipoSetor;
        internal System.Windows.Forms.RadioButton filtroTipoIndiv;
        internal System.Windows.Forms.RadioButton filtroTipoFranquia;
        internal System.Windows.Forms.RadioButton filtroTipoRede;

    }
}