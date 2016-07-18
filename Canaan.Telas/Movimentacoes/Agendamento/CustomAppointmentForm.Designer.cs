using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Movimentacoes.Agendamento
{
    partial class CustomAppointmentForm
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
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numConfirmacaoLabel;
            this.horaTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.tbCupom = new System.Windows.Forms.TabPage();
            this.gpCupom = new System.Windows.Forms.GroupBox();
            this.obsLabel = new System.Windows.Forms.Label();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularLabel = new System.Windows.Forms.Label();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lkParceria = new System.Windows.Forms.LinkLabel();
            this.idParceriaLabel = new System.Windows.Forms.Label();
            this.idParceriaTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.isAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.enderecoLabel = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numConfirmacaoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lkLabelAgenda = new System.Windows.Forms.LinkLabel();
            this.dataDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtEnd = new DevExpress.XtraEditors.DateEdit();
            this.timeEnd = new DevExpress.XtraEditors.TimeEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btFilterTel = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            observacaoLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numConfirmacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.horaTimeEdit.Properties)).BeginInit();
            this.tbCupom.SuspendLayout();
            this.gpCupom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConfirmacaoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(11, 62);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(135, 13);
            observacaoLabel.TabIndex = 0;
            observacaoLabel.Text = "Observação Agendamento";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(11, 11);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(41, 13);
            modeloLabel.TabIndex = 2;
            modeloLabel.Text = "Modelo";
            // 
            // numConfirmacaoLabel
            // 
            numConfirmacaoLabel.AutoSize = true;
            numConfirmacaoLabel.Location = new System.Drawing.Point(11, 239);
            numConfirmacaoLabel.Name = "numConfirmacaoLabel";
            numConfirmacaoLabel.Size = new System.Drawing.Size(72, 13);
            numConfirmacaoLabel.TabIndex = 4;
            numConfirmacaoLabel.Text = "Confirmações";
            // 
            // horaTimeEdit
            // 
            this.horaTimeEdit.EditValue = new System.DateTime(2013, 10, 8, 0, 0, 0, 0);
            this.horaTimeEdit.Location = new System.Drawing.Point(312, 49);
            this.horaTimeEdit.Name = "horaTimeEdit";
            this.horaTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.horaTimeEdit.Size = new System.Drawing.Size(151, 20);
            this.horaTimeEdit.TabIndex = 2;
            this.horaTimeEdit.EditValueChanged += new System.EventHandler(this.timeStart_EditValueChanged);
            // 
            // tbCupom
            // 
            this.tbCupom.AutoScroll = true;
            this.tbCupom.Controls.Add(this.gpCupom);
            this.tbCupom.Location = new System.Drawing.Point(4, 22);
            this.tbCupom.Name = "tbCupom";
            this.tbCupom.Padding = new System.Windows.Forms.Padding(3);
            this.tbCupom.Size = new System.Drawing.Size(446, 362);
            this.tbCupom.TabIndex = 0;
            this.tbCupom.Text = "Dados do Agendamento";
            this.tbCupom.UseVisualStyleBackColor = true;
            // 
            // gpCupom
            // 
            this.gpCupom.Controls.Add(this.obsLabel);
            this.gpCupom.Controls.Add(this.obsTextBox);
            this.gpCupom.Controls.Add(this.telefoneLabel);
            this.gpCupom.Controls.Add(this.telefoneMaskedTextBox);
            this.gpCupom.Controls.Add(this.celularLabel);
            this.gpCupom.Controls.Add(this.celularMaskedTextBox);
            this.gpCupom.Controls.Add(this.lkParceria);
            this.gpCupom.Controls.Add(this.idParceriaLabel);
            this.gpCupom.Controls.Add(this.idParceriaTextBox);
            this.gpCupom.Controls.Add(this.statusLabel);
            this.gpCupom.Controls.Add(this.statusTextBox);
            this.gpCupom.Controls.Add(this.isAtivoCheckBox);
            this.gpCupom.Controls.Add(this.enderecoLabel);
            this.gpCupom.Controls.Add(this.enderecoTextBox);
            this.gpCupom.Controls.Add(this.emailLabel);
            this.gpCupom.Controls.Add(this.emailTextBox);
            this.gpCupom.Controls.Add(this.nomeLabel);
            this.gpCupom.Controls.Add(this.nomeTextBox);
            this.gpCupom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCupom.Enabled = false;
            this.gpCupom.Location = new System.Drawing.Point(3, 3);
            this.gpCupom.Name = "gpCupom";
            this.gpCupom.Size = new System.Drawing.Size(440, 356);
            this.gpCupom.TabIndex = 0;
            this.gpCupom.TabStop = false;
            // 
            // obsLabel
            // 
            this.obsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obsLabel.AutoSize = true;
            this.obsLabel.Location = new System.Drawing.Point(11, 219);
            this.obsLabel.Name = "obsLabel";
            this.obsLabel.Size = new System.Drawing.Size(70, 13);
            this.obsLabel.TabIndex = 34;
            this.obsLabel.Text = "Observações";
            // 
            // obsTextBox
            // 
            this.obsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Cupom.Obs", true));
            this.obsTextBox.Location = new System.Drawing.Point(14, 235);
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(415, 90);
            this.obsTextBox.TabIndex = 31;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataSource = typeof(Canaan.Dados.Agendamento);
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(182, 132);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(49, 13);
            this.telefoneLabel.TabIndex = 33;
            this.telefoneLabel.Text = "Telefone";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Cupom.Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(178, 149);
            this.telefoneMaskedTextBox.Mask = "[99]99999-9999";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(110, 21);
            this.telefoneMaskedTextBox.TabIndex = 25;
            this.telefoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // celularLabel
            // 
            this.celularLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.celularLabel.AutoSize = true;
            this.celularLabel.Location = new System.Drawing.Point(11, 133);
            this.celularLabel.Name = "celularLabel";
            this.celularLabel.Size = new System.Drawing.Size(40, 13);
            this.celularLabel.TabIndex = 30;
            this.celularLabel.Text = "Celular";
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Cupom.Celular", true));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(10, 149);
            this.celularMaskedTextBox.Mask = "[99]99999-9999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(119, 21);
            this.celularMaskedTextBox.TabIndex = 24;
            this.celularMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lkParceria
            // 
            this.lkParceria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lkParceria.AutoSize = true;
            this.lkParceria.Location = new System.Drawing.Point(295, 197);
            this.lkParceria.Name = "lkParceria";
            this.lkParceria.Size = new System.Drawing.Size(53, 13);
            this.lkParceria.TabIndex = 29;
            this.lkParceria.TabStop = true;
            this.lkParceria.Text = "linkLabel1";
            this.lkParceria.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkParceria_LinkClicked);
            // 
            // idParceriaLabel
            // 
            this.idParceriaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idParceriaLabel.AutoSize = true;
            this.idParceriaLabel.Location = new System.Drawing.Point(179, 178);
            this.idParceriaLabel.Name = "idParceriaLabel";
            this.idParceriaLabel.Size = new System.Drawing.Size(46, 13);
            this.idParceriaLabel.TabIndex = 26;
            this.idParceriaLabel.Text = "Parceria";
            // 
            // idParceriaTextBox
            // 
            this.idParceriaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idParceriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Cupom.IdParceria", true));
            this.idParceriaTextBox.Enabled = false;
            this.idParceriaTextBox.Location = new System.Drawing.Point(178, 194);
            this.idParceriaTextBox.Name = "idParceriaTextBox";
            this.idParceriaTextBox.Size = new System.Drawing.Size(111, 21);
            this.idParceriaTextBox.TabIndex = 28;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(11, 178);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 13);
            this.statusLabel.TabIndex = 23;
            this.statusLabel.Text = "Status";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Cupom.Status", true));
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(10, 194);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(120, 21);
            this.statusTextBox.TabIndex = 27;
            // 
            // isAtivoCheckBox
            // 
            this.isAtivoCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.isAtivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.agendamentoBindingSource, "Cupom.IsAtivo", true));
            this.isAtivoCheckBox.Location = new System.Drawing.Point(14, 323);
            this.isAtivoCheckBox.Name = "isAtivoCheckBox";
            this.isAtivoCheckBox.Size = new System.Drawing.Size(86, 30);
            this.isAtivoCheckBox.TabIndex = 32;
            this.isAtivoCheckBox.Text = "Status";
            this.isAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // enderecoLabel
            // 
            this.enderecoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enderecoLabel.AutoSize = true;
            this.enderecoLabel.Location = new System.Drawing.Point(9, 52);
            this.enderecoLabel.Name = "enderecoLabel";
            this.enderecoLabel.Size = new System.Drawing.Size(52, 13);
            this.enderecoLabel.TabIndex = 19;
            this.enderecoLabel.Text = "Endereco";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Cupom.Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(12, 68);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(420, 21);
            this.enderecoTextBox.TabIndex = 21;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(9, 95);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(31, 13);
            this.emailLabel.TabIndex = 18;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Cupom.Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(12, 111);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(420, 21);
            this.emailTextBox.TabIndex = 22;
            // 
            // nomeLabel
            // 
            this.nomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(9, 11);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(34, 13);
            this.nomeLabel.TabIndex = 17;
            this.nomeLabel.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Cupom.Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(12, 27);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(216, 21);
            this.nomeTextBox.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCupom);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(454, 388);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.numConfirmacaoNumericUpDown);
            this.tabPage2.Controls.Add(numConfirmacaoLabel);
            this.tabPage2.Controls.Add(modeloLabel);
            this.tabPage2.Controls.Add(this.modeloTextBox);
            this.tabPage2.Controls.Add(observacaoLabel);
            this.tabPage2.Controls.Add(this.observacaoTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(446, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Observações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numConfirmacaoNumericUpDown
            // 
            this.numConfirmacaoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendamentoBindingSource, "NumConfirmacao", true));
            this.numConfirmacaoNumericUpDown.Location = new System.Drawing.Point(14, 255);
            this.numConfirmacaoNumericUpDown.Name = "numConfirmacaoNumericUpDown";
            this.numConfirmacaoNumericUpDown.Size = new System.Drawing.Size(120, 21);
            this.numConfirmacaoNumericUpDown.TabIndex = 6;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(14, 27);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(419, 21);
            this.modeloTextBox.TabIndex = 3;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(11, 78);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(422, 149);
            this.observacaoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Horário do Agendamento";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(158, 33);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(115, 13);
            this.lbData.TabIndex = 10;
            this.lbData.Text = "Data do Agendamento";
            // 
            // lkLabelAgenda
            // 
            this.lkLabelAgenda.AutoSize = true;
            this.lkLabelAgenda.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lkLabelAgenda.Location = new System.Drawing.Point(12, 9);
            this.lkLabelAgenda.Name = "lkLabelAgenda";
            this.lkLabelAgenda.Size = new System.Drawing.Size(66, 17);
            this.lkLabelAgenda.TabIndex = 9;
            this.lkLabelAgenda.TabStop = true;
            this.lkLabelAgenda.Text = "linkLabel1";
            // 
            // dataDateEdit
            // 
            this.dataDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendamentoBindingSource, "Inicio", true));
            this.dataDateEdit.EditValue = new System.DateTime(2013, 10, 9, 10, 34, 51, 766);
            this.dataDateEdit.Location = new System.Drawing.Point(158, 49);
            this.dataDateEdit.Name = "dataDateEdit";
            this.dataDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Size = new System.Drawing.Size(148, 20);
            this.dataDateEdit.TabIndex = 1;
            this.dataDateEdit.EditValueChanged += new System.EventHandler(this.dtStart_EditValueChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(16, 52);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 21);
            this.txtCodigo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Código";
            // 
            // dtEnd
            // 
            this.dtEnd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendamentoBindingSource, "Termino", true));
            this.dtEnd.EditValue = new System.DateTime(2013, 10, 9, 10, 34, 1, 404);
            this.dtEnd.Enabled = false;
            this.dtEnd.Location = new System.Drawing.Point(158, 92);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEnd.Size = new System.Drawing.Size(148, 20);
            this.dtEnd.TabIndex = 3;
            // 
            // timeEnd
            // 
            this.timeEnd.EditValue = new System.DateTime(2013, 10, 8, 0, 0, 0, 0);
            this.timeEnd.Location = new System.Drawing.Point(312, 92);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEnd.Size = new System.Drawing.Size(151, 20);
            this.timeEnd.TabIndex = 4;
            this.timeEnd.EditValueChanged += new System.EventHandler(this.timeEnd_EditValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Horário Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Consulta Telefone";
            // 
            // btFilterTel
            // 
            this.btFilterTel.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.btFilterTel.Location = new System.Drawing.Point(117, 90);
            this.btFilterTel.Name = "btFilterTel";
            this.btFilterTel.Size = new System.Drawing.Size(25, 23);
            this.btFilterTel.TabIndex = 28;
            this.btFilterTel.UseVisualStyleBackColor = true;
            this.btFilterTel.Click += new System.EventHandler(this.btFilterTel_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(15, 91);
            this.txtTel.Mask = "[99]99999-9999";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 21);
            this.txtTel.TabIndex = 0;
            this.txtTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(391, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btFilterTel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.horaTimeEdit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lkLabelAgenda);
            this.Controls.Add(this.dataDateEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomAppointmentForm";
            this.Load += new System.EventHandler(this.CustomAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horaTimeEdit.Properties)).EndInit();
            this.tbCupom.ResumeLayout(false);
            this.gpCupom.ResumeLayout(false);
            this.gpCupom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConfirmacaoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEnd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TimeEdit horaTimeEdit;
        private BindingSource agendamentoBindingSource;
        private TabPage tbCupom;
        private TabControl tabControl1;
        private Label label1;
        private Label lbData;
        private LinkLabel lkLabelAgenda;
        private DateEdit dataDateEdit;
        private TextBox txtCodigo;
        private Label label2;
        private DateEdit dtEnd;
        private TimeEdit timeEnd;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btFilterTel;
        private MaskedTextBox txtTel;
        private TabPage tabPage2;
        private TextBox observacaoTextBox;
        private TextBox modeloTextBox;
        private GroupBox gpCupom;
        private Label obsLabel;
        private TextBox obsTextBox;
        private Label telefoneLabel;
        private MaskedTextBox telefoneMaskedTextBox;
        private Label celularLabel;
        private MaskedTextBox celularMaskedTextBox;
        private LinkLabel lkParceria;
        private Label idParceriaLabel;
        private TextBox idParceriaTextBox;
        private Label statusLabel;
        private TextBox statusTextBox;
        private CheckBox isAtivoCheckBox;
        private Label enderecoLabel;
        private TextBox enderecoTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label nomeLabel;
        private TextBox nomeTextBox;
        private Button button1;
        private NumericUpDown numConfirmacaoNumericUpDown;

    }
}