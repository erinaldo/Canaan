using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Movimentacoes.Consulta.Detalhes
{
    partial class Detalhes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.gridEnvelopes = new System.Windows.Forms.DataGridView();
            this.CodEnvelope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moldura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusEnvelopeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusEnvelope = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.gridParcelas = new System.Windows.Forms.DataGridView();
            this.TipoLancamento = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClasseContabil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbFormaEntrada = new Canaan.Lib.Componentes.CLabel();
            this.cLabel7 = new Canaan.Lib.Componentes.CLabel();
            this.lbIndicacao = new Canaan.Lib.Componentes.CLabel();
            this.lbParceria = new Canaan.Lib.Componentes.CLabel();
            this.lbConvenio = new Canaan.Lib.Componentes.CLabel();
            this.lbFormaPagamento = new Canaan.Lib.Componentes.CLabel();
            this.lbResponsavelFinanceiro = new Canaan.Lib.Componentes.CLabel();
            this.lbVendedora = new Canaan.Lib.Componentes.CLabel();
            this.cLabel6 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel5 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel4 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel3 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel2 = new Canaan.Lib.Componentes.CLabel();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gridMovimentacoes = new System.Windows.Forms.DataGridView();
            this.CodigoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.datagridMotivos = new System.Windows.Forms.DataGridView();
            this.IdMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridDevolucoes = new System.Windows.Forms.DataGridView();
            this.IdMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodAtend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvelopes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParcelas)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentacoes)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMotivos)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucoes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bindingNavigator2);
            this.tabPage1.Controls.Add(this.gridEnvelopes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações do Envelope";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripSeparator7,
            this.toolStripButton5});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 378);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator2.Size = new System.Drawing.Size(842, 25);
            this.bindingNavigator2.TabIndex = 5;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Canaan.Telas.Properties.Resources.Security_Shields_Critical_16xLG;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(182, 22);
            this.toolStripButton4.Text = "Não possui itens no envelope";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Canaan.Telas.Properties.Resources.Security_Shields_Complete_and_ok_16xLG_color;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(157, 22);
            this.toolStripButton5.Text = "Possui itens no envelope";
            // 
            // gridEnvelopes
            // 
            this.gridEnvelopes.AllowUserToAddRows = false;
            this.gridEnvelopes.AllowUserToDeleteRows = false;
            this.gridEnvelopes.AllowUserToResizeColumns = false;
            this.gridEnvelopes.AllowUserToResizeRows = false;
            this.gridEnvelopes.BackgroundColor = System.Drawing.Color.White;
            this.gridEnvelopes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEnvelopes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridEnvelopes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodEnvelope,
            this.Servico,
            this.Album,
            this.Moldura,
            this.Fotos,
            this.StatusEnvelopeItem,
            this.StatusEnvelope});
            this.gridEnvelopes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEnvelopes.Location = new System.Drawing.Point(3, 3);
            this.gridEnvelopes.MultiSelect = false;
            this.gridEnvelopes.Name = "gridEnvelopes";
            this.gridEnvelopes.ReadOnly = true;
            this.gridEnvelopes.RowHeadersVisible = false;
            this.gridEnvelopes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridEnvelopes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEnvelopes.ShowCellErrors = false;
            this.gridEnvelopes.ShowCellToolTips = false;
            this.gridEnvelopes.ShowEditingIcon = false;
            this.gridEnvelopes.ShowRowErrors = false;
            this.gridEnvelopes.Size = new System.Drawing.Size(842, 400);
            this.gridEnvelopes.TabIndex = 3;
            // 
            // CodEnvelope
            // 
            this.CodEnvelope.DataPropertyName = "Codigo";
            this.CodEnvelope.FillWeight = 80F;
            this.CodEnvelope.HeaderText = "Codigo";
            this.CodEnvelope.Name = "CodEnvelope";
            this.CodEnvelope.ReadOnly = true;
            this.CodEnvelope.Width = 70;
            // 
            // Servico
            // 
            this.Servico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Servico.DataPropertyName = "Servico";
            this.Servico.FillWeight = 41.4197F;
            this.Servico.HeaderText = "Serviço";
            this.Servico.Name = "Servico";
            this.Servico.ReadOnly = true;
            // 
            // Album
            // 
            this.Album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Album.DataPropertyName = "Album";
            this.Album.FillWeight = 41.4197F;
            this.Album.HeaderText = "Álbum";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            // 
            // Moldura
            // 
            this.Moldura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Moldura.DataPropertyName = "Moldura";
            this.Moldura.FillWeight = 41.4197F;
            this.Moldura.HeaderText = "Moldura";
            this.Moldura.Name = "Moldura";
            this.Moldura.ReadOnly = true;
            // 
            // Fotos
            // 
            this.Fotos.DataPropertyName = "Fotos";
            this.Fotos.FillWeight = 257.7952F;
            this.Fotos.HeaderText = "Fotos";
            this.Fotos.Name = "Fotos";
            this.Fotos.ReadOnly = true;
            this.Fotos.Width = 70;
            // 
            // StatusEnvelopeItem
            // 
            this.StatusEnvelopeItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusEnvelopeItem.DataPropertyName = "StatusItem";
            this.StatusEnvelopeItem.FillWeight = 41.4197F;
            this.StatusEnvelopeItem.HeaderText = "Status";
            this.StatusEnvelopeItem.Name = "StatusEnvelopeItem";
            this.StatusEnvelopeItem.ReadOnly = true;
            this.StatusEnvelopeItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusEnvelopeItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StatusEnvelope
            // 
            this.StatusEnvelope.DataPropertyName = "Status";
            this.StatusEnvelope.FillWeight = 106.599F;
            this.StatusEnvelope.HeaderText = "";
            this.StatusEnvelope.Name = "StatusEnvelope";
            this.StatusEnvelope.ReadOnly = true;
            this.StatusEnvelope.Width = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridProdutos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produtos Adquiridos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridProdutos
            // 
            this.gridProdutos.AllowUserToAddRows = false;
            this.gridProdutos.AllowUserToDeleteRows = false;
            this.gridProdutos.AllowUserToResizeColumns = false;
            this.gridProdutos.AllowUserToResizeRows = false;
            this.gridProdutos.BackgroundColor = System.Drawing.Color.White;
            this.gridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Quantidade,
            this.Valor});
            this.gridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProdutos.Location = new System.Drawing.Point(3, 3);
            this.gridProdutos.MultiSelect = false;
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.RowHeadersVisible = false;
            this.gridProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.ShowCellErrors = false;
            this.gridProdutos.ShowCellToolTips = false;
            this.gridProdutos.ShowEditingIcon = false;
            this.gridProdutos.ShowRowErrors = false;
            this.gridProdutos.Size = new System.Drawing.Size(842, 400);
            this.gridProdutos.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.FillWeight = 60F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 30;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Produto";
            this.Nome.FillWeight = 140F;
            this.Nome.HeaderText = "Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.FillWeight = 60F;
            this.Quantidade.HeaderText = "Quant";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 80;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 120;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bindingNavigator1);
            this.tabPage3.Controls.Add(this.gridParcelas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(848, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Parcelas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 378);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(842, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.money2;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton1.Text = "Entrada";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.money_envelope;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(70, 22);
            this.toolStripButton2.Text = "Parcelas";
            // 
            // gridParcelas
            // 
            this.gridParcelas.AllowUserToAddRows = false;
            this.gridParcelas.AllowUserToDeleteRows = false;
            this.gridParcelas.AllowUserToResizeColumns = false;
            this.gridParcelas.AllowUserToResizeRows = false;
            this.gridParcelas.BackgroundColor = System.Drawing.Color.White;
            this.gridParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoLancamento,
            this.Cliente,
            this.Tipo,
            this.ClasseContabil,
            this.DataEmissao,
            this.DataVencimento,
            this.ValorOriginal});
            this.gridParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridParcelas.Location = new System.Drawing.Point(3, 3);
            this.gridParcelas.MultiSelect = false;
            this.gridParcelas.Name = "gridParcelas";
            this.gridParcelas.ReadOnly = true;
            this.gridParcelas.RowHeadersVisible = false;
            this.gridParcelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridParcelas.ShowCellErrors = false;
            this.gridParcelas.ShowCellToolTips = false;
            this.gridParcelas.ShowEditingIcon = false;
            this.gridParcelas.ShowRowErrors = false;
            this.gridParcelas.Size = new System.Drawing.Size(842, 400);
            this.gridParcelas.TabIndex = 4;
            // 
            // TipoLancamento
            // 
            this.TipoLancamento.DataPropertyName = "TipoParcela";
            this.TipoLancamento.FillWeight = 30F;
            this.TipoLancamento.HeaderText = "";
            this.TipoLancamento.MinimumWidth = 30;
            this.TipoLancamento.Name = "TipoLancamento";
            this.TipoLancamento.ReadOnly = true;
            this.TipoLancamento.Width = 30;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.FillWeight = 96.8818F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.FillWeight = 96.8818F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // ClasseContabil
            // 
            this.ClasseContabil.DataPropertyName = "ClasseContabil";
            this.ClasseContabil.FillWeight = 96.8818F;
            this.ClasseContabil.HeaderText = "Classe Contabil";
            this.ClasseContabil.Name = "ClasseContabil";
            this.ClasseContabil.ReadOnly = true;
            this.ClasseContabil.Width = 120;
            // 
            // DataEmissao
            // 
            this.DataEmissao.DataPropertyName = "DataEmissao";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.DataEmissao.DefaultCellStyle = dataGridViewCellStyle13;
            this.DataEmissao.FillWeight = 96.8818F;
            this.DataEmissao.HeaderText = "Emissão";
            this.DataEmissao.Name = "DataEmissao";
            this.DataEmissao.ReadOnly = true;
            this.DataEmissao.Width = 80;
            // 
            // DataVencimento
            // 
            this.DataVencimento.DataPropertyName = "DataVencimento";
            dataGridViewCellStyle14.Format = "d";
            this.DataVencimento.DefaultCellStyle = dataGridViewCellStyle14;
            this.DataVencimento.FillWeight = 96.8818F;
            this.DataVencimento.HeaderText = "Vencimento";
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.ReadOnly = true;
            this.DataVencimento.Width = 115;
            // 
            // ValorOriginal
            // 
            this.ValorOriginal.DataPropertyName = "ValorOriginal";
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.ValorOriginal.DefaultCellStyle = dataGridViewCellStyle15;
            this.ValorOriginal.FillWeight = 96.8818F;
            this.ValorOriginal.HeaderText = "Valor Original";
            this.ValorOriginal.Name = "ValorOriginal";
            this.ValorOriginal.ReadOnly = true;
            this.ValorOriginal.Width = 120;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbFormaEntrada);
            this.tabPage4.Controls.Add(this.cLabel7);
            this.tabPage4.Controls.Add(this.lbIndicacao);
            this.tabPage4.Controls.Add(this.lbParceria);
            this.tabPage4.Controls.Add(this.lbConvenio);
            this.tabPage4.Controls.Add(this.lbFormaPagamento);
            this.tabPage4.Controls.Add(this.lbResponsavelFinanceiro);
            this.tabPage4.Controls.Add(this.lbVendedora);
            this.tabPage4.Controls.Add(this.cLabel6);
            this.tabPage4.Controls.Add(this.cLabel5);
            this.tabPage4.Controls.Add(this.cLabel4);
            this.tabPage4.Controls.Add(this.cLabel3);
            this.tabPage4.Controls.Add(this.cLabel2);
            this.tabPage4.Controls.Add(this.cLabel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(848, 406);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Outras Informações";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbFormaEntrada
            // 
            this.lbFormaEntrada.AutoSize = true;
            this.lbFormaEntrada.Location = new System.Drawing.Point(176, 93);
            this.lbFormaEntrada.Name = "lbFormaEntrada";
            this.lbFormaEntrada.Padding = new System.Windows.Forms.Padding(5);
            this.lbFormaEntrada.Size = new System.Drawing.Size(91, 23);
            this.lbFormaEntrada.TabIndex = 13;
            this.lbFormaEntrada.Text = "lbFormaEntrada";
            // 
            // cLabel7
            // 
            this.cLabel7.AutoSize = true;
            this.cLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel7.Location = new System.Drawing.Point(6, 93);
            this.cLabel7.Name = "cLabel7";
            this.cLabel7.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel7.Size = new System.Drawing.Size(117, 23);
            this.cLabel7.TabIndex = 12;
            this.cLabel7.Text = "Forma de Entrada";
            // 
            // lbIndicacao
            // 
            this.lbIndicacao.AutoSize = true;
            this.lbIndicacao.Location = new System.Drawing.Point(176, 167);
            this.lbIndicacao.Name = "lbIndicacao";
            this.lbIndicacao.Padding = new System.Windows.Forms.Padding(5);
            this.lbIndicacao.Size = new System.Drawing.Size(72, 23);
            this.lbIndicacao.TabIndex = 11;
            this.lbIndicacao.Text = "lbIndicacao";
            // 
            // lbParceria
            // 
            this.lbParceria.AutoSize = true;
            this.lbParceria.Location = new System.Drawing.Point(176, 141);
            this.lbParceria.Name = "lbParceria";
            this.lbParceria.Padding = new System.Windows.Forms.Padding(5);
            this.lbParceria.Size = new System.Drawing.Size(64, 23);
            this.lbParceria.TabIndex = 10;
            this.lbParceria.Text = "lbParceria";
            // 
            // lbConvenio
            // 
            this.lbConvenio.AutoSize = true;
            this.lbConvenio.Location = new System.Drawing.Point(176, 117);
            this.lbConvenio.Name = "lbConvenio";
            this.lbConvenio.Padding = new System.Windows.Forms.Padding(5);
            this.lbConvenio.Size = new System.Drawing.Size(70, 23);
            this.lbConvenio.TabIndex = 9;
            this.lbConvenio.Text = "lbConvenio";
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Location = new System.Drawing.Point(176, 69);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Padding = new System.Windows.Forms.Padding(5);
            this.lbFormaPagamento.Size = new System.Drawing.Size(108, 23);
            this.lbFormaPagamento.TabIndex = 8;
            this.lbFormaPagamento.Text = "lbFormaPagamento";
            // 
            // lbResponsavelFinanceiro
            // 
            this.lbResponsavelFinanceiro.AutoSize = true;
            this.lbResponsavelFinanceiro.Location = new System.Drawing.Point(176, 45);
            this.lbResponsavelFinanceiro.Name = "lbResponsavelFinanceiro";
            this.lbResponsavelFinanceiro.Padding = new System.Windows.Forms.Padding(5);
            this.lbResponsavelFinanceiro.Size = new System.Drawing.Size(136, 23);
            this.lbResponsavelFinanceiro.TabIndex = 7;
            this.lbResponsavelFinanceiro.Text = "lbResponsavelFinanceiro";
            // 
            // lbVendedora
            // 
            this.lbVendedora.AutoSize = true;
            this.lbVendedora.Location = new System.Drawing.Point(176, 23);
            this.lbVendedora.Name = "lbVendedora";
            this.lbVendedora.Padding = new System.Windows.Forms.Padding(5);
            this.lbVendedora.Size = new System.Drawing.Size(77, 23);
            this.lbVendedora.TabIndex = 6;
            this.lbVendedora.Text = "lbVendedora";
            // 
            // cLabel6
            // 
            this.cLabel6.AutoSize = true;
            this.cLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel6.Location = new System.Drawing.Point(6, 167);
            this.cLabel6.Name = "cLabel6";
            this.cLabel6.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel6.Size = new System.Drawing.Size(73, 23);
            this.cLabel6.TabIndex = 5;
            this.cLabel6.Text = "Indicação";
            // 
            // cLabel5
            // 
            this.cLabel5.AutoSize = true;
            this.cLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel5.Location = new System.Drawing.Point(6, 141);
            this.cLabel5.Name = "cLabel5";
            this.cLabel5.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel5.Size = new System.Drawing.Size(64, 23);
            this.cLabel5.TabIndex = 4;
            this.cLabel5.Text = "Parceria";
            // 
            // cLabel4
            // 
            this.cLabel4.AutoSize = true;
            this.cLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel4.Location = new System.Drawing.Point(6, 117);
            this.cLabel4.Name = "cLabel4";
            this.cLabel4.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel4.Size = new System.Drawing.Size(70, 23);
            this.cLabel4.TabIndex = 3;
            this.cLabel4.Text = "Convênio";
            // 
            // cLabel3
            // 
            this.cLabel3.AutoSize = true;
            this.cLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel3.Location = new System.Drawing.Point(6, 69);
            this.cLabel3.Name = "cLabel3";
            this.cLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel3.Size = new System.Drawing.Size(136, 23);
            this.cLabel3.TabIndex = 2;
            this.cLabel3.Text = "Forma de Pagamento";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel2.Location = new System.Drawing.Point(6, 45);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel2.Size = new System.Drawing.Size(153, 23);
            this.cLabel2.TabIndex = 1;
            this.cLabel2.Text = "Responsavel Financeiro";
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel1.Location = new System.Drawing.Point(6, 23);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(132, 23);
            this.cLabel1.TabIndex = 0;
            this.cLabel1.Text = "Nome da Vendedora";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gridMovimentacoes);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(848, 406);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Movimentações";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gridMovimentacoes
            // 
            this.gridMovimentacoes.AllowUserToAddRows = false;
            this.gridMovimentacoes.AllowUserToDeleteRows = false;
            this.gridMovimentacoes.AllowUserToResizeColumns = false;
            this.gridMovimentacoes.AllowUserToResizeRows = false;
            this.gridMovimentacoes.BackgroundColor = System.Drawing.Color.White;
            this.gridMovimentacoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMovimentacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMovimentacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoMov,
            this.StatusMov,
            this.DataMov,
            this.UsuarioMov});
            this.gridMovimentacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMovimentacoes.Location = new System.Drawing.Point(3, 3);
            this.gridMovimentacoes.MultiSelect = false;
            this.gridMovimentacoes.Name = "gridMovimentacoes";
            this.gridMovimentacoes.ReadOnly = true;
            this.gridMovimentacoes.RowHeadersVisible = false;
            this.gridMovimentacoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridMovimentacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMovimentacoes.ShowCellErrors = false;
            this.gridMovimentacoes.ShowCellToolTips = false;
            this.gridMovimentacoes.ShowEditingIcon = false;
            this.gridMovimentacoes.ShowRowErrors = false;
            this.gridMovimentacoes.Size = new System.Drawing.Size(842, 400);
            this.gridMovimentacoes.TabIndex = 0;
            // 
            // CodigoMov
            // 
            this.CodigoMov.DataPropertyName = "IdMov";
            this.CodigoMov.HeaderText = "Codigo";
            this.CodigoMov.Name = "CodigoMov";
            this.CodigoMov.ReadOnly = true;
            this.CodigoMov.Width = 80;
            // 
            // StatusMov
            // 
            this.StatusMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StatusMov.DataPropertyName = "Status";
            this.StatusMov.HeaderText = "Status";
            this.StatusMov.Name = "StatusMov";
            this.StatusMov.ReadOnly = true;
            // 
            // DataMov
            // 
            this.DataMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataMov.DataPropertyName = "Data";
            dataGridViewCellStyle16.Format = "g";
            dataGridViewCellStyle16.NullValue = null;
            this.DataMov.DefaultCellStyle = dataGridViewCellStyle16;
            this.DataMov.HeaderText = "Data";
            this.DataMov.Name = "DataMov";
            this.DataMov.ReadOnly = true;
            // 
            // UsuarioMov
            // 
            this.UsuarioMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsuarioMov.DataPropertyName = "Usuario";
            this.UsuarioMov.HeaderText = "Usuário";
            this.UsuarioMov.Name = "UsuarioMov";
            this.UsuarioMov.ReadOnly = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox9);
            this.tabPage6.Controls.Add(this.groupBox5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(848, 406);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Historico de Devoluções";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.datagridMotivos);
            this.groupBox9.Location = new System.Drawing.Point(6, 167);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(836, 231);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Motivos";
            // 
            // datagridMotivos
            // 
            this.datagridMotivos.AllowUserToAddRows = false;
            this.datagridMotivos.AllowUserToDeleteRows = false;
            this.datagridMotivos.AllowUserToResizeColumns = false;
            this.datagridMotivos.AllowUserToResizeRows = false;
            this.datagridMotivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridMotivos.BackgroundColor = System.Drawing.Color.White;
            this.datagridMotivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridMotivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridMotivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMotivo,
            this.Qtdade,
            this.Motivo,
            this.Observacao});
            this.datagridMotivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridMotivos.Location = new System.Drawing.Point(3, 16);
            this.datagridMotivos.MultiSelect = false;
            this.datagridMotivos.Name = "datagridMotivos";
            this.datagridMotivos.ReadOnly = true;
            this.datagridMotivos.RowHeadersVisible = false;
            this.datagridMotivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridMotivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridMotivos.ShowCellErrors = false;
            this.datagridMotivos.ShowCellToolTips = false;
            this.datagridMotivos.ShowEditingIcon = false;
            this.datagridMotivos.ShowRowErrors = false;
            this.datagridMotivos.Size = new System.Drawing.Size(830, 212);
            this.datagridMotivos.TabIndex = 1;
            // 
            // IdMotivo
            // 
            this.IdMotivo.DataPropertyName = "IdMotivoDevolucao";
            this.IdMotivo.HeaderText = "Código Motivo";
            this.IdMotivo.Name = "IdMotivo";
            this.IdMotivo.ReadOnly = true;
            // 
            // Qtdade
            // 
            this.Qtdade.DataPropertyName = "Quantidade";
            this.Qtdade.HeaderText = "Quantidade";
            this.Qtdade.Name = "Qtdade";
            this.Qtdade.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // Observacao
            // 
            this.Observacao.DataPropertyName = "Observacao";
            this.Observacao.FillWeight = 300F;
            this.Observacao.HeaderText = "Observação";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridDevolucoes);
            this.groupBox5.Location = new System.Drawing.Point(6, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(836, 153);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Devoluções";
            // 
            // dataGridDevolucoes
            // 
            this.dataGridDevolucoes.AllowUserToAddRows = false;
            this.dataGridDevolucoes.AllowUserToDeleteRows = false;
            this.dataGridDevolucoes.AllowUserToResizeColumns = false;
            this.dataGridDevolucoes.AllowUserToResizeRows = false;
            this.dataGridDevolucoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDevolucoes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDevolucoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDevolucoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridDevolucoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMov,
            this.StatusDev,
            this.CodAtend,
            this.Data});
            this.dataGridDevolucoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDevolucoes.Location = new System.Drawing.Point(3, 16);
            this.dataGridDevolucoes.MultiSelect = false;
            this.dataGridDevolucoes.Name = "dataGridDevolucoes";
            this.dataGridDevolucoes.ReadOnly = true;
            this.dataGridDevolucoes.RowHeadersVisible = false;
            this.dataGridDevolucoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridDevolucoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDevolucoes.ShowCellErrors = false;
            this.dataGridDevolucoes.ShowCellToolTips = false;
            this.dataGridDevolucoes.ShowEditingIcon = false;
            this.dataGridDevolucoes.ShowRowErrors = false;
            this.dataGridDevolucoes.Size = new System.Drawing.Size(830, 134);
            this.dataGridDevolucoes.TabIndex = 1;
            this.dataGridDevolucoes.SelectionChanged += new System.EventHandler(this.dataGridDevolucoes_SelectionChanged);
            // 
            // IdMov
            // 
            this.IdMov.DataPropertyName = "IdMov";
            this.IdMov.HeaderText = "Código Mov.";
            this.IdMov.Name = "IdMov";
            this.IdMov.ReadOnly = true;
            // 
            // StatusDev
            // 
            this.StatusDev.DataPropertyName = "Status";
            this.StatusDev.HeaderText = "Status Devolução";
            this.StatusDev.Name = "StatusDev";
            this.StatusDev.ReadOnly = true;
            // 
            // CodAtend
            // 
            this.CodAtend.DataPropertyName = "Atendimento";
            this.CodAtend.HeaderText = "Cod. Atendimento";
            this.CodAtend.Name = "CodAtend";
            this.CodAtend.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data Devolução";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Detalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 456);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Detalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes";
            this.Load += new System.EventHandler(this.Detalhes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvelopes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParcelas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMovimentacoes)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridMotivos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView gridEnvelopes;
        protected DataGridView gridProdutos;
        private BindingNavigator bindingNavigator2;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButton5;
        private BindingNavigator bindingNavigator1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private CLabel cLabel2;
        private CLabel cLabel1;
        private CLabel cLabel3;
        private CLabel cLabel6;
        private CLabel cLabel5;
        private CLabel cLabel4;
        private CLabel lbIndicacao;
        private CLabel lbParceria;
        private CLabel lbConvenio;
        private CLabel lbFormaPagamento;
        private CLabel lbResponsavelFinanceiro;
        private CLabel lbVendedora;
        private CLabel cLabel7;
        private CLabel lbFormaEntrada;
        private DataGridViewTextBoxColumn CodEnvelope;
        private DataGridViewTextBoxColumn Servico;
        private DataGridViewTextBoxColumn Album;
        private DataGridViewTextBoxColumn Moldura;
        private DataGridViewTextBoxColumn Fotos;
        private DataGridViewTextBoxColumn StatusEnvelopeItem;
        private DataGridViewImageColumn StatusEnvelope;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewImageColumn TipoLancamento;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn ClasseContabil;
        private DataGridViewTextBoxColumn DataEmissao;
        private DataGridViewTextBoxColumn DataVencimento;
        private DataGridViewTextBoxColumn ValorOriginal;
        private DataGridView gridParcelas;
        private TabPage tabPage6;
        private DataGridView gridMovimentacoes;
        private DataGridViewTextBoxColumn CodigoMov;
        private DataGridViewTextBoxColumn StatusMov;
        private DataGridViewTextBoxColumn DataMov;
        private DataGridViewTextBoxColumn UsuarioMov;
        private GroupBox groupBox9;
        protected DataGridView datagridMotivos;
        private DataGridViewTextBoxColumn IdMotivo;
        private DataGridViewTextBoxColumn Qtdade;
        private DataGridViewTextBoxColumn Motivo;
        private DataGridViewTextBoxColumn Observacao;
        private GroupBox groupBox5;
        protected DataGridView dataGridDevolucoes;
        private DataGridViewTextBoxColumn IdMov;
        private DataGridViewTextBoxColumn StatusDev;
        private DataGridViewTextBoxColumn CodAtend;
        private DataGridViewTextBoxColumn Data;
    }
}