using System.ComponentModel;
using System.Windows.Forms;
using Canaan.Lib.Componentes;

namespace Canaan.Telas.Configuracoes.Pedido.Status
{
    partial class StatusServico
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
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.btnInsert = new System.Windows.Forms.ToolStripButton();
            this.separatorNovo = new System.Windows.Forms.ToolStripSeparator();
            this.btnActions = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFiltros = new System.Windows.Forms.ToolStripSplitButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridServicos = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CodEnvelope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moldura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridVendas = new System.Windows.Forms.DataGridView();
            this.CodPacote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cLabel2 = new Canaan.Lib.Componentes.CLabel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cLabel1 = new Canaan.Lib.Componentes.CLabel();
            this.toolstripActions.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.separatorNovo,
            this.btnActions,
            this.toolStripSeparator4,
            this.btnFiltros});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(812, 33);
            this.toolstripActions.TabIndex = 2;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::Canaan.Telas.Properties.Resources.arrow_Down_16xLG;
            this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(97, 20);
            this.btnInsert.Text = "Mudar Status";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // separatorNovo
            // 
            this.separatorNovo.Name = "separatorNovo";
            this.separatorNovo.Size = new System.Drawing.Size(6, 23);
            // 
            // btnActions
            // 
            this.btnActions.Image = global::Canaan.Telas.Properties.Resources.gear_16xLG;
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
            this.btnFiltros.Image = global::Canaan.Telas.Properties.Resources.filter_16xLG;
            this.btnFiltros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(71, 20);
            this.btnFiltros.Text = "Filtros";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 435);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mudança de Status";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridServicos);
            this.groupBox3.Location = new System.Drawing.Point(6, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 201);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviços";
            // 
            // dataGridServicos
            // 
            this.dataGridServicos.AllowUserToAddRows = false;
            this.dataGridServicos.AllowUserToDeleteRows = false;
            this.dataGridServicos.AllowUserToResizeColumns = false;
            this.dataGridServicos.AllowUserToResizeRows = false;
            this.dataGridServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridServicos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridServicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.CodEnvelope,
            this.Servico,
            this.Album,
            this.Moldura,
            this.Status});
            this.dataGridServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridServicos.Location = new System.Drawing.Point(3, 16);
            this.dataGridServicos.MultiSelect = false;
            this.dataGridServicos.Name = "dataGridServicos";
            this.dataGridServicos.RowHeadersVisible = false;
            this.dataGridServicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridServicos.ShowCellErrors = false;
            this.dataGridServicos.ShowCellToolTips = false;
            this.dataGridServicos.ShowEditingIcon = false;
            this.dataGridServicos.ShowRowErrors = false;
            this.dataGridServicos.Size = new System.Drawing.Size(761, 182);
            this.dataGridServicos.TabIndex = 1;
            this.dataGridServicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridServicos_CellContentClick);
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selecionado";
            this.Selected.FillWeight = 30F;
            this.Selected.HeaderText = "";
            this.Selected.Name = "Selected";
            // 
            // CodEnvelope
            // 
            this.CodEnvelope.DataPropertyName = "CodOrdem";
            this.CodEnvelope.HeaderText = "Cód. Envelope";
            this.CodEnvelope.Name = "CodEnvelope";
            this.CodEnvelope.ReadOnly = true;
            // 
            // Servico
            // 
            this.Servico.DataPropertyName = "Servico";
            this.Servico.FillWeight = 230F;
            this.Servico.HeaderText = "Serviço";
            this.Servico.Name = "Servico";
            this.Servico.ReadOnly = true;
            // 
            // Album
            // 
            this.Album.DataPropertyName = "Album";
            this.Album.HeaderText = "Álbum";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            // 
            // Moldura
            // 
            this.Moldura.DataPropertyName = "Moldura";
            this.Moldura.HeaderText = "Moldura";
            this.Moldura.Name = "Moldura";
            this.Moldura.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridVendas);
            this.groupBox2.Location = new System.Drawing.Point(6, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 138);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendas";
            // 
            // dataGridVendas
            // 
            this.dataGridVendas.AllowUserToAddRows = false;
            this.dataGridVendas.AllowUserToDeleteRows = false;
            this.dataGridVendas.AllowUserToResizeColumns = false;
            this.dataGridVendas.AllowUserToResizeRows = false;
            this.dataGridVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVendas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPacote,
            this.CodVenda,
            this.Cliente,
            this.DataVenda,
            this.DataEnvio,
            this.DataRecebimento});
            this.dataGridVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVendas.Location = new System.Drawing.Point(3, 16);
            this.dataGridVendas.MultiSelect = false;
            this.dataGridVendas.Name = "dataGridVendas";
            this.dataGridVendas.ReadOnly = true;
            this.dataGridVendas.RowHeadersVisible = false;
            this.dataGridVendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVendas.ShowCellErrors = false;
            this.dataGridVendas.ShowCellToolTips = false;
            this.dataGridVendas.ShowEditingIcon = false;
            this.dataGridVendas.ShowRowErrors = false;
            this.dataGridVendas.Size = new System.Drawing.Size(761, 119);
            this.dataGridVendas.TabIndex = 1;
            this.dataGridVendas.SelectionChanged += new System.EventHandler(this.dataGridVendas_SelectionChanged);
            // 
            // CodPacote
            // 
            this.CodPacote.DataPropertyName = "CodigoReduzido";
            this.CodPacote.HeaderText = "Cód. Pacote";
            this.CodPacote.Name = "CodPacote";
            this.CodPacote.ReadOnly = true;
            // 
            // CodVenda
            // 
            this.CodVenda.DataPropertyName = "IdVenda";
            this.CodVenda.HeaderText = "Cód. Venda";
            this.CodVenda.Name = "CodVenda";
            this.CodVenda.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.FillWeight = 230F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // DataVenda
            // 
            this.DataVenda.DataPropertyName = "DataVenda";
            this.DataVenda.HeaderText = "Data Venda";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            // 
            // DataEnvio
            // 
            this.DataEnvio.DataPropertyName = "DataLiberacao";
            this.DataEnvio.HeaderText = "Data Envio";
            this.DataEnvio.Name = "DataEnvio";
            this.DataEnvio.ReadOnly = true;
            // 
            // DataRecebimento
            // 
            this.DataRecebimento.HeaderText = "DataRecebimento";
            this.DataRecebimento.Name = "DataRecebimento";
            this.DataRecebimento.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cLabel2);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.cLabel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // cLabel2
            // 
            this.cLabel2.AutoSize = true;
            this.cLabel2.Location = new System.Drawing.Point(322, 25);
            this.cLabel2.Name = "cLabel2";
            this.cLabel2.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel2.Size = new System.Drawing.Size(76, 23);
            this.cLabel2.TabIndex = 4;
            this.cLabel2.Text = "Novo Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(400, 27);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(347, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(194, 26);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 2;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(88, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Location = new System.Drawing.Point(6, 25);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.cLabel1.Size = new System.Drawing.Size(76, 23);
            this.cLabel1.TabIndex = 0;
            this.cLabel1.Text = "Cód. Pacote";
            // 
            // StatusServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 456);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolstripActions);
            this.Name = "StatusServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mudança de Status";
            this.Load += new System.EventHandler(this.StatusServico_Load);
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ToolStrip toolstripActions;
        protected ToolStripButton btnInsert;
        protected ToolStripSeparator separatorNovo;
        protected ToolStripSplitButton btnActions;
        private ToolStripSeparator toolStripSeparator4;
        protected ToolStripSplitButton btnFiltros;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        protected DataGridView dataGridServicos;
        private DataGridViewCheckBoxColumn Selected;
        private DataGridViewTextBoxColumn CodEnvelope;
        private DataGridViewTextBoxColumn Servico;
        private DataGridViewTextBoxColumn Album;
        private DataGridViewTextBoxColumn Moldura;
        private DataGridViewTextBoxColumn Status;
        private GroupBox groupBox2;
        protected DataGridView dataGridVendas;
        private GroupBox groupBox1;
        private Button btConsultar;
        private TextBox txtCodigo;
        private CLabel cLabel1;
        private DataGridViewTextBoxColumn CodPacote;
        private DataGridViewTextBoxColumn CodVenda;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn DataVenda;
        private DataGridViewTextBoxColumn DataEnvio;
        private DataGridViewTextBoxColumn DataRecebimento;
        private CLabel cLabel2;
        private ComboBox cbStatus;
    }
}