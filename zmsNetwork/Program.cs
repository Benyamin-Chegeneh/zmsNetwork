using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace zmsNetwork
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //App Start as Run as Administrator
            if (IsAdmin() == true)
            {
                Application.Run(new frm_Main());
            }
            else
            {
                if (MessageBox.Show("Error : You must Start App from 'Run as Administrator'", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Retry)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }

        }
        static bool IsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
