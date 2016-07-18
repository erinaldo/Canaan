using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Sessao.Telas
{
    partial class Info
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
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActions = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltros = new System.Windows.Forms.ToolStripSplitButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCriptografia = new System.Windows.Forms.Label();
            this.lbBackup = new System.Windows.Forms.Label();
            this.lbTempoSessao = new System.Windows.Forms.Label();
            this.lbQuantidadeFoto = new System.Windows.Forms.Label();
            this.lbNumeroSessao = new System.Windows.Forms.Label();
            this.lbDataSessao = new System.Windows.Forms.Label();
            this.lbFotografa = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbCodigoSessao = new System.Windows.Forms.Label();
            this.lbAtendimento = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolstripActions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnActions,
            this.toolStripSeparator4,
            this.btnFiltros});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(735, 33);
            this.toolstripActions.TabIndex = 2;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 20);
            this.toolStripButton1.Text = "Salvar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripSalvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnActions
            // 
            this.btnActions.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.btnActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(109, 20);
            this.btnActions.Text = "Outras Ações";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnFiltros
            // 
            this.btnFiltros.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.btnFiltros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(71, 20);
            this.btnFiltros.Text = "Filtros";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 342);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lbGenero);
            this.tabPage1.Controls.Add(this.lbTipo);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.lbCriptografia);
            this.tabPage1.Controls.Add(this.lbBackup);
            this.tabPage1.Controls.Add(this.lbTempoSessao);
            this.tabPage1.Controls.Add(this.lbQuantidadeFoto);
            this.tabPage1.Controls.Add(this.lbNumeroSessao);
            this.tabPage1.Controls.Add(this.lbDataSessao);
            this.tabPage1.Controls.Add(this.lbFotografa);
            this.tabPage1.Controls.Add(this.lbCliente);
            this.tabPage1.Controls.Add(this.lbCodigoSessao);
            this.tabPage1.Controls.Add(this.lbAtendimento);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(703, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações Gerais do Atendimento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbGenero);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(381, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 146);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Adicionais";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(19, 102);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(267, 21);
            this.cbTipo.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tipo";
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(19, 46);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(267, 21);
            this.cbGenero.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Genero";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(192, 83);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(50, 13);
            this.lbGenero.TabIndex = 23;
            this.lbGenero.Text = "lbGenero";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(192, 104);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(35, 13);
            this.lbTipo.TabIndex = 22;
            this.lbTipo.Text = "lbTipo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Tipo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Genero";
            // 
            // lbCriptografia
            // 
            this.lbCriptografia.AutoSize = true;
            this.lbCriptografia.Location = new System.Drawing.Point(192, 265);
            this.lbCriptografia.Name = "lbCriptografia";
            this.lbCriptografia.Size = new System.Drawing.Size(72, 13);
            this.lbCriptografia.TabIndex = 19;
            this.lbCriptografia.Text = "lbCriptografia";
            // 
            // lbBackup
            // 
            this.lbBackup.AutoSize = true;
            this.lbBackup.Location = new System.Drawing.Point(192, 242);
            this.lbBackup.Name = "lbBackup";
            this.lbBackup.Size = new System.Drawing.Size(49, 13);
            this.lbBackup.TabIndex = 18;
            this.lbBackup.Text = "lbBackup";
            // 
            // lbTempoSessao
            // 
            this.lbTempoSessao.AutoSize = true;
            this.lbTempoSessao.Location = new System.Drawing.Point(192, 219);
            this.lbTempoSessao.Name = "lbTempoSessao";
            this.lbTempoSessao.Size = new System.Drawing.Size(81, 13);
            this.lbTempoSessao.TabIndex = 17;
            this.lbTempoSessao.Text = "lbTempoSessao";
            // 
            // lbQuantidadeFoto
            // 
            this.lbQuantidadeFoto.AutoSize = true;
            this.lbQuantidadeFoto.Location = new System.Drawing.Point(192, 196);
            this.lbQuantidadeFoto.Name = "lbQuantidadeFoto";
            this.lbQuantidadeFoto.Size = new System.Drawing.Size(93, 13);
            this.lbQuantidadeFoto.TabIndex = 16;
            this.lbQuantidadeFoto.Text = "lbQuantidadeFoto";
            // 
            // lbNumeroSessao
            // 
            this.lbNumeroSessao.AutoSize = true;
            this.lbNumeroSessao.Location = new System.Drawing.Point(192, 173);
            this.lbNumeroSessao.Name = "lbNumeroSessao";
            this.lbNumeroSessao.Size = new System.Drawing.Size(86, 13);
            this.lbNumeroSessao.TabIndex = 15;
            this.lbNumeroSessao.Text = "lbNumeroSessao";
            // 
            // lbDataSessao
            // 
            this.lbDataSessao.AutoSize = true;
            this.lbDataSessao.Location = new System.Drawing.Point(192, 150);
            this.lbDataSessao.Name = "lbDataSessao";
            this.lbDataSessao.Size = new System.Drawing.Size(72, 13);
            this.lbDataSessao.TabIndex = 14;
            this.lbDataSessao.Text = "lbDataSessao";
            // 
            // lbFotografa
            // 
            this.lbFotografa.AutoSize = true;
            this.lbFotografa.Location = new System.Drawing.Point(192, 127);
            this.lbFotografa.Name = "lbFotografa";
            this.lbFotografa.Size = new System.Drawing.Size(63, 13);
            this.lbFotografa.TabIndex = 13;
            this.lbFotografa.Text = "lbFotografa";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(192, 63);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(48, 13);
            this.lbCliente.TabIndex = 12;
            this.lbCliente.Text = "lbCliente";
            // 
            // lbCodigoSessao
            // 
            this.lbCodigoSessao.AutoSize = true;
            this.lbCodigoSessao.Location = new System.Drawing.Point(192, 40);
            this.lbCodigoSessao.Name = "lbCodigoSessao";
            this.lbCodigoSessao.Size = new System.Drawing.Size(82, 13);
            this.lbCodigoSessao.TabIndex = 11;
            this.lbCodigoSessao.Text = "lbCodigoSessao";
            // 
            // lbAtendimento
            // 
            this.lbAtendimento.AutoSize = true;
            this.lbAtendimento.Location = new System.Drawing.Point(192, 17);
            this.lbAtendimento.Name = "lbAtendimento";
            this.lbAtendimento.Size = new System.Drawing.Size(76, 13);
            this.lbAtendimento.TabIndex = 10;
            this.lbAtendimento.Text = "lbAtendimento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status da Criptografia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Backup";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tempo da Sessão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quantidade de Fotos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero da Sessão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data da Sessão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fotografa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código da Sessão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Atendimento";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 390);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolstripActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Info";
            this.Text = "Info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Info_FormClosed);
            this.Load += new System.EventHandler(this.Info_Load);
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ToolStrip toolstripActions;
        protected ToolStripSplitButton btnActions;
        private ToolStripSeparator toolStripSeparator4;
        protected ToolStripSplitButton btnFiltros;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lbAtendimento;
        private Label lbCodigoSessao;
        private Label lbCliente;
        private Label lbFotografa;
        private Label lbDataSessao;
        private Label lbNumeroSessao;
        private Label lbQuantidadeFoto;
        private Label lbTempoSessao;
        private Label lbBackup;
        private Label lbCriptografia;
        private Label label12;
        private Label label11;
        private Label lbTipo;
        private Label lbGenero;
        private GroupBox groupBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private Label label13;
        private ComboBox cbTipo;
        private Label label14;
        private ComboBox cbGenero;
    }
}