namespace RM.Relatorios.Cobranca.UltimaParcela
{
    partial class frmFiltro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.finalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextoIndividual = new System.Windows.Forms.RadioButton();
            this.contextoFranquia = new System.Windows.Forms.RadioButton();
            this.contextoGrupo = new System.Windows.Forms.RadioButton();
            this.filialComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.relEtiqueta = new System.Windows.Forms.RadioButton();
            this.relSintetico = new System.Windows.Forms.RadioButton();
            this.relAnalitico = new System.Windows.Forms.RadioButton();
            this.btnGerar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbProgress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.finalDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inicioDateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(282, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período da Pesquisa";
            // 
            // finalDateTimePicker
            // 
            this.finalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finalDateTimePicker.Location = new System.Drawing.Point(8, 73);
            this.finalDateTimePicker.Name = "finalDateTimePicker";
            this.finalDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.finalDateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final";
            // 
            // inicioDateTimePicker
            // 
            this.inicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inicioDateTimePicker.Location = new System.Drawing.Point(8, 34);
            this.inicioDateTimePicker.Name = "inicioDateTimePicker";
            this.inicioDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.inicioDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Inicial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contextoIndividual);
            this.groupBox2.Controls.Add(this.contextoFranquia);
            this.groupBox2.Controls.Add(this.contextoGrupo);
            this.groupBox2.Controls.Add(this.filialComboBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contexto da Pesquisa";
            // 
            // contextoIndividual
            // 
            this.contextoIndividual.AutoSize = true;
            this.contextoIndividual.Location = new System.Drawing.Point(8, 65);
            this.contextoIndividual.Name = "contextoIndividual";
            this.contextoIndividual.Size = new System.Drawing.Size(70, 17);
            this.contextoIndividual.TabIndex = 6;
            this.contextoIndividual.TabStop = true;
            this.contextoIndividual.Text = "Individual";
            this.contextoIndividual.UseVisualStyleBackColor = true;
            this.contextoIndividual.CheckedChanged += new System.EventHandler(this.contextoIndividual_CheckedChanged);
            // 
            // contextoFranquia
            // 
            this.contextoFranquia.AutoSize = true;
            this.contextoFranquia.Location = new System.Drawing.Point(8, 42);
            this.contextoFranquia.Name = "contextoFranquia";
            this.contextoFranquia.Size = new System.Drawing.Size(71, 17);
            this.contextoFranquia.TabIndex = 5;
            this.contextoFranquia.TabStop = true;
            this.contextoFranquia.Text = "Franquias";
            this.contextoFranquia.UseVisualStyleBackColor = true;
            this.contextoFranquia.CheckedChanged += new System.EventHandler(this.contextoFranquia_CheckedChanged);
            // 
            // contextoGrupo
            // 
            this.contextoGrupo.AutoSize = true;
            this.contextoGrupo.Location = new System.Drawing.Point(8, 19);
            this.contextoGrupo.Name = "contextoGrupo";
            this.contextoGrupo.Size = new System.Drawing.Size(118, 17);
            this.contextoGrupo.TabIndex = 4;
            this.contextoGrupo.TabStop = true;
            this.contextoGrupo.Text = "Empresas do Grupo";
            this.contextoGrupo.UseVisualStyleBackColor = true;
            this.contextoGrupo.CheckedChanged += new System.EventHandler(this.contextoGrupo_CheckedChanged);
            // 
            // filialComboBox
            // 
            this.filialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filialComboBox.FormattingEnabled = true;
            this.filialComboBox.Location = new System.Drawing.Point(8, 88);
            this.filialComboBox.Name = "filialComboBox";
            this.filialComboBox.Size = new System.Drawing.Size(268, 21);
            this.filialComboBox.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.relEtiqueta);
            this.groupBox3.Controls.Add(this.relSintetico);
            this.groupBox3.Controls.Add(this.relAnalitico);
            this.groupBox3.Location = new System.Drawing.Point(8, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modelo do Relatório";
            // 
            // relEtiqueta
            // 
            this.relEtiqueta.AutoSize = true;
            this.relEtiqueta.Location = new System.Drawing.Point(8, 65);
            this.relEtiqueta.Name = "relEtiqueta";
            this.relEtiqueta.Size = new System.Drawing.Size(69, 17);
            this.relEtiqueta.TabIndex = 7;
            this.relEtiqueta.TabStop = true;
            this.relEtiqueta.Text = "Etiquetas";
            this.relEtiqueta.UseVisualStyleBackColor = true;
            // 
            // relSintetico
            // 
            this.relSintetico.AutoSize = true;
            this.relSintetico.Location = new System.Drawing.Point(8, 42);
            this.relSintetico.Name = "relSintetico";
            this.relSintetico.Size = new System.Drawing.Size(111, 17);
            this.relSintetico.TabIndex = 6;
            this.relSintetico.TabStop = true;
            this.relSintetico.Text = "Relatório Sintético";
            this.relSintetico.UseVisualStyleBackColor = true;
            // 
            // relAnalitico
            // 
            this.relAnalitico.AutoSize = true;
            this.relAnalitico.Location = new System.Drawing.Point(8, 19);
            this.relAnalitico.Name = "relAnalitico";
            this.relAnalitico.Size = new System.Drawing.Size(112, 17);
            this.relAnalitico.TabIndex = 5;
            this.relAnalitico.TabStop = true;
            this.relAnalitico.Text = "Relatório Analítico";
            this.relAnalitico.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(184, 344);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(106, 23);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar Relatório";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(10, 350);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(0, 13);
            this.lbProgress.TabIndex = 4;
            // 
            // frmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 378);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltro";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro do Relatório";
            this.Load += new System.EventHandler(this.frmFiltro_Load);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker finalDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker inicioDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton contextoIndividual;
        private System.Windows.Forms.RadioButton contextoFranquia;
        private System.Windows.Forms.RadioButton contextoGrupo;
        private System.Windows.Forms.ComboBox filialComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton relEtiqueta;
        private System.Windows.Forms.RadioButton relSintetico;
        private System.Windows.Forms.RadioButton relAnalitico;
        private System.Windows.Forms.Button btnGerar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbProgress;
    }
}