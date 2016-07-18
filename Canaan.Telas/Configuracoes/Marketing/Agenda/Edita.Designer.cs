using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Configuracoes.Agenda
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
            System.Windows.Forms.Label distanciaLabel;
            System.Windows.Forms.Label domInicioLabel;
            System.Windows.Forms.Label segInicioLabel;
            System.Windows.Forms.Label terInicioLabel;
            System.Windows.Forms.Label quaInicioLabel;
            System.Windows.Forms.Label quiInicioLabel;
            System.Windows.Forms.Label sexInicioLabel;
            System.Windows.Forms.Label sabInicioLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.distanciaTextBox = new System.Windows.Forms.TextBox();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isAtivoCheckBox = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.filialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sabFimTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.sabInicioTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.sexFimTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.sexInicioTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.quiFimTimeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.quiInicioTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.quiFimTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.quaInicioTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.terFimTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.terInicioTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.segFimTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.segInicioTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.domFimTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.domInicioTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            idFilialLabel = new System.Windows.Forms.Label();
            distanciaLabel = new System.Windows.Forms.Label();
            domInicioLabel = new System.Windows.Forms.Label();
            segInicioLabel = new System.Windows.Forms.Label();
            terInicioLabel = new System.Windows.Forms.Label();
            quaInicioLabel = new System.Windows.Forms.Label();
            quiInicioLabel = new System.Windows.Forms.Label();
            sexInicioLabel = new System.Windows.Forms.Label();
            sabInicioLabel = new System.Windows.Forms.Label();
            this.panelEdit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabFimTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabInicioTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexFimTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexInicioTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiFimTimeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiInicioTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiFimTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quaInicioTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terFimTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terInicioTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segFimTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segInicioTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domFimTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domInicioTimeEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabControl1);
            this.panelEdit.Size = new System.Drawing.Size(352, 384);
            // 
            // idFilialLabel
            // 
            idFilialLabel.AutoSize = true;
            idFilialLabel.Location = new System.Drawing.Point(6, 3);
            idFilialLabel.Name = "idFilialLabel";
            idFilialLabel.Size = new System.Drawing.Size(27, 13);
            idFilialLabel.TabIndex = 0;
            idFilialLabel.Text = "Filial";
            // 
            // distanciaLabel
            // 
            distanciaLabel.AutoSize = true;
            distanciaLabel.Location = new System.Drawing.Point(174, 3);
            distanciaLabel.Name = "distanciaLabel";
            distanciaLabel.Size = new System.Drawing.Size(135, 13);
            distanciaLabel.TabIndex = 2;
            distanciaLabel.Text = "Intervalo entre as sessões";
            // 
            // domInicioLabel
            // 
            domInicioLabel.AutoSize = true;
            domInicioLabel.Location = new System.Drawing.Point(6, 116);
            domInicioLabel.Name = "domInicioLabel";
            domInicioLabel.Size = new System.Drawing.Size(48, 13);
            domInicioLabel.TabIndex = 8;
            domInicioLabel.Text = "Domingo";
            // 
            // segInicioLabel
            // 
            segInicioLabel.AutoSize = true;
            segInicioLabel.Location = new System.Drawing.Point(6, 142);
            segInicioLabel.Name = "segInicioLabel";
            segInicioLabel.Size = new System.Drawing.Size(77, 13);
            segInicioLabel.TabIndex = 11;
            segInicioLabel.Text = "Segunda-Feira";
            // 
            // terInicioLabel
            // 
            terInicioLabel.AutoSize = true;
            terInicioLabel.Location = new System.Drawing.Point(6, 168);
            terInicioLabel.Name = "terInicioLabel";
            terInicioLabel.Size = new System.Drawing.Size(62, 13);
            terInicioLabel.TabIndex = 14;
            terInicioLabel.Text = "Terça-Feira";
            // 
            // quaInicioLabel
            // 
            quaInicioLabel.AutoSize = true;
            quaInicioLabel.Location = new System.Drawing.Point(6, 195);
            quaInicioLabel.Name = "quaInicioLabel";
            quaInicioLabel.Size = new System.Drawing.Size(69, 13);
            quaInicioLabel.TabIndex = 17;
            quaInicioLabel.Text = "Quarta-Feira";
            // 
            // quiInicioLabel
            // 
            quiInicioLabel.AutoSize = true;
            quiInicioLabel.Location = new System.Drawing.Point(6, 220);
            quiInicioLabel.Name = "quiInicioLabel";
            quiInicioLabel.Size = new System.Drawing.Size(67, 13);
            quiInicioLabel.TabIndex = 20;
            quiInicioLabel.Text = "Quinta-Feira";
            // 
            // sexInicioLabel
            // 
            sexInicioLabel.AutoSize = true;
            sexInicioLabel.Location = new System.Drawing.Point(6, 244);
            sexInicioLabel.Name = "sexInicioLabel";
            sexInicioLabel.Size = new System.Drawing.Size(63, 13);
            sexInicioLabel.TabIndex = 23;
            sexInicioLabel.Text = "Sexta-Feira";
            // 
            // sabInicioLabel
            // 
            sabInicioLabel.AutoSize = true;
            sabInicioLabel.Location = new System.Drawing.Point(6, 272);
            sabInicioLabel.Name = "sabInicioLabel";
            sabInicioLabel.Size = new System.Drawing.Size(43, 13);
            sabInicioLabel.TabIndex = 26;
            sabInicioLabel.Text = "Sábado";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(328, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.distanciaTextBox);
            this.tabPage1.Controls.Add(this.isAtivoCheckBox);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.sabFimTimeEdit);
            this.tabPage1.Controls.Add(sabInicioLabel);
            this.tabPage1.Controls.Add(this.sabInicioTimeEdit);
            this.tabPage1.Controls.Add(this.sexFimTimeEdit);
            this.tabPage1.Controls.Add(sexInicioLabel);
            this.tabPage1.Controls.Add(this.sexInicioTimeEdit);
            this.tabPage1.Controls.Add(this.quiFimTimeEdit1);
            this.tabPage1.Controls.Add(quiInicioLabel);
            this.tabPage1.Controls.Add(this.quiInicioTimeEdit);
            this.tabPage1.Controls.Add(this.quiFimTimeEdit);
            this.tabPage1.Controls.Add(quaInicioLabel);
            this.tabPage1.Controls.Add(this.quaInicioTimeEdit);
            this.tabPage1.Controls.Add(this.terFimTimeEdit);
            this.tabPage1.Controls.Add(terInicioLabel);
            this.tabPage1.Controls.Add(this.terInicioTimeEdit);
            this.tabPage1.Controls.Add(this.segFimTimeEdit);
            this.tabPage1.Controls.Add(segInicioLabel);
            this.tabPage1.Controls.Add(this.segInicioTimeEdit);
            this.tabPage1.Controls.Add(this.domFimTimeEdit);
            this.tabPage1.Controls.Add(domInicioLabel);
            this.tabPage1.Controls.Add(this.domInicioTimeEdit);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(distanciaLabel);
            this.tabPage1.Controls.Add(idFilialLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(320, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações da Agenda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // distanciaTextBox
            // 
            this.distanciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Distancia", true));
            this.distanciaTextBox.Location = new System.Drawing.Point(240, 21);
            this.distanciaTextBox.Name = "distanciaTextBox";
            this.distanciaTextBox.Size = new System.Drawing.Size(69, 21);
            this.distanciaTextBox.TabIndex = 32;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataSource = typeof(Canaan.Dados.Agenda);
            // 
            // isAtivoCheckBox
            // 
            this.isAtivoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.agendaBindingSource, "IsAtivo", true));
            this.isAtivoCheckBox.Location = new System.Drawing.Point(9, 302);
            this.isAtivoCheckBox.Name = "isAtivoCheckBox";
            this.isAtivoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isAtivoCheckBox.TabIndex = 31;
            this.isAtivoCheckBox.Text = "Status";
            this.isAtivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filialBindingSource, "NomeFantasia", true));
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(6, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 17);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // filialBindingSource
            // 
            this.filialBindingSource.DataSource = typeof(Canaan.Dados.Filial);
            // 
            // sabFimTimeEdit
            // 
            this.sabFimTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "SabFim", true));
            this.sabFimTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.sabFimTimeEdit.Location = new System.Drawing.Point(240, 269);
            this.sabFimTimeEdit.Name = "sabFimTimeEdit";
            this.sabFimTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sabFimTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.sabFimTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.sabFimTimeEdit.Size = new System.Drawing.Size(69, 20);
            this.sabFimTimeEdit.TabIndex = 13;
            // 
            // sabInicioTimeEdit
            // 
            this.sabInicioTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "SabInicio", true));
            this.sabInicioTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.sabInicioTimeEdit.Location = new System.Drawing.Point(124, 269);
            this.sabInicioTimeEdit.Name = "sabInicioTimeEdit";
            this.sabInicioTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sabInicioTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.sabInicioTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.sabInicioTimeEdit.Size = new System.Drawing.Size(76, 20);
            this.sabInicioTimeEdit.TabIndex = 12;
            // 
            // sexFimTimeEdit
            // 
            this.sexFimTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "SexFim", true));
            this.sexFimTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.sexFimTimeEdit.Location = new System.Drawing.Point(240, 244);
            this.sexFimTimeEdit.Name = "sexFimTimeEdit";
            this.sexFimTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sexFimTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.sexFimTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.sexFimTimeEdit.Size = new System.Drawing.Size(69, 20);
            this.sexFimTimeEdit.TabIndex = 11;
            // 
            // sexInicioTimeEdit
            // 
            this.sexInicioTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "SexInicio", true));
            this.sexInicioTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.sexInicioTimeEdit.Location = new System.Drawing.Point(124, 243);
            this.sexInicioTimeEdit.Name = "sexInicioTimeEdit";
            this.sexInicioTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sexInicioTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.sexInicioTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.sexInicioTimeEdit.Size = new System.Drawing.Size(76, 20);
            this.sexInicioTimeEdit.TabIndex = 10;
            // 
            // quiFimTimeEdit1
            // 
            this.quiFimTimeEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "QuiFim", true));
            this.quiFimTimeEdit1.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.quiFimTimeEdit1.Location = new System.Drawing.Point(240, 218);
            this.quiFimTimeEdit1.Name = "quiFimTimeEdit1";
            this.quiFimTimeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quiFimTimeEdit1.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.quiFimTimeEdit1.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.quiFimTimeEdit1.Size = new System.Drawing.Size(69, 20);
            this.quiFimTimeEdit1.TabIndex = 9;
            // 
            // quiInicioTimeEdit
            // 
            this.quiInicioTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "QuiInicio", true));
            this.quiInicioTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.quiInicioTimeEdit.Location = new System.Drawing.Point(124, 217);
            this.quiInicioTimeEdit.Name = "quiInicioTimeEdit";
            this.quiInicioTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quiInicioTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.quiInicioTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.quiInicioTimeEdit.Size = new System.Drawing.Size(76, 20);
            this.quiInicioTimeEdit.TabIndex = 8;
            // 
            // quiFimTimeEdit
            // 
            this.quiFimTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "QuaFim", true));
            this.quiFimTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.quiFimTimeEdit.Location = new System.Drawing.Point(240, 192);
            this.quiFimTimeEdit.Name = "quiFimTimeEdit";
            this.quiFimTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quiFimTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.quiFimTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.quiFimTimeEdit.Size = new System.Drawing.Size(69, 20);
            this.quiFimTimeEdit.TabIndex = 7;
            // 
            // quaInicioTimeEdit
            // 
            this.quaInicioTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "QuaInicio", true));
            this.quaInicioTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.quaInicioTimeEdit.Location = new System.Drawing.Point(124, 191);
            this.quaInicioTimeEdit.Name = "quaInicioTimeEdit";
            this.quaInicioTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quaInicioTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.quaInicioTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.quaInicioTimeEdit.Size = new System.Drawing.Size(76, 20);
            this.quaInicioTimeEdit.TabIndex = 6;
            // 
            // terFimTimeEdit
            // 
            this.terFimTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "TerFim", true));
            this.terFimTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.terFimTimeEdit.Location = new System.Drawing.Point(240, 165);
            this.terFimTimeEdit.Name = "terFimTimeEdit";
            this.terFimTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.terFimTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.terFimTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.terFimTimeEdit.Size = new System.Drawing.Size(69, 20);
            this.terFimTimeEdit.TabIndex = 5;
            // 
            // terInicioTimeEdit
            // 
            this.terInicioTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "TerInicio", true));
            this.terInicioTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.terInicioTimeEdit.Location = new System.Drawing.Point(124, 165);
            this.terInicioTimeEdit.Name = "terInicioTimeEdit";
            this.terInicioTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.terInicioTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.terInicioTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.terInicioTimeEdit.Size = new System.Drawing.Size(76, 20);
            this.terInicioTimeEdit.TabIndex = 4;
            // 
            // segFimTimeEdit
            // 
            this.segFimTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "SegFim", true));
            this.segFimTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.segFimTimeEdit.Location = new System.Drawing.Point(240, 139);
            this.segFimTimeEdit.Name = "segFimTimeEdit";
            this.segFimTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.segFimTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.segFimTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.segFimTimeEdit.Size = new System.Drawing.Size(69, 20);
            this.segFimTimeEdit.TabIndex = 3;
            // 
            // segInicioTimeEdit
            // 
            this.segInicioTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "SegInicio", true));
            this.segInicioTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.segInicioTimeEdit.Location = new System.Drawing.Point(124, 139);
            this.segInicioTimeEdit.Name = "segInicioTimeEdit";
            this.segInicioTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.segInicioTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.segInicioTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.segInicioTimeEdit.Size = new System.Drawing.Size(76, 20);
            this.segInicioTimeEdit.TabIndex = 2;
            // 
            // domFimTimeEdit
            // 
            this.domFimTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "DomFim", true));
            this.domFimTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.domFimTimeEdit.Location = new System.Drawing.Point(240, 113);
            this.domFimTimeEdit.Name = "domFimTimeEdit";
            this.domFimTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.domFimTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.domFimTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.domFimTimeEdit.Size = new System.Drawing.Size(69, 20);
            this.domFimTimeEdit.TabIndex = 0;
            // 
            // domInicioTimeEdit
            // 
            this.domInicioTimeEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.agendaBindingSource, "DomInicio", true));
            this.domInicioTimeEdit.EditValue = new System.DateTime(2013, 10, 7, 0, 0, 0, 0);
            this.domInicioTimeEdit.Location = new System.Drawing.Point(124, 113);
            this.domInicioTimeEdit.Name = "domInicioTimeEdit";
            this.domInicioTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.domInicioTimeEdit.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.domInicioTimeEdit.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.domInicioTimeEdit.Size = new System.Drawing.Size(76, 20);
            this.domInicioTimeEdit.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dia da Semana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "HORÁRIO DE FUNCIONAMENTO";
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 417);
            this.Name = "Edita";
            this.Text = "Edita";
            this.Load += new System.EventHandler(this.Edita_Load);
            this.panelEdit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabFimTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabInicioTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexFimTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexInicioTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiFimTimeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiInicioTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiFimTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quaInicioTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terFimTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terInicioTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segFimTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segInicioTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domFimTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domInicioTimeEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TimeEdit domFimTimeEdit;
        private TimeEdit domInicioTimeEdit;
        private TimeEdit segInicioTimeEdit;
        private TimeEdit segFimTimeEdit;
        private TimeEdit terInicioTimeEdit;
        private TimeEdit terFimTimeEdit;
        private TimeEdit quiFimTimeEdit;
        private TimeEdit quaInicioTimeEdit;
        private TimeEdit quiInicioTimeEdit;
        private TimeEdit sexInicioTimeEdit;
        private TimeEdit quiFimTimeEdit1;
        private TimeEdit sexFimTimeEdit;
        private TimeEdit sabInicioTimeEdit;
        private TimeEdit sabFimTimeEdit;
        private BindingSource filialBindingSource;
        private BindingSource agendaBindingSource;
        private LinkLabel linkLabel1;
        private CheckBox isAtivoCheckBox;
        private TextBox distanciaTextBox;
    }
}