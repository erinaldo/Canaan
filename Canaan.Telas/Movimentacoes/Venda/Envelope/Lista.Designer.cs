using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Venda.Envelope
{
    partial class Lista
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
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolstripActionsProduto = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnovoProduto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarProduto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btExcluirProduto = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.datagridEnvelope = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serviço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolstripActions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolstripActionsProduto)).BeginInit();
            this.toolstripActionsProduto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEnvelope)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolstripActions);
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(964, 419);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Size = new System.Drawing.Size(956, 393);
            this.tabPage1.Text = "Lista de Envelopes";
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripSeparator8});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(990, 33);
            this.toolstripActions.TabIndex = 1;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(93, 20);
            this.toolStripButton6.Text = "Salvar Venda";
            this.toolStripButton6.Click += new System.EventHandler(this.btSalvarVenda_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dataGridProduto);
            this.groupBox1.Controls.Add(this.toolstripActionsProduto);
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(459, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos Selecionados";
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.AllowUserToAddRows = false;
            this.dataGridProduto.AllowUserToDeleteRows = false;
            this.dataGridProduto.AllowUserToResizeColumns = false;
            this.dataGridProduto.AllowUserToResizeRows = false;
            this.dataGridProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Quantidade,
            this.Valor});
            this.dataGridProduto.Location = new System.Drawing.Point(8, 46);
            this.dataGridProduto.MultiSelect = false;
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.ReadOnly = true;
            this.dataGridProduto.RowHeadersVisible = false;
            this.dataGridProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduto.ShowCellErrors = false;
            this.dataGridProduto.ShowCellToolTips = false;
            this.dataGridProduto.ShowEditingIcon = false;
            this.dataGridProduto.ShowRowErrors = false;
            this.dataGridProduto.Size = new System.Drawing.Size(389, 316);
            this.dataGridProduto.TabIndex = 2;
            this.dataGridProduto.SelectionChanged += new System.EventHandler(this.dataGridProduto_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.FillWeight = 60F;
            this.Codigo.HeaderText = "Cod";
            this.Codigo.MinimumWidth = 30;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nome
            // 
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
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // toolstripActionsProduto
            // 
            this.toolstripActionsProduto.AddNewItem = null;
            this.toolstripActionsProduto.CountItem = null;
            this.toolstripActionsProduto.DeleteItem = null;
            this.toolstripActionsProduto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActionsProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnovoProduto,
            this.toolStripSeparator3,
            this.btnEditarProduto,
            this.toolStripSeparator6,
            this.btExcluirProduto});
            this.toolstripActionsProduto.Location = new System.Drawing.Point(5, 18);
            this.toolstripActionsProduto.MoveFirstItem = null;
            this.toolstripActionsProduto.MoveLastItem = null;
            this.toolstripActionsProduto.MoveNextItem = null;
            this.toolstripActionsProduto.MovePreviousItem = null;
            this.toolstripActionsProduto.Name = "toolstripActionsProduto";
            this.toolstripActionsProduto.PositionItem = null;
            this.toolstripActionsProduto.Size = new System.Drawing.Size(449, 25);
            this.toolstripActionsProduto.TabIndex = 3;
            this.toolstripActionsProduto.Text = "toolstripActionsProduto";
            // 
            // btnovoProduto
            // 
            this.btnovoProduto.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.btnovoProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnovoProduto.Name = "btnovoProduto";
            this.btnovoProduto.Size = new System.Drawing.Size(102, 22);
            this.btnovoProduto.Text = "Novo Produto";
            this.btnovoProduto.Click += new System.EventHandler(this.novoProduto_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Image = global::Canaan.Telas.Properties.Resources.pencil_005_16xLG;
            this.btnEditarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(103, 22);
            this.btnEditarProduto.Text = "Editar Produto";
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btExcluirProduto
            // 
            this.btExcluirProduto.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.btExcluirProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExcluirProduto.Name = "btExcluirProduto";
            this.btExcluirProduto.Size = new System.Drawing.Size(107, 22);
            this.btExcluirProduto.Text = "Excluir Produto";
            this.btExcluirProduto.Click += new System.EventHandler(this.btExcluirProduto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bindingNavigator1);
            this.groupBox2.Controls.Add(this.bindingNavigator2);
            this.groupBox2.Controls.Add(this.datagridEnvelope);
            this.groupBox2.Location = new System.Drawing.Point(471, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 370);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envelopes";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator9,
            this.toolStripButton2,
            this.toolStripSeparator10,
            this.toolStripButton3});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(473, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 22);
            this.toolStripButton1.Text = "Novo Envelope";
            this.toolStripButton1.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.folder_Open_16xLG;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(108, 22);
            this.toolStripButton2.Text = "Editar Envelope";
            this.toolStripButton2.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton3.Text = "Excluir Envelope";
            this.toolStripButton3.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 342);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator2.Size = new System.Drawing.Size(473, 25);
            this.bindingNavigator2.TabIndex = 3;
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
            // datagridEnvelope
            // 
            this.datagridEnvelope.AllowUserToAddRows = false;
            this.datagridEnvelope.AllowUserToDeleteRows = false;
            this.datagridEnvelope.AllowUserToResizeColumns = false;
            this.datagridEnvelope.AllowUserToResizeRows = false;
            this.datagridEnvelope.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridEnvelope.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridEnvelope.BackgroundColor = System.Drawing.Color.White;
            this.datagridEnvelope.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridEnvelope.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridEnvelope.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Serviço,
            this.Status});
            this.datagridEnvelope.Location = new System.Drawing.Point(6, 44);
            this.datagridEnvelope.MultiSelect = false;
            this.datagridEnvelope.Name = "datagridEnvelope";
            this.datagridEnvelope.ReadOnly = true;
            this.datagridEnvelope.RowHeadersVisible = false;
            this.datagridEnvelope.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridEnvelope.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridEnvelope.ShowCellErrors = false;
            this.datagridEnvelope.ShowCellToolTips = false;
            this.datagridEnvelope.ShowEditingIcon = false;
            this.datagridEnvelope.ShowRowErrors = false;
            this.datagridEnvelope.Size = new System.Drawing.Size(467, 295);
            this.datagridEnvelope.TabIndex = 5;
            this.datagridEnvelope.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.datagridEnvelope_DataBindingComplete);
            this.datagridEnvelope.SelectionChanged += new System.EventHandler(this.datagridEnvelope_SelectionChanged);
            this.datagridEnvelope.DoubleClick += new System.EventHandler(this.datagridEnvelope_DoubleClick);
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "Codigo";
            this.Cod.FillWeight = 52.78625F;
            this.Cod.HeaderText = "Código";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // Serviço
            // 
            this.Serviço.DataPropertyName = "Servico";
            this.Serviço.FillWeight = 102.4053F;
            this.Serviço.HeaderText = "Serviço";
            this.Serviço.Name = "Serviço";
            this.Serviço.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 50F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 50;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 506);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolstripActionsProduto)).EndInit();
            this.toolstripActionsProduto.ResumeLayout(false);
            this.toolstripActionsProduto.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEnvelope)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected ToolStrip toolstripActions;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        protected DataGridView datagridEnvelope;
        protected DataGridView dataGridProduto;
        private BindingNavigator toolstripActionsProduto;
        private ToolStripButton btnovoProduto;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btExcluirProduto;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Valor;
        private ToolStripButton btnEditarProduto;
        private ToolStripSeparator toolStripSeparator6;
        private BindingNavigator bindingNavigator2;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButton5;
        private DataGridViewTextBoxColumn Cod;
        private DataGridViewTextBoxColumn Serviço;
        private DataGridViewImageColumn Status;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator8;
        private BindingNavigator bindingNavigator1;
        protected ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator9;
        protected ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator10;
        protected ToolStripButton toolStripButton3;
    }
}