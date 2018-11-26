using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignByContract
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
            Application.Run(new form());

            Account a1 = new Account("A1", 100);
            a1.Deposit(50);

            System.Diagnostics.Debug.Write("this is amouuuunt " + a1.name);
            System.Diagnostics.Debug.Write("\nthis is amouuuunt " + a1.amount + "\n");
        }
    }
}
