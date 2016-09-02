namespace Canaan.Telas.Movimentacoes.Venda.Evento
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
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.eventoComboBox = new System.Windows.Forms.ComboBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.dataInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataFimDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.groupInfo);
            this.panelEdit.Size = new System.Drawing.Size(358, 279);
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.horaFimDateTimePicker);
            this.groupInfo.Controls.Add(this.dataFimDateTimePicker);
            this.groupInfo.Controls.Add(this.label3);
            this.groupInfo.Controls.Add(this.horaInicioDateTimePicker);
            this.groupInfo.Controls.Add(this.dataInicioDateTimePicker);
            this.groupInfo.Controls.Add(this.eventoComboBox);
            this.groupInfo.Controls.Add(this.descricaoTextBox);
            this.groupInfo.Controls.Add(this.label2);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Controls.Add(this.lbNome);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfo.Location = new System.Drawing.Point(10, 10);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Padding = new System.Windows.Forms.Padding(5);
            this.groupInfo.Size = new System.Drawing.Size(338, 259);
            this.groupInfo.TabIndex = 3;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Informações do Evento";
            // 
            // eventoComboBox
            // 
            this.eventoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventoComboBox.FormattingEnabled = true;
            this.eventoComboBox.Location = new System.Drawing.Point(8, 34);
            this.eventoComboBox.Name = "eventoComboBox";
            this.eventoComboBox.Size = new System.Drawing.Size(318, 21);
            this.eventoComboBox.TabIndex = 6;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(8, 156);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(318, 87);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(8, 18);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(27, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Tipo";
            // 
            // dataInicioDateTimePicker
            // 
            this.dataInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicioDateTimePicker.Location = new System.Drawing.Point(9, 75);
            this.dataInicioDateTimePicker.Name = "dataInicioDateTimePicker";
            this.dataInicioDateTimePicker.Size = new System.Drawing.Size(94, 21);
            this.dataInicioDateTimePicker.TabIndex = 7;
            // 
            // horaInicioDateTimePicker
            // 
            this.horaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaInicioDateTimePicker.Location = new System.Drawing.Point(109, 75);
            this.horaInicioDateTimePicker.Name = "horaInicioDateTimePicker";
            this.horaInicioDateTimePicker.Size = new System.Drawing.Size(83, 21);
            this.horaInicioDateTimePicker.TabIndex = 8;
            // 
            // horaFimDateTimePicker
            // 
            this.horaFimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaFimDateTimePicker.Location = new System.Drawing.Point(109, 116);
            this.horaFimDateTimePicker.Name = "horaFimDateTimePicker";
            this.horaFimDateTimePicker.Size = new System.Drawing.Size(83, 21);
            this.horaFimDateTimePicker.TabIndex = 11;
            // 
            // dataFimDateTimePicker
            // 
            this.dataFimDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFimDateTimePicker.Location = new System.Drawing.Point(9, 116);
            this.dataFimDateTimePicker.Name = "dataFimDateTimePicker";
            this.dataFimDateTimePicker.Size = new System.Drawing.Size(94, 21);
            this.dataFimDateTimePicker.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fim";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 312);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.DateTimePicker horaFimDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataFimDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker horaInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataInicioDateTimePicker;
        private System.Windows.Forms.ComboBox eventoComboBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
    }
}