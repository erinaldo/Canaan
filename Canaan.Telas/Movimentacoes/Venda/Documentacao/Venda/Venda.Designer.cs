using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Venda.Documentacao.Venda
{
    partial class Venda
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btSalvarEntrada = new System.Windows.Forms.Button();
            this.txtEntradaDinheiro = new System.Windows.Forms.TextBox();
            this.txtEntradaCartao = new System.Windows.Forms.TextBox();
            this.lbRestante = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbValorTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(223, 202);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btSalvarEntrada);
            this.tabPage1.Controls.Add(this.txtEntradaDinheiro);
            this.tabPage1.Controls.Add(this.txtEntradaCartao);
            this.tabPage1.Controls.Add(this.lbRestante);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lbValorTotal);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(215, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados da Venda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btSalvarEntrada
            // 
            this.btSalvarEntrada.Location = new System.Drawing.Point(126, 115);
            this.btSalvarEntrada.Name = "btSalvarEntrada";
            this.btSalvarEntrada.Size = new System.Drawing.Size(75, 23);
            this.btSalvarEntrada.TabIndex = 8;
            this.btSalvarEntrada.Text = "Salvar";
            this.btSalvarEntrada.UseVisualStyleBackColor = true;
            this.btSalvarEntrada.Click += new System.EventHandler(this.btSalvarEntrada_Click);
            // 
            // txtEntradaDinheiro
            // 
            this.txtEntradaDinheiro.Location = new System.Drawing.Point(69, 83);
            this.txtEntradaDinheiro.Name = "txtEntradaDinheiro";
            this.txtEntradaDinheiro.Size = new System.Drawing.Size(132, 20);
            this.txtEntradaDinheiro.TabIndex = 7;
            // 
            // txtEntradaCartao
            // 
            this.txtEntradaCartao.Location = new System.Drawing.Point(69, 57);
            this.txtEntradaCartao.Name = "txtEntradaCartao";
            this.txtEntradaCartao.Size = new System.Drawing.Size(132, 20);
            this.txtEntradaCartao.TabIndex = 6;
            // 
            // lbRestante
            // 
            this.lbRestante.AutoSize = true;
            this.lbRestante.Location = new System.Drawing.Point(144, 157);
            this.lbRestante.Name = "lbRestante";
            this.lbRestante.Size = new System.Drawing.Size(58, 13);
            this.lbRestante.TabIndex = 5;
            this.lbRestante.Text = "lbRestante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Restante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dinheiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cartão";
            // 
            // lbValorTotal
            // 
            this.lbValorTotal.AutoSize = true;
            this.lbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorTotal.Location = new System.Drawing.Point(113, 19);
            this.lbValorTotal.Name = "lbValorTotal";
            this.lbValorTotal.Size = new System.Drawing.Size(74, 16);
            this.lbValorTotal.TabIndex = 1;
            this.lbValorTotal.Text = "Valor Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Total";
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 202);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btSalvarEntrada;
        private TextBox txtEntradaDinheiro;
        private TextBox txtEntradaCartao;
        private Label lbRestante;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbValorTotal;
        private Label label1;
    }
}