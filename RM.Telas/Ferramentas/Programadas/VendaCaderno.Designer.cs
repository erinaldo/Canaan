namespace RM.Telas.Ferramentas.Programadas
{
    partial class VendaCaderno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cadernoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbComEntrada = new System.Windows.Forms.RadioButton();
            this.rbSemEntrada = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lancamentoGridView = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baixado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.classeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cadernoDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(869, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe a Data do Caderno";
            // 
            // cadernoDateTimePicker
            // 
            this.cadernoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cadernoDateTimePicker.Location = new System.Drawing.Point(8, 21);
            this.cadernoDateTimePicker.Name = "cadernoDateTimePicker";
            this.cadernoDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.cadernoDateTimePicker.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbComEntrada);
            this.groupBox2.Controls.Add(this.rbSemEntrada);
            this.groupBox2.Location = new System.Drawing.Point(8, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(869, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações da Entrada";
            // 
            // rbComEntrada
            // 
            this.rbComEntrada.AutoSize = true;
            this.rbComEntrada.Location = new System.Drawing.Point(8, 44);
            this.rbComEntrada.Name = "rbComEntrada";
            this.rbComEntrada.Size = new System.Drawing.Size(86, 17);
            this.rbComEntrada.TabIndex = 1;
            this.rbComEntrada.TabStop = true;
            this.rbComEntrada.Text = "Com Entrada";
            this.rbComEntrada.UseVisualStyleBackColor = true;
            this.rbComEntrada.CheckedChanged += new System.EventHandler(this.rbComEntrada_CheckedChanged);
            // 
            // rbSemEntrada
            // 
            this.rbSemEntrada.AutoSize = true;
            this.rbSemEntrada.Location = new System.Drawing.Point(8, 21);
            this.rbSemEntrada.Name = "rbSemEntrada";
            this.rbSemEntrada.Size = new System.Drawing.Size(86, 17);
            this.rbSemEntrada.TabIndex = 0;
            this.rbSemEntrada.TabStop = true;
            this.rbSemEntrada.Text = "Sem Entrada";
            this.rbSemEntrada.UseVisualStyleBackColor = true;
            this.rbSemEntrada.CheckedChanged += new System.EventHandler(this.rbSemEntrada_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lancamentoGridView);
            this.groupBox3.Location = new System.Drawing.Point(8, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(869, 253);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecione a(s) Parcela(s) da Entrada";
            // 
            // lancamentoGridView
            // 
            this.lancamentoGridView.AllowUserToAddRows = false;
            this.lancamentoGridView.AllowUserToDeleteRows = false;
            this.lancamentoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lancamentoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.Codigo,
            this.Classe,
            this.Emissao,
            this.Vencimento,
            this.Baixa,
            this.Valor,
            this.Baixado});
            this.lancamentoGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lancamentoGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lancamentoGridView.Location = new System.Drawing.Point(5, 18);
            this.lancamentoGridView.Name = "lancamentoGridView";
            this.lancamentoGridView.RowHeadersVisible = false;
            this.lancamentoGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lancamentoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lancamentoGridView.ShowCellErrors = false;
            this.lancamentoGridView.ShowCellToolTips = false;
            this.lancamentoGridView.ShowEditingIcon = false;
            this.lancamentoGridView.ShowRowErrors = false;
            this.lancamentoGridView.Size = new System.Drawing.Size(859, 230);
            this.lancamentoGridView.TabIndex = 2;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Classe
            // 
            this.Classe.DataPropertyName = "Classe";
            this.Classe.HeaderText = "Classe";
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            // 
            // Emissao
            // 
            this.Emissao.DataPropertyName = "Emissao";
            dataGridViewCellStyle1.Format = "d";
            this.Emissao.DefaultCellStyle = dataGridViewCellStyle1;
            this.Emissao.HeaderText = "Emissao";
            this.Emissao.Name = "Emissao";
            this.Emissao.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "Vencimento";
            dataGridViewCellStyle2.Format = "d";
            this.Vencimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // Baixa
            // 
            this.Baixa.DataPropertyName = "Baixa";
            dataGridViewCellStyle3.Format = "d";
            this.Baixa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Baixa.HeaderText = "Baixa";
            this.Baixa.Name = "Baixa";
            this.Baixa.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle4;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Baixado
            // 
            this.Baixado.DataPropertyName = "Baixado";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Baixado.DefaultCellStyle = dataGridViewCellStyle5;
            this.Baixado.HeaderText = "Baixado";
            this.Baixado.Name = "Baixado";
            this.Baixado.ReadOnly = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(797, 465);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.classeComboBox);
            this.groupBox4.Location = new System.Drawing.Point(8, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(869, 54);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Classe Contábil Utilizada nas Parcelas";
            // 
            // classeComboBox
            // 
            this.classeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classeComboBox.FormattingEnabled = true;
            this.classeComboBox.Location = new System.Drawing.Point(8, 19);
            this.classeComboBox.Name = "classeComboBox";
            this.classeComboBox.Size = new System.Drawing.Size(278, 21);
            this.classeComboBox.TabIndex = 0;
            // 
            // VendaCaderno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 496);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendaCaderno";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendaCaderno";
            this.Load += new System.EventHandler(this.VendaCaderno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker cadernoDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbComEntrada;
        private System.Windows.Forms.RadioButton rbSemEntrada;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.DataGridView lancamentoGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baixado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox classeComboBox;
    }
}