namespace Canaan.CService.Telas.Integracao.PagSeguro
{
    partial class Edita
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFinaliza = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dddTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.freteTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.servicoTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch,
            this.toolStripSeparator1,
            this.btnFinaliza});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Canaan.CService.Telas.Properties.Resources.filter_16xLG;
            this.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 22);
            this.btnSearch.Text = "Procurar Cliente";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Image = global::Canaan.CService.Telas.Properties.Resources.process_16xLG;
            this.btnFinaliza.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFinaliza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(105, 22);
            this.btnFinaliza.Text = "Finalizar Venda";
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dddTextBox);
            this.groupBox1.Controls.Add(this.telefoneTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.documentoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(9, 32);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(131, 20);
            this.codigoTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(9, 71);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(241, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.Location = new System.Drawing.Point(256, 71);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(241, 20);
            this.documentoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Documento";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(9, 110);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(241, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(318, 110);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(179, 20);
            this.telefoneTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone";
            // 
            // dddTextBox
            // 
            this.dddTextBox.Location = new System.Drawing.Point(256, 110);
            this.dddTextBox.Name = "dddTextBox";
            this.dddTextBox.Size = new System.Drawing.Size(56, 20);
            this.dddTextBox.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.complementoTextBox);
            this.groupBox2.Controls.Add(this.Complemento);
            this.groupBox2.Controls.Add(this.numeroTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ruaTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.estadoTextBox);
            this.groupBox2.Controls.Add(this.cidadeTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cepTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bairroTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 151);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // cepTextBox
            // 
            this.cepTextBox.Location = new System.Drawing.Point(9, 71);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(241, 20);
            this.cepTextBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "CEP";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(256, 32);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(241, 20);
            this.bairroTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bairro";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.Location = new System.Drawing.Point(9, 32);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(56, 20);
            this.estadoTextBox.TabIndex = 15;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(71, 32);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(179, 20);
            this.cidadeTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cidade";
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.Location = new System.Drawing.Point(256, 71);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(241, 20);
            this.ruaTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rua";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(9, 110);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(241, 20);
            this.numeroTextBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Numero";
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.Location = new System.Drawing.Point(256, 110);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(241, 20);
            this.complementoTextBox.TabIndex = 22;
            // 
            // Complemento
            // 
            this.Complemento.AutoSize = true;
            this.Complemento.Location = new System.Drawing.Point(253, 94);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(27, 13);
            this.Complemento.TabIndex = 21;
            this.Complemento.Text = "Rua";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.freteTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.valorTextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.servicoTextBox);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(12, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 112);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valores";
            // 
            // freteTextBox
            // 
            this.freteTextBox.Location = new System.Drawing.Point(256, 71);
            this.freteTextBox.Name = "freteTextBox";
            this.freteTextBox.Size = new System.Drawing.Size(241, 20);
            this.freteTextBox.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Frete";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(9, 71);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(241, 20);
            this.valorTextBox.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Valor";
            // 
            // servicoTextBox
            // 
            this.servicoTextBox.Location = new System.Drawing.Point(9, 32);
            this.servicoTextBox.Name = "servicoTextBox";
            this.servicoTextBox.Size = new System.Drawing.Size(488, 20);
            this.servicoTextBox.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Descrição do Serviço";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnFinaliza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dddTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox complementoTextBox;
        private System.Windows.Forms.Label Complemento;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ruaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox freteTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox servicoTextBox;
        private System.Windows.Forms.Label label17;

    }
}