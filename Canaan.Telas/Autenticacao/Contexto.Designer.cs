using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Autenticacao
{
    partial class Contexto
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
            this.filialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelecionar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.idFilialComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filialBindingSource
            // 
            this.filialBindingSource.DataSource = typeof(Canaan.Dados.Filial);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(158, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Informe a filial que deseja utilizar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(11, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(172, 70);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(104, 23);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "Selecionar Filial";
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.idFilialComboBox);
            this.groupControl1.Controls.Add(this.btnSelecionar);
            this.groupControl1.Controls.Add(this.btnCancelar);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(281, 109);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Informação do Contexto";
            // 
            // idFilialComboBox
            // 
            this.idFilialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.filialBindingSource, "IdFilial", true));
            this.idFilialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "NomeFantasia", true));
            this.idFilialComboBox.DataSource = this.filialBindingSource;
            this.idFilialComboBox.DisplayMember = "NomeFantasia";
            this.idFilialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idFilialComboBox.FormattingEnabled = true;
            this.idFilialComboBox.Location = new System.Drawing.Point(11, 43);
            this.idFilialComboBox.Name = "idFilialComboBox";
            this.idFilialComboBox.Size = new System.Drawing.Size(265, 21);
            this.idFilialComboBox.TabIndex = 5;
            this.idFilialComboBox.ValueMember = "IdFilial";
            // 
            // Contexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 119);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Contexto";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione o Contexto";
            this.Load += new System.EventHandler(this.Contexto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource filialBindingSource;
        private LabelControl labelControl1;
        private SimpleButton btnCancelar;
        private SimpleButton btnSelecionar;
        private GroupControl groupControl1;
        private ComboBox idFilialComboBox;
    }
}