using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRotator {
    class Startup {
        //Startup registry key and value
        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "Screen Rotator";

        internal static void SetStartup(bool start) {
            if (start) {
                //Set the application to run at startup
                RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
                key.SetValue(StartupValue, Application.ExecutablePath.ToString());
            } else {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
                key.DeleteValue(StartupValue);
            }
        }

        internal static bool GetStartup() {
            //Set the application to run at startup
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, false);
            return (key.GetValue(StartupValue) != null);
        }
    }
}