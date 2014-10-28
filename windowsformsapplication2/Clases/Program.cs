using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmSplash());
            bool mutexCreado = false;
            Mutex miMutex = new Mutex(true, "Hidroelectrica", out mutexCreado);
            if (mutexCreado)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmSplash());
                miMutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("La aplicación ya se encuentra abierta.","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
