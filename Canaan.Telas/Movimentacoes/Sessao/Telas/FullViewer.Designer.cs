using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Sessao.Telas
{
    partial class FullViewer
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
            this.bNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btAddSelecionada = new System.Windows.Forms.ToolStripButton();
            this.btAddVenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtNome = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator)).BeginInit();
            this.bNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bNavigator
            // 
            this.bNavigator.AddNewItem = null;
            this.bNavigator.CountItem = null;
            this.bNavigator.DeleteItem = null;
            this.bNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.btPlay,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.toolStripButton5,
            this.tsSeparator,
            this.btAddSelecionada,
            this.btAddVenda,
            this.toolStripSeparator2,
            this.txtNome});
            this.bNavigator.Location = new System.Drawing.Point(0, 482);
            this.bNavigator.MoveFirstItem = null;
            this.bNavigator.MoveLastItem = null;
            this.bNavigator.MoveNextItem = null;
            this.bNavigator.MovePreviousItem = null;
            this.bNavigator.Name = "bNavigator";
            this.bNavigator.PositionItem = null;
            this.bNavigator.Size = new System.Drawing.Size(762, 33);
            this.bNavigator.TabIndex = 0;
            this.bNavigator.Text = "bNavigator";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Canaan.Telas.Properties.Resources.close;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton4.Text = "Fechar";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.rewind;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton1.Text = "Voltar";
            this.toolStripButton1.Click += new System.EventHandler(this.back_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.fast_forward;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton2.Text = "Adiantar";
            this.toolStripButton2.Click += new System.EventHandler(this.forward_Click);
            // 
            // btPlay
            // 
            this.btPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPlay.Image = global::Canaan.Telas.Properties.Resources.play;
            this.btPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(30, 30);
            this.btPlay.Text = "Iniciar Slide Show";
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Canaan.Telas.Properties.Resources.undo;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton3.Text = "Girar Esquerda";
            this.toolStripButton3.Click += new System.EventHandler(this.girarEsquerda_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Canaan.Telas.Properties.Resources.redo;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton5.Text = "Girar para Direita";
            this.toolStripButton5.Click += new System.EventHandler(this.giraDireita_Click);
            // 
            // tsSeparator
            // 
            this.tsSeparator.Name = "tsSeparator";
            this.tsSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // btAddSelecionada
            // 
            this.btAddSelecionada.Image = global::Canaan.Telas.Properties.Resources.add_list;
            this.btAddSelecionada.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAddSelecionada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAddSelecionada.Name = "btAddSelecionada";
            this.btAddSelecionada.Size = new System.Drawing.Size(169, 30);
            this.btAddSelecionada.Text = "Adiciona as Selecionadas";
            this.btAddSelecionada.Click += new System.EventHandler(this.btAddSelecionada_Click);
            // 
            // btAddVenda
            // 
            this.btAddVenda.Image = global::Canaan.Telas.Properties.Resources.add_list;
            this.btAddVenda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAddVenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAddVenda.Name = "btAddVenda";
            this.btAddVenda.Size = new System.Drawing.Size(132, 30);
            this.btAddVenda.Text = "Adicionar à Venda";
            this.btAddVenda.Click += new System.EventHandler(this.tsAddVenda_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // txtNome
            // 
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(103, 30);
            this.txtNome.Text = "Nome da Imagem";
            // 
            // timer
            // 
            this.timer.Interval = 3000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FullViewer
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 515);
            this.Controls.Add(this.bNavigator);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullViewer";
            this.Text = "FullViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FullViewer_FormClosed);
            this.Load += new System.EventHandler(this.FullViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator)).EndInit();
            this.bNavigator.ResumeLayout(false);
            this.bNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingNavigator bNavigator;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton btPlay;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private PictureBox pictureBox1;
        private Timer timer;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator tsSeparator;
        private ToolStripButton btAddVenda;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel txtNome;
        private ToolStripButton btAddSelecionada;
    }
}