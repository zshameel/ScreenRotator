using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRotator {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void noRotationToolStripMenuItem_Click(object sender, EventArgs e) {
            Display.Rotate(1, Display.Orientations.DEGREES_CW_0);
        }

        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e) {
            Display.Rotate(1, Display.Orientations.DEGREES_CW_90);
        }

        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e) {
            Display.Rotate(1, Display.Orientations.DEGREES_CW_180);
        }

        private void rotate270ToolStripMenuItem_Click(object sender, EventArgs e) {
            Display.Rotate(1, Display.Orientations.DEGREES_CW_270);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void startWithWindowsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (startWithWindowsToolStripMenuItem.Checked) {
                Startup.SetStartup(false);
                startWithWindowsToolStripMenuItem.Checked = false;
            } else {
                Startup.SetStartup(true);
                startWithWindowsToolStripMenuItem.Checked = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            startWithWindowsToolStripMenuItem.Checked = Startup.GetStartup();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e) {
            UnsafeNativeMethods.SetForegroundWindow(new HandleRef(contextMenuStrip1,contextMenuStrip1.Handle));
            contextMenuStrip1.Show(Cursor.Position);
        }
    }
}
