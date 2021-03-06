﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Venda.Imagem
{
    partial class Imagem
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
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btAddSelecionada = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btDeleteSelecionada = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btBackup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbSessoes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbPastas = new System.Windows.Forms.ToolStripComboBox();
            this.imgListVenda = new System.Windows.Forms.ImageList(this.components);
            this.lvImagensVenda = new System.Windows.Forms.ListView();
            this.lvImagensSessao = new System.Windows.Forms.ListView();
            this.labelImagensVenda = new System.Windows.Forms.Label();
            this.labelImagensSessao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolstripActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolstripActions);
            this.panel1.Size = new System.Drawing.Size(1277, 39);
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(1251, 533);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelImagensSessao);
            this.tabPage1.Controls.Add(this.labelImagensVenda);
            this.tabPage1.Controls.Add(this.lvImagensSessao);
            this.tabPage1.Controls.Add(this.lvImagensVenda);
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(1243, 507);
            this.tabPage1.Text = "Seleção de Imagens";
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(200, 200);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.btAddSelecionada,
            this.toolStripSeparator2,
            this.btDeleteSelecionada,
            this.toolStripSeparator3,
            this.btBackup,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cbSessoes,
            this.toolStripLabel2,
            this.cbPastas});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(1277, 33);
            this.toolstripActions.TabIndex = 2;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.StatusAnnotations_Play_16xLG;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(115, 20);
            this.toolStripButton1.Text = "Exibir Slide Show";
            this.toolStripButton1.Click += new System.EventHandler(this.slideShow_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // btAddSelecionada
            // 
            this.btAddSelecionada.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.btAddSelecionada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAddSelecionada.Name = "btAddSelecionada";
            this.btAddSelecionada.Size = new System.Drawing.Size(78, 20);
            this.btAddSelecionada.Text = "Adicionar";
            this.btAddSelecionada.Click += new System.EventHandler(this.btAddSelecionada_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btDeleteSelecionada
            // 
            this.btDeleteSelecionada.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.btDeleteSelecionada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDeleteSelecionada.Name = "btDeleteSelecionada";
            this.btDeleteSelecionada.Size = new System.Drawing.Size(74, 20);
            this.btDeleteSelecionada.Text = "Remover";
            this.btDeleteSelecionada.Click += new System.EventHandler(this.btDeleteSelecionada_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // btBackup
            // 
            this.btBackup.Image = global::Canaan.Telas.Properties.Resources.Loop_16xLG;
            this.btBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(118, 20);
            this.btBackup.Text = "Restaurar Backup";
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 20);
            this.toolStripLabel1.Text = "Selecionar Sessão";
            // 
            // cbSessoes
            // 
            this.cbSessoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSessoes.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbSessoes.Name = "cbSessoes";
            this.cbSessoes.Size = new System.Drawing.Size(180, 23);
            this.cbSessoes.SelectedIndexChanged += new System.EventHandler(this.cbSessoes_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(92, 20);
            this.toolStripLabel2.Text = "Selecionar Pasta";
            // 
            // cbPastas
            // 
            this.cbPastas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPastas.DropDownWidth = 180;
            this.cbPastas.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbPastas.Name = "cbPastas";
            this.cbPastas.Size = new System.Drawing.Size(180, 23);
            this.cbPastas.SelectedIndexChanged += new System.EventHandler(this.cbPastas_SelectedIndexChanged);
            // 
            // imgListVenda
            // 
            this.imgListVenda.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListVenda.ImageSize = new System.Drawing.Size(200, 200);
            this.imgListVenda.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvImagensVenda
            // 
            this.lvImagensVenda.AllowDrop = true;
            this.lvImagensVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvImagensVenda.LargeImageList = this.imgListVenda;
            this.lvImagensVenda.Location = new System.Drawing.Point(13, 29);
            this.lvImagensVenda.Name = "lvImagensVenda";
            this.lvImagensVenda.Size = new System.Drawing.Size(272, 465);
            this.lvImagensVenda.TabIndex = 0;
            this.lvImagensVenda.UseCompatibleStateImageBehavior = false;
            this.lvImagensVenda.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvImagensVenda_ItemDrag);
            this.lvImagensVenda.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvImagensVenda_DragDrop);
            this.lvImagensVenda.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvImagensVenda_DragEnter);
            this.lvImagensVenda.DoubleClick += new System.EventHandler(this.lvImagensSelecionadas_DoubleClick);
            // 
            // lvImagensSessao
            // 
            this.lvImagensSessao.AllowDrop = true;
            this.lvImagensSessao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvImagensSessao.LargeImageList = this.imgList;
            this.lvImagensSessao.Location = new System.Drawing.Point(291, 29);
            this.lvImagensSessao.Name = "lvImagensSessao";
            this.lvImagensSessao.Size = new System.Drawing.Size(939, 465);
            this.lvImagensSessao.TabIndex = 1;
            this.lvImagensSessao.UseCompatibleStateImageBehavior = false;
            this.lvImagensSessao.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvImagensSessao_ItemDrag);
            this.lvImagensSessao.SelectedIndexChanged += new System.EventHandler(this.lvImagensSessao_SelectedIndexChanged);
            this.lvImagensSessao.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvImagensSessao_DragDrop);
            this.lvImagensSessao.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvImagensSessao_DragEnter);
            this.lvImagensSessao.DoubleClick += new System.EventHandler(this.lvImagensSessao_DoubleClick);
            // 
            // labelImagensVenda
            // 
            this.labelImagensVenda.AutoSize = true;
            this.labelImagensVenda.Location = new System.Drawing.Point(13, 10);
            this.labelImagensVenda.Name = "labelImagensVenda";
            this.labelImagensVenda.Size = new System.Drawing.Size(114, 13);
            this.labelImagensVenda.TabIndex = 2;
            this.labelImagensVenda.Text = "Imagens Selecionadas";
            // 
            // labelImagensSessao
            // 
            this.labelImagensSessao.AutoSize = true;
            this.labelImagensSessao.Location = new System.Drawing.Point(288, 10);
            this.labelImagensSessao.Name = "labelImagensSessao";
            this.labelImagensSessao.Size = new System.Drawing.Size(100, 13);
            this.labelImagensSessao.TabIndex = 3;
            this.labelImagensSessao.Text = "Imagens da Sessão";
            // 
            // Imagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 600);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Imagem";
            this.Text = "FormImagem";
            this.Load += new System.EventHandler(this.Imagem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected ToolStrip toolstripActions;
        private ToolStripButton toolStripButton1;
        private ToolStripComboBox cbSessoes;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripLabel toolStripLabel1;
        private ImageList imgList;
        private ImageList imgListVenda;
        private Label labelImagensSessao;
        private Label labelImagensVenda;
        public ListView lvImagensSessao;
        public ListView lvImagensVenda;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox cbPastas;
        private ToolStripButton btBackup;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btAddSelecionada;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btDeleteSelecionada;
        private ToolStripSeparator toolStripSeparator3;
    }
}