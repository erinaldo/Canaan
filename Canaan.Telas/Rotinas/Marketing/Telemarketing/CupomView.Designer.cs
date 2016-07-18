using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Rotinas.Marketing.Telemarketing
{
    partial class CupomView
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label dataPreenchimentoLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label idParceriaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idStatusTeleLabel;
            System.Windows.Forms.Label idUsuarioTeleLabel;
            System.Windows.Forms.Label dataTeleLabel;
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.nãoAtendeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desligadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.celularPictureBox = new System.Windows.Forms.PictureBox();
            this.telefonePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clIndicacao = new Canaan.Lib.Componentes.CLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cLembreteReponsavel = new Canaan.Lib.Componentes.CLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataTeleDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cupomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idUsuarioTeleComboBox = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idStatusTeleComboBox = new System.Windows.Forms.ComboBox();
            this.telemarketingStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.dataPreenchimentoDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.isAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.parceriaLabel = new System.Windows.Forms.LinkLabel();
            this.idParceriaTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.tbLembrete = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            dataLabel = new System.Windows.Forms.Label();
            dataPreenchimentoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            idParceriaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idStatusTeleLabel = new System.Windows.Forms.Label();
            idUsuarioTeleLabel = new System.Windows.Forms.Label();
            dataTeleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celularPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonePictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeleDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeleDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telemarketingStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreenchimentoDateEdit.Properties)).BeginInit();
            this.tbLembrete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(9, 187);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(30, 13);
            dataLabel.TabIndex = 20;
            dataLabel.Text = "Data";
            // 
            // dataPreenchimentoLabel
            // 
            dataPreenchimentoLabel.AutoSize = true;
            dataPreenchimentoLabel.Location = new System.Drawing.Point(182, 187);
            dataPreenchimentoLabel.Name = "dataPreenchimentoLabel";
            dataPreenchimentoLabel.Size = new System.Drawing.Size(108, 13);
            dataPreenchimentoLabel.TabIndex = 18;
            dataPreenchimentoLabel.Text = "Data Preenchimento:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(9, 235);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(38, 13);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "Status";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(9, 275);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(26, 13);
            obsLabel.TabIndex = 13;
            obsLabel.Text = "Obs";
            // 
            // idParceriaLabel
            // 
            idParceriaLabel.AutoSize = true;
            idParceriaLabel.Enabled = false;
            idParceriaLabel.Location = new System.Drawing.Point(179, 235);
            idParceriaLabel.Name = "idParceriaLabel";
            idParceriaLabel.Size = new System.Drawing.Size(46, 13);
            idParceriaLabel.TabIndex = 10;
            idParceriaLabel.Text = "Parceria";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(9, 147);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(31, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(182, 95);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(49, 13);
            telefoneLabel.TabIndex = 6;
            telefoneLabel.Text = "Telefone";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(4, 95);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(40, 13);
            celularLabel.TabIndex = 4;
            celularLabel.Text = "Celular";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(4, 50);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(52, 13);
            enderecoLabel.TabIndex = 2;
            enderecoLabel.Text = "Endereco";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(4, 7);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(34, 13);
            nomeLabel.TabIndex = 0;
            nomeLabel.Text = "Nome";
            // 
            // idStatusTeleLabel
            // 
            idStatusTeleLabel.AutoSize = true;
            idStatusTeleLabel.Location = new System.Drawing.Point(15, 27);
            idStatusTeleLabel.Name = "idStatusTeleLabel";
            idStatusTeleLabel.Size = new System.Drawing.Size(108, 13);
            idStatusTeleLabel.TabIndex = 0;
            idStatusTeleLabel.Text = "Status Telemarketing";
            // 
            // idUsuarioTeleLabel
            // 
            idUsuarioTeleLabel.AutoSize = true;
            idUsuarioTeleLabel.Location = new System.Drawing.Point(15, 72);
            idUsuarioTeleLabel.Name = "idUsuarioTeleLabel";
            idUsuarioTeleLabel.Size = new System.Drawing.Size(107, 13);
            idUsuarioTeleLabel.TabIndex = 2;
            idUsuarioTeleLabel.Text = "Usuário Responsável";
            // 
            // dataTeleLabel
            // 
            dataTeleLabel.AutoSize = true;
            dataTeleLabel.Location = new System.Drawing.Point(16, 120);
            dataTeleLabel.Name = "dataTeleLabel";
            dataTeleLabel.Size = new System.Drawing.Size(54, 13);
            dataTeleLabel.TabIndex = 4;
            dataTeleLabel.Text = "Expira Em";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator5,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSeparator4,
            this.toolStripSplitButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(675, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton4.Text = "Descartar";
            this.toolStripButton4.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.tear_off_calendar;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton1.Text = "Agendar";
            this.toolStripButton1.Click += new System.EventHandler(this.agendarStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.library_16xLG;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton2.Text = "Historico";
            this.toolStripButton2.Click += new System.EventHandler(this.btHistorico_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Canaan.Telas.Properties.Resources.clock_16xLG;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(109, 22);
            this.toolStripButton3.Text = "Novo Lembrete";
            this.toolStripButton3.Click += new System.EventHandler(this.btLembrete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nãoAtendeToolStripMenuItem,
            this.desligadoToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripSplitButton1.Text = "Outras Ações";
            // 
            // nãoAtendeToolStripMenuItem
            // 
            this.nãoAtendeToolStripMenuItem.Name = "nãoAtendeToolStripMenuItem";
            this.nãoAtendeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.nãoAtendeToolStripMenuItem.Text = "Não Atende";
            this.nãoAtendeToolStripMenuItem.Click += new System.EventHandler(this.nãoAtendeToolStripMenuItem_Click);
            // 
            // desligadoToolStripMenuItem
            // 
            this.desligadoToolStripMenuItem.Name = "desligadoToolStripMenuItem";
            this.desligadoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.desligadoToolStripMenuItem.Text = "Desligado";
            this.desligadoToolStripMenuItem.Click += new System.EventHandler(this.desligadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(71, 22);
            this.toolStripSplitButton2.Text = "Filtros";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tbLembrete);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 428);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.celularPictureBox);
            this.tabPage1.Controls.Add(this.telefonePictureBox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(dataLabel);
            this.tabPage1.Controls.Add(this.dataDateEdit);
            this.tabPage1.Controls.Add(dataPreenchimentoLabel);
            this.tabPage1.Controls.Add(this.dataPreenchimentoDateEdit);
            this.tabPage1.Controls.Add(statusLabel);
            this.tabPage1.Controls.Add(this.statusTextBox);
            this.tabPage1.Controls.Add(this.isAtivoCheckBox);
            this.tabPage1.Controls.Add(obsLabel);
            this.tabPage1.Controls.Add(this.obsTextBox);
            this.tabPage1.Controls.Add(this.parceriaLabel);
            this.tabPage1.Controls.Add(idParceriaLabel);
            this.tabPage1.Controls.Add(this.idParceriaTextBox);
            this.tabPage1.Controls.Add(emailLabel);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(telefoneLabel);
            this.tabPage1.Controls.Add(this.telefoneMaskedTextBox);
            this.tabPage1.Controls.Add(celularLabel);
            this.tabPage1.Controls.Add(this.celularMaskedTextBox);
            this.tabPage1.Controls.Add(enderecoLabel);
            this.tabPage1.Controls.Add(this.enderecoTextBox);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações do Cupom";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // celularPictureBox
            // 
            this.celularPictureBox.ErrorImage = global::Canaan.Telas.Properties.Resources.blank;
            this.celularPictureBox.Location = new System.Drawing.Point(136, 99);
            this.celularPictureBox.Name = "celularPictureBox";
            this.celularPictureBox.Size = new System.Drawing.Size(36, 36);
            this.celularPictureBox.TabIndex = 26;
            this.celularPictureBox.TabStop = false;
            // 
            // telefonePictureBox
            // 
            this.telefonePictureBox.ErrorImage = global::Canaan.Telas.Properties.Resources.blank;
            this.telefonePictureBox.Location = new System.Drawing.Point(315, 99);
            this.telefonePictureBox.Name = "telefonePictureBox";
            this.telefonePictureBox.Size = new System.Drawing.Size(36, 36);
            this.telefonePictureBox.TabIndex = 25;
            this.telefonePictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clIndicacao);
            this.groupBox3.Location = new System.Drawing.Point(379, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 67);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Indicação de";
            // 
            // clIndicacao
            // 
            this.clIndicacao.AutoSize = true;
            this.clIndicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clIndicacao.Location = new System.Drawing.Point(5, 26);
            this.clIndicacao.Name = "clIndicacao";
            this.clIndicacao.Padding = new System.Windows.Forms.Padding(5);
            this.clIndicacao.Size = new System.Drawing.Size(92, 23);
            this.clIndicacao.TabIndex = 0;
            this.clIndicacao.Text = "Nenhum Cliente";
            this.clIndicacao.Click += new System.EventHandler(this.clIndicacao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cLembreteReponsavel);
            this.groupBox2.Location = new System.Drawing.Point(379, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 60);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lembrete do Usuário";
            // 
            // cLembreteReponsavel
            // 
            this.cLembreteReponsavel.AutoSize = true;
            this.cLembreteReponsavel.Location = new System.Drawing.Point(16, 23);
            this.cLembreteReponsavel.Name = "cLembreteReponsavel";
            this.cLembreteReponsavel.Padding = new System.Windows.Forms.Padding(5);
            this.cLembreteReponsavel.Size = new System.Drawing.Size(56, 23);
            this.cLembreteReponsavel.TabIndex = 0;
            this.cLembreteReponsavel.Text = "Nenhum";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(dataTeleLabel);
            this.groupBox1.Controls.Add(this.dataTeleDateEdit);
            this.groupBox1.Controls.Add(idUsuarioTeleLabel);
            this.groupBox1.Controls.Add(this.idUsuarioTeleComboBox);
            this.groupBox1.Controls.Add(idStatusTeleLabel);
            this.groupBox1.Controls.Add(this.idStatusTeleComboBox);
            this.groupBox1.Location = new System.Drawing.Point(379, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 177);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telemarketing";
            // 
            // dataTeleDateEdit
            // 
            this.dataTeleDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cupomBindingSource, "DataTele", true));
            this.dataTeleDateEdit.EditValue = null;
            this.dataTeleDateEdit.Enabled = false;
            this.dataTeleDateEdit.Location = new System.Drawing.Point(19, 137);
            this.dataTeleDateEdit.Name = "dataTeleDateEdit";
            this.dataTeleDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataTeleDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataTeleDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataTeleDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataTeleDateEdit.Size = new System.Drawing.Size(203, 20);
            this.dataTeleDateEdit.TabIndex = 5;
            // 
            // cupomBindingSource
            // 
            this.cupomBindingSource.DataSource = typeof(Canaan.Dados.Cupom);
            // 
            // idUsuarioTeleComboBox
            // 
            this.idUsuarioTeleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "IdUsuarioTele", true));
            this.idUsuarioTeleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cupomBindingSource, "IdUsuarioTele", true));
            this.idUsuarioTeleComboBox.DataSource = this.usuarioBindingSource;
            this.idUsuarioTeleComboBox.DisplayMember = "Nome";
            this.idUsuarioTeleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idUsuarioTeleComboBox.Enabled = false;
            this.idUsuarioTeleComboBox.FormattingEnabled = true;
            this.idUsuarioTeleComboBox.Location = new System.Drawing.Point(18, 91);
            this.idUsuarioTeleComboBox.Name = "idUsuarioTeleComboBox";
            this.idUsuarioTeleComboBox.Size = new System.Drawing.Size(203, 21);
            this.idUsuarioTeleComboBox.TabIndex = 3;
            this.idUsuarioTeleComboBox.ValueMember = "IdUsuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Canaan.Dados.Usuario);
            // 
            // idStatusTeleComboBox
            // 
            this.idStatusTeleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "IdStatusTele", true));
            this.idStatusTeleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cupomBindingSource, "IdStatusTele", true));
            this.idStatusTeleComboBox.DataSource = this.telemarketingStatusBindingSource;
            this.idStatusTeleComboBox.DisplayMember = "Nome";
            this.idStatusTeleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idStatusTeleComboBox.Enabled = false;
            this.idStatusTeleComboBox.FormattingEnabled = true;
            this.idStatusTeleComboBox.Location = new System.Drawing.Point(18, 43);
            this.idStatusTeleComboBox.Name = "idStatusTeleComboBox";
            this.idStatusTeleComboBox.Size = new System.Drawing.Size(204, 21);
            this.idStatusTeleComboBox.TabIndex = 1;
            this.idStatusTeleComboBox.ValueMember = "IdStatus";
            // 
            // telemarketingStatusBindingSource
            // 
            this.telemarketingStatusBindingSource.DataSource = typeof(Canaan.Dados.TelemarketingStatus);
            // 
            // dataDateEdit
            // 
            this.dataDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cupomBindingSource, "Data", true));
            this.dataDateEdit.EditValue = null;
            this.dataDateEdit.Enabled = false;
            this.dataDateEdit.Location = new System.Drawing.Point(12, 203);
            this.dataDateEdit.Name = "dataDateEdit";
            this.dataDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataDateEdit.Size = new System.Drawing.Size(167, 20);
            this.dataDateEdit.TabIndex = 21;
            // 
            // dataPreenchimentoDateEdit
            // 
            this.dataPreenchimentoDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cupomBindingSource, "DataPreenchimento", true));
            this.dataPreenchimentoDateEdit.EditValue = null;
            this.dataPreenchimentoDateEdit.Enabled = false;
            this.dataPreenchimentoDateEdit.Location = new System.Drawing.Point(185, 203);
            this.dataPreenchimentoDateEdit.Name = "dataPreenchimentoDateEdit";
            this.dataPreenchimentoDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataPreenchimentoDateEdit.Size = new System.Drawing.Size(170, 20);
            this.dataPreenchimentoDateEdit.TabIndex = 19;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Status", true));
            this.statusTextBox.Enabled = false;
            this.statusTextBox.Location = new System.Drawing.Point(12, 251);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(145, 21);
            this.statusTextBox.TabIndex = 17;
            // 
            // isAtivoCheckBox
            // 
            this.isAtivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cupomBindingSource, "IsAtivo", true));
            this.isAtivoCheckBox.Enabled = false;
            this.isAtivoCheckBox.Location = new System.Drawing.Point(12, 374);
            this.isAtivoCheckBox.Name = "isAtivoCheckBox";
            this.isAtivoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isAtivoCheckBox.TabIndex = 16;
            this.isAtivoCheckBox.Text = "Status";
            this.isAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // obsTextBox
            // 
            this.obsTextBox.CausesValidation = false;
            this.obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Obs", true));
            this.obsTextBox.Enabled = false;
            this.obsTextBox.Location = new System.Drawing.Point(12, 291);
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(343, 77);
            this.obsTextBox.TabIndex = 14;
            // 
            // parceriaLabel
            // 
            this.parceriaLabel.AutoSize = true;
            this.parceriaLabel.Enabled = false;
            this.parceriaLabel.Location = new System.Drawing.Point(232, 254);
            this.parceriaLabel.Name = "parceriaLabel";
            this.parceriaLabel.Size = new System.Drawing.Size(103, 13);
            this.parceriaLabel.TabIndex = 12;
            this.parceriaLabel.TabStop = true;
            this.parceriaLabel.Text = "Selecione a Parceria";
            // 
            // idParceriaTextBox
            // 
            this.idParceriaTextBox.CausesValidation = false;
            this.idParceriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "IdParceria", true));
            this.idParceriaTextBox.Enabled = false;
            this.idParceriaTextBox.Location = new System.Drawing.Point(182, 251);
            this.idParceriaTextBox.Name = "idParceriaTextBox";
            this.idParceriaTextBox.Size = new System.Drawing.Size(44, 21);
            this.idParceriaTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CausesValidation = false;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Email", true));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(12, 163);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(343, 21);
            this.emailTextBox.TabIndex = 9;
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.CausesValidation = false;
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Enabled = false;
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(185, 114);
            this.telefoneMaskedTextBox.Mask = "[99]99999-9999";
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(120, 21);
            this.telefoneMaskedTextBox.TabIndex = 7;
            this.telefoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.CausesValidation = false;
            this.celularMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Celular", true));
            this.celularMaskedTextBox.Enabled = false;
            this.celularMaskedTextBox.Location = new System.Drawing.Point(7, 114);
            this.celularMaskedTextBox.Mask = "[99]99999-9999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(120, 21);
            this.celularMaskedTextBox.TabIndex = 5;
            this.celularMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.CausesValidation = false;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Endereco", true));
            this.enderecoTextBox.Enabled = false;
            this.enderecoTextBox.Location = new System.Drawing.Point(7, 66);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(348, 21);
            this.enderecoTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.CausesValidation = false;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cupomBindingSource, "Nome", true));
            this.nomeTextBox.Enabled = false;
            this.nomeTextBox.Location = new System.Drawing.Point(7, 23);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(348, 21);
            this.nomeTextBox.TabIndex = 1;
            // 
            // tbLembrete
            // 
            this.tbLembrete.Controls.Add(this.dataGrid);
            this.tbLembrete.Location = new System.Drawing.Point(4, 22);
            this.tbLembrete.Name = "tbLembrete";
            this.tbLembrete.Padding = new System.Windows.Forms.Padding(3);
            this.tbLembrete.Size = new System.Drawing.Size(643, 402);
            this.tbLembrete.TabIndex = 1;
            this.tbLembrete.Text = "Lembretes";
            this.tbLembrete.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.ShowCellErrors = false;
            this.dataGrid.ShowCellToolTips = false;
            this.dataGrid.ShowEditingIcon = false;
            this.dataGrid.ShowRowErrors = false;
            this.dataGrid.Size = new System.Drawing.Size(637, 396);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.DoubleClick += new System.EventHandler(this.dataGrid_DoubleClick);
            // 
            // CupomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(675, 479);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CupomView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar";
            this.Load += new System.EventHandler(this.CupomView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.celularPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonePictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeleDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTeleDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cupomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telemarketingStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreenchimentoDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreenchimentoDateEdit.Properties)).EndInit();
            this.tbLembrete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource cupomBindingSource;
        private BindingNavigator bindingNavigator1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DateEdit dataDateEdit;
        private DateEdit dataPreenchimentoDateEdit;
        private TextBox statusTextBox;
        private CheckBox isAtivoCheckBox;
        private TextBox obsTextBox;
        private LinkLabel parceriaLabel;
        private TextBox idParceriaTextBox;
        private TextBox emailTextBox;
        private MaskedTextBox telefoneMaskedTextBox;
        private MaskedTextBox celularMaskedTextBox;
        private TextBox enderecoTextBox;
        private TextBox nomeTextBox;
        private GroupBox groupBox1;
        private ComboBox idStatusTeleComboBox;
        private ComboBox idUsuarioTeleComboBox;
        private DateEdit dataTeleDateEdit;
        private BindingSource telemarketingStatusBindingSource;
        private BindingSource usuarioBindingSource;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator5;
        private GroupBox groupBox2;
        private CLabel cLembreteReponsavel;
        private GroupBox groupBox3;
        private CLabel clIndicacao;
        private ToolStripMenuItem nãoAtendeToolStripMenuItem;
        private ToolStripMenuItem desligadoToolStripMenuItem;
        private TabPage tbLembrete;
        protected DataGridView dataGrid;
        private PictureBox celularPictureBox;
        private PictureBox telefonePictureBox;
    }
}