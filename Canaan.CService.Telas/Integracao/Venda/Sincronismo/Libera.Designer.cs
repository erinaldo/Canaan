namespace Canaan.CService.Telas.Integracao.Venda.Sincronismo
{
    partial class Libera
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
            this.autenticaGroupBox = new System.Windows.Forms.GroupBox();
            this.btnLibera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autenticaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // autenticaGroupBox
            // 
            this.autenticaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autenticaGroupBox.Controls.Add(this.senhaTextBox);
            this.autenticaGroupBox.Controls.Add(this.label2);
            this.autenticaGroupBox.Controls.Add(this.usuarioTextBox);
            this.autenticaGroupBox.Controls.Add(this.label1);
            this.autenticaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.autenticaGroupBox.Name = "autenticaGroupBox";
            this.autenticaGroupBox.Size = new System.Drawing.Size(209, 117);
            this.autenticaGroupBox.TabIndex = 0;
            this.autenticaGroupBox.TabStop = false;
            this.autenticaGroupBox.Text = "Autenticação";
            // 
            // btnLibera
            // 
            this.btnLibera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLibera.Location = new System.Drawing.Point(12, 135);
            this.btnLibera.Name = "btnLibera";
            this.btnLibera.Size = new System.Drawing.Size(209, 23);
            this.btnLibera.TabIndex = 1;
            this.btnLibera.Text = "Autoriza Pedido";
            this.btnLibera.UseVisualStyleBackColor = true;
            this.btnLibera.Click += new System.EventHandler(this.btnLibera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Usuário";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuarioTextBox.Location = new System.Drawing.Point(6, 38);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(197, 20);
            this.usuarioTextBox.TabIndex = 1;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.senhaTextBox.Location = new System.Drawing.Point(6, 81);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(197, 20);
            this.senhaTextBox.TabIndex = 3;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // Libera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(233, 170);
            this.Controls.Add(this.btnLibera);
            this.Controls.Add(this.autenticaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Libera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liberação Administrativa";
            this.Load += new System.EventHandler(this.Libera_Load);
            this.autenticaGroupBox.ResumeLayout(false);
            this.autenticaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox autenticaGroupBox;
        private System.Windows.Forms.Button btnLibera;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Label label1;
    }
}