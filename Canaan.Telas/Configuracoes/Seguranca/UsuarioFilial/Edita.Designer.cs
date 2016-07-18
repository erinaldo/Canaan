using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Seguranca.UsuarioFilial
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
            System.Windows.Forms.Label idFilialLabel;
            System.Windows.Forms.Label idUsuarioGrupoLabel;
            this.UsuarioFilialGroupBox = new System.Windows.Forms.GroupBox();
            this.usuarioFilialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idFilialComboBox = new System.Windows.Forms.ComboBox();
            this.idUsuarioGrupoComboBox = new System.Windows.Forms.ComboBox();
            this.usuarioNomeLabel = new System.Windows.Forms.Label();
            this.filialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idFilialLabel = new System.Windows.Forms.Label();
            idUsuarioGrupoLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.UsuarioFilialGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioFilialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioGrupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.UsuarioFilialGroupBox);
            this.panelEdit.Size = new System.Drawing.Size(360, 164);
            // 
            // UsuarioFilialGroupBox
            // 
            this.UsuarioFilialGroupBox.Controls.Add(this.usuarioNomeLabel);
            this.UsuarioFilialGroupBox.Controls.Add(idUsuarioGrupoLabel);
            this.UsuarioFilialGroupBox.Controls.Add(this.idUsuarioGrupoComboBox);
            this.UsuarioFilialGroupBox.Controls.Add(idFilialLabel);
            this.UsuarioFilialGroupBox.Controls.Add(this.idFilialComboBox);
            this.UsuarioFilialGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuarioFilialGroupBox.Location = new System.Drawing.Point(10, 10);
            this.UsuarioFilialGroupBox.Name = "UsuarioFilialGroupBox";
            this.UsuarioFilialGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.UsuarioFilialGroupBox.Size = new System.Drawing.Size(340, 144);
            this.UsuarioFilialGroupBox.TabIndex = 0;
            this.UsuarioFilialGroupBox.TabStop = false;
            this.UsuarioFilialGroupBox.Text = "Informações das Permissões";
            // 
            // usuarioFilialBindingSource
            // 
            this.usuarioFilialBindingSource.DataSource = typeof(Canaan.Dados.UsuarioFilial);
            // 
            // idFilialLabel
            // 
            idFilialLabel.AutoSize = true;
            idFilialLabel.Location = new System.Drawing.Point(8, 42);
            idFilialLabel.Name = "idFilialLabel";
            idFilialLabel.Size = new System.Drawing.Size(86, 13);
            idFilialLabel.TabIndex = 0;
            idFilialLabel.Text = "Selecione a Filial";
            // 
            // idFilialComboBox
            // 
            this.idFilialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioFilialBindingSource, "IdFilial", true));
            this.idFilialComboBox.DataSource = this.filialBindingSource;
            this.idFilialComboBox.DisplayMember = "NomeFantasia";
            this.idFilialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idFilialComboBox.FormattingEnabled = true;
            this.idFilialComboBox.Location = new System.Drawing.Point(8, 58);
            this.idFilialComboBox.Name = "idFilialComboBox";
            this.idFilialComboBox.Size = new System.Drawing.Size(324, 21);
            this.idFilialComboBox.TabIndex = 1;
            this.idFilialComboBox.ValueMember = "IdFilial";
            // 
            // idUsuarioGrupoLabel
            // 
            idUsuarioGrupoLabel.AutoSize = true;
            idUsuarioGrupoLabel.Location = new System.Drawing.Point(8, 82);
            idUsuarioGrupoLabel.Name = "idUsuarioGrupoLabel";
            idUsuarioGrupoLabel.Size = new System.Drawing.Size(149, 13);
            idUsuarioGrupoLabel.TabIndex = 2;
            idUsuarioGrupoLabel.Text = "Selecione o Grupo de Usuário";
            // 
            // idUsuarioGrupoComboBox
            // 
            this.idUsuarioGrupoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioFilialBindingSource, "IdUsuarioGrupo", true));
            this.idUsuarioGrupoComboBox.DataSource = this.usuarioGrupoBindingSource;
            this.idUsuarioGrupoComboBox.DisplayMember = "Nome";
            this.idUsuarioGrupoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idUsuarioGrupoComboBox.FormattingEnabled = true;
            this.idUsuarioGrupoComboBox.Location = new System.Drawing.Point(8, 98);
            this.idUsuarioGrupoComboBox.Name = "idUsuarioGrupoComboBox";
            this.idUsuarioGrupoComboBox.Size = new System.Drawing.Size(324, 21);
            this.idUsuarioGrupoComboBox.TabIndex = 3;
            this.idUsuarioGrupoComboBox.ValueMember = "IdUsuarioGrupo";
            // 
            // usuarioNomeLabel
            // 
            this.usuarioNomeLabel.AutoSize = true;
            this.usuarioNomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioNomeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usuarioNomeLabel.Location = new System.Drawing.Point(8, 18);
            this.usuarioNomeLabel.Name = "usuarioNomeLabel";
            this.usuarioNomeLabel.Size = new System.Drawing.Size(51, 20);
            this.usuarioNomeLabel.TabIndex = 5;
            this.usuarioNomeLabel.Text = "label2";
            // 
            // filialBindingSource
            // 
            this.filialBindingSource.DataSource = typeof(Canaan.Dados.Filial);
            // 
            // usuarioGrupoBindingSource
            // 
            this.usuarioGrupoBindingSource.DataSource = typeof(Canaan.Dados.UsuarioGrupo);
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 197);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            this.UsuarioFilialGroupBox.ResumeLayout(false);
            this.UsuarioFilialGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioFilialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioGrupoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox UsuarioFilialGroupBox;
        private Label usuarioNomeLabel;
        private ComboBox idUsuarioGrupoComboBox;
        private BindingSource usuarioFilialBindingSource;
        private BindingSource usuarioGrupoBindingSource;
        private ComboBox idFilialComboBox;
        private BindingSource filialBindingSource;
    }
}