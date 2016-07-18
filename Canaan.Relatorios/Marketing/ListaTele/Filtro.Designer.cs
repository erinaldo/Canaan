namespace Canaan.Relatorios.Marketing.ListaTele
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
            this.gBox = new System.Windows.Forms.GroupBox();
            this.cRadioButtonTeleFilter1 = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.rbListaOuro = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.rbClientesVendidos = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.rbVendasDevolvidas = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.rbProgramadas = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.rbAguardandoFinalizacao = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.rbPegouBrinde = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.rbNaoComprou = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.rbNaoViu = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.rbFichaPronta = new Canaan.Lib.Componentes.CRadioButtonTeleFilter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.btGerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckEtiquetas = new System.Windows.Forms.RadioButton();
            this.ckCartas = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(360, 451);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btGerar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.gBox);
            this.tabPage1.Size = new System.Drawing.Size(352, 425);
            this.tabPage1.Text = "Tipo de Cliente";
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.cRadioButtonTeleFilter1);
            this.gBox.Controls.Add(this.rbListaOuro);
            this.gBox.Controls.Add(this.rbClientesVendidos);
            this.gBox.Controls.Add(this.rbVendasDevolvidas);
            this.gBox.Controls.Add(this.rbProgramadas);
            this.gBox.Controls.Add(this.rbAguardandoFinalizacao);
            this.gBox.Controls.Add(this.rbPegouBrinde);
            this.gBox.Controls.Add(this.rbNaoComprou);
            this.gBox.Controls.Add(this.rbNaoViu);
            this.gBox.Controls.Add(this.rbFichaPronta);
            this.gBox.Location = new System.Drawing.Point(6, 6);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(339, 250);
            this.gBox.TabIndex = 0;
            this.gBox.TabStop = false;
            // 
            // cRadioButtonTeleFilter1
            // 
            this.cRadioButtonTeleFilter1.AutoSize = true;
            this.cRadioButtonTeleFilter1.Location = new System.Drawing.Point(6, 224);
            this.cRadioButtonTeleFilter1.Name = "cRadioButtonTeleFilter1";
            this.cRadioButtonTeleFilter1.Size = new System.Drawing.Size(143, 17);
            this.cRadioButtonTeleFilter1.TabIndex = 9;
            this.cRadioButtonTeleFilter1.Text = "Clientes - Aniversariantes";
            this.cRadioButtonTeleFilter1.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.Aniversario;
            this.cRadioButtonTeleFilter1.TipoRelatorio = "Aniversario";
            this.cRadioButtonTeleFilter1.UseVisualStyleBackColor = true;
            // 
            // rbListaOuro
            // 
            this.rbListaOuro.AutoSize = true;
            this.rbListaOuro.Location = new System.Drawing.Point(6, 201);
            this.rbListaOuro.Name = "rbListaOuro";
            this.rbListaOuro.Size = new System.Drawing.Size(119, 17);
            this.rbListaOuro.TabIndex = 8;
            this.rbListaOuro.Text = "Clientes - Lista Ouro";
            this.rbListaOuro.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.ListaOuro;
            this.rbListaOuro.TipoRelatorio = "ListaOuro";
            this.rbListaOuro.UseVisualStyleBackColor = true;
            // 
            // rbClientesVendidos
            // 
            this.rbClientesVendidos.AutoSize = true;
            this.rbClientesVendidos.Location = new System.Drawing.Point(6, 178);
            this.rbClientesVendidos.Name = "rbClientesVendidos";
            this.rbClientesVendidos.Size = new System.Drawing.Size(115, 17);
            this.rbClientesVendidos.TabIndex = 7;
            this.rbClientesVendidos.Text = "Clientes - Vendidos";
            this.rbClientesVendidos.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.Vendidos;
            this.rbClientesVendidos.TipoRelatorio = "Vendidos";
            this.rbClientesVendidos.UseVisualStyleBackColor = true;
            // 
            // rbVendasDevolvidas
            // 
            this.rbVendasDevolvidas.AutoSize = true;
            this.rbVendasDevolvidas.Location = new System.Drawing.Point(6, 155);
            this.rbVendasDevolvidas.Name = "rbVendasDevolvidas";
            this.rbVendasDevolvidas.Size = new System.Drawing.Size(193, 17);
            this.rbVendasDevolvidas.TabIndex = 6;
            this.rbVendasDevolvidas.Text = "Clientes - Vendas Devolvidas [SPC]";
            this.rbVendasDevolvidas.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.Devolvidas;
            this.rbVendasDevolvidas.TipoRelatorio = "Devolvidas";
            this.rbVendasDevolvidas.UseVisualStyleBackColor = true;
            // 
            // rbProgramadas
            // 
            this.rbProgramadas.AutoSize = true;
            this.rbProgramadas.Location = new System.Drawing.Point(6, 132);
            this.rbProgramadas.Name = "rbProgramadas";
            this.rbProgramadas.Size = new System.Drawing.Size(133, 17);
            this.rbProgramadas.TabIndex = 5;
            this.rbProgramadas.Text = "Clientes - Programadas";
            this.rbProgramadas.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.Programadas;
            this.rbProgramadas.TipoRelatorio = "Programadas";
            this.rbProgramadas.UseVisualStyleBackColor = true;
            // 
            // rbAguardandoFinalizacao
            // 
            this.rbAguardandoFinalizacao.AutoSize = true;
            this.rbAguardandoFinalizacao.Location = new System.Drawing.Point(6, 109);
            this.rbAguardandoFinalizacao.Name = "rbAguardandoFinalizacao";
            this.rbAguardandoFinalizacao.Size = new System.Drawing.Size(185, 17);
            this.rbAguardandoFinalizacao.TabIndex = 4;
            this.rbAguardandoFinalizacao.Text = "Clientes - Aguardando Finalização";
            this.rbAguardandoFinalizacao.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.AguardandoFinalizacao;
            this.rbAguardandoFinalizacao.TipoRelatorio = "AguardandoFinalizacao";
            this.rbAguardandoFinalizacao.UseVisualStyleBackColor = true;
            // 
            // rbPegouBrinde
            // 
            this.rbPegouBrinde.AutoSize = true;
            this.rbPegouBrinde.Location = new System.Drawing.Point(6, 86);
            this.rbPegouBrinde.Name = "rbPegouBrinde";
            this.rbPegouBrinde.Size = new System.Drawing.Size(135, 17);
            this.rbPegouBrinde.TabIndex = 3;
            this.rbPegouBrinde.Text = "Clientes - Pegou Brinde";
            this.rbPegouBrinde.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.PegouBrinde;
            this.rbPegouBrinde.TipoRelatorio = "PegouBrinde";
            this.rbPegouBrinde.UseVisualStyleBackColor = true;
            // 
            // rbNaoComprou
            // 
            this.rbNaoComprou.AutoSize = true;
            this.rbNaoComprou.Location = new System.Drawing.Point(6, 63);
            this.rbNaoComprou.Name = "rbNaoComprou";
            this.rbNaoComprou.Size = new System.Drawing.Size(136, 17);
            this.rbNaoComprou.TabIndex = 2;
            this.rbNaoComprou.Text = "Clientes - Não Comprou";
            this.rbNaoComprou.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.NaoComprou;
            this.rbNaoComprou.TipoRelatorio = "NaoComprou";
            this.rbNaoComprou.UseVisualStyleBackColor = true;
            // 
            // rbNaoViu
            // 
            this.rbNaoViu.AutoSize = true;
            this.rbNaoViu.Location = new System.Drawing.Point(6, 40);
            this.rbNaoViu.Name = "rbNaoViu";
            this.rbNaoViu.Size = new System.Drawing.Size(109, 17);
            this.rbNaoViu.TabIndex = 1;
            this.rbNaoViu.Text = "Clientes - Não Viu";
            this.rbNaoViu.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.NaoViu;
            this.rbNaoViu.TipoRelatorio = "NaoViu";
            this.rbNaoViu.UseVisualStyleBackColor = true;
            // 
            // rbFichaPronta
            // 
            this.rbFichaPronta.AutoSize = true;
            this.rbFichaPronta.Checked = true;
            this.rbFichaPronta.Location = new System.Drawing.Point(6, 17);
            this.rbFichaPronta.Name = "rbFichaPronta";
            this.rbFichaPronta.Size = new System.Drawing.Size(131, 17);
            this.rbFichaPronta.TabIndex = 0;
            this.rbFichaPronta.TabStop = true;
            this.rbFichaPronta.Text = "Clientes - Ficha Pronta";
            this.rbFichaPronta.Tipo = Canaan.Lib.Componentes.TipoRelatorioTele.FichaPronta;
            this.rbFichaPronta.TipoRelatorio = "FichaPronta";
            this.rbFichaPronta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtFinal);
            this.groupBox2.Controls.Add(this.cLabel1);
            this.groupBox2.Controls.Add(this.dtInicial);
            this.groupBox2.Location = new System.Drawing.Point(6, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período do Atendimento";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(149, 21);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(109, 20);
            this.dtFinal.TabIndex = 2;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(126, 18);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(23, 23);
            this.cLabel1.TabIndex = 1;
            this.cLabel1.Text = "a";
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(16, 21);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(109, 20);
            this.dtInicial.TabIndex = 0;
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(270, 396);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(75, 23);
            this.btGerar.TabIndex = 2;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckCartas);
            this.groupBox1.Controls.Add(this.ckEtiquetas);
            this.groupBox1.Location = new System.Drawing.Point(6, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Relatorio";
            // 
            // ckEtiquetas
            // 
            this.ckEtiquetas.AutoSize = true;
            this.ckEtiquetas.Location = new System.Drawing.Point(11, 28);
            this.ckEtiquetas.Name = "ckEtiquetas";
            this.ckEtiquetas.Size = new System.Drawing.Size(69, 17);
            this.ckEtiquetas.TabIndex = 0;
            this.ckEtiquetas.TabStop = true;
            this.ckEtiquetas.Text = "Etiquetas";
            this.ckEtiquetas.UseVisualStyleBackColor = true;
            // 
            // ckCartas
            // 
            this.ckCartas.AutoSize = true;
            this.ckCartas.Location = new System.Drawing.Point(86, 28);
            this.ckCartas.Name = "ckCartas";
            this.ckCartas.Size = new System.Drawing.Size(55, 17);
            this.ckCartas.TabIndex = 1;
            this.ckCartas.TabStop = true;
            this.ckCartas.Text = "Cartas";
            this.ckCartas.UseVisualStyleBackColor = true;
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 475);
            this.Name = "Filtro";
            this.Text = "Filtro";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox;
        private Lib.Componentes.CRadioButtonTeleFilter rbFichaPronta;
        private Lib.Componentes.CRadioButtonTeleFilter rbNaoViu;
        private Lib.Componentes.CRadioButtonTeleFilter rbNaoComprou;
        private Lib.Componentes.CRadioButtonTeleFilter rbPegouBrinde;
        private Lib.Componentes.CRadioButtonTeleFilter rbAguardandoFinalizacao;
        private Lib.Componentes.CRadioButtonTeleFilter rbProgramadas;
        private Lib.Componentes.CRadioButtonTeleFilter rbVendasDevolvidas;
        private Lib.Componentes.CRadioButtonTeleFilter rbClientesVendidos;
        private Lib.Componentes.CRadioButtonTeleFilter rbListaOuro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private Lib.Componentes.CLabel cLabel1;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Button btGerar;
        private Lib.Componentes.CRadioButtonTeleFilter cRadioButtonTeleFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ckEtiquetas;
        private System.Windows.Forms.RadioButton ckCartas;
    }
}