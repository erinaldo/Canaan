using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Geral.GrupoEmpresa
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
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.ctrlAtivo = new System.Windows.Forms.CheckBox();
            this.ctrlFranquia = new System.Windows.Forms.CheckBox();
            this.ctrlDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.ctrlNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.groupInfo);
            this.panelEdit.Size = new System.Drawing.Size(383, 263);
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.ctrlAtivo);
            this.groupInfo.Controls.Add(this.ctrlFranquia);
            this.groupInfo.Controls.Add(this.ctrlDescricao);
            this.groupInfo.Controls.Add(this.lbDescricao);
            this.groupInfo.Controls.Add(this.ctrlNome);
            this.groupInfo.Controls.Add(this.lbNome);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupInfo.Location = new System.Drawing.Point(10, 10);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Padding = new System.Windows.Forms.Padding(5);
            this.groupInfo.Size = new System.Drawing.Size(363, 243);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Informações do Grupo de Empresa";
            // 
            // ctrlAtivo
            // 
            this.ctrlAtivo.AutoSize = true;
            this.ctrlAtivo.Location = new System.Drawing.Point(11, 208);
            this.ctrlAtivo.Name = "ctrlAtivo";
            this.ctrlAtivo.Size = new System.Drawing.Size(114, 17);
            this.ctrlAtivo.TabIndex = 5;
            this.ctrlAtivo.Text = "Registro está ativo";
            this.ctrlAtivo.UseVisualStyleBackColor = true;
            // 
            // ctrlFranquia
            // 
            this.ctrlFranquia.AutoSize = true;
            this.ctrlFranquia.Location = new System.Drawing.Point(11, 185);
            this.ctrlFranquia.Name = "ctrlFranquia";
            this.ctrlFranquia.Size = new System.Drawing.Size(138, 17);
            this.ctrlFranquia.TabIndex = 4;
            this.ctrlFranquia.Text = "Grupo é um franqueado";
            this.ctrlFranquia.UseVisualStyleBackColor = true;
            // 
            // ctrlDescricao
            // 
            this.ctrlDescricao.Location = new System.Drawing.Point(8, 73);
            this.ctrlDescricao.Multiline = true;
            this.ctrlDescricao.Name = "ctrlDescricao";
            this.ctrlDescricao.Size = new System.Drawing.Size(335, 106);
            this.ctrlDescricao.TabIndex = 3;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(8, 57);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(55, 13);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição";
            // 
            // ctrlNome
            // 
            this.ctrlNome.Location = new System.Drawing.Point(8, 34);
            this.ctrlNome.Name = "ctrlNome";
            this.ctrlNome.Size = new System.Drawing.Size(335, 20);
            this.ctrlNome.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(8, 18);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(141, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome do Grupo de Empresa";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 296);
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

        private GroupBox groupInfo;
        private CheckBox ctrlAtivo;
        private CheckBox ctrlFranquia;
        private TextBox ctrlDescricao;
        private Label lbDescricao;
        private TextBox ctrlNome;
        private Label lbNome;

    }
}