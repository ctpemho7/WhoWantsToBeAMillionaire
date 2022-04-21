using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeAMillionaire
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new StartGameForm());

            //using (StartGameForm login = new StartGameForm())
            //{
            //    login.ShowDialog();
            //    if (login.Name != null &&
            //        login.Amount != null &&
            //        login.Name.Length > 0 &&
            //        login.Amount.Length > 0)
            //    {
            //        Application.Run(new Form1(login.Name, login.Amount));
            //    }
            //}
        }
    }
}
