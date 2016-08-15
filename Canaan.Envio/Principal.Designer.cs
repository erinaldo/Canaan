namespace Canaan.Envio
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Selecao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IdEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibEscrit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LibGerente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icone = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbArquivosTransferidos = new System.Windows.Forms.Label();
            this.lbTotalArquivos = new System.Windows.Forms.Label();
            this.lbPacotesTransferidos = new System.Windows.Forms.Label();
            this.lbTotalPacotes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbArqTranferidosPacote = new System.Windows.Forms.Label();
            this.lbTotalImagens = new System.Windows.Forms.Label();
            this.lbTotalEnvelopes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbPasta = new System.Windows.Forms.Label();
            this.lbServer = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pBarTotal = new System.Windows.Forms.ProgressBar();
            this.pBarAtual = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbSituacao = new Canaan.Lib.Componentes.CLabel();
            this.timeUltimaExecucao = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.notificationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(800, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Envio";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.Selecao,
            this.IdEnvio,
            this.IdPedido,
            this.Cliente,
            this.Atendimento,
            this.DataVenda,
            this.LibEscrit,
            this.LibGerente,
            this.Valor,
            this.Icone});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowCellErrors = false;
            this.dataGrid.ShowCellToolTips = false;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.ShowRowErrors = false;
            this.dataGrid.Size = new System.Drawing.Size(786, 285);
            this.dataGrid.TabIndex = 1;
            // 
            // Selecao
            // 
            this.Selecao.FillWeight = 20F;
            this.Selecao.HeaderText = "";
            this.Selecao.Name = "Selecao";
            // 
            // IdEnvio
            // 
            this.IdEnvio.DataPropertyName = "IdEnvio";
            this.IdEnvio.HeaderText = "IdEnvio";
            this.IdEnvio.Name = "IdEnvio";
            this.IdEnvio.Visible = false;
            // 
            // IdPedido
            // 
            this.IdPedido.DataPropertyName = "IdPedido";
            this.IdPedido.HeaderText = "IdPedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
            this.IdPedido.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.FillWeight = 150F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Atendimento
            // 
            this.Atendimento.DataPropertyName = "CodigoReduzido";
            this.Atendimento.FillWeight = 40F;
            this.Atendimento.HeaderText = "Atendimento";
            this.Atendimento.Name = "Atendimento";
            this.Atendimento.ReadOnly = true;
            // 
            // DataVenda
            // 
            this.DataVenda.DataPropertyName = "DataVenda";
            this.DataVenda.FillWeight = 50F;
            this.DataVenda.HeaderText = "Data da Venda";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            // 
            // LibEscrit
            // 
            this.LibEscrit.DataPropertyName = "LibEscrit";
            this.LibEscrit.FillWeight = 50F;
            this.LibEscrit.HeaderText = "Lib. Escrit.";
            this.LibEscrit.Name = "LibEscrit";
            this.LibEscrit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LibEscrit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LibGerente
            // 
            this.LibGerente.DataPropertyName = "LibGerente";
            this.LibGerente.FillWeight = 50F;
            this.LibGerente.HeaderText = "Lib. Gerente";
            this.LibGerente.Name = "LibGerente";
            this.LibGerente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LibGerente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.FillWeight = 40F;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Icone
            // 
            this.Icone.DataPropertyName = "Icone";
            this.Icone.FillWeight = 20F;
            this.Icone.HeaderText = "";
            this.Icone.Name = "Icone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbArquivosTransferidos);
            this.groupBox1.Controls.Add(this.lbTotalArquivos);
            this.groupBox1.Controls.Add(this.lbPacotesTransferidos);
            this.groupBox1.Controls.Add(this.lbTotalPacotes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info. do Envio";
            // 
            // lbArquivosTransferidos
            // 
            this.lbArquivosTransferidos.AutoSize = true;
            this.lbArquivosTransferidos.Location = new System.Drawing.Point(129, 71);
            this.lbArquivosTransferidos.Name = "lbArquivosTransferidos";
            this.lbArquivosTransferidos.Size = new System.Drawing.Size(13, 13);
            this.lbArquivosTransferidos.TabIndex = 11;
            this.lbArquivosTransferidos.Text = "0";
            // 
            // lbTotalArquivos
            // 
            this.lbTotalArquivos.AutoSize = true;
            this.lbTotalArquivos.Location = new System.Drawing.Point(129, 53);
            this.lbTotalArquivos.Name = "lbTotalArquivos";
            this.lbTotalArquivos.Size = new System.Drawing.Size(13, 13);
            this.lbTotalArquivos.TabIndex = 10;
            this.lbTotalArquivos.Text = "0";
            // 
            // lbPacotesTransferidos
            // 
            this.lbPacotesTransferidos.AutoSize = true;
            this.lbPacotesTransferidos.Location = new System.Drawing.Point(129, 35);
            this.lbPacotesTransferidos.Name = "lbPacotesTransferidos";
            this.lbPacotesTransferidos.Size = new System.Drawing.Size(13, 13);
            this.lbPacotesTransferidos.TabIndex = 9;
            this.lbPacotesTransferidos.Text = "0";
            // 
            // lbTotalPacotes
            // 
            this.lbTotalPacotes.AutoSize = true;
            this.lbTotalPacotes.Location = new System.Drawing.Point(129, 17);
            this.lbTotalPacotes.Name = "lbTotalPacotes";
            this.lbTotalPacotes.Size = new System.Drawing.Size(13, 13);
            this.lbTotalPacotes.TabIndex = 8;
            this.lbTotalPacotes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arquivos Transferidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total de Arquivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pacotes Transferidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Pacotes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbArqTranferidosPacote);
            this.groupBox2.Controls.Add(this.lbTotalImagens);
            this.groupBox2.Controls.Add(this.lbTotalEnvelopes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(388, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info. Pacote Atual";
            // 
            // lbArqTranferidosPacote
            // 
            this.lbArqTranferidosPacote.AutoSize = true;
            this.lbArqTranferidosPacote.Location = new System.Drawing.Point(127, 61);
            this.lbArqTranferidosPacote.Name = "lbArqTranferidosPacote";
            this.lbArqTranferidosPacote.Size = new System.Drawing.Size(13, 13);
            this.lbArqTranferidosPacote.TabIndex = 17;
            this.lbArqTranferidosPacote.Text = "0";
            // 
            // lbTotalImagens
            // 
            this.lbTotalImagens.AutoSize = true;
            this.lbTotalImagens.Location = new System.Drawing.Point(127, 43);
            this.lbTotalImagens.Name = "lbTotalImagens";
            this.lbTotalImagens.Size = new System.Drawing.Size(13, 13);
            this.lbTotalImagens.TabIndex = 16;
            this.lbTotalImagens.Text = "0";
            // 
            // lbTotalEnvelopes
            // 
            this.lbTotalEnvelopes.AutoSize = true;
            this.lbTotalEnvelopes.Location = new System.Drawing.Point(127, 25);
            this.lbTotalEnvelopes.Name = "lbTotalEnvelopes";
            this.lbTotalEnvelopes.Size = new System.Drawing.Size(13, 13);
            this.lbTotalEnvelopes.TabIndex = 15;
            this.lbTotalEnvelopes.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Arquivos Transferidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total de Imagens";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total de Envelopes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbStatus);
            this.groupBox3.Controls.Add(this.lbPasta);
            this.groupBox3.Controls.Add(this.lbServer);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Label20);
            this.groupBox3.Location = new System.Drawing.Point(596, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 96);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info. Conexão";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(70, 63);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(45, 13);
            this.lbStatus.TabIndex = 22;
            this.lbStatus.Text = "lbStatus";
            // 
            // lbPasta
            // 
            this.lbPasta.AutoSize = true;
            this.lbPasta.Location = new System.Drawing.Point(70, 45);
            this.lbPasta.Name = "lbPasta";
            this.lbPasta.Size = new System.Drawing.Size(42, 13);
            this.lbPasta.TabIndex = 21;
            this.lbPasta.Text = "lbPasta";
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(70, 27);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(46, 13);
            this.lbServer.TabIndex = 18;
            this.lbServer.Text = "lbServer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Pasta";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(6, 27);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(46, 13);
            this.Label20.TabIndex = 18;
            this.Label20.Text = "Servidor";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pBarTotal);
            this.groupBox4.Controls.Add(this.pBarAtual);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 435);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 74);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Progresso";
            // 
            // pBarTotal
            // 
            this.pBarTotal.Location = new System.Drawing.Point(124, 43);
            this.pBarTotal.Name = "pBarTotal";
            this.pBarTotal.Size = new System.Drawing.Size(240, 19);
            this.pBarTotal.TabIndex = 11;
            // 
            // pBarAtual
            // 
            this.pBarAtual.Location = new System.Drawing.Point(124, 20);
            this.pBarAtual.Name = "pBarAtual";
            this.pBarAtual.Size = new System.Drawing.Size(240, 19);
            this.pBarAtual.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Processo Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Processo Atual";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbSituacao);
            this.groupBox5.Controls.Add(this.timeUltimaExecucao);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(389, 437);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(423, 72);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Horário Funcionamento";
            // 
            // lbSituacao
            // 
            this.lbSituacao.AutoSize = true;
            this.lbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSituacao.Location = new System.Drawing.Point(6, 40);
            this.lbSituacao.Name = "lbSituacao";
            this.lbSituacao.Padding = new System.Windows.Forms.Padding(5);
            this.lbSituacao.Size = new System.Drawing.Size(72, 30);
            this.lbSituacao.TabIndex = 18;
            this.lbSituacao.Text = "Status";
            // 
            // timeUltimaExecucao
            // 
            this.timeUltimaExecucao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.timeUltimaExecucao.Enabled = false;
            this.timeUltimaExecucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeUltimaExecucao.Location = new System.Drawing.Point(105, 19);
            this.timeUltimaExecucao.Name = "timeUltimaExecucao";
            this.timeUltimaExecucao.Size = new System.Drawing.Size(151, 20);
            this.timeUltimaExecucao.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Última Execução";
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(824, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // notificationLabel
            // 
            this.notificationLabel.Name = "notificationLabel";
            this.notificationLabel.Size = new System.Drawing.Size(122, 17);
            this.notificationLabel.Text = "Informações do Envio";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 540);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Imagens";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbArquivosTransferidos;
        private System.Windows.Forms.Label lbTotalArquivos;
        private System.Windows.Forms.Label lbPacotesTransferidos;
        private System.Windows.Forms.Label lbTotalPacotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbArqTranferidosPacote;
        private System.Windows.Forms.Label lbTotalImagens;
        private System.Windows.Forms.Label lbTotalEnvelopes;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbPasta;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar pBarTotal;
        private System.Windows.Forms.ProgressBar pBarAtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Lib.Componentes.CLabel lbSituacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atendimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LibEscrit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LibGerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewImageColumn Icone;
        private System.Windows.Forms.DateTimePicker timeUltimaExecucao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel notificationLabel;
    }
}

