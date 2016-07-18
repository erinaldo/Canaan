using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Canaan.Telas.Rotinas.Marketing.DistribuicaoFaltantes
{
    partial class DistribuicaoFaltantes
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
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.distribuirAgendadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.tabDistribuicao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ckTodos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckListParcerias = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.label1 = new System.Windows.Forms.Label();
            this.ckListFuncionarios = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabDistribuicao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckListParcerias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckListFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.toolStripSplitButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(877, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.lightningBolt_16xLG;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(75, 22);
            this.toolStripButton1.Text = "Distribuir";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribuirAgendadoToolStripMenuItem,
            this.alterarToolStripMenuItem});
            this.toolStripSplitButton1.Enabled = false;
            this.toolStripSplitButton1.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripSplitButton1.Text = "Outras Ações";
            // 
            // distribuirAgendadoToolStripMenuItem
            // 
            this.distribuirAgendadoToolStripMenuItem.Enabled = false;
            this.distribuirAgendadoToolStripMenuItem.Name = "distribuirAgendadoToolStripMenuItem";
            this.distribuirAgendadoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.distribuirAgendadoToolStripMenuItem.Text = "Redistribuir Agendados";
            this.distribuirAgendadoToolStripMenuItem.Click += new System.EventHandler(this.distribuirAgendadoToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Enabled = false;
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.alterarToolStripMenuItem.Text = "Reditribuir Cupons";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(71, 22);
            this.toolStripSplitButton2.Text = "Filtros";
            // 
            // tabDistribuicao
            // 
            this.tabDistribuicao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDistribuicao.Controls.Add(this.tabPage1);
            this.tabDistribuicao.Location = new System.Drawing.Point(12, 28);
            this.tabDistribuicao.Name = "tabDistribuicao";
            this.tabDistribuicao.SelectedIndex = 0;
            this.tabDistribuicao.Size = new System.Drawing.Size(853, 402);
            this.tabDistribuicao.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ckTodos);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ckListParcerias);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ckListFuncionarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Distribuição de Cupons";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ckTodos
            // 
            this.ckTodos.AutoSize = true;
            this.ckTodos.Enabled = false;
            this.ckTodos.Location = new System.Drawing.Point(783, 6);
            this.ckTodos.Name = "ckTodos";
            this.ckTodos.Size = new System.Drawing.Size(56, 17);
            this.ckTodos.TabIndex = 6;
            this.ckTodos.Text = "Todos";
            this.ckTodos.UseVisualStyleBackColor = true;
            this.ckTodos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parcerias";
            // 
            // ckListParcerias
            // 
            this.ckListParcerias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckListParcerias.Enabled = false;
            this.ckListParcerias.Location = new System.Drawing.Point(288, 28);
            this.ckListParcerias.Name = "ckListParcerias";
            this.ckListParcerias.Size = new System.Drawing.Size(551, 326);
            this.ckListParcerias.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atendentes";
            // 
            // ckListFuncionarios
            // 
            this.ckListFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ckListFuncionarios.Location = new System.Drawing.Point(6, 28);
            this.ckListFuncionarios.Name = "ckListFuncionarios";
            this.ckListFuncionarios.Size = new System.Drawing.Size(276, 326);
            this.ckListFuncionarios.TabIndex = 0;
            this.ckListFuncionarios.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl1_ItemCheck);
            // 
            // DistribuicaoFaltantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 442);
            this.Controls.Add(this.tabDistribuicao);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DistribuicaoFaltantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuição de Faltantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DistribuicaoFaltantes_FormClosing);
            this.Load += new System.EventHandler(this.SelecaoCupons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabDistribuicao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckListParcerias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckListFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingNavigator bindingNavigator1;
        private TabControl tabDistribuicao;
        private TabPage tabPage1;
        private Label label1;
        private CheckedListBoxControl ckListFuncionarios;
        private CheckedListBoxControl ckListParcerias;
        private Label label2;
        private ToolStripButton toolStripButton1;
        private CheckBox ckTodos;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem distribuirAgendadoToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripSeparator toolStripSeparator2;

    }
}