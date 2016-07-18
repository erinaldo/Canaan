using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Financeiro.Lancamento
{
    partial class Filtro
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExecutar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusCancelado = new System.Windows.Forms.CheckBox();
            this.statusAcordo = new System.Windows.Forms.CheckBox();
            this.statusBaixado = new System.Windows.Forms.CheckBox();
            this.statusAberto = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.baixaFimDate = new System.Windows.Forms.DateTimePicker();
            this.baixaInicioDate = new System.Windows.Forms.DateTimePicker();
            this.vencFimDate = new System.Windows.Forms.DateTimePicker();
            this.vencInicioDate = new System.Windows.Forms.DateTimePicker();
            this.emissaoFimDate = new System.Windows.Forms.DateTimePicker();
            this.emissaoInicioDate = new System.Windows.Forms.DateTimePicker();
            this.filtroBaixa = new System.Windows.Forms.CheckBox();
            this.filtroVencimento = new System.Windows.Forms.CheckBox();
            this.filtroEmissao = new System.Windows.Forms.CheckBox();
            this.groupBoxUsuario = new System.Windows.Forms.GroupBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.filtroCpf = new System.Windows.Forms.CheckBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.filtroNome = new System.Windows.Forms.CheckBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.filtroCodigo = new System.Windows.Forms.CheckBox();
            this.tipoReceber = new System.Windows.Forms.CheckBox();
            this.tipoPagar = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExecutar,
            this.toolStripSeparator1,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(592, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Image = global::Canaan.Telas.Properties.Resources.lightningBolt_16xLG;
            this.btnExecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.RightToLeftAutoMirrorImage = true;
            this.btnExecutar.Size = new System.Drawing.Size(101, 22);
            this.btnExecutar.Text = "Executar Filtro";
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Canaan.Telas.Properties.Resources.StatusAnnotations_Critical_16xLG;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tipoPagar);
            this.panel1.Controls.Add(this.tipoReceber);
            this.panel1.Controls.Add(this.statusCancelado);
            this.panel1.Controls.Add(this.statusAcordo);
            this.panel1.Controls.Add(this.statusBaixado);
            this.panel1.Controls.Add(this.statusAberto);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(592, 298);
            this.panel1.TabIndex = 1;
            // 
            // statusCancelado
            // 
            this.statusCancelado.AutoSize = true;
            this.statusCancelado.Location = new System.Drawing.Point(18, 263);
            this.statusCancelado.Name = "statusCancelado";
            this.statusCancelado.Size = new System.Drawing.Size(77, 17);
            this.statusCancelado.TabIndex = 9;
            this.statusCancelado.Text = "Cancelado";
            this.statusCancelado.UseVisualStyleBackColor = true;
            // 
            // statusAcordo
            // 
            this.statusAcordo.AutoSize = true;
            this.statusAcordo.Location = new System.Drawing.Point(18, 240);
            this.statusAcordo.Name = "statusAcordo";
            this.statusAcordo.Size = new System.Drawing.Size(120, 17);
            this.statusAcordo.TabIndex = 8;
            this.statusAcordo.Text = "Baixado Por Acordo";
            this.statusAcordo.UseVisualStyleBackColor = true;
            // 
            // statusBaixado
            // 
            this.statusBaixado.AutoSize = true;
            this.statusBaixado.Location = new System.Drawing.Point(18, 217);
            this.statusBaixado.Name = "statusBaixado";
            this.statusBaixado.Size = new System.Drawing.Size(64, 17);
            this.statusBaixado.TabIndex = 7;
            this.statusBaixado.Text = "Baixado";
            this.statusBaixado.UseVisualStyleBackColor = true;
            // 
            // statusAberto
            // 
            this.statusAberto.AutoSize = true;
            this.statusAberto.Location = new System.Drawing.Point(18, 194);
            this.statusAberto.Name = "statusAberto";
            this.statusAberto.Size = new System.Drawing.Size(75, 17);
            this.statusAberto.TabIndex = 6;
            this.statusAberto.Text = "Em Aberto";
            this.statusAberto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.baixaFimDate);
            this.groupBox1.Controls.Add(this.baixaInicioDate);
            this.groupBox1.Controls.Add(this.vencFimDate);
            this.groupBox1.Controls.Add(this.vencInicioDate);
            this.groupBox1.Controls.Add(this.emissaoFimDate);
            this.groupBox1.Controls.Add(this.emissaoInicioDate);
            this.groupBox1.Controls.Add(this.filtroBaixa);
            this.groupBox1.Controls.Add(this.filtroVencimento);
            this.groupBox1.Controls.Add(this.filtroEmissao);
            this.groupBox1.Location = new System.Drawing.Point(294, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 175);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Data";
            // 
            // baixaFimDate
            // 
            this.baixaFimDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baixaFimDate.Location = new System.Drawing.Point(143, 137);
            this.baixaFimDate.Name = "baixaFimDate";
            this.baixaFimDate.Size = new System.Drawing.Size(120, 20);
            this.baixaFimDate.TabIndex = 11;
            // 
            // baixaInicioDate
            // 
            this.baixaInicioDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baixaInicioDate.Location = new System.Drawing.Point(6, 137);
            this.baixaInicioDate.Name = "baixaInicioDate";
            this.baixaInicioDate.Size = new System.Drawing.Size(121, 20);
            this.baixaInicioDate.TabIndex = 10;
            // 
            // vencFimDate
            // 
            this.vencFimDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vencFimDate.Location = new System.Drawing.Point(143, 91);
            this.vencFimDate.Name = "vencFimDate";
            this.vencFimDate.Size = new System.Drawing.Size(120, 20);
            this.vencFimDate.TabIndex = 9;
            // 
            // vencInicioDate
            // 
            this.vencInicioDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vencInicioDate.Location = new System.Drawing.Point(6, 91);
            this.vencInicioDate.Name = "vencInicioDate";
            this.vencInicioDate.Size = new System.Drawing.Size(121, 20);
            this.vencInicioDate.TabIndex = 8;
            // 
            // emissaoFimDate
            // 
            this.emissaoFimDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.emissaoFimDate.Location = new System.Drawing.Point(143, 42);
            this.emissaoFimDate.Name = "emissaoFimDate";
            this.emissaoFimDate.Size = new System.Drawing.Size(120, 20);
            this.emissaoFimDate.TabIndex = 7;
            // 
            // emissaoInicioDate
            // 
            this.emissaoInicioDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.emissaoInicioDate.Location = new System.Drawing.Point(6, 42);
            this.emissaoInicioDate.Name = "emissaoInicioDate";
            this.emissaoInicioDate.Size = new System.Drawing.Size(121, 20);
            this.emissaoInicioDate.TabIndex = 6;
            // 
            // filtroBaixa
            // 
            this.filtroBaixa.AutoSize = true;
            this.filtroBaixa.Location = new System.Drawing.Point(6, 117);
            this.filtroBaixa.Name = "filtroBaixa";
            this.filtroBaixa.Size = new System.Drawing.Size(98, 17);
            this.filtroBaixa.TabIndex = 4;
            this.filtroBaixa.Text = "Filtrar por Baixa";
            this.filtroBaixa.UseVisualStyleBackColor = true;
            // 
            // filtroVencimento
            // 
            this.filtroVencimento.AutoSize = true;
            this.filtroVencimento.Location = new System.Drawing.Point(6, 68);
            this.filtroVencimento.Name = "filtroVencimento";
            this.filtroVencimento.Size = new System.Drawing.Size(128, 17);
            this.filtroVencimento.TabIndex = 2;
            this.filtroVencimento.Text = "Filtrar por Vencimento";
            this.filtroVencimento.UseVisualStyleBackColor = true;
            // 
            // filtroEmissao
            // 
            this.filtroEmissao.AutoSize = true;
            this.filtroEmissao.Location = new System.Drawing.Point(6, 19);
            this.filtroEmissao.Name = "filtroEmissao";
            this.filtroEmissao.Size = new System.Drawing.Size(111, 17);
            this.filtroEmissao.TabIndex = 0;
            this.filtroEmissao.Text = "Filtrar por Emissão";
            this.filtroEmissao.UseVisualStyleBackColor = true;
            // 
            // groupBoxUsuario
            // 
            this.groupBoxUsuario.Controls.Add(this.cpfTextBox);
            this.groupBoxUsuario.Controls.Add(this.filtroCpf);
            this.groupBoxUsuario.Controls.Add(this.nomeTextBox);
            this.groupBoxUsuario.Controls.Add(this.filtroNome);
            this.groupBoxUsuario.Controls.Add(this.codigoTextBox);
            this.groupBoxUsuario.Controls.Add(this.filtroCodigo);
            this.groupBoxUsuario.Location = new System.Drawing.Point(12, 13);
            this.groupBoxUsuario.Name = "groupBoxUsuario";
            this.groupBoxUsuario.Size = new System.Drawing.Size(276, 175);
            this.groupBoxUsuario.TabIndex = 1;
            this.groupBoxUsuario.TabStop = false;
            this.groupBoxUsuario.Text = "Informações do Usuario";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(6, 140);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(257, 20);
            this.cpfTextBox.TabIndex = 5;
            // 
            // filtroCpf
            // 
            this.filtroCpf.AutoSize = true;
            this.filtroCpf.Location = new System.Drawing.Point(6, 117);
            this.filtroCpf.Name = "filtroCpf";
            this.filtroCpf.Size = new System.Drawing.Size(88, 17);
            this.filtroCpf.TabIndex = 4;
            this.filtroCpf.Text = "Filtrar por Cpf";
            this.filtroCpf.UseVisualStyleBackColor = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(6, 91);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(257, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // filtroNome
            // 
            this.filtroNome.AutoSize = true;
            this.filtroNome.Location = new System.Drawing.Point(6, 68);
            this.filtroNome.Name = "filtroNome";
            this.filtroNome.Size = new System.Drawing.Size(100, 17);
            this.filtroNome.TabIndex = 2;
            this.filtroNome.Text = "Filtrar por Nome";
            this.filtroNome.UseVisualStyleBackColor = true;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(6, 42);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(257, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // filtroCodigo
            // 
            this.filtroCodigo.AutoSize = true;
            this.filtroCodigo.Location = new System.Drawing.Point(6, 19);
            this.filtroCodigo.Name = "filtroCodigo";
            this.filtroCodigo.Size = new System.Drawing.Size(105, 17);
            this.filtroCodigo.TabIndex = 0;
            this.filtroCodigo.Text = "Filtrar por Código";
            this.filtroCodigo.UseVisualStyleBackColor = true;
            // 
            // tipoReceber
            // 
            this.tipoReceber.AutoSize = true;
            this.tipoReceber.Location = new System.Drawing.Point(300, 194);
            this.tipoReceber.Name = "tipoReceber";
            this.tipoReceber.Size = new System.Drawing.Size(77, 17);
            this.tipoReceber.TabIndex = 10;
            this.tipoReceber.Text = "A Receber";
            this.tipoReceber.UseVisualStyleBackColor = true;
            // 
            // tipoPagar
            // 
            this.tipoPagar.AutoSize = true;
            this.tipoPagar.Location = new System.Drawing.Point(300, 217);
            this.tipoPagar.Name = "tipoPagar";
            this.tipoPagar.Size = new System.Drawing.Size(64, 17);
            this.tipoPagar.TabIndex = 11;
            this.tipoPagar.Text = "A Pagar";
            this.tipoPagar.UseVisualStyleBackColor = true;
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 323);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Lançamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Filtro_FormClosed);
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxUsuario.ResumeLayout(false);
            this.groupBoxUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnExecutar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCancelar;
        private Panel panel1;
        private CheckBox filtroCodigo;
        private CheckBox statusCancelado;
        private CheckBox statusAcordo;
        private CheckBox statusBaixado;
        private CheckBox statusAberto;
        private GroupBox groupBox1;
        private DateTimePicker baixaFimDate;
        private DateTimePicker baixaInicioDate;
        private DateTimePicker vencFimDate;
        private DateTimePicker vencInicioDate;
        private DateTimePicker emissaoFimDate;
        private DateTimePicker emissaoInicioDate;
        private CheckBox filtroBaixa;
        private CheckBox filtroVencimento;
        private CheckBox filtroEmissao;
        private GroupBox groupBoxUsuario;
        private TextBox cpfTextBox;
        private CheckBox filtroCpf;
        private TextBox nomeTextBox;
        private CheckBox filtroNome;
        private TextBox codigoTextBox;
        private CheckBox tipoPagar;
        private CheckBox tipoReceber;
    }
}