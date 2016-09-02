namespace RM.Telas.Ferramentas.Spc
{
    partial class Envio
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
            this.listInfo = new System.Windows.Forms.ListBox();
            this.workerRegistro = new System.ComponentModel.BackgroundWorker();
            this.statusWorker = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusWorker.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listInfo
            // 
            this.listInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listInfo.FormattingEnabled = true;
            this.listInfo.Location = new System.Drawing.Point(0, 0);
            this.listInfo.Name = "listInfo";
            this.listInfo.Size = new System.Drawing.Size(645, 326);
            this.listInfo.TabIndex = 0;
            // 
            // workerRegistro
            // 
            this.workerRegistro.WorkerReportsProgress = true;
            this.workerRegistro.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerRegistro_DoWork);
            this.workerRegistro.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerRegistro_ProgressChanged);
            this.workerRegistro.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerRegistro_RunWorkerCompleted);
            // 
            // statusWorker
            // 
            this.statusWorker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgress,
            this.statusText});
            this.statusWorker.Location = new System.Drawing.Point(0, 326);
            this.statusWorker.Name = "statusWorker";
            this.statusWorker.Size = new System.Drawing.Size(645, 22);
            this.statusWorker.SizingGrip = false;
            this.statusWorker.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 326);
            this.panel1.TabIndex = 2;
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 17);
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // Envio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusWorker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Envio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio";
            this.Load += new System.EventHandler(this.Envio_Load);
            this.statusWorker.ResumeLayout(false);
            this.statusWorker.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listInfo;
        private System.ComponentModel.BackgroundWorker workerRegistro;
        private System.Windows.Forms.StatusStrip statusWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel statusText;

    }
}