using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Mouse_Capture
{
    public partial class frmMain : Form
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private void Startup()
        {

        }

        private void Shutdown()
        {

        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Startup();
            notifyIconMain.Visible = true;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Shutdown();
            notifyIconMain.Visible = false;
        }
    }
}
