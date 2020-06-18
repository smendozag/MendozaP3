/*
 * Progammer: Sergio Mendoza
 * Email: smendozagomez@cnm.edu
 * Class: CIS 1280
 * 06/10/20
 * Program: MendozaP3
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MendozaP3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogoItemOrderForm());
        }
    }
}
