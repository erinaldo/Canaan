using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Configuracoes.Pedido.Tabela.Estudio
{
    partial class Seleciona
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bNavigatorModelo = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lbSelecionado = new System.Windows.Forms.ListBox();
            this.lbDisponivel = new System.Windows.Forms.ListBox();
            this.lkNomeTabela = new System.Windows.Forms.LinkLabel();
            this.panelEdit.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorModelo)).BeginInit();
            this.bNavigatorModelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.tabControl2);
            this.panelEdit.Size = new System.Drawing.Size(518, 368);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 265);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(381, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Selecinar Estúdios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(12, 13);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(494, 343);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bNavigatorModelo);
            this.tabPage2.Controls.Add(this.lbSelecionado);
            this.tabPage2.Controls.Add(this.lbDisponivel);
            this.tabPage2.Controls.Add(this.lkNomeTabela);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 317);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Selecionar Estúdios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estudio Selecionados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estudio Disponíveis";
            // 
            // bNavigatorModelo
            // 
            this.bNavigatorModelo.AddNewItem = null;
            this.bNavigatorModelo.BackColor = System.Drawing.Color.White;
            this.bNavigatorModelo.CountItem = null;
            this.bNavigatorModelo.DeleteItem = null;
            this.bNavigatorModelo.Dock = System.Windows.Forms.DockStyle.None;
            this.bNavigatorModelo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bNavigatorModelo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.bNavigatorModelo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.bNavigatorModelo.Location = new System.Drawing.Point(230, 135);
            this.bNavigatorModelo.MoveFirstItem = null;
            this.bNavigatorModelo.MoveLastItem = null;
            this.bNavigatorModelo.MoveNextItem = null;
            this.bNavigatorModelo.MovePreviousItem = null;
            this.bNavigatorModelo.Name = "bNavigatorModelo";
            this.bNavigatorModelo.PositionItem = null;
            this.bNavigatorModelo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bNavigatorModelo.Size = new System.Drawing.Size(32, 87);
            this.bNavigatorModelo.TabIndex = 4;
            this.bNavigatorModelo.Text = "bNavigatorModelo";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.fast_forward;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.addEstudio_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.rewind;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.remove_Click);
            // 
            // lbSelecionado
            // 
            this.lbSelecionado.FormattingEnabled = true;
            this.lbSelecionado.Location = new System.Drawing.Point(290, 83);
            this.lbSelecionado.Name = "lbSelecionado";
            this.lbSelecionado.Size = new System.Drawing.Size(178, 212);
            this.lbSelecionado.TabIndex = 2;
            // 
            // lbDisponivel
            // 
            this.lbDisponivel.FormattingEnabled = true;
            this.lbDisponivel.Location = new System.Drawing.Point(21, 83);
            this.lbDisponivel.Name = "lbDisponivel";
            this.lbDisponivel.Size = new System.Drawing.Size(178, 212);
            this.lbDisponivel.TabIndex = 1;
            // 
            // lkNomeTabela
            // 
            this.lkNomeTabela.AutoSize = true;
            this.lkNomeTabela.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lkNomeTabela.Location = new System.Drawing.Point(17, 21);
            this.lkNomeTabela.Name = "lkNomeTabela";
            this.lkNomeTabela.Size = new System.Drawing.Size(110, 19);
            this.lkNomeTabela.TabIndex = 0;
            this.lkNomeTabela.TabStop = true;
            this.lkNomeTabela.Text = "lkNomeTabela";
            // 
            // Seleciona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 401);
            this.Controls.Add(this.tabControl1);
            this.Name = "Seleciona";
            this.Text = "Seleciona";
            this.Load += new System.EventHandler(this.Seleciona_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.panelEdit, 0);
            this.panelEdit.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorModelo)).EndInit();
            this.bNavigatorModelo.ResumeLayout(false);
            this.bNavigatorModelo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabControl tabControl2;
        private TabPage tabPage2;
        private LinkLabel lkNomeTabela;
        private ListBox lbDisponivel;
        private ListBox lbSelecionado;
        private BindingNavigator bNavigatorModelo;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Label label1;
        private Label label2;
    }
}