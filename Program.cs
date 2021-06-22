using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRotator {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm f = new MainForm();
            f.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            f.ShowInTaskbar = false;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = new System.Drawing.Point(-2000, -2000);
            f.Size = new System.Drawing.Size(1, 1);

            Application.Run(f);
        }
    }

    public static class UnsafeNativeMethods {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetForegroundWindow(HandleRef hWnd);
    }
}
