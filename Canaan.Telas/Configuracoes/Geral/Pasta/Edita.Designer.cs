namespace Canaan.Telas.Configuracoes.Geral.Pasta
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
            this.ctrlDefault = new System.Windows.Forms.CheckBox();
            this.ctrlNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.groupInfo);
            this.panelEdit.Size = new System.Drawing.Size(285, 121);
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.ctrlDefault);
            this.groupInfo.Controls.Add(this.ctrlNome);
            this.groupInfo.Controls.Add(this.lbNome);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfo.Location = new System.Drawing.Point(10, 10);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Padding = new System.Windows.Forms.Padding(5);
            this.groupInfo.Size = new System.Drawing.Size(265, 101);
            this.groupInfo.TabIndex = 1;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Informações da Pasta";
            // 
            // ctrlDefault
            // 
            this.ctrlDefault.AutoSize = true;
            this.ctrlDefault.Location = new System.Drawing.Point(8, 61);
            this.ctrlDefault.Name = "ctrlDefault";
            this.ctrlDefault.Size = new System.Drawing.Size(90, 17);
            this.ctrlDefault.TabIndex = 4;
            this.ctrlDefault.Text = "Pasta Padrão";
            this.ctrlDefault.UseVisualStyleBackColor = true;
            // 
            // ctrlNome
            // 
            this.ctrlNome.Location = new System.Drawing.Point(8, 34);
            this.ctrlNome.Name = "ctrlNome";
            this.ctrlNome.Size = new System.Drawing.Size(249, 21);
            this.ctrlNome.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(8, 18);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(34, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 154);
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
        private System.Windows.Forms.CheckBox ctrlDefault;
        private System.Windows.Forms.TextBox ctrlNome;
        private System.Windows.Forms.Label lbNome;
    }
}