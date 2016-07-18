using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Venda.Documentacao
{
    partial class Documentacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIndiquePlus = new System.Windows.Forms.Button();
            this.btnControlePgto = new System.Windows.Forms.Button();
            this.btnComprovante = new System.Windows.Forms.Button();
            this.btnContrato = new System.Windows.Forms.Button();
            this.btnEnvelope = new System.Windows.Forms.Button();
            this.btAditamento = new System.Windows.Forms.Button();
            this.btnBoleto = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.btLiberarVenda = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbVendedoras = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolstripActions.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolstripActions);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Text = "Documentação / Finalização";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnIndiquePlus);
            this.groupBox1.Controls.Add(this.btnControlePgto);
            this.groupBox1.Controls.Add(this.btAditamento);
            this.groupBox1.Controls.Add(this.btnComprovante);
            this.groupBox1.Controls.Add(this.btnBoleto);
            this.groupBox1.Controls.Add(this.btnServicos);
            this.groupBox1.Controls.Add(this.btnContrato);
            this.groupBox1.Controls.Add(this.btnEnvelope);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(300, 468);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentação";
            // 
            // btnIndiquePlus
            // 
            this.btnIndiquePlus.Location = new System.Drawing.Point(53, 143);
            this.btnIndiquePlus.Name = "btnIndiquePlus";
            this.btnIndiquePlus.Size = new System.Drawing.Size(175, 23);
            this.btnIndiquePlus.TabIndex = 7;
            this.btnIndiquePlus.Text = "Indique e Ganhe Plus";
            this.btnIndiquePlus.UseVisualStyleBackColor = true;
            this.btnIndiquePlus.Click += new System.EventHandler(this.btnIndiquePlus_Click);
            // 
            // btnControlePgto
            // 
            this.btnControlePgto.Location = new System.Drawing.Point(53, 114);
            this.btnControlePgto.Name = "btnControlePgto";
            this.btnControlePgto.Size = new System.Drawing.Size(175, 23);
            this.btnControlePgto.TabIndex = 6;
            this.btnControlePgto.Text = "Controle de Pagamento";
            this.btnControlePgto.UseVisualStyleBackColor = true;
            this.btnControlePgto.Click += new System.EventHandler(this.btnControlePgto_Click);
            // 
            // btnComprovante
            // 
            this.btnComprovante.Location = new System.Drawing.Point(53, 85);
            this.btnComprovante.Name = "btnComprovante";
            this.btnComprovante.Size = new System.Drawing.Size(175, 23);
            this.btnComprovante.TabIndex = 4;
            this.btnComprovante.Text = "Comprovante de Entrada";
            this.btnComprovante.UseVisualStyleBackColor = true;
            this.btnComprovante.Click += new System.EventHandler(this.btnComprovante_Click);
            // 
            // btnContrato
            // 
            this.btnContrato.Location = new System.Drawing.Point(53, 56);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(175, 23);
            this.btnContrato.TabIndex = 3;
            this.btnContrato.Text = "Contrato";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // btnEnvelope
            // 
            this.btnEnvelope.Location = new System.Drawing.Point(53, 27);
            this.btnEnvelope.Name = "btnEnvelope";
            this.btnEnvelope.Size = new System.Drawing.Size(175, 23);
            this.btnEnvelope.TabIndex = 1;
            this.btnEnvelope.Text = "Envelope de Serviço";
            this.btnEnvelope.UseVisualStyleBackColor = true;
            this.btnEnvelope.Click += new System.EventHandler(this.btnEnvelope_Click);
            // 
            // btAditamento
            // 
            this.btAditamento.Location = new System.Drawing.Point(53, 230);
            this.btAditamento.Name = "btAditamento";
            this.btAditamento.Size = new System.Drawing.Size(175, 23);
            this.btAditamento.TabIndex = 5;
            this.btAditamento.Text = "Aditamento";
            this.btAditamento.UseVisualStyleBackColor = true;
            this.btAditamento.Click += new System.EventHandler(this.btAditamento_Click);
            // 
            // btnBoleto
            // 
            this.btnBoleto.Location = new System.Drawing.Point(53, 201);
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.Size = new System.Drawing.Size(175, 23);
            this.btnBoleto.TabIndex = 2;
            this.btnBoleto.Text = "Boleto";
            this.btnBoleto.UseVisualStyleBackColor = true;
            this.btnBoleto.Click += new System.EventHandler(this.btnBoleto_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Location = new System.Drawing.Point(53, 172);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(175, 23);
            this.btnServicos.TabIndex = 0;
            this.btnServicos.Text = "Serviços Contratados";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btLiberarVenda});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(990, 33);
            this.toolstripActions.TabIndex = 2;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // btLiberarVenda
            // 
            this.btLiberarVenda.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.btLiberarVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLiberarVenda.Name = "btLiberarVenda";
            this.btLiberarVenda.Size = new System.Drawing.Size(105, 20);
            this.btLiberarVenda.Text = "Finalizar Venda";
            this.btLiberarVenda.Click += new System.EventHandler(this.btLiberarVenda_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbVendedoras);
            this.groupBox2.Location = new System.Drawing.Point(332, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendedora";
            // 
            // cbVendedoras
            // 
            this.cbVendedoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendedoras.FormattingEnabled = true;
            this.cbVendedoras.Location = new System.Drawing.Point(23, 30);
            this.cbVendedoras.Name = "cbVendedoras";
            this.cbVendedoras.Size = new System.Drawing.Size(477, 21);
            this.cbVendedoras.TabIndex = 0;
            this.cbVendedoras.SelectedIndexChanged += new System.EventHandler(this.cbVendedoras_SelectedIndexChanged);
            // 
            // Documentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Documentacao";
            this.Text = "Documentacao";
            this.Load += new System.EventHandler(this.Documentacao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnServicos;
        private Button btnBoleto;
        private Button btnEnvelope;
        private Button btnContrato;
        private Button btnComprovante;
        public GroupBox groupBox1;
        protected ToolStrip toolstripActions;
        private ToolStripButton btLiberarVenda;
        private Button btAditamento;
        private GroupBox groupBox2;
        private ComboBox cbVendedoras;
        private Button btnControlePgto;
        private Button btnIndiquePlus;

    }
}