using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Rotinas.Marketing.Telemarketing.Lembrete
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label idCupomLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label horaLabel;
            this.telemarketingAgendaBindingSource = new System.Windows.Forms.BindingSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.dataDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.idCupomComboBox = new System.Windows.Forms.ComboBox();
            this.cupomBindingSource = new System.Windows.Forms.BindingSource();
            this.idUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource();
            dataLabel = new System.Windows.Forms.Label();
            idCupomLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telemarketingAgendaBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabControl1);
            this.panelEdit.Size = new System.Drawing.Size(347, 294);
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(23, 92);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(95, 13);
            dataLabel.TabIndex = 8;
            dataLabel.Text = "Data para contato";
            // 
            // idCupomLabel
            // 
            idCupomLabel.AutoSize = true;
            idCupomLabel.Location = new System.Drawing.Point(23, 12);
            idCupomLabel.Name = "idCupomLabel";
            idCupomLabel.Size = new System.Drawing.Size(85, 13);
            idCupomLabel.TabIndex = 10;
            idCupomLabel.Text = "Nome do Cliente";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(23, 52);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(104, 13);
            idUsuarioLabel.TabIndex = 14;
            idUsuarioLabel.Text = "Usuário responsável";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(23, 140);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(69, 13);
            observacaoLabel.TabIndex = 15;
            observacaoLabel.Text = "Observacao:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(190, 94);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(95, 13);
            horaLabel.TabIndex = 16;
            horaLabel.Text = "Hora para contato";
            // 
            // telemarketingAgendaBindingSource
            // 
            this.telemarketingAgendaBindingSource.DataSource = typeof(Canaan.Dados.TelemarketingAgenda);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(horaLabel);
            this.tabPage1.Controls.Add(observacaoLabel);
            this.tabPage1.Controls.Add(this.observacaoTextBox);
            this.tabPage1.Controls.Add(dataLabel);
            this.tabPage1.Controls.Add(this.dataDateEdit);
            this.tabPage1.Controls.Add(idCupomLabel);
            this.tabPage1.Controls.Add(this.idCupomComboBox);
            this.tabPage1.Controls.Add(idUsuarioLabel);
            this.tabPage1.Controls.Add(this.idUsuarioComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(314, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações do Lembrete";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telemarketingAgendaBindingSource, "Hora", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(193, 111);
            this.maskedTextBox1.Mask = "90:99:99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(92, 21);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telemarketingAgendaBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(26, 156);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(259, 74);
            this.observacaoTextBox.TabIndex = 16;
            // 
            // dataDateEdit
            // 
            this.dataDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.telemarketingAgendaBindingSource, "Data", true));
            this.dataDateEdit.EditValue = null;
            this.dataDateEdit.Location = new System.Drawing.Point(26, 108);
            this.dataDateEdit.Name = "dataDateEdit";
            this.dataDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataDateEdit.Size = new System.Drawing.Size(121, 20);
            this.dataDateEdit.TabIndex = 9;
            // 
            // idCupomComboBox
            // 
            this.idCupomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telemarketingAgendaBindingSource, "IdCupom", true));
            this.idCupomComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.telemarketingAgendaBindingSource, "IdCupom", true));
            this.idCupomComboBox.DataSource = this.cupomBindingSource;
            this.idCupomComboBox.DisplayMember = "Nome";
            this.idCupomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCupomComboBox.Enabled = false;
            this.idCupomComboBox.FormattingEnabled = true;
            this.idCupomComboBox.Location = new System.Drawing.Point(26, 28);
            this.idCupomComboBox.Name = "idCupomComboBox";
            this.idCupomComboBox.Size = new System.Drawing.Size(259, 21);
            this.idCupomComboBox.TabIndex = 11;
            this.idCupomComboBox.ValueMember = "IdCupom";
            // 
            // cupomBindingSource
            // 
            this.cupomBindingSource.DataSource = typeof(Canaan.Dados.Cupom);
            // 
            // idUsuarioComboBox
            // 
            this.idUsuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telemarketingAgendaBindingSource, "IdUsuario", true));
            this.idUsuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.telemarketingAgendaBindingSource, "IdUsuario", true));
            this.idUsuarioComboBox.DataSource = this.usuarioBindingSource;
            this.idUsuarioComboBox.DisplayMember = "Nome";
            this.idUsuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idUsuarioComboBox.Enabled = false;
            this.idUsuarioComboBox.FormattingEnabled = true;
            this.idUsuarioComboBox.Location = new System.Drawing.Point(26, 68);
            this.idUsuarioComboBox.Name = "idUsuarioComboBox";
            this.idUsuarioComboBox.Size = new System.Drawing.Size(259, 21);
            this.idUsuarioComboBox.TabIndex = 15;
            this.idUsuarioComboBox.ValueMember = "IdUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Canaan.Dados.Usuario);
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 327);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.telemarketingAgendaBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private BindingSource telemarketingAgendaBindingSource;
        private DateEdit dataDateEdit;
        private ComboBox idCupomComboBox;
        private ComboBox idUsuarioComboBox;
        private TextBox observacaoTextBox;
        private BindingSource cupomBindingSource;
        private BindingSource usuarioBindingSource;
        private MaskedTextBox maskedTextBox1;

    }
}