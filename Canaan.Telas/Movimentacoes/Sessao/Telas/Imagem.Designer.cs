using System.ComponentModel;
using System.Windows.Forms;

namespace Canaan.Telas.Movimentacoes.Sessao.Telas
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
            this.toolstripActions = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.btExcluirFoto = new System.Windows.Forms.ToolStripButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lbInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstFotos = new System.Windows.Forms.ListView();
            this.dialogFile = new System.Windows.Forms.OpenFileDialog();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolstripActions.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolstripActions
            // 
            this.toolstripActions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.btExcluirFoto});
            this.toolstripActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripActions.Location = new System.Drawing.Point(0, 0);
            this.toolstripActions.Name = "toolstripActions";
            this.toolstripActions.Padding = new System.Windows.Forms.Padding(5);
            this.toolstripActions.Size = new System.Drawing.Size(710, 33);
            this.toolstripActions.TabIndex = 3;
            this.toolstripActions.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Canaan.Telas.Properties.Resources.arrow_Up_16xLG;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(107, 20);
            this.toolStripButton1.Text = "Incluir Imagem";
            this.toolStripButton1.Click += new System.EventHandler(this.upload_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::Canaan.Telas.Properties.Resources.Loop_16xLG;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(121, 20);
            this.toolStripButton5.Text = "Atualizar Imagens";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Canaan.Telas.Properties.Resources.arrow_Down_16xLG;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(118, 20);
            this.toolStripButton2.Text = "Restaurar Backup";
            this.toolStripButton2.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(110, 20);
            this.toolStripLabel1.Text = "Opções de Imagem";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Canaan.Telas.Properties.Resources.Arrow_UndoRevertRestore_16xLG;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.rotacionarEsquerda_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Canaan.Telas.Properties.Resources.Arrow_RedoRetry_16xLG;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.rotacionarDireita_Click);
            // 
            // btExcluirFoto
            // 
            this.btExcluirFoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btExcluirFoto.Image = global::Canaan.Telas.Properties.Resources.action_Cancel_16xLG;
            this.btExcluirFoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExcluirFoto.Name = "btExcluirFoto";
            this.btExcluirFoto.Size = new System.Drawing.Size(23, 20);
            this.btExcluirFoto.Text = "toolStripButton5";
            this.btExcluirFoto.Click += new System.EventHandler(this.btExcluirFoto_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.lbInfo});
            this.statusBar.Location = new System.Drawing.Point(0, 444);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(710, 22);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // lbInfo
            // 
            this.lbInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(41, 17);
            this.lbInfo.Text = "LbInfo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 411);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstFotos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Imagens da Sessão";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstFotos
            // 
            this.lstFotos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFotos.Location = new System.Drawing.Point(3, 3);
            this.lstFotos.Name = "lstFotos";
            this.lstFotos.Size = new System.Drawing.Size(696, 379);
            this.lstFotos.TabIndex = 5;
            this.lstFotos.UseCompatibleStateImageBehavior = false;
            this.lstFotos.DoubleClick += new System.EventHandler(this.lstFotos_DoubleClick);
            // 
            // dialogFile
            // 
            this.dialogFile.FileName = "openFileDialog1";
            this.dialogFile.Filter = "Files|*.jpg;*.jpeg;";
            this.dialogFile.Multiselect = true;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(200, 200);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Imagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 466);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolstripActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Imagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Imagem_FormClosed);
            this.Load += new System.EventHandler(this.Imagem_Load);
            this.toolstripActions.ResumeLayout(false);
            this.toolstripActions.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ToolStrip toolstripActions;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton btExcluirFoto;
        private StatusStrip statusBar;
        private ToolStripProgressBar progressBar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListView lstFotos;
        private ToolStripStatusLabel lbInfo;
        private OpenFileDialog dialogFile;
        private ImageList imgList;
        private FolderBrowserDialog folderDialog;
        private ToolStripButton toolStripButton5;
    }
}