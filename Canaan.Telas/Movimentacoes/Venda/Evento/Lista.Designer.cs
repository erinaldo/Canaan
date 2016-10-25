namespace Canaan.Telas.Movimentacoes.Venda.Evento
{
    partial class Lista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.eventosDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eventoEspecificacaoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeModeloTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoEventoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolstripActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolstripActions);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Text = "Detalhes do Contrato";
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnAdicionar,
            this.toolStripSeparator1,
            this.btnEditar,
            this.toolStripSeparator2,
            this.btnExcluir});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(990, 33);
            this.toolstripActions.TabIndex = 3;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Canaan.Telas.Properties.Resources.save_16xLG;
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 20);
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::Canaan.Telas.Properties.Resources.action_add_16xLG;
            this.btnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(134, 20);
            this.btnAdicionar.Text = "Novo Compromisso";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::Canaan.Telas.Properties.Resources.folder_Open_16xLG;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 20);
            this.btnEditar.Text = "Editar Selecionado";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 20);
            this.btnExcluir.Text = "Excluir Selecionado";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // eventosDataGridView
            // 
            this.eventosDataGridView.AllowUserToAddRows = false;
            this.eventosDataGridView.AllowUserToDeleteRows = false;
            this.eventosDataGridView.AllowUserToResizeColumns = false;
            this.eventosDataGridView.AllowUserToResizeRows = false;
            this.eventosDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.eventosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.eventosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Evento,
            this.Descricao});
            this.eventosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.eventosDataGridView.MultiSelect = false;
            this.eventosDataGridView.Name = "eventosDataGridView";
            this.eventosDataGridView.ReadOnly = true;
            this.eventosDataGridView.RowHeadersVisible = false;
            this.eventosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.eventosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventosDataGridView.ShowCellErrors = false;
            this.eventosDataGridView.ShowCellToolTips = false;
            this.eventosDataGridView.ShowEditingIcon = false;
            this.eventosDataGridView.ShowRowErrors = false;
            this.eventosDataGridView.Size = new System.Drawing.Size(950, 210);
            this.eventosDataGridView.TabIndex = 0;
            this.eventosDataGridView.DoubleClick += new System.EventHandler(this.eventosDataGridView_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eventoEspecificacaoTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nomeModeloTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tipoEventoTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 213);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(950, 291);
            this.panel2.TabIndex = 1;
            // 
            // eventoEspecificacaoTextBox
            // 
            this.eventoEspecificacaoTextBox.Location = new System.Drawing.Point(11, 60);
            this.eventoEspecificacaoTextBox.Multiline = true;
            this.eventoEspecificacaoTextBox.Name = "eventoEspecificacaoTextBox";
            this.eventoEspecificacaoTextBox.Size = new System.Drawing.Size(650, 223);
            this.eventoEspecificacaoTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serviços  / Produtos";
            // 
            // nomeModeloTextBox
            // 
            this.nomeModeloTextBox.Location = new System.Drawing.Point(339, 21);
            this.nomeModeloTextBox.Name = "nomeModeloTextBox";
            this.nomeModeloTextBox.Size = new System.Drawing.Size(322, 20);
            this.nomeModeloTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome dos Modelos";
            // 
            // tipoEventoTextBox
            // 
            this.tipoEventoTextBox.Location = new System.Drawing.Point(11, 21);
            this.tipoEventoTextBox.Name = "tipoEventoTextBox";
            this.tipoEventoTextBox.Size = new System.Drawing.Size(322, 20);
            this.tipoEventoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Contrato";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.eventosDataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 210);
            this.panel3.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Evento
            // 
            this.Evento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Evento.DataPropertyName = "Evento";
            this.Evento.HeaderText = "Tipo de Compromisso";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle1;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
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
            ((System.ComponentModel.ISupportInitialize)(this.eventosDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.ToolStrip toolstripActions;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.DataGridView eventosDataGridView;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox eventoEspecificacaoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeModeloTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tipoEventoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}