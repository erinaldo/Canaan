using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Movimentacoes.Venda.Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.btnInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActions = new System.Windows.Forms.ToolStripSplitButton();
            this.envelopesDeServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosContratadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conprovanteDeEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.termoDeAditamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltros = new System.Windows.Forms.ToolStripSplitButton();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cLbStatusPedido = new Canaan.Lib.Componentes.CLabel();
            this.cLbDataEntrega = new Canaan.Lib.Componentes.CLabel();
            this.cLbDataRecebimento = new Canaan.Lib.Componentes.CLabel();
            this.cLbDataEnvio = new Canaan.Lib.Componentes.CLabel();
            this.cLbDataAtendimento = new Canaan.Lib.Componentes.CLabel();
            this.cLbResponsavelFinanceiro = new Canaan.Lib.Componentes.CLabel();
            this.cLbCliente = new Canaan.Lib.Componentes.CLabel();
            this.cLbAtendenteResponsavel = new Canaan.Lib.Componentes.CLabel();
            this.cLbCodPacote = new Canaan.Lib.Componentes.CLabel();
            this.cLbCodAtendimento = new Canaan.Lib.Componentes.CLabel();
            this.cLbEstudio = new Canaan.Lib.Componentes.CLabel();
            this.label7 = new Canaan.Lib.Componentes.CLabel();
            this.label8 = new Canaan.Lib.Componentes.CLabel();
            this.label9 = new Canaan.Lib.Componentes.CLabel();
            this.label10 = new Canaan.Lib.Componentes.CLabel();
            this.label12 = new Canaan.Lib.Componentes.CLabel();
            this.label6 = new Canaan.Lib.Componentes.CLabel();
            this.label5 = new Canaan.Lib.Componentes.CLabel();
            this.label4 = new Canaan.Lib.Componentes.CLabel();
            this.label3 = new Canaan.Lib.Componentes.CLabel();
            this.label2 = new Canaan.Lib.Componentes.CLabel();
            this.label1 = new Canaan.Lib.Componentes.CLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCarta = new System.Windows.Forms.ComboBox();
            this.cbParceria = new System.Windows.Forms.ComboBox();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.cLabel3 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel2 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolstripActions.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolstripActions);
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(973, 533);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelInfo);
            this.tabPage1.Size = new System.Drawing.Size(965, 507);
            this.tabPage1.Text = "Informações do Atendimento";
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.btnActions,
            this.toolStripSeparator4,
            this.btnFiltros});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(990, 33);
            this.toolstripActions.TabIndex = 1;
            this.toolstripActions.Text = "toolbarinfo";
            // 
            // btnInsert
            // 
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(58, 20);
            this.btnInsert.Text = "Salvar";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.arrow_Sync_16xLG;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(122, 20);
            this.toolStripButton1.Text = "Troca de Cadastro";
            this.toolStripButton1.Click += new System.EventHandler(this.btTrocaCadastro_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnActions
            // 
            this.btnActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envelopesDeServiçosToolStripMenuItem,
            this.serviçosContratadosToolStripMenuItem,
            this.boletoToolStripMenuItem,
            this.contratoToolStripMenuItem,
            this.conprovanteDeEntradaToolStripMenuItem,
            this.termoDeAditamentoToolStripMenuItem});
            this.btnActions.Image = ((System.Drawing.Image)(resources.GetObject("btnActions.Image")));
            this.btnActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(109, 20);
            this.btnActions.Text = "Outras Ações";
            // 
            // envelopesDeServiçosToolStripMenuItem
            // 
            this.envelopesDeServiçosToolStripMenuItem.Name = "envelopesDeServiçosToolStripMenuItem";
            this.envelopesDeServiçosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.envelopesDeServiçosToolStripMenuItem.Text = "Envelopes de Serviços";
            this.envelopesDeServiçosToolStripMenuItem.Click += new System.EventHandler(this.envelopesDeServiçosToolStripMenuItem_Click);
            // 
            // serviçosContratadosToolStripMenuItem
            // 
            this.serviçosContratadosToolStripMenuItem.Name = "serviçosContratadosToolStripMenuItem";
            this.serviçosContratadosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.serviçosContratadosToolStripMenuItem.Text = "Serviços Contratados";
            this.serviçosContratadosToolStripMenuItem.Click += new System.EventHandler(this.serviçosContratadosToolStripMenuItem_Click);
            // 
            // boletoToolStripMenuItem
            // 
            this.boletoToolStripMenuItem.Name = "boletoToolStripMenuItem";
            this.boletoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.boletoToolStripMenuItem.Text = "Boleto";
            this.boletoToolStripMenuItem.Click += new System.EventHandler(this.boletoToolStripMenuItem_Click);
            // 
            // contratoToolStripMenuItem
            // 
            this.contratoToolStripMenuItem.Name = "contratoToolStripMenuItem";
            this.contratoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.contratoToolStripMenuItem.Text = "Contrato";
            this.contratoToolStripMenuItem.Click += new System.EventHandler(this.contratoToolStripMenuItem_Click);
            // 
            // conprovanteDeEntradaToolStripMenuItem
            // 
            this.conprovanteDeEntradaToolStripMenuItem.Name = "conprovanteDeEntradaToolStripMenuItem";
            this.conprovanteDeEntradaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.conprovanteDeEntradaToolStripMenuItem.Text = "Conprovante de Entrada";
            this.conprovanteDeEntradaToolStripMenuItem.Click += new System.EventHandler(this.conprovanteDeEntradaToolStripMenuItem_Click);
            // 
            // termoDeAditamentoToolStripMenuItem
            // 
            this.termoDeAditamentoToolStripMenuItem.Name = "termoDeAditamentoToolStripMenuItem";
            this.termoDeAditamentoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.termoDeAditamentoToolStripMenuItem.Text = "Termo de Aditamento";
            this.termoDeAditamentoToolStripMenuItem.Click += new System.EventHandler(this.termoDeAditamentoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnFiltros
            // 
            this.btnFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltros.Image")));
            this.btnFiltros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(71, 20);
            this.btnFiltros.Text = "Filtros";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.groupBox1);
            this.panelInfo.Controls.Add(this.groupBox2);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(3, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(959, 501);
            this.panelInfo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cLbStatusPedido);
            this.groupBox1.Controls.Add(this.cLbDataEntrega);
            this.groupBox1.Controls.Add(this.cLbDataRecebimento);
            this.groupBox1.Controls.Add(this.cLbDataEnvio);
            this.groupBox1.Controls.Add(this.cLbDataAtendimento);
            this.groupBox1.Controls.Add(this.cLbResponsavelFinanceiro);
            this.groupBox1.Controls.Add(this.cLbCliente);
            this.groupBox1.Controls.Add(this.cLbAtendenteResponsavel);
            this.groupBox1.Controls.Add(this.cLbCodPacote);
            this.groupBox1.Controls.Add(this.cLbCodAtendimento);
            this.groupBox1.Controls.Add(this.cLbEstudio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Gerais do Atendimento";
            // 
            // cLbStatusPedido
            // 
            this.cLbStatusPedido.AutoSize = true;
            this.cLbStatusPedido.Location = new System.Drawing.Point(757, 130);
            this.cLbStatusPedido.Name = "cLbStatusPedido";
            this.cLbStatusPedido.Padding = new System.Windows.Forms.Padding(5);
            this.cLbStatusPedido.Size = new System.Drawing.Size(98, 23);
            this.cLbStatusPedido.TabIndex = 23;
            this.cLbStatusPedido.Text = "cLbStatusPedido";
            // 
            // cLbDataEntrega
            // 
            this.cLbDataEntrega.AutoSize = true;
            this.cLbDataEntrega.Location = new System.Drawing.Point(757, 105);
            this.cLbDataEntrega.Name = "cLbDataEntrega";
            this.cLbDataEntrega.Padding = new System.Windows.Forms.Padding(5);
            this.cLbDataEntrega.Size = new System.Drawing.Size(95, 23);
            this.cLbDataEntrega.TabIndex = 22;
            this.cLbDataEntrega.Text = "cLbDataEntrega";
            // 
            // cLbDataRecebimento
            // 
            this.cLbDataRecebimento.AutoSize = true;
            this.cLbDataRecebimento.Location = new System.Drawing.Point(757, 78);
            this.cLbDataRecebimento.Name = "cLbDataRecebimento";
            this.cLbDataRecebimento.Padding = new System.Windows.Forms.Padding(5);
            this.cLbDataRecebimento.Size = new System.Drawing.Size(121, 23);
            this.cLbDataRecebimento.TabIndex = 21;
            this.cLbDataRecebimento.Text = "cLbDataRecebimento";
            // 
            // cLbDataEnvio
            // 
            this.cLbDataEnvio.AutoSize = true;
            this.cLbDataEnvio.Location = new System.Drawing.Point(757, 55);
            this.cLbDataEnvio.Name = "cLbDataEnvio";
            this.cLbDataEnvio.Padding = new System.Windows.Forms.Padding(5);
            this.cLbDataEnvio.Size = new System.Drawing.Size(85, 23);
            this.cLbDataEnvio.TabIndex = 20;
            this.cLbDataEnvio.Text = "cLbDataEnvio";
            // 
            // cLbDataAtendimento
            // 
            this.cLbDataAtendimento.AutoSize = true;
            this.cLbDataAtendimento.Location = new System.Drawing.Point(757, 30);
            this.cLbDataAtendimento.Name = "cLbDataAtendimento";
            this.cLbDataAtendimento.Padding = new System.Windows.Forms.Padding(5);
            this.cLbDataAtendimento.Size = new System.Drawing.Size(117, 23);
            this.cLbDataAtendimento.TabIndex = 18;
            this.cLbDataAtendimento.Text = "cLbDataAtendimento";
            // 
            // cLbResponsavelFinanceiro
            // 
            this.cLbResponsavelFinanceiro.AutoSize = true;
            this.cLbResponsavelFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cLbResponsavelFinanceiro.ForeColor = System.Drawing.Color.Blue;
            this.cLbResponsavelFinanceiro.Location = new System.Drawing.Point(203, 151);
            this.cLbResponsavelFinanceiro.Name = "cLbResponsavelFinanceiro";
            this.cLbResponsavelFinanceiro.Padding = new System.Windows.Forms.Padding(5);
            this.cLbResponsavelFinanceiro.Size = new System.Drawing.Size(146, 23);
            this.cLbResponsavelFinanceiro.TabIndex = 17;
            this.cLbResponsavelFinanceiro.Text = "cLbResponsavelFinanceiro";
            this.cLbResponsavelFinanceiro.Click += new System.EventHandler(this.cLbResponsavelFinanceiro_Click);
            // 
            // cLbCliente
            // 
            this.cLbCliente.AutoSize = true;
            this.cLbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cLbCliente.ForeColor = System.Drawing.Color.Blue;
            this.cLbCliente.Location = new System.Drawing.Point(203, 126);
            this.cLbCliente.Name = "cLbCliente";
            this.cLbCliente.Padding = new System.Windows.Forms.Padding(5);
            this.cLbCliente.Size = new System.Drawing.Size(67, 23);
            this.cLbCliente.TabIndex = 16;
            this.cLbCliente.Text = "cLbCliente";
            this.cLbCliente.Click += new System.EventHandler(this.cLbCliente_Click);
            // 
            // cLbAtendenteResponsavel
            // 
            this.cLbAtendenteResponsavel.AutoSize = true;
            this.cLbAtendenteResponsavel.Location = new System.Drawing.Point(203, 99);
            this.cLbAtendenteResponsavel.Name = "cLbAtendenteResponsavel";
            this.cLbAtendenteResponsavel.Padding = new System.Windows.Forms.Padding(5);
            this.cLbAtendenteResponsavel.Size = new System.Drawing.Size(146, 23);
            this.cLbAtendenteResponsavel.TabIndex = 15;
            this.cLbAtendenteResponsavel.Text = "cLbAtendenteResponsavel";
            // 
            // cLbCodPacote
            // 
            this.cLbCodPacote.AutoSize = true;
            this.cLbCodPacote.Location = new System.Drawing.Point(203, 76);
            this.cLbCodPacote.Name = "cLbCodPacote";
            this.cLbCodPacote.Padding = new System.Windows.Forms.Padding(5);
            this.cLbCodPacote.Size = new System.Drawing.Size(88, 23);
            this.cLbCodPacote.TabIndex = 14;
            this.cLbCodPacote.Text = "cLbCodPacote";
            // 
            // cLbCodAtendimento
            // 
            this.cLbCodAtendimento.AutoSize = true;
            this.cLbCodAtendimento.Location = new System.Drawing.Point(203, 51);
            this.cLbCodAtendimento.Name = "cLbCodAtendimento";
            this.cLbCodAtendimento.Padding = new System.Windows.Forms.Padding(5);
            this.cLbCodAtendimento.Size = new System.Drawing.Size(113, 23);
            this.cLbCodAtendimento.TabIndex = 13;
            this.cLbCodAtendimento.Text = "cLbCodAtendimento";
            // 
            // cLbEstudio
            // 
            this.cLbEstudio.AutoSize = true;
            this.cLbEstudio.Location = new System.Drawing.Point(203, 26);
            this.cLbEstudio.Name = "cLbEstudio";
            this.cLbEstudio.Padding = new System.Windows.Forms.Padding(5);
            this.cLbEstudio.Size = new System.Drawing.Size(70, 23);
            this.cLbEstudio.TabIndex = 12;
            this.cLbEstudio.Text = "cLbEstudio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(608, 126);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Status da Venda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(608, 101);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data da Entrega";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(608, 76);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(140, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data do Recebimento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(608, 51);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(98, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Data do Envio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(608, 26);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5);
            this.label12.Size = new System.Drawing.Size(136, 23);
            this.label12.TabIndex = 6;
            this.label12.Text = "Data do Atendimento\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 151);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Responsável Financeiro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 126);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 101);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Atendente Responsável";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 76);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código do Pacote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 51);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do Atendimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estúdio Responsável";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbCarta);
            this.groupBox2.Controls.Add(this.cbParceria);
            this.groupBox2.Controls.Add(this.cbConvenio);
            this.groupBox2.Controls.Add(this.cLabel3);
            this.groupBox2.Controls.Add(this.cLabel2);
            this.groupBox2.Controls.Add(this.cLabel1);
            this.groupBox2.Location = new System.Drawing.Point(9, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de Promoções e Parcerias";
            // 
            // cbCarta
            // 
            this.cbCarta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarta.FormattingEnabled = true;
            this.cbCarta.Location = new System.Drawing.Point(104, 87);
            this.cbCarta.Name = "cbCarta";
            this.cbCarta.Size = new System.Drawing.Size(268, 21);
            this.cbCarta.TabIndex = 5;
            // 
            // cbParceria
            // 
            this.cbParceria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParceria.Enabled = false;
            this.cbParceria.FormattingEnabled = true;
            this.cbParceria.Location = new System.Drawing.Point(104, 59);
            this.cbParceria.Name = "cbParceria";
            this.cbParceria.Size = new System.Drawing.Size(268, 21);
            this.cbParceria.TabIndex = 4;
            // 
            // cbConvenio
            // 
            this.cbConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConvenio.Enabled = false;
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Location = new System.Drawing.Point(104, 32);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(268, 21);
            this.cbConvenio.TabIndex = 3;
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel3.Location = new System.Drawing.Point(33, 86);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel3.Size = new System.Drawing.Size(47, 23);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "Carta";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel2.Location = new System.Drawing.Point(33, 59);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel2.Size = new System.Drawing.Size(64, 23);
            this.cLabel2.TabIndex = 1;
            this.cLabel2.Text = "Parceria";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel1.Location = new System.Drawing.Point(33, 30);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(70, 23);
            this.cLabel1.TabIndex = 0;
            this.cLabel1.Text = "Convênio";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected ToolStrip toolstripActions;
        protected ToolStripButton btnInsert;
        private ToolStripSeparator toolStripSeparator2;
        protected ToolStripSplitButton btnActions;
        private ToolStripSeparator toolStripSeparator4;
        protected ToolStripSplitButton btnFiltros;
        private Panel panelInfo;
        private GroupBox groupBox1;
        private CLabel cLbStatusPedido;
        private CLabel cLbDataEntrega;
        private CLabel cLbDataRecebimento;
        private CLabel cLbDataEnvio;
        private CLabel cLbDataAtendimento;
        private CLabel cLbResponsavelFinanceiro;
        private CLabel cLbCliente;
        private CLabel cLbAtendenteResponsavel;
        private CLabel cLbCodPacote;
        private CLabel cLbCodAtendimento;
        private CLabel cLbEstudio;
        private CLabel label7;
        private CLabel label8;
        private CLabel label9;
        private CLabel label10;
        private CLabel label12;
        private CLabel label6;
        private CLabel label5;
        private CLabel label4;
        private CLabel label3;
        private CLabel label2;
        private CLabel label1;
        private GroupBox groupBox2;
        private ComboBox cbCarta;
        private ComboBox cbParceria;
        private ComboBox cbConvenio;
        private CLabel cLabel3;
        private CLabel cLabel2;
        private CLabel cLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private ToolStripMenuItem serviçosContratadosToolStripMenuItem;
        private ToolStripMenuItem envelopesDeServiçosToolStripMenuItem;
        private ToolStripMenuItem boletoToolStripMenuItem;
        private ToolStripMenuItem contratoToolStripMenuItem;
        private ToolStripMenuItem conprovanteDeEntradaToolStripMenuItem;
        private ToolStripMenuItem termoDeAditamentoToolStripMenuItem;
    }
}