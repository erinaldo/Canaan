using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope.Colecoes
{
    partial class Edita
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
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cLabel3 = new Canaan.Lib.Componentes.CLabel();
            this.txtValorManual = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lbNovoValor = new Canaan.Lib.Componentes.CLabel();
            this.cLabel8 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel7 = new Canaan.Lib.Componentes.CLabel();
            this.lkLabelProduto = new System.Windows.Forms.LinkLabel();
            this.lbValorUnitario = new Canaan.Lib.Componentes.CLabel();
            this.cLabel5 = new Canaan.Lib.Componentes.CLabel();
            this.lbQuantidadeAtual = new Canaan.Lib.Componentes.CLabel();
            this.lbValorAtual = new Canaan.Lib.Componentes.CLabel();
            this.cLabel2 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.toolstripActions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar});
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(482, 33);
            this.toolstripActions.TabIndex = 1;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 20);
            this.btnSalvar.Text = "Salvar Registro";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cLabel3);
            this.groupBox1.Controls.Add(this.txtValorManual);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.lbNovoValor);
            this.groupBox1.Controls.Add(this.cLabel8);
            this.groupBox1.Controls.Add(this.cLabel7);
            this.groupBox1.Controls.Add(this.lkLabelProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Produto";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.Location = new System.Drawing.Point(19, 92);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel3.Size = new System.Drawing.Size(79, 23);
            this.cLabel3.TabIndex = 16;
            this.cLabel3.Text = "Valor Manual";
            // 
            // txtValorManual
            // 
            this.txtValorManual.Location = new System.Drawing.Point(22, 118);
            this.txtValorManual.Name = "txtValorManual";
            this.txtValorManual.Size = new System.Drawing.Size(122, 20);
            this.txtValorManual.TabIndex = 15;
            this.txtValorManual.Leave += new System.EventHandler(this.txtValorManual_Leave);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(22, 65);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(120, 20);
            this.txtQuantidade.TabIndex = 14;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // lbNovoValor
            // 
            this.lbNovoValor.AutoSize = true;
            this.lbNovoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNovoValor.Location = new System.Drawing.Point(239, 52);
            this.lbNovoValor.Name = "lbNovoValor";
            this.lbNovoValor.Padding = new System.Windows.Forms.Padding(5);
            this.lbNovoValor.Size = new System.Drawing.Size(84, 27);
            this.lbNovoValor.TabIndex = 13;
            this.lbNovoValor.Text = "NovoValor";
            // 
            // cLabel8
            // 
            this.cLabel8.AutoSize = true;
            this.cLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel8.Location = new System.Drawing.Point(239, 24);
            this.cLabel8.Name = "cLabel8";
            this.cLabel8.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel8.Size = new System.Drawing.Size(141, 28);
            this.cLabel8.TabIndex = 3;
            this.cLabel8.Text = "Valor a Atualizar";
            // 
            // cLabel7
            // 
            this.cLabel7.AutoSize = true;
            this.cLabel7.Location = new System.Drawing.Point(17, 42);
            this.cLabel7.Name = "cLabel7";
            this.cLabel7.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel7.Size = new System.Drawing.Size(72, 23);
            this.cLabel7.TabIndex = 2;
            this.cLabel7.Text = "Quantidade";
            // 
            // lkLabelProduto
            // 
            this.lkLabelProduto.AutoSize = true;
            this.lkLabelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLabelProduto.Location = new System.Drawing.Point(17, 21);
            this.lkLabelProduto.Name = "lkLabelProduto";
            this.lkLabelProduto.Size = new System.Drawing.Size(148, 17);
            this.lkLabelProduto.TabIndex = 0;
            this.lkLabelProduto.TabStop = true;
            this.lkLabelProduto.Text = "Produtod Selecionado";
            // 
            // lbValorUnitario
            // 
            this.lbValorUnitario.AutoSize = true;
            this.lbValorUnitario.Location = new System.Drawing.Point(133, 203);
            this.lbValorUnitario.Name = "lbValorUnitario";
            this.lbValorUnitario.Padding = new System.Windows.Forms.Padding(5);
            this.lbValorUnitario.Size = new System.Drawing.Size(80, 23);
            this.lbValorUnitario.TabIndex = 12;
            this.lbValorUnitario.Text = "Valor Unitário";
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel5.Location = new System.Drawing.Point(12, 203);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel5.Size = new System.Drawing.Size(94, 23);
            this.cLabel5.TabIndex = 11;
            this.cLabel5.Text = "Valor Unitário";
            // 
            // lbQuantidadeAtual
            // 
            this.lbQuantidadeAtual.AutoSize = true;
            this.lbQuantidadeAtual.Location = new System.Drawing.Point(133, 250);
            this.lbQuantidadeAtual.Name = "lbQuantidadeAtual";
            this.lbQuantidadeAtual.Padding = new System.Windows.Forms.Padding(5);
            this.lbQuantidadeAtual.Size = new System.Drawing.Size(99, 23);
            this.lbQuantidadeAtual.TabIndex = 10;
            this.lbQuantidadeAtual.Text = "Quantidade Atual";
            // 
            // lbValorAtual
            // 
            this.lbValorAtual.AutoSize = true;
            this.lbValorAtual.Location = new System.Drawing.Point(133, 227);
            this.lbValorAtual.Name = "lbValorAtual";
            this.lbValorAtual.Padding = new System.Windows.Forms.Padding(5);
            this.lbValorAtual.Size = new System.Drawing.Size(68, 23);
            this.lbValorAtual.TabIndex = 9;
            this.lbValorAtual.Text = "Valor Atual";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel2.Location = new System.Drawing.Point(12, 250);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel2.Size = new System.Drawing.Size(115, 23);
            this.cLabel2.TabIndex = 8;
            this.cLabel2.Text = "Quantidade Atual";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel1.Location = new System.Drawing.Point(12, 228);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(79, 23);
            this.cLabel1.TabIndex = 7;
            this.cLabel1.Text = "Valor Atual";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 283);
            this.Controls.Add(this.lbValorUnitario);
            this.Controls.Add(this.cLabel5);
            this.Controls.Add(this.lbQuantidadeAtual);
            this.Controls.Add(this.lbValorAtual);
            this.Controls.Add(this.cLabel2);
            this.Controls.Add(this.cLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolstripActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Edita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolstripActions;
        private ToolStripButton btnSalvar;
        private GroupBox groupBox1;
        private LinkLabel lkLabelProduto;
        private CLabel lbValorUnitario;
        private CLabel cLabel5;
        private CLabel lbQuantidadeAtual;
        private CLabel lbValorAtual;
        private CLabel cLabel2;
        private CLabel cLabel1;
        private CLabel cLabel7;
        private CLabel cLabel8;
        private CLabel lbNovoValor;
        private NumericUpDown txtQuantidade;
        private CLabel cLabel3;
        private TextBox txtValorManual;
    }
}