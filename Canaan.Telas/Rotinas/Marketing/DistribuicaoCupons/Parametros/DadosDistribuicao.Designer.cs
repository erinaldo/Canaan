using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Rotinas.Marketing.DistribuicaoCupons.Parametros
{
    partial class DadosDistribuicao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtEditLimite = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.oiCheckBox = new System.Windows.Forms.CheckBox();
            this.timCheckBox = new System.Windows.Forms.CheckBox();
            this.vivoCheckBox = new System.Windows.Forms.CheckBox();
            this.claroCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditLimite.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditLimite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(283, 175);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.claroCheckBox);
            this.tabPage1.Controls.Add(this.vivoCheckBox);
            this.tabPage1.Controls.Add(this.timCheckBox);
            this.tabPage1.Controls.Add(this.oiCheckBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtEditLimite);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtQuantidade);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(275, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados para Distribuição";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtEditLimite
            // 
            this.dtEditLimite.EditValue = null;
            this.dtEditLimite.Location = new System.Drawing.Point(133, 28);
            this.dtEditLimite.Name = "dtEditLimite";
            this.dtEditLimite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditLimite.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEditLimite.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dtEditLimite.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dtEditLimite.Size = new System.Drawing.Size(118, 20);
            this.dtEditLimite.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Limite";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(9, 28);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(118, 20);
            this.txtQuantidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Cupons";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(307, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operadoras";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.lightningBolt_16xLG;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton1.Text = "Finalizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // oiCheckBox
            // 
            this.oiCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.oiCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.oiCheckBox.Image = global::Canaan.Telas.Properties.Resources.operadora_oi;
            this.oiCheckBox.Location = new System.Drawing.Point(9, 67);
            this.oiCheckBox.Name = "oiCheckBox";
            this.oiCheckBox.Size = new System.Drawing.Size(60, 68);
            this.oiCheckBox.TabIndex = 9;
            this.oiCheckBox.UseVisualStyleBackColor = true;
            // 
            // timCheckBox
            // 
            this.timCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.timCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timCheckBox.Image = global::Canaan.Telas.Properties.Resources.operadora_tim;
            this.timCheckBox.Location = new System.Drawing.Point(75, 67);
            this.timCheckBox.Name = "timCheckBox";
            this.timCheckBox.Size = new System.Drawing.Size(60, 68);
            this.timCheckBox.TabIndex = 10;
            this.timCheckBox.UseVisualStyleBackColor = true;
            // 
            // vivoCheckBox
            // 
            this.vivoCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vivoCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vivoCheckBox.Image = global::Canaan.Telas.Properties.Resources.operadora_vivo;
            this.vivoCheckBox.Location = new System.Drawing.Point(141, 67);
            this.vivoCheckBox.Name = "vivoCheckBox";
            this.vivoCheckBox.Size = new System.Drawing.Size(60, 68);
            this.vivoCheckBox.TabIndex = 11;
            this.vivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // claroCheckBox
            // 
            this.claroCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.claroCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.claroCheckBox.Image = global::Canaan.Telas.Properties.Resources.operadora_claro;
            this.claroCheckBox.Location = new System.Drawing.Point(207, 67);
            this.claroCheckBox.Name = "claroCheckBox";
            this.claroCheckBox.Size = new System.Drawing.Size(60, 68);
            this.claroCheckBox.TabIndex = 12;
            this.claroCheckBox.UseVisualStyleBackColor = true;
            // 
            // DadosDistribuicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 215);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DadosDistribuicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados da Distribuição";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditLimite.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEditLimite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private BindingNavigator bindingNavigator1;
        private ToolStripButton toolStripButton1;
        private Label label1;
        private TextBox txtQuantidade;
        private Label label2;
        private DateEdit dtEditLimite;
        private Label label3;
        private CheckBox claroCheckBox;
        private CheckBox vivoCheckBox;
        private CheckBox timCheckBox;
        private CheckBox oiCheckBox;
    }
}