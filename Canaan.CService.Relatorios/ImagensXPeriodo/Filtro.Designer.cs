namespace Canaan.CService.Relatorios.ImagensXPeriodo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipoCheckBox = new System.Windows.Forms.CheckBox();
            this.fimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.inicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeCheckBox = new System.Windows.Forms.CheckBox();
            this.gerarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tipoCheckBox);
            this.groupBox1.Controls.Add(this.fimDateTimePicker);
            this.groupBox1.Controls.Add(this.inicioDateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cidadeComboBox);
            this.groupBox1.Controls.Add(this.cidadeCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(289, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Filtro";
            // 
            // tipoCheckBox
            // 
            this.tipoCheckBox.AutoSize = true;
            this.tipoCheckBox.Enabled = false;
            this.tipoCheckBox.Location = new System.Drawing.Point(8, 118);
            this.tipoCheckBox.Name = "tipoCheckBox";
            this.tipoCheckBox.Size = new System.Drawing.Size(186, 17);
            this.tipoCheckBox.TabIndex = 5;
            this.tipoCheckBox.Text = "Todas as Imagens dos Envelopes";
            this.tipoCheckBox.UseVisualStyleBackColor = true;
            this.tipoCheckBox.CheckedChanged += new System.EventHandler(this.tipoCheckBox_CheckedChanged);
            // 
            // fimDateTimePicker
            // 
            this.fimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fimDateTimePicker.Location = new System.Drawing.Point(149, 89);
            this.fimDateTimePicker.Name = "fimDateTimePicker";
            this.fimDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.fimDateTimePicker.TabIndex = 4;
            // 
            // inicioDateTimePicker
            // 
            this.inicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inicioDateTimePicker.Location = new System.Drawing.Point(8, 89);
            this.inicioDateTimePicker.Name = "inicioDateTimePicker";
            this.inicioDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.inicioDateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o Período";
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cidadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Location = new System.Drawing.Point(8, 44);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(273, 21);
            this.cidadeComboBox.TabIndex = 1;
            // 
            // cidadeCheckBox
            // 
            this.cidadeCheckBox.AutoSize = true;
            this.cidadeCheckBox.Location = new System.Drawing.Point(8, 21);
            this.cidadeCheckBox.Name = "cidadeCheckBox";
            this.cidadeCheckBox.Size = new System.Drawing.Size(106, 17);
            this.cidadeCheckBox.TabIndex = 0;
            this.cidadeCheckBox.Text = "Filtrar Por Cidade";
            this.cidadeCheckBox.UseVisualStyleBackColor = true;
            this.cidadeCheckBox.CheckedChanged += new System.EventHandler(this.cidadeCheckBox_CheckedChanged);
            // 
            // gerarButton
            // 
            this.gerarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gerarButton.Location = new System.Drawing.Point(171, 165);
            this.gerarButton.Name = "gerarButton";
            this.gerarButton.Size = new System.Drawing.Size(130, 23);
            this.gerarButton.TabIndex = 1;
            this.gerarButton.Text = "Gerar Relatório";
            this.gerarButton.UseVisualStyleBackColor = true;
            this.gerarButton.Click += new System.EventHandler(this.gerarButton_Click);
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(313, 200);
            this.Controls.Add(this.gerarButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button gerarButton;
        private System.Windows.Forms.DateTimePicker fimDateTimePicker;
        private System.Windows.Forms.DateTimePicker inicioDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.CheckBox cidadeCheckBox;
        private System.Windows.Forms.CheckBox tipoCheckBox;
    }
}