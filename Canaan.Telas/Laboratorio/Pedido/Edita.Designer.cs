namespace Canaan.Telas.Laboratorio.Pedido
{
    partial class Edita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pedidoWizard = new DevExpress.XtraWizard.WizardControl();
            this.pageInit = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pageProduct = new DevExpress.XtraWizard.WizardPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.tamanhoComboBox = new System.Windows.Forms.ComboBox();
            this.tamanhoLabel = new System.Windows.Forms.Label();
            this.produtosListView = new System.Windows.Forms.ListView();
            this.produtoLabel = new System.Windows.Forms.Label();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.pageFinaliza = new DevExpress.XtraWizard.CompletionWizardPage();
            this.resumoTextBox = new System.Windows.Forms.RichTextBox();
            this.pageComplementos = new DevExpress.XtraWizard.WizardPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.acessoriosDataGrid = new System.Windows.Forms.DataGridView();
            this.Acessorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opcoes = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.acessorioLabel = new System.Windows.Forms.Label();
            this.papelComboBox = new System.Windows.Forms.ComboBox();
            this.papelLabel = new System.Windows.Forms.Label();
            this.pageImagensCapa = new DevExpress.XtraWizard.WizardPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.capaListView = new System.Windows.Forms.ListView();
            this.imagemCapaToolStrip = new System.Windows.Forms.ToolStrip();
            this.imagemCapaAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imagemCapaDelete = new System.Windows.Forms.ToolStripButton();
            this.pageRevestimentos = new DevExpress.XtraWizard.WizardPage();
            this.revestimentosListView = new System.Windows.Forms.ListView();
            this.pageImagensBloco = new DevExpress.XtraWizard.WizardPage();
            this.blocoListView = new System.Windows.Forms.ListView();
            this.imagemBlocoToolStrip = new System.Windows.Forms.ToolStrip();
            this.imagemBlocoAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imagemBlocoDelete = new System.Windows.Forms.ToolStripButton();
            this.pageObservacoes = new DevExpress.XtraWizard.WizardPage();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.produtosImageList = new System.Windows.Forms.ImageList();
            this.revestimentosImageList = new System.Windows.Forms.ImageList();
            this.capaImageList = new System.Windows.Forms.ImageList();
            this.blocoImageList = new System.Windows.Forms.ImageList();
            this.pageImagensEmbalagem = new DevExpress.XtraWizard.WizardPage();
            this.imagemEmbalagemToolStrip = new System.Windows.Forms.ToolStrip();
            this.imagemEmbalagemAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.imagemEmbalagemDelete = new System.Windows.Forms.ToolStripButton();
            this.embalagemImageList = new System.Windows.Forms.ImageList();
            this.embalagemListView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoWizard)).BeginInit();
            this.pedidoWizard.SuspendLayout();
            this.pageInit.SuspendLayout();
            this.pageProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pageFinaliza.SuspendLayout();
            this.pageComplementos.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acessoriosDataGrid)).BeginInit();
            this.pageImagensCapa.SuspendLayout();
            this.panel3.SuspendLayout();
            this.imagemCapaToolStrip.SuspendLayout();
            this.pageRevestimentos.SuspendLayout();
            this.pageImagensBloco.SuspendLayout();
            this.imagemBlocoToolStrip.SuspendLayout();
            this.pageObservacoes.SuspendLayout();
            this.pageImagensEmbalagem.SuspendLayout();
            this.imagemEmbalagemToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pedidoWizard
            // 
            this.pedidoWizard.CancelText = "Cancelar";
            this.pedidoWizard.Controls.Add(this.pageInit);
            this.pedidoWizard.Controls.Add(this.pageProduct);
            this.pedidoWizard.Controls.Add(this.pageFinaliza);
            this.pedidoWizard.Controls.Add(this.pageComplementos);
            this.pedidoWizard.Controls.Add(this.pageImagensCapa);
            this.pedidoWizard.Controls.Add(this.pageRevestimentos);
            this.pedidoWizard.Controls.Add(this.pageImagensBloco);
            this.pedidoWizard.Controls.Add(this.pageObservacoes);
            this.pedidoWizard.Controls.Add(this.pageImagensEmbalagem);
            this.pedidoWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pedidoWizard.Location = new System.Drawing.Point(0, 0);
            this.pedidoWizard.Name = "pedidoWizard";
            this.pedidoWizard.NextText = "Próximo >";
            this.pedidoWizard.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.pageInit,
            this.pageProduct,
            this.pageComplementos,
            this.pageRevestimentos,
            this.pageImagensCapa,
            this.pageImagensEmbalagem,
            this.pageImagensBloco,
            this.pageObservacoes,
            this.pageFinaliza});
            this.pedidoWizard.PreviousText = "< Anterior";
            this.pedidoWizard.Size = new System.Drawing.Size(786, 568);
            this.pedidoWizard.Text = "Pedido de Encadernação Canaan";
            this.pedidoWizard.UseAcceptButton = false;
            this.pedidoWizard.UseCancelButton = false;
            this.pedidoWizard.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.pedidoWizard.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.pedidoWizard_SelectedPageChanged);
            this.pedidoWizard.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.pedidoWizard_SelectedPageChanging);
            this.pedidoWizard.CancelClick += new System.ComponentModel.CancelEventHandler(this.pedidoWizard_CancelClick);
            this.pedidoWizard.FinishClick += new System.ComponentModel.CancelEventHandler(this.pedidoWizard_FinishClick);
            this.pedidoWizard.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.pedidoWizard_NextClick);
            // 
            // pageInit
            // 
            this.pageInit.Controls.Add(this.label1);
            this.pageInit.IntroductionText = "";
            this.pageInit.Name = "pageInit";
            this.pageInit.ProceedText = "";
            this.pageInit.Size = new System.Drawing.Size(726, 400);
            this.pageInit.Text = "Guia Passo a Passo para Criação do Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao Guia de Criação de Pedido Canaan. Clique em Próximo para iniciar a  " +
    "montagem do seu Pedido";
            // 
            // pageProduct
            // 
            this.pageProduct.Controls.Add(this.panel1);
            this.pageProduct.Name = "pageProduct";
            this.pageProduct.Size = new System.Drawing.Size(726, 400);
            this.pageProduct.Text = "Seleção do Produto";
            this.pageProduct.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.pageProduct_PageValidating);
            this.pageProduct.PageCommit += new System.EventHandler(this.pageProduct_PageCommit);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clienteTextBox);
            this.panel1.Controls.Add(this.clienteLabel);
            this.panel1.Controls.Add(this.tamanhoComboBox);
            this.panel1.Controls.Add(this.tamanhoLabel);
            this.panel1.Controls.Add(this.produtosListView);
            this.panel1.Controls.Add(this.produtoLabel);
            this.panel1.Controls.Add(this.categoriaComboBox);
            this.panel1.Controls.Add(this.categoriaLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(726, 400);
            this.panel1.TabIndex = 0;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(13, 36);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(536, 21);
            this.clienteTextBox.TabIndex = 7;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.clienteLabel.Location = new System.Drawing.Point(13, 10);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.clienteLabel.Size = new System.Drawing.Size(165, 23);
            this.clienteLabel.TabIndex = 6;
            this.clienteLabel.Text = "Nome / Descrição do Cliente";
            // 
            // tamanhoComboBox
            // 
            this.tamanhoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tamanhoComboBox.FormattingEnabled = true;
            this.tamanhoComboBox.Location = new System.Drawing.Point(284, 86);
            this.tamanhoComboBox.Name = "tamanhoComboBox";
            this.tamanhoComboBox.Size = new System.Drawing.Size(265, 21);
            this.tamanhoComboBox.TabIndex = 5;
            // 
            // tamanhoLabel
            // 
            this.tamanhoLabel.AutoSize = true;
            this.tamanhoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tamanhoLabel.Location = new System.Drawing.Point(284, 60);
            this.tamanhoLabel.Name = "tamanhoLabel";
            this.tamanhoLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tamanhoLabel.Size = new System.Drawing.Size(127, 23);
            this.tamanhoLabel.TabIndex = 4;
            this.tamanhoLabel.Text = "Selecione o Tamanho";
            // 
            // produtosListView
            // 
            this.produtosListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produtosListView.HideSelection = false;
            this.produtosListView.Location = new System.Drawing.Point(13, 136);
            this.produtosListView.MultiSelect = false;
            this.produtosListView.Name = "produtosListView";
            this.produtosListView.Size = new System.Drawing.Size(700, 251);
            this.produtosListView.TabIndex = 3;
            this.produtosListView.UseCompatibleStateImageBehavior = false;
            this.produtosListView.SelectedIndexChanged += new System.EventHandler(this.produtosListView_SelectedIndexChanged);
            // 
            // produtoLabel
            // 
            this.produtoLabel.AutoSize = true;
            this.produtoLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.produtoLabel.Location = new System.Drawing.Point(13, 110);
            this.produtoLabel.Name = "produtoLabel";
            this.produtoLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.produtoLabel.Size = new System.Drawing.Size(119, 23);
            this.produtoLabel.TabIndex = 2;
            this.produtoLabel.Text = "Selecione o Produto";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(13, 86);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(265, 21);
            this.categoriaComboBox.TabIndex = 1;
            this.categoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriaComboBox_SelectedIndexChanged);
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.categoriaLabel.Location = new System.Drawing.Point(13, 60);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.categoriaLabel.Size = new System.Drawing.Size(129, 23);
            this.categoriaLabel.TabIndex = 0;
            this.categoriaLabel.Text = "Selecione a Categoria";
            // 
            // pageFinaliza
            // 
            this.pageFinaliza.Controls.Add(this.resumoTextBox);
            this.pageFinaliza.Name = "pageFinaliza";
            this.pageFinaliza.Size = new System.Drawing.Size(726, 400);
            this.pageFinaliza.Text = "Conferindo e Finalizando o Pedido";
            this.pageFinaliza.PageCommit += new System.EventHandler(this.pageFinaliza_PageCommit);
            this.pageFinaliza.PageInit += new System.EventHandler(this.pageFinaliza_PageInit);
            // 
            // resumoTextBox
            // 
            this.resumoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resumoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resumoTextBox.Location = new System.Drawing.Point(0, 0);
            this.resumoTextBox.Name = "resumoTextBox";
            this.resumoTextBox.ReadOnly = true;
            this.resumoTextBox.Size = new System.Drawing.Size(726, 400);
            this.resumoTextBox.TabIndex = 0;
            this.resumoTextBox.Text = "";
            // 
            // pageComplementos
            // 
            this.pageComplementos.Controls.Add(this.panel2);
            this.pageComplementos.Name = "pageComplementos";
            this.pageComplementos.Size = new System.Drawing.Size(726, 400);
            this.pageComplementos.Text = "Seleção dos Complementos";
            this.pageComplementos.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.pageComplementos_PageValidating);
            this.pageComplementos.PageCommit += new System.EventHandler(this.pageComplementos_PageCommit);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.acessoriosDataGrid);
            this.panel2.Controls.Add(this.acessorioLabel);
            this.panel2.Controls.Add(this.papelComboBox);
            this.panel2.Controls.Add(this.papelLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(726, 400);
            this.panel2.TabIndex = 0;
            // 
            // acessoriosDataGrid
            // 
            this.acessoriosDataGrid.AllowUserToAddRows = false;
            this.acessoriosDataGrid.AllowUserToDeleteRows = false;
            this.acessoriosDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.acessoriosDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.acessoriosDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.acessoriosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acessoriosDataGrid.ColumnHeadersVisible = false;
            this.acessoriosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Acessorio,
            this.Opcoes});
            this.acessoriosDataGrid.Location = new System.Drawing.Point(13, 86);
            this.acessoriosDataGrid.Name = "acessoriosDataGrid";
            this.acessoriosDataGrid.RowHeadersVisible = false;
            this.acessoriosDataGrid.ShowCellErrors = false;
            this.acessoriosDataGrid.ShowCellToolTips = false;
            this.acessoriosDataGrid.ShowEditingIcon = false;
            this.acessoriosDataGrid.ShowRowErrors = false;
            this.acessoriosDataGrid.Size = new System.Drawing.Size(700, 301);
            this.acessoriosDataGrid.TabIndex = 5;
            // 
            // Acessorio
            // 
            this.Acessorio.HeaderText = "Acessório";
            this.Acessorio.Name = "Acessorio";
            this.Acessorio.ReadOnly = true;
            this.Acessorio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Acessorio.Width = 300;
            // 
            // Opcoes
            // 
            this.Opcoes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Opcoes.HeaderText = "Opcoes";
            this.Opcoes.Name = "Opcoes";
            // 
            // acessorioLabel
            // 
            this.acessorioLabel.AutoSize = true;
            this.acessorioLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.acessorioLabel.Location = new System.Drawing.Point(13, 60);
            this.acessorioLabel.Name = "acessorioLabel";
            this.acessorioLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.acessorioLabel.Size = new System.Drawing.Size(68, 23);
            this.acessorioLabel.TabIndex = 4;
            this.acessorioLabel.Text = "Acessórios";
            // 
            // papelComboBox
            // 
            this.papelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.papelComboBox.FormattingEnabled = true;
            this.papelComboBox.Location = new System.Drawing.Point(16, 36);
            this.papelComboBox.Name = "papelComboBox";
            this.papelComboBox.Size = new System.Drawing.Size(265, 21);
            this.papelComboBox.TabIndex = 3;
            // 
            // papelLabel
            // 
            this.papelLabel.AutoSize = true;
            this.papelLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.papelLabel.Location = new System.Drawing.Point(13, 10);
            this.papelLabel.Name = "papelLabel";
            this.papelLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.papelLabel.Size = new System.Drawing.Size(82, 23);
            this.papelLabel.TabIndex = 2;
            this.papelLabel.Text = "Tipo de Papel";
            // 
            // pageImagensCapa
            // 
            this.pageImagensCapa.Controls.Add(this.panel3);
            this.pageImagensCapa.Controls.Add(this.imagemCapaToolStrip);
            this.pageImagensCapa.Name = "pageImagensCapa";
            this.pageImagensCapa.Size = new System.Drawing.Size(726, 400);
            this.pageImagensCapa.Text = "Seleção das Imagens da Capa";
            this.pageImagensCapa.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.pageImagensCapa_PageValidating);
            this.pageImagensCapa.PageCommit += new System.EventHandler(this.pageImagensCapa_PageCommit);
            this.pageImagensCapa.PageInit += new System.EventHandler(this.pageImagensCapa_PageInit);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.capaListView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 375);
            this.panel3.TabIndex = 1;
            // 
            // capaListView
            // 
            this.capaListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.capaListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capaListView.Location = new System.Drawing.Point(0, 0);
            this.capaListView.Name = "capaListView";
            this.capaListView.Size = new System.Drawing.Size(726, 375);
            this.capaListView.TabIndex = 0;
            this.capaListView.UseCompatibleStateImageBehavior = false;
            // 
            // imagemCapaToolStrip
            // 
            this.imagemCapaToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.imagemCapaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemCapaAdd,
            this.toolStripSeparator1,
            this.imagemCapaDelete});
            this.imagemCapaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.imagemCapaToolStrip.Name = "imagemCapaToolStrip";
            this.imagemCapaToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.imagemCapaToolStrip.Size = new System.Drawing.Size(726, 25);
            this.imagemCapaToolStrip.TabIndex = 0;
            this.imagemCapaToolStrip.Text = "toolStrip1";
            // 
            // imagemCapaAdd
            // 
            this.imagemCapaAdd.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.imagemCapaAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imagemCapaAdd.Name = "imagemCapaAdd";
            this.imagemCapaAdd.Size = new System.Drawing.Size(126, 22);
            this.imagemCapaAdd.Text = "Adicionar Imagens";
            this.imagemCapaAdd.Click += new System.EventHandler(this.imagemCapaAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // imagemCapaDelete
            // 
            this.imagemCapaDelete.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.imagemCapaDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imagemCapaDelete.Name = "imagemCapaDelete";
            this.imagemCapaDelete.Size = new System.Drawing.Size(145, 22);
            this.imagemCapaDelete.Text = "Remover Selecionadas";
            this.imagemCapaDelete.Click += new System.EventHandler(this.imagemCapaDelete_Click);
            // 
            // pageRevestimentos
            // 
            this.pageRevestimentos.Controls.Add(this.revestimentosListView);
            this.pageRevestimentos.Name = "pageRevestimentos";
            this.pageRevestimentos.Size = new System.Drawing.Size(726, 400);
            this.pageRevestimentos.Text = "Selecione o Revestimento";
            this.pageRevestimentos.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.pageRevestimentos_PageValidating);
            this.pageRevestimentos.PageCommit += new System.EventHandler(this.pageRevestimentos_PageCommit);
            this.pageRevestimentos.PageInit += new System.EventHandler(this.pageRevestimentos_PageInit);
            // 
            // revestimentosListView
            // 
            this.revestimentosListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.revestimentosListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.revestimentosListView.HideSelection = false;
            this.revestimentosListView.Location = new System.Drawing.Point(0, 0);
            this.revestimentosListView.Name = "revestimentosListView";
            this.revestimentosListView.Size = new System.Drawing.Size(726, 400);
            this.revestimentosListView.TabIndex = 0;
            this.revestimentosListView.UseCompatibleStateImageBehavior = false;
            // 
            // pageImagensBloco
            // 
            this.pageImagensBloco.Controls.Add(this.blocoListView);
            this.pageImagensBloco.Controls.Add(this.imagemBlocoToolStrip);
            this.pageImagensBloco.Name = "pageImagensBloco";
            this.pageImagensBloco.Size = new System.Drawing.Size(726, 400);
            this.pageImagensBloco.Text = "Selecione as Imagens do Álbum / Foto Produto";
            this.pageImagensBloco.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.pageImagensBloco_PageValidating);
            this.pageImagensBloco.PageCommit += new System.EventHandler(this.pageImagensBloco_PageCommit);
            this.pageImagensBloco.PageInit += new System.EventHandler(this.pageImagensBloco_PageInit);
            // 
            // blocoListView
            // 
            this.blocoListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blocoListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blocoListView.Location = new System.Drawing.Point(0, 25);
            this.blocoListView.Name = "blocoListView";
            this.blocoListView.Size = new System.Drawing.Size(726, 375);
            this.blocoListView.TabIndex = 2;
            this.blocoListView.UseCompatibleStateImageBehavior = false;
            // 
            // imagemBlocoToolStrip
            // 
            this.imagemBlocoToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.imagemBlocoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemBlocoAdd,
            this.toolStripSeparator2,
            this.imagemBlocoDelete});
            this.imagemBlocoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.imagemBlocoToolStrip.Name = "imagemBlocoToolStrip";
            this.imagemBlocoToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.imagemBlocoToolStrip.Size = new System.Drawing.Size(726, 25);
            this.imagemBlocoToolStrip.TabIndex = 1;
            this.imagemBlocoToolStrip.Text = "toolStrip1";
            // 
            // imagemBlocoAdd
            // 
            this.imagemBlocoAdd.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.imagemBlocoAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imagemBlocoAdd.Name = "imagemBlocoAdd";
            this.imagemBlocoAdd.Size = new System.Drawing.Size(126, 22);
            this.imagemBlocoAdd.Text = "Adicionar Imagens";
            this.imagemBlocoAdd.Click += new System.EventHandler(this.imagemBlocoAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // imagemBlocoDelete
            // 
            this.imagemBlocoDelete.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.imagemBlocoDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imagemBlocoDelete.Name = "imagemBlocoDelete";
            this.imagemBlocoDelete.Size = new System.Drawing.Size(145, 22);
            this.imagemBlocoDelete.Text = "Remover Selecionadas";
            this.imagemBlocoDelete.Click += new System.EventHandler(this.imagemBlocoDelete_Click);
            // 
            // pageObservacoes
            // 
            this.pageObservacoes.Controls.Add(this.observacoesTextBox);
            this.pageObservacoes.Name = "pageObservacoes";
            this.pageObservacoes.Size = new System.Drawing.Size(726, 400);
            this.pageObservacoes.Text = "Informe todas as observações sobre o pedido";
            this.pageObservacoes.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.pageObservacoes_PageValidating);
            this.pageObservacoes.PageCommit += new System.EventHandler(this.pageObservacoes_PageCommit);
            this.pageObservacoes.PageInit += new System.EventHandler(this.pageObservacoes_PageInit);
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.observacoesTextBox.Location = new System.Drawing.Point(0, 0);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(726, 400);
            this.observacoesTextBox.TabIndex = 0;
            // 
            // produtosImageList
            // 
            this.produtosImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.produtosImageList.ImageSize = new System.Drawing.Size(150, 150);
            this.produtosImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // revestimentosImageList
            // 
            this.revestimentosImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.revestimentosImageList.ImageSize = new System.Drawing.Size(150, 150);
            this.revestimentosImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // capaImageList
            // 
            this.capaImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.capaImageList.ImageSize = new System.Drawing.Size(150, 150);
            this.capaImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // blocoImageList
            // 
            this.blocoImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.blocoImageList.ImageSize = new System.Drawing.Size(150, 150);
            this.blocoImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pageImagensEmbalagem
            // 
            this.pageImagensEmbalagem.Controls.Add(this.embalagemListView);
            this.pageImagensEmbalagem.Controls.Add(this.imagemEmbalagemToolStrip);
            this.pageImagensEmbalagem.Name = "pageImagensEmbalagem";
            this.pageImagensEmbalagem.Size = new System.Drawing.Size(726, 400);
            this.pageImagensEmbalagem.Text = "Imagens da Embalagem / Maleta";
            this.pageImagensEmbalagem.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.pageImagensEmbalagem_PageValidating);
            this.pageImagensEmbalagem.PageCommit += new System.EventHandler(this.pageImagensEmbalagem_PageCommit);
            this.pageImagensEmbalagem.PageInit += new System.EventHandler(this.pageImagensEmbalagem_PageInit);
            // 
            // imagemEmbalagemToolStrip
            // 
            this.imagemEmbalagemToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.imagemEmbalagemToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemEmbalagemAdd,
            this.toolStripSeparator3,
            this.imagemEmbalagemDelete});
            this.imagemEmbalagemToolStrip.Location = new System.Drawing.Point(0, 0);
            this.imagemEmbalagemToolStrip.Name = "imagemEmbalagemToolStrip";
            this.imagemEmbalagemToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.imagemEmbalagemToolStrip.Size = new System.Drawing.Size(726, 25);
            this.imagemEmbalagemToolStrip.TabIndex = 1;
            this.imagemEmbalagemToolStrip.Text = "toolStrip1";
            // 
            // imagemEmbalagemAdd
            // 
            this.imagemEmbalagemAdd.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.imagemEmbalagemAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imagemEmbalagemAdd.Name = "imagemEmbalagemAdd";
            this.imagemEmbalagemAdd.Size = new System.Drawing.Size(126, 22);
            this.imagemEmbalagemAdd.Text = "Adicionar Imagens";
            this.imagemEmbalagemAdd.Click += new System.EventHandler(this.imagemEmbalagemAdd_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // imagemEmbalagemDelete
            // 
            this.imagemEmbalagemDelete.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.imagemEmbalagemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imagemEmbalagemDelete.Name = "imagemEmbalagemDelete";
            this.imagemEmbalagemDelete.Size = new System.Drawing.Size(145, 22);
            this.imagemEmbalagemDelete.Text = "Remover Selecionadas";
            this.imagemEmbalagemDelete.Click += new System.EventHandler(this.imagemEmbalagemDelete_Click);
            // 
            // embalagemImageList
            // 
            this.embalagemImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.embalagemImageList.ImageSize = new System.Drawing.Size(150, 150);
            this.embalagemImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // embalagemListView
            // 
            this.embalagemListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.embalagemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.embalagemListView.Location = new System.Drawing.Point(0, 25);
            this.embalagemListView.Name = "embalagemListView";
            this.embalagemListView.Size = new System.Drawing.Size(726, 375);
            this.embalagemListView.TabIndex = 2;
            this.embalagemListView.UseCompatibleStateImageBehavior = false;
            // 
            // Edita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 568);
            this.Controls.Add(this.pedidoWizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Edita";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard de Criação de Pedido";
            this.Load += new System.EventHandler(this.Edita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoWizard)).EndInit();
            this.pedidoWizard.ResumeLayout(false);
            this.pageInit.ResumeLayout(false);
            this.pageInit.PerformLayout();
            this.pageProduct.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pageFinaliza.ResumeLayout(false);
            this.pageComplementos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acessoriosDataGrid)).EndInit();
            this.pageImagensCapa.ResumeLayout(false);
            this.pageImagensCapa.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.imagemCapaToolStrip.ResumeLayout(false);
            this.imagemCapaToolStrip.PerformLayout();
            this.pageRevestimentos.ResumeLayout(false);
            this.pageImagensBloco.ResumeLayout(false);
            this.pageImagensBloco.PerformLayout();
            this.imagemBlocoToolStrip.ResumeLayout(false);
            this.imagemBlocoToolStrip.PerformLayout();
            this.pageObservacoes.ResumeLayout(false);
            this.pageObservacoes.PerformLayout();
            this.pageImagensEmbalagem.ResumeLayout(false);
            this.pageImagensEmbalagem.PerformLayout();
            this.imagemEmbalagemToolStrip.ResumeLayout(false);
            this.imagemEmbalagemToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl pedidoWizard;
        private DevExpress.XtraWizard.WelcomeWizardPage pageInit;
        private DevExpress.XtraWizard.WizardPage pageProduct;
        private DevExpress.XtraWizard.CompletionWizardPage pageFinaliza;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraWizard.WizardPage pageComplementos;
        private DevExpress.XtraWizard.WizardPage pageImagensCapa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.Label produtoLabel;
        private System.Windows.Forms.ComboBox tamanhoComboBox;
        private System.Windows.Forms.Label tamanhoLabel;
        private System.Windows.Forms.ListView produtosListView;
        private System.Windows.Forms.ImageList produtosImageList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView acessoriosDataGrid;
        private System.Windows.Forms.ComboBox papelComboBox;
        private System.Windows.Forms.Label papelLabel;
        private DevExpress.XtraWizard.WizardPage pageRevestimentos;
        private System.Windows.Forms.ListView revestimentosListView;
        private System.Windows.Forms.ImageList revestimentosImageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acessorio;
        private System.Windows.Forms.DataGridViewComboBoxColumn Opcoes;
        private DevExpress.XtraWizard.WizardPage pageImagensBloco;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView capaListView;
        private System.Windows.Forms.ToolStrip imagemCapaToolStrip;
        private System.Windows.Forms.ToolStripButton imagemCapaAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton imagemCapaDelete;
        private System.Windows.Forms.ImageList capaImageList;
        private System.Windows.Forms.ListView blocoListView;
        private System.Windows.Forms.ToolStrip imagemBlocoToolStrip;
        private System.Windows.Forms.ToolStripButton imagemBlocoAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton imagemBlocoDelete;
        private System.Windows.Forms.ImageList blocoImageList;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.RichTextBox resumoTextBox;
        private System.Windows.Forms.Label acessorioLabel;
        private DevExpress.XtraWizard.WizardPage pageObservacoes;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private DevExpress.XtraWizard.WizardPage pageImagensEmbalagem;
        private System.Windows.Forms.ListView embalagemListView;
        private System.Windows.Forms.ToolStrip imagemEmbalagemToolStrip;
        private System.Windows.Forms.ToolStripButton imagemEmbalagemAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton imagemEmbalagemDelete;
        private System.Windows.Forms.ImageList embalagemImageList;
    }
}