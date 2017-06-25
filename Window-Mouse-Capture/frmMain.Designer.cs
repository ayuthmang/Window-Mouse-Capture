namespace Window_Mouse_Capture
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripMain;
            this.notifyIconMain.Text = "notifyIconMain";
            this.notifyIconMain.Visible = true;
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.exitToolStripMenuItem});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStripMain.Size = new System.Drawing.Size(161, 73);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStripMain.ResumeLayout(false);
            this.contextMenuStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
    }
}

