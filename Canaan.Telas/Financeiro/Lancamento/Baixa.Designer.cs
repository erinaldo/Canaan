using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Canaan.Telas.Financeiro.Lancamento
{
    partial class Baixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.actionToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnEfetuaBaixa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCalculaValores = new System.Windows.Forms.ToolStripButton();
            this.lancGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.lancDataGridView = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancPanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.valorPagoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.baixaGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipoPgtoComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.contaCaixaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.idContaCaixaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dataBaixaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.valorLiquidoLabel = new System.Windows.Forms.Label();
            this.valorTrocoLabel = new System.Windows.Forms.Label();
            this.actionToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancGroupControl)).BeginInit();
            this.lancGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancDataGridView)).BeginInit();
            this.lancPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorPagoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baixaGroupControl)).BeginInit();
            this.baixaGroupControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idContaCaixaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaixaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaixaDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // actionToolStrip
            // 
            this.actionToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.actionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEfetuaBaixa,
            this.toolStripSeparator1,
            this.btnCalculaValores});
            this.actionToolStrip.Location = new System.Drawing.Point(0, 0);
            this.actionToolStrip.Name = "actionToolStrip";
            this.actionToolStrip.Padding = new System.Windows.Forms.Padding(5);
            this.actionToolStrip.Size = new System.Drawing.Size(663, 33);
            this.actionToolStrip.TabIndex = 0;
            this.actionToolStrip.Text = "toolStrip1";
            // 
            // btnEfetuaBaixa
            // 
            this.btnEfetuaBaixa.Image = global::Canaan.Telas.Properties.Resources.lightningBolt_16xLG;
            this.btnEfetuaBaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEfetuaBaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEfetuaBaixa.Name = "btnEfetuaBaixa";
            this.btnEfetuaBaixa.Size = new System.Drawing.Size(94, 20);
            this.btnEfetuaBaixa.Text = "Efetuar Baixa";
            this.btnEfetuaBaixa.Click += new System.EventHandler(this.btnEfetuaBaixa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnCalculaValores
            // 
            this.btnCalculaValores.Image = global::Canaan.Telas.Properties.Resources.sigma_16xLG;
            this.btnCalculaValores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalculaValores.Name = "btnCalculaValores";
            this.btnCalculaValores.Size = new System.Drawing.Size(118, 20);
            this.btnCalculaValores.Text = "Recalcula Valores";
            this.btnCalculaValores.Click += new System.EventHandler(this.btnCalculaValores_Click);
            // 
            // lancGroupControl
            // 
            this.lancGroupControl.Appearance.BackColor = System.Drawing.Color.White;
            this.lancGroupControl.Appearance.Options.UseBackColor = true;
            this.lancGroupControl.Controls.Add(this.lancDataGridView);
            this.lancGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lancGroupControl.Location = new System.Drawing.Point(5, 5);
            this.lancGroupControl.Name = "lancGroupControl";
            this.lancGroupControl.Size = new System.Drawing.Size(653, 177);
            this.lancGroupControl.TabIndex = 1;
            this.lancGroupControl.Text = "Informações dos Lançamentos";
            // 
            // lancDataGridView
            // 
            this.lancDataGridView.AllowUserToAddRows = false;
            this.lancDataGridView.AllowUserToDeleteRows = false;
            this.lancDataGridView.AllowUserToResizeColumns = false;
            this.lancDataGridView.AllowUserToResizeRows = false;
            this.lancDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.lancDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lancDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lancDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Vencimento,
            this.ValorOriginal,
            this.ValorJuros,
            this.ValorMulta,
            this.ValorAcrescimo,
            this.ValorDesconto,
            this.ValorLiquido});
            this.lancDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lancDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lancDataGridView.Location = new System.Drawing.Point(2, 21);
            this.lancDataGridView.MultiSelect = false;
            this.lancDataGridView.Name = "lancDataGridView";
            this.lancDataGridView.RowHeadersVisible = false;
            this.lancDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.lancDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lancDataGridView.ShowCellErrors = false;
            this.lancDataGridView.ShowCellToolTips = false;
            this.lancDataGridView.ShowEditingIcon = false;
            this.lancDataGridView.ShowRowErrors = false;
            this.lancDataGridView.Size = new System.Drawing.Size(649, 154);
            this.lancDataGridView.TabIndex = 0;
            this.lancDataGridView.CurrentCellChanged += new System.EventHandler(this.lancDataGridView_CurrentCellChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "Vencimento";
            dataGridViewCellStyle22.Format = "d";
            this.Vencimento.DefaultCellStyle = dataGridViewCellStyle22;
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            this.Vencimento.Width = 80;
            // 
            // ValorOriginal
            // 
            this.ValorOriginal.DataPropertyName = "ValorOriginal";
            dataGridViewCellStyle23.Format = "C2";
            dataGridViewCellStyle23.NullValue = null;
            this.ValorOriginal.DefaultCellStyle = dataGridViewCellStyle23;
            this.ValorOriginal.HeaderText = "Original";
            this.ValorOriginal.Name = "ValorOriginal";
            this.ValorOriginal.Width = 80;
            // 
            // ValorJuros
            // 
            this.ValorJuros.DataPropertyName = "ValorJuros";
            dataGridViewCellStyle24.Format = "C2";
            this.ValorJuros.DefaultCellStyle = dataGridViewCellStyle24;
            this.ValorJuros.HeaderText = "Juros";
            this.ValorJuros.Name = "ValorJuros";
            this.ValorJuros.Width = 80;
            // 
            // ValorMulta
            // 
            this.ValorMulta.DataPropertyName = "ValorMulta";
            dataGridViewCellStyle25.Format = "C2";
            this.ValorMulta.DefaultCellStyle = dataGridViewCellStyle25;
            this.ValorMulta.HeaderText = "Multa";
            this.ValorMulta.Name = "ValorMulta";
            this.ValorMulta.Width = 80;
            // 
            // ValorAcrescimo
            // 
            this.ValorAcrescimo.DataPropertyName = "ValorAcrescimo";
            dataGridViewCellStyle26.Format = "C2";
            this.ValorAcrescimo.DefaultCellStyle = dataGridViewCellStyle26;
            this.ValorAcrescimo.HeaderText = "Acréscimo";
            this.ValorAcrescimo.Name = "ValorAcrescimo";
            this.ValorAcrescimo.Width = 80;
            // 
            // ValorDesconto
            // 
            this.ValorDesconto.DataPropertyName = "ValorDesconto";
            dataGridViewCellStyle27.Format = "C2";
            this.ValorDesconto.DefaultCellStyle = dataGridViewCellStyle27;
            this.ValorDesconto.HeaderText = "Desconto";
            this.ValorDesconto.Name = "ValorDesconto";
            this.ValorDesconto.Width = 80;
            // 
            // ValorLiquido
            // 
            this.ValorLiquido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorLiquido.DataPropertyName = "ValorLiquido";
            dataGridViewCellStyle28.Format = "C2";
            this.ValorLiquido.DefaultCellStyle = dataGridViewCellStyle28;
            this.ValorLiquido.HeaderText = "Líquido";
            this.ValorLiquido.Name = "ValorLiquido";
            this.ValorLiquido.ReadOnly = true;
            // 
            // lancPanel
            // 
            this.lancPanel.Controls.Add(this.lancGroupControl);
            this.lancPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lancPanel.Location = new System.Drawing.Point(0, 33);
            this.lancPanel.Name = "lancPanel";
            this.lancPanel.Padding = new System.Windows.Forms.Padding(5);
            this.lancPanel.Size = new System.Drawing.Size(663, 187);
            this.lancPanel.TabIndex = 2;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.groupControl1);
            this.infoPanel.Controls.Add(this.baixaGroupControl);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(0, 220);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(5);
            this.infoPanel.Size = new System.Drawing.Size(663, 181);
            this.infoPanel.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.panel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(342, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(316, 171);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Informações do Pagamento";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.valorTrocoLabel);
            this.panel2.Controls.Add(this.valorLiquidoLabel);
            this.panel2.Controls.Add(this.valorPagoTextEdit);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 21);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(312, 148);
            this.panel2.TabIndex = 0;
            // 
            // valorPagoTextEdit
            // 
            this.valorPagoTextEdit.Location = new System.Drawing.Point(11, 66);
            this.valorPagoTextEdit.Name = "valorPagoTextEdit";
            this.valorPagoTextEdit.Properties.Mask.EditMask = "c";
            this.valorPagoTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.valorPagoTextEdit.Size = new System.Drawing.Size(159, 20);
            this.valorPagoTextEdit.TabIndex = 13;
            this.valorPagoTextEdit.EditValueChanged += new System.EventHandler(this.valorPagoTextEdit_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Troco";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Valor Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor Líquido";
            // 
            // baixaGroupControl
            // 
            this.baixaGroupControl.Appearance.BackColor = System.Drawing.Color.White;
            this.baixaGroupControl.Appearance.Options.UseBackColor = true;
            this.baixaGroupControl.Controls.Add(this.panel1);
            this.baixaGroupControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.baixaGroupControl.Location = new System.Drawing.Point(5, 5);
            this.baixaGroupControl.Name = "baixaGroupControl";
            this.baixaGroupControl.Size = new System.Drawing.Size(331, 171);
            this.baixaGroupControl.TabIndex = 2;
            this.baixaGroupControl.Text = "Informações da Baixa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tipoPgtoComboBox);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Controls.Add(this.contaCaixaLinkLabel);
            this.panel1.Controls.Add(this.idContaCaixaTextEdit);
            this.panel1.Controls.Add(this.dataBaixaDateEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(327, 148);
            this.panel1.TabIndex = 0;
            // 
            // tipoPgtoComboBox
            // 
            this.tipoPgtoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPgtoComboBox.FormattingEnabled = true;
            this.tipoPgtoComboBox.Location = new System.Drawing.Point(11, 111);
            this.tipoPgtoComboBox.Name = "tipoPgtoComboBox";
            this.tipoPgtoComboBox.Size = new System.Drawing.Size(223, 21);
            this.tipoPgtoComboBox.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 92);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Forma de Pagamento";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(11, 47);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(59, 13);
            this.labelControl14.TabIndex = 8;
            this.labelControl14.Text = "Conta Caixa";
            // 
            // contaCaixaLinkLabel
            // 
            this.contaCaixaLinkLabel.AutoSize = true;
            this.contaCaixaLinkLabel.Location = new System.Drawing.Point(76, 69);
            this.contaCaixaLinkLabel.Name = "contaCaixaLinkLabel";
            this.contaCaixaLinkLabel.Size = new System.Drawing.Size(123, 13);
            this.contaCaixaLinkLabel.TabIndex = 10;
            this.contaCaixaLinkLabel.TabStop = true;
            this.contaCaixaLinkLabel.Text = "Selecione a Conta Caixa";
            this.contaCaixaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contaCaixaLinkLabel_LinkClicked);
            // 
            // idContaCaixaTextEdit
            // 
            this.idContaCaixaTextEdit.Enabled = false;
            this.idContaCaixaTextEdit.Location = new System.Drawing.Point(11, 66);
            this.idContaCaixaTextEdit.Name = "idContaCaixaTextEdit";
            this.idContaCaixaTextEdit.Size = new System.Drawing.Size(59, 20);
            this.idContaCaixaTextEdit.TabIndex = 9;
            // 
            // dataBaixaDateEdit
            // 
            this.dataBaixaDateEdit.EditValue = null;
            this.dataBaixaDateEdit.Location = new System.Drawing.Point(8, 21);
            this.dataBaixaDateEdit.Name = "dataBaixaDateEdit";
            this.dataBaixaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataBaixaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataBaixaDateEdit.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dataBaixaDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dataBaixaDateEdit.Size = new System.Drawing.Size(147, 20);
            this.dataBaixaDateEdit.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data da Baixa";
            // 
            // valorLiquidoLabel
            // 
            this.valorLiquidoLabel.AutoSize = true;
            this.valorLiquidoLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorLiquidoLabel.ForeColor = System.Drawing.Color.Red;
            this.valorLiquidoLabel.Location = new System.Drawing.Point(8, 22);
            this.valorLiquidoLabel.Name = "valorLiquidoLabel";
            this.valorLiquidoLabel.Size = new System.Drawing.Size(55, 18);
            this.valorLiquidoLabel.TabIndex = 15;
            this.valorLiquidoLabel.Text = "label3";
            // 
            // valorTrocoLabel
            // 
            this.valorTrocoLabel.AutoSize = true;
            this.valorTrocoLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTrocoLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.valorTrocoLabel.Location = new System.Drawing.Point(8, 111);
            this.valorTrocoLabel.Name = "valorTrocoLabel";
            this.valorTrocoLabel.Size = new System.Drawing.Size(0, 18);
            this.valorTrocoLabel.TabIndex = 16;
            // 
            // Baixa
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 401);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.lancPanel);
            this.Controls.Add(this.actionToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Baixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baixa";
            this.Load += new System.EventHandler(this.Baixa_Load);
            this.actionToolStrip.ResumeLayout(false);
            this.actionToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lancGroupControl)).EndInit();
            this.lancGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lancDataGridView)).EndInit();
            this.lancPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorPagoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baixaGroupControl)).EndInit();
            this.baixaGroupControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idContaCaixaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaixaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaixaDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip actionToolStrip;
        private ToolStripButton btnEfetuaBaixa;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCalculaValores;
        private GroupControl lancGroupControl;
        private DataGridView lancDataGridView;
        private Panel lancPanel;
        private Panel infoPanel;
        private GroupControl baixaGroupControl;
        private Panel panel1;
        private Label label1;
        private DateEdit dataBaixaDateEdit;
        private LabelControl labelControl14;
        private LinkLabel contaCaixaLinkLabel;
        private TextEdit idContaCaixaTextEdit;
        private ComboBox tipoPgtoComboBox;
        private LabelControl labelControl1;
        private GroupControl groupControl1;
        private Panel panel2;
        private LabelControl labelControl2;
        private LabelControl labelControl3;
        private Label label2;
        private TextEdit valorPagoTextEdit;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Vencimento;
        private DataGridViewTextBoxColumn ValorOriginal;
        private DataGridViewTextBoxColumn ValorJuros;
        private DataGridViewTextBoxColumn ValorMulta;
        private DataGridViewTextBoxColumn ValorAcrescimo;
        private DataGridViewTextBoxColumn ValorDesconto;
        private DataGridViewTextBoxColumn ValorLiquido;
        private Label valorTrocoLabel;
        private Label valorLiquidoLabel;
    }
}