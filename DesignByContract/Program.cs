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

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new form());

            Account a1 = new Account("A1", 100.1);
            Account a2 = new Account("A2", 200.1);
            a1.Deposit(50);
            a1.Withdraw(10.9);
            a1.Withdraw(7);
            a2.Deposit(20);
            a2.Withdraw(150.9);
            System.Diagnostics.Debug.Write("Name is : " + a1.name);
            System.Diagnostics.Debug.Write("\n Account is :" + a1.amount + "\n");
            System.Diagnostics.Debug.Write("Name is : " + a2.name);
            System.Diagnostics.Debug.Write("\n Account is :" + a2.amount + "\n");
        }
    }
}
