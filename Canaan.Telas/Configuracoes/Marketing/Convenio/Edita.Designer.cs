using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Marketing.Convenio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label tipoLabel1;
            this.convenioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.tipoConvenioLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            nomeLabel = new System.Windows.Forms.Label();
            tipoLabel1 = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convenioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tipoConvenioLabel);
            this.panelEdit.Controls.Add(this.tipoTextBox);
            this.panelEdit.Controls.Add(tipoLabel1);
            this.panelEdit.Controls.Add(this.isAtivoCheckBox);
            this.panelEdit.Controls.Add(nomeLabel);
            this.panelEdit.Controls.Add(this.nomeTextBox);
            this.panelEdit.Controls.Add(this.groupBox1);
            this.panelEdit.Size = new System.Drawing.Size(382, 169);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(27, 35);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(34, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome";
            // 
            // tipoLabel1
            // 
            tipoLabel1.AutoSize = true;
            tipoLabel1.Location = new System.Drawing.Point(27, 75);
            tipoLabel1.Name = "tipoLabel1";
            tipoLabel1.Size = new System.Drawing.Size(27, 13);
            tipoLabel1.TabIndex = 8;
            tipoLabel1.Text = "Tipo";
            // 
            // convenioBindingSource
            // 
            this.convenioBindingSource.DataSource = typeof(Canaan.Dados.Convenio);
            // 
            // isAtivoCheckBox
            // 
            this.isAtivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.convenioBindingSource, "IsAtivo", true));
            this.isAtivoCheckBox.Location = new System.Drawing.Point(30, 118);
            this.isAtivoCheckBox.Name = "isAtivoCheckBox";
            this.isAtivoCheckBox.Size = new System.Drawing.Size(210, 24);
            this.isAtivoCheckBox.TabIndex = 2;
            this.isAtivoCheckBox.Text = "Status do Convênio";
            this.isAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.convenioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(30, 51);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(332, 21);
            this.nomeTextBox.TabIndex = 0;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.convenioBindingSource, "Tipo", true));
            this.tipoTextBox.Enabled = false;
            this.tipoTextBox.Location = new System.Drawing.Point(30, 92);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(210, 21);
            this.tipoTextBox.TabIndex = 1;
            // 
            // tipoConvenioLabel
            // 
            this.tipoConvenioLabel.AutoSize = true;
            this.tipoConvenioLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.convenioBindingSource, "Tipo", true));
            this.tipoConvenioLabel.Location = new System.Drawing.Point(247, 95);
            this.tipoConvenioLabel.Name = "tipoConvenioLabel";
            this.tipoConvenioLabel.Size = new System.Drawing.Size(53, 13);
            this.tipoConvenioLabel.TabIndex = 10;
            this.tipoConvenioLabel.TabStop = true;
            this.tipoConvenioLabel.Text = "linkLabel1";
            this.tipoConvenioLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tipoConvenioLabel_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Convênio";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 202);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.convenioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource convenioBindingSource;
        private CheckBox isAtivoCheckBox;
        private TextBox nomeTextBox;
        private TextBox tipoTextBox;
        private LinkLabel tipoConvenioLabel;
        private GroupBox groupBox1;

    }
}