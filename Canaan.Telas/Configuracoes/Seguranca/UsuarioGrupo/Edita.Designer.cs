using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Seguranca.UsuarioGrupo
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
            this.usuarioGrupoGroupBox = new System.Windows.Forms.GroupBox();
            this.isAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.usuarioGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isMarketingCheckBox = new System.Windows.Forms.CheckBox();
            this.isProducaoCheckBox = new System.Windows.Forms.CheckBox();
            this.isComercialCheckBox = new System.Windows.Forms.CheckBox();
            this.isFinanceiroCheckBox = new System.Windows.Forms.CheckBox();
            this.isSupervisorCheckBox = new System.Windows.Forms.CheckBox();
            this.isGerenteCheckBox = new System.Windows.Forms.CheckBox();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            nomeLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.usuarioGrupoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioGrupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.usuarioGrupoGroupBox);
            this.panelEdit.Size = new System.Drawing.Size(311, 270);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(5, 18);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(139, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome do Grupo de Usuário:";
            // 
            // usuarioGrupoGroupBox
            // 
            this.usuarioGrupoGroupBox.Controls.Add(this.isAtivoCheckBox);
            this.usuarioGrupoGroupBox.Controls.Add(this.isMarketingCheckBox);
            this.usuarioGrupoGroupBox.Controls.Add(this.isProducaoCheckBox);
            this.usuarioGrupoGroupBox.Controls.Add(this.isComercialCheckBox);
            this.usuarioGrupoGroupBox.Controls.Add(this.isFinanceiroCheckBox);
            this.usuarioGrupoGroupBox.Controls.Add(this.isSupervisorCheckBox);
            this.usuarioGrupoGroupBox.Controls.Add(this.isGerenteCheckBox);
            this.usuarioGrupoGroupBox.Controls.Add(this.isAdminCheckBox);
            this.usuarioGrupoGroupBox.Controls.Add(nomeLabel);
            this.usuarioGrupoGroupBox.Controls.Add(this.nomeTextBox);
            this.usuarioGrupoGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuarioGrupoGroupBox.Location = new System.Drawing.Point(10, 10);
            this.usuarioGrupoGroupBox.Name = "usuarioGrupoGroupBox";
            this.usuarioGrupoGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.usuarioGrupoGroupBox.Size = new System.Drawing.Size(291, 250);
            this.usuarioGrupoGroupBox.TabIndex = 0;
            this.usuarioGrupoGroupBox.TabStop = false;
            this.usuarioGrupoGroupBox.Text = "Informações do Grupo de Usuário";
            // 
            // isAtivoCheckBox
            // 
            this.isAtivoCheckBox.AutoSize = true;
            this.isAtivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioGrupoBindingSource, "IsAtivo", true));
            this.isAtivoCheckBox.Location = new System.Drawing.Point(8, 221);
            this.isAtivoCheckBox.Name = "isAtivoCheckBox";
            this.isAtivoCheckBox.Size = new System.Drawing.Size(159, 17);
            this.isAtivoCheckBox.TabIndex = 13;
            this.isAtivoCheckBox.Text = "Grupo de Usuário está Ativo";
            this.isAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // usuarioGrupoBindingSource
            // 
            this.usuarioGrupoBindingSource.DataSource = typeof(Canaan.Dados.UsuarioGrupo);
            // 
            // isMarketingCheckBox
            // 
            this.isMarketingCheckBox.AutoSize = true;
            this.isMarketingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioGrupoBindingSource, "IsMarketing", true));
            this.isMarketingCheckBox.Location = new System.Drawing.Point(8, 198);
            this.isMarketingCheckBox.Name = "isMarketingCheckBox";
            this.isMarketingCheckBox.Size = new System.Drawing.Size(73, 17);
            this.isMarketingCheckBox.TabIndex = 12;
            this.isMarketingCheckBox.Text = "Marketing";
            this.isMarketingCheckBox.UseVisualStyleBackColor = true;
            // 
            // isProducaoCheckBox
            // 
            this.isProducaoCheckBox.AutoSize = true;
            this.isProducaoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioGrupoBindingSource, "IsProducao", true));
            this.isProducaoCheckBox.Location = new System.Drawing.Point(8, 175);
            this.isProducaoCheckBox.Name = "isProducaoCheckBox";
            this.isProducaoCheckBox.Size = new System.Drawing.Size(72, 17);
            this.isProducaoCheckBox.TabIndex = 11;
            this.isProducaoCheckBox.Text = "Produção";
            this.isProducaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // isComercialCheckBox
            // 
            this.isComercialCheckBox.AutoSize = true;
            this.isComercialCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioGrupoBindingSource, "IsComercial", true));
            this.isComercialCheckBox.Location = new System.Drawing.Point(8, 152);
            this.isComercialCheckBox.Name = "isComercialCheckBox";
            this.isComercialCheckBox.Size = new System.Drawing.Size(72, 17);
            this.isComercialCheckBox.TabIndex = 10;
            this.isComercialCheckBox.Text = "Comercial";
            this.isComercialCheckBox.UseVisualStyleBackColor = true;
            // 
            // isFinanceiroCheckBox
            // 
            this.isFinanceiroCheckBox.AutoSize = true;
            this.isFinanceiroCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioGrupoBindingSource, "IsFinanceiro", true));
            this.isFinanceiroCheckBox.Location = new System.Drawing.Point(8, 129);
            this.isFinanceiroCheckBox.Name = "isFinanceiroCheckBox";
            this.isFinanceiroCheckBox.Size = new System.Drawing.Size(75, 17);
            this.isFinanceiroCheckBox.TabIndex = 9;
            this.isFinanceiroCheckBox.Text = "Financeiro";
            this.isFinanceiroCheckBox.UseVisualStyleBackColor = true;
            // 
            // isSupervisorCheckBox
            // 
            this.isSupervisorCheckBox.AutoSize = true;
            this.isSupervisorCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioGrupoBindingSource, "IsSupervisor", true));
            this.isSupervisorCheckBox.Location = new System.Drawing.Point(8, 106);
            this.isSupervisorCheckBox.Name = "isSupervisorCheckBox";
            this.isSupervisorCheckBox.Size = new System.Drawing.Size(76, 17);
            this.isSupervisorCheckBox.TabIndex = 7;
            this.isSupervisorCheckBox.Text = "Supervisor";
            this.isSupervisorCheckBox.UseVisualStyleBackColor = true;
            // 
            // isGerenteCheckBox
            // 
            this.isGerenteCheckBox.AutoSize = true;
            this.isGerenteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioGrupoBindingSource, "IsGerente", true));
            this.isGerenteCheckBox.Location = new System.Drawing.Point(8, 83);
            this.isGerenteCheckBox.Name = "isGerenteCheckBox";
            this.isGerenteCheckBox.Size = new System.Drawing.Size(64, 17);
            this.isGerenteCheckBox.TabIndex = 5;
            this.isGerenteCheckBox.Text = "Gerente";
            this.isGerenteCheckBox.UseVisualStyleBackColor = true;
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.AutoSize = true;
            this.isAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.usuarioGrupoBindingSource, "IsAdmin", true));
            this.isAdminCheckBox.Location = new System.Drawing.Point(8, 60);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(89, 17);
            this.isAdminCheckBox.TabIndex = 3;
            this.isAdminCheckBox.Text = "Administrador";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioGrupoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(8, 34);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(275, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 303);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            this.usuarioGrupoGroupBox.ResumeLayout(false);
            this.usuarioGrupoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioGrupoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox usuarioGrupoGroupBox;
        private TextBox nomeTextBox;
        private BindingSource usuarioGrupoBindingSource;
        private CheckBox isAtivoCheckBox;
        private CheckBox isMarketingCheckBox;
        private CheckBox isProducaoCheckBox;
        private CheckBox isComercialCheckBox;
        private CheckBox isFinanceiroCheckBox;
        private CheckBox isSupervisorCheckBox;
        private CheckBox isGerenteCheckBox;
        private CheckBox isAdminCheckBox;
    }
}