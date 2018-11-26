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
          //  Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new form());

            Account a1 = new Account("A1", 100.1);
            a1.Withdraw(50.9);
            a1.Withdraw(7);
            System.Diagnostics.Debug.Write("Name is : " + a1.name);
            System.Diagnostics.Debug.Write("\n Account is :" + a1.amount + "\n");
        }
    }
}
