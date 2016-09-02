namespace RM.Telas.Ferramentas.Spc
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.groupBoxContexto = new System.Windows.Forms.GroupBox();
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.cbFilial = new System.Windows.Forms.ComboBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.rbRegistrar = new System.Windows.Forms.RadioButton();
            this.rbReabilitar = new System.Windows.Forms.RadioButton();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.groupBoxContexto.SuspendLayout();
            this.groupBoxPeriodo.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.btnExecutar);
            this.panelContainer.Controls.Add(this.groupBoxAction);
            this.panelContainer.Controls.Add(this.groupBoxPeriodo);
            this.panelContainer.Controls.Add(this.groupBoxContexto);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(10);
            this.panelContainer.Size = new System.Drawing.Size(369, 256);
            this.panelContainer.TabIndex = 0;
            // 
            // groupBoxContexto
            // 
            this.groupBoxContexto.Controls.Add(this.cbFilial);
            this.groupBoxContexto.Location = new System.Drawing.Point(13, 13);
            this.groupBoxContexto.Name = "groupBoxContexto";
            this.groupBoxContexto.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxContexto.Size = new System.Drawing.Size(344, 58);
            this.groupBoxContexto.TabIndex = 0;
            this.groupBoxContexto.TabStop = false;
            this.groupBoxContexto.Text = "Selecione a Filial";
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.Controls.Add(this.dtFim);
            this.groupBoxPeriodo.Controls.Add(this.dtInicio);
            this.groupBoxPeriodo.Location = new System.Drawing.Point(13, 77);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxPeriodo.Size = new System.Drawing.Size(343, 58);
            this.groupBoxPeriodo.TabIndex = 1;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "Informe o Periodo";
            // 
            // cbFilial
            // 
            this.cbFilial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilial.FormattingEnabled = true;
            this.cbFilial.Location = new System.Drawing.Point(8, 21);
            this.cbFilial.Name = "cbFilial";
            this.cbFilial.Size = new System.Drawing.Size(328, 21);
            this.cbFilial.TabIndex = 0;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(8, 21);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(114, 20);
            this.dtInicio.TabIndex = 2;
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(128, 21);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(114, 20);
            this.dtFim.TabIndex = 3;
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.rbReabilitar);
            this.groupBoxAction.Controls.Add(this.rbRegistrar);
            this.groupBoxAction.Location = new System.Drawing.Point(13, 141);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxAction.Size = new System.Drawing.Size(343, 72);
            this.groupBoxAction.TabIndex = 4;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Tipo de Ação";
            // 
            // rbRegistrar
            // 
            this.rbRegistrar.AutoSize = true;
            this.rbRegistrar.Checked = true;
            this.rbRegistrar.Location = new System.Drawing.Point(8, 21);
            this.rbRegistrar.Name = "rbRegistrar";
            this.rbRegistrar.Size = new System.Drawing.Size(67, 17);
            this.rbRegistrar.TabIndex = 0;
            this.rbRegistrar.TabStop = true;
            this.rbRegistrar.Text = "Registrar";
            this.rbRegistrar.UseVisualStyleBackColor = true;
            // 
            // rbReabilitar
            // 
            this.rbReabilitar.AutoSize = true;
            this.rbReabilitar.Location = new System.Drawing.Point(8, 44);
            this.rbReabilitar.Name = "rbReabilitar";
            this.rbReabilitar.Size = new System.Drawing.Size(69, 17);
            this.rbReabilitar.TabIndex = 1;
            this.rbReabilitar.TabStop = true;
            this.rbReabilitar.Text = "Reabilitar";
            this.rbReabilitar.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Image = global::RM.Telas.Properties.Resources.filter_16xLG;
            this.btnExecutar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecutar.Location = new System.Drawing.Point(245, 219);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(111, 23);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "Executar Filtro";
            this.btnExecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 256);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.panelContainer.ResumeLayout(false);
            this.groupBoxContexto.ResumeLayout(false);
            this.groupBoxPeriodo.ResumeLayout(false);
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.RadioButton rbReabilitar;
        private System.Windows.Forms.RadioButton rbRegistrar;
        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.GroupBox groupBoxContexto;
        private System.Windows.Forms.ComboBox cbFilial;
    }
}