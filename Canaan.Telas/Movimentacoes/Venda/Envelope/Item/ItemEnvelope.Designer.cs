using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope.Item
{
    partial class ItemEnvelope
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEnvelope));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtNomeAbertura = new System.Windows.Forms.TextBox();
            this.cbMoldura = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.lkLabelServico = new System.Windows.Forms.LinkLabel();
            this.cLabel6 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel5 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel3 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel2 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvImgVenda = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvImgEnvelope = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolTipDeleteEfeito = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.txtInfoImagem = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.txtNomeImagem = new Canaan.Lib.Componentes.CLabel();
            this.lkEfeito = new System.Windows.Forms.LinkLabel();
            this.tbInfoQuant = new System.Windows.Forms.NumericUpDown();
            this.cLabel11 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel10 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel9 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel8 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel7 = new Canaan.Lib.Componentes.CLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.imgListVenda = new System.Windows.Forms.ImageList(this.components);
            this.imgListEnvelope = new System.Windows.Forms.ImageList(this.components);
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.btnInsert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActions = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltros = new System.Windows.Forms.ToolStripSplitButton();
            this.cLabel4 = new Canaan.Lib.Componentes.CLabel();
            this.cQuantidade = new Canaan.Lib.Componentes.CLabel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTipDeleteEfeito)).BeginInit();
            this.toolTipDeleteEfeito.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInfoQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.toolstripActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolstripActions);
            this.panel1.Size = new System.Drawing.Size(1190, 39);
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(1164, 620);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cQuantidade);
            this.tabPage1.Controls.Add(this.cLabel4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Size = new System.Drawing.Size(1156, 594);
            this.tabPage1.Text = "Dados do Envelope";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.txtNomeAbertura);
            this.groupBox1.Controls.Add(this.cbMoldura);
            this.groupBox1.Controls.Add(this.cbAlbum);
            this.groupBox1.Controls.Add(this.lkLabelServico);
            this.groupBox1.Controls.Add(this.cLabel6);
            this.groupBox1.Controls.Add(this.cLabel5);
            this.groupBox1.Controls.Add(this.cLabel3);
            this.groupBox1.Controls.Add(this.cLabel2);
            this.groupBox1.Controls.Add(this.cLabel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(533, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Envelope";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(94, 139);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(419, 78);
            this.txtObservacao.TabIndex = 11;
            // 
            // txtNomeAbertura
            // 
            this.txtNomeAbertura.Location = new System.Drawing.Point(94, 112);
            this.txtNomeAbertura.Name = "txtNomeAbertura";
            this.txtNomeAbertura.Size = new System.Drawing.Size(419, 20);
            this.txtNomeAbertura.TabIndex = 10;
            // 
            // cbMoldura
            // 
            this.cbMoldura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoldura.FormattingEnabled = true;
            this.cbMoldura.Location = new System.Drawing.Point(94, 82);
            this.cbMoldura.Name = "cbMoldura";
            this.cbMoldura.Size = new System.Drawing.Size(419, 21);
            this.cbMoldura.TabIndex = 8;
            // 
            // cbAlbum
            // 
            this.cbAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(94, 55);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(419, 21);
            this.cbAlbum.TabIndex = 7;
            // 
            // lkLabelServico
            // 
            this.lkLabelServico.AutoSize = true;
            this.lkLabelServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLabelServico.Location = new System.Drawing.Point(92, 27);
            this.lkLabelServico.Name = "lkLabelServico";
            this.lkLabelServico.Size = new System.Drawing.Size(72, 17);
            this.lkLabelServico.TabIndex = 6;
            this.lkLabelServico.TabStop = true;
            this.lkLabelServico.Text = "linkLabel1";
            this.lkLabelServico.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLabelServico_LinkClicked);
            // 
            // cLabel6
            // 
            this.cLabel6.AutoSize = true;
            this.cLabel6.Location = new System.Drawing.Point(8, 137);
            this.cLabel6.Name = "cLabel6";
            this.cLabel6.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel6.Size = new System.Drawing.Size(80, 23);
            this.cLabel6.TabIndex = 5;
            this.cLabel6.Text = "Observações";
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.Location = new System.Drawing.Point(8, 109);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel5.Size = new System.Drawing.Size(88, 23);
            this.cLabel5.TabIndex = 4;
            this.cLabel5.Text = "Nome Abertura";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.Location = new System.Drawing.Point(8, 80);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel3.Size = new System.Drawing.Size(55, 23);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "Moldura";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.Location = new System.Drawing.Point(8, 53);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel2.Size = new System.Drawing.Size(46, 23);
            this.cLabel2.TabIndex = 1;
            this.cLabel2.Text = "Álbum";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(8, 23);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(53, 23);
            this.cLabel1.TabIndex = 0;
            this.cLabel1.Text = "Serviço";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvImgVenda);
            this.groupBox2.Location = new System.Drawing.Point(13, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(533, 259);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagens da Venda";
            // 
            // lvImgVenda
            // 
            this.lvImgVenda.AllowDrop = true;
            this.lvImgVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvImgVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvImgVenda.Location = new System.Drawing.Point(5, 18);
            this.lvImgVenda.Name = "lvImgVenda";
            this.lvImgVenda.Size = new System.Drawing.Size(523, 236);
            this.lvImgVenda.TabIndex = 0;
            this.lvImgVenda.UseCompatibleStateImageBehavior = false;
            this.lvImgVenda.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvImgVenda_ItemDrag);
            this.lvImgVenda.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvImgVenda_DragDrop);
            this.lvImgVenda.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvImgVenda_DragEnter);
            this.lvImgVenda.DoubleClick += new System.EventHandler(this.lvImgVenda_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvImgEnvelope);
            this.groupBox3.Location = new System.Drawing.Point(552, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(584, 236);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagens do Envelope";
            // 
            // lvImgEnvelope
            // 
            this.lvImgEnvelope.AllowDrop = true;
            this.lvImgEnvelope.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvImgEnvelope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvImgEnvelope.Location = new System.Drawing.Point(5, 18);
            this.lvImgEnvelope.Name = "lvImgEnvelope";
            this.lvImgEnvelope.Size = new System.Drawing.Size(574, 213);
            this.lvImgEnvelope.TabIndex = 0;
            this.lvImgEnvelope.UseCompatibleStateImageBehavior = false;
            this.lvImgEnvelope.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvImgEnvelope_ItemDrag);
            this.lvImgEnvelope.SelectedIndexChanged += new System.EventHandler(this.lvImgEnvelope_SelectedIndexChanged);
            this.lvImgEnvelope.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvImgEnvelope_DragDrop);
            this.lvImgEnvelope.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvImgEnvelope_DragEnter);
            this.lvImgEnvelope.DoubleClick += new System.EventHandler(this.lvImgEnvelope_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.toolTipDeleteEfeito);
            this.groupBox4.Controls.Add(this.txtInfoImagem);
            this.groupBox4.Controls.Add(this.toolStrip1);
            this.groupBox4.Controls.Add(this.txtNomeImagem);
            this.groupBox4.Controls.Add(this.lkEfeito);
            this.groupBox4.Controls.Add(this.tbInfoQuant);
            this.groupBox4.Controls.Add(this.cLabel11);
            this.groupBox4.Controls.Add(this.cLabel10);
            this.groupBox4.Controls.Add(this.cLabel9);
            this.groupBox4.Controls.Add(this.cLabel8);
            this.groupBox4.Controls.Add(this.cLabel7);
            this.groupBox4.Controls.Add(this.picBox);
            this.groupBox4.Location = new System.Drawing.Point(552, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(584, 294);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Imagens do Envelope";
            // 
            // toolTipDeleteEfeito
            // 
            this.toolTipDeleteEfeito.AddNewItem = null;
            this.toolTipDeleteEfeito.CountItem = null;
            this.toolTipDeleteEfeito.DeleteItem = null;
            this.toolTipDeleteEfeito.Dock = System.Windows.Forms.DockStyle.None;
            this.toolTipDeleteEfeito.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolTipDeleteEfeito.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3});
            this.toolTipDeleteEfeito.Location = new System.Drawing.Point(260, 235);
            this.toolTipDeleteEfeito.MoveFirstItem = null;
            this.toolTipDeleteEfeito.MoveLastItem = null;
            this.toolTipDeleteEfeito.MoveNextItem = null;
            this.toolTipDeleteEfeito.MovePreviousItem = null;
            this.toolTipDeleteEfeito.Name = "toolTipDeleteEfeito";
            this.toolTipDeleteEfeito.PositionItem = null;
            this.toolTipDeleteEfeito.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolTipDeleteEfeito.Size = new System.Drawing.Size(26, 25);
            this.toolTipDeleteEfeito.TabIndex = 33;
            this.toolTipDeleteEfeito.Text = "bindingNavigator1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.btRemoveEfeito_Click);
            // 
            // txtInfoImagem
            // 
            this.txtInfoImagem.Location = new System.Drawing.Point(147, 84);
            this.txtInfoImagem.Multiline = true;
            this.txtInfoImagem.Name = "txtInfoImagem";
            this.txtInfoImagem.Size = new System.Drawing.Size(429, 84);
            this.txtInfoImagem.TabIndex = 32;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripSeparator3,
            this.toolStripSplitButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(5, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(574, 33);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 20);
            this.toolStripButton1.Text = "Salvar";
            this.toolStripButton1.Click += new System.EventHandler(this.atualizarServico_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(61, 20);
            this.toolStripButton2.Text = "Excluir";
            this.toolStripButton2.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(109, 20);
            this.toolStripSplitButton1.Text = "Outras Ações";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(71, 20);
            this.toolStripSplitButton2.Text = "Filtros";
            // 
            // txtNomeImagem
            // 
            this.txtNomeImagem.AutoSize = true;
            this.txtNomeImagem.Location = new System.Drawing.Point(139, 208);
            this.txtNomeImagem.Name = "txtNomeImagem";
            this.txtNomeImagem.Padding = new System.Windows.Forms.Padding(5);
            this.txtNomeImagem.Size = new System.Drawing.Size(85, 23);
            this.txtNomeImagem.TabIndex = 29;
            this.txtNomeImagem.Text = "Nome Imagem";
            // 
            // lkEfeito
            // 
            this.lkEfeito.AutoSize = true;
            this.lkEfeito.Location = new System.Drawing.Point(144, 241);
            this.lkEfeito.Name = "lkEfeito";
            this.lkEfeito.Size = new System.Drawing.Size(113, 13);
            this.lkEfeito.TabIndex = 28;
            this.lkEfeito.TabStop = true;
            this.lkEfeito.Text = "Selecione efeito digital";
            this.lkEfeito.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEfeito_LinkClicked);
            // 
            // tbInfoQuant
            // 
            this.tbInfoQuant.Location = new System.Drawing.Point(147, 267);
            this.tbInfoQuant.Name = "tbInfoQuant";
            this.tbInfoQuant.Size = new System.Drawing.Size(67, 20);
            this.tbInfoQuant.TabIndex = 27;
            // 
            // cLabel11
            // 
            this.cLabel11.AutoSize = true;
            this.cLabel11.Location = new System.Drawing.Point(8, 264);
            this.cLabel11.Name = "cLabel11";
            this.cLabel11.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel11.Size = new System.Drawing.Size(72, 23);
            this.cLabel11.TabIndex = 17;
            this.cLabel11.Text = "Quantidade";
            // 
            // cLabel10
            // 
            this.cLabel10.AutoSize = true;
            this.cLabel10.Location = new System.Drawing.Point(7, 235);
            this.cLabel10.Name = "cLabel10";
            this.cLabel10.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel10.Size = new System.Drawing.Size(76, 23);
            this.cLabel10.TabIndex = 16;
            this.cLabel10.Text = "Efeito Digital";
            // 
            // cLabel9
            // 
            this.cLabel9.AutoSize = true;
            this.cLabel9.Location = new System.Drawing.Point(6, 208);
            this.cLabel9.Name = "cLabel9";
            this.cLabel9.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel9.Size = new System.Drawing.Size(100, 23);
            this.cLabel9.TabIndex = 15;
            this.cLabel9.Text = "Nome da Imagem";
            // 
            // cLabel8
            // 
            this.cLabel8.AutoSize = true;
            this.cLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel8.Location = new System.Drawing.Point(5, 183);
            this.cLabel8.Name = "cLabel8";
            this.cLabel8.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel8.Size = new System.Drawing.Size(151, 23);
            this.cLabel8.TabIndex = 14;
            this.cLabel8.Text = "Informações da Imagem";
            // 
            // cLabel7
            // 
            this.cLabel7.AutoSize = true;
            this.cLabel7.Location = new System.Drawing.Point(140, 58);
            this.cLabel7.Name = "cLabel7";
            this.cLabel7.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel7.Size = new System.Drawing.Size(130, 23);
            this.cLabel7.TabIndex = 13;
            this.cLabel7.Text = "Informações da Imagem";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(8, 68);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(100, 100);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // imgListVenda
            // 
            this.imgListVenda.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListVenda.ImageSize = new System.Drawing.Size(100, 100);
            this.imgListVenda.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imgListEnvelope
            // 
            this.imgListEnvelope.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListEnvelope.ImageSize = new System.Drawing.Size(100, 100);
            this.imgListEnvelope.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.toolStripSeparator1,
            this.btnActions,
            this.toolStripSeparator4,
            this.btnFiltros});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(1190, 33);
            this.toolstripActions.TabIndex = 2;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(58, 20);
            this.btnInsert.Text = "Salvar";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnActions
            // 
            this.btnActions.Image = ((System.Drawing.Image)(resources.GetObject("btnActions.Image")));
            this.btnActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActions.Name = "btnActions";
            this.btnActions.Size = new System.Drawing.Size(109, 20);
            this.btnActions.Text = "Outras Ações";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnFiltros
            // 
            this.btnFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltros.Image")));
            this.btnFiltros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(71, 20);
            this.btnFiltros.Text = "Filtros";
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.Location = new System.Drawing.Point(552, 553);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel4.Size = new System.Drawing.Size(119, 23);
            this.cLabel4.TabIndex = 15;
            this.cLabel4.Text = "Fotos Selecionadas : ";
            // 
            // cQuantidade
            // 
            this.cQuantidade.AutoSize = true;
            this.cQuantidade.Location = new System.Drawing.Point(664, 553);
            this.cQuantidade.Name = "cQuantidade";
            this.cQuantidade.Padding = new System.Windows.Forms.Padding(5);
            this.cQuantidade.Size = new System.Drawing.Size(61, 23);
            this.cQuantidade.TabIndex = 16;
            this.cQuantidade.Text = "cLabel12";
            // 
            // ItemEnvelope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 687);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemEnvelope";
            this.Text = "ItemEnvelope";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.ItemEnvelope_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toolTipDeleteEfeito)).EndInit();
            this.toolTipDeleteEfeito.ResumeLayout(false);
            this.toolTipDeleteEfeito.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInfoQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CLabel cLabel1;
        private CLabel cLabel2;
        private CLabel cLabel3;
        private CLabel cLabel5;
        private CLabel cLabel6;
        private LinkLabel lkLabelServico;
        private ComboBox cbMoldura;
        private TextBox txtObservacao;
        private TextBox txtNomeAbertura;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private PictureBox picBox;
        private CLabel cLabel7;
        private CLabel cLabel11;
        private CLabel cLabel10;
        private CLabel cLabel9;
        private CLabel cLabel8;
        private NumericUpDown tbInfoQuant;
        private ComboBox cbAlbum;
        private LinkLabel lkEfeito;
        private CLabel txtNomeImagem;
        private ImageList imgListVenda;
        private ImageList imgListEnvelope;
        private ListView lvImgEnvelope;
        private ListView lvImgVenda;
        protected ToolStrip toolstripActions;
        protected ToolStripButton btnInsert;
        private ToolStripSeparator toolStripSeparator1;
        protected ToolStripSplitButton btnActions;
        private ToolStripSeparator toolStripSeparator4;
        protected ToolStripSplitButton btnFiltros;
        protected ToolStrip toolStrip1;
        protected ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator2;
        protected ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSeparator toolStripSeparator3;
        protected ToolStripSplitButton toolStripSplitButton2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton2;
        private TextBox txtInfoImagem;
        private BindingNavigator toolTipDeleteEfeito;
        private ToolStripButton toolStripButton3;
        private CLabel cLabel4;
        private CLabel cQuantidade;

    }
}