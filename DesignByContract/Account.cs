using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace DesignByContract
{
    class Account
    {

        public String name { get; set; }
   
        public int amount { get; set; }

        public Account(string name,  int amount)
        {
            this.name = name;
          
            this.amount = amount;
        }

       

        public override string ToString()
        {
            return  " name : " + name + "; amount :" + amount.ToString() ;
        }


        public void setNewAmount(int amountn)
        {
            amount = amount + amountn;
        }

        public void Deposit(int d)
        {
            Contract.Requires(d >= 0);
            Contract.Ensures(Contract.OldValue(amount) + d == amount);
            amount += d;
        }

        public void Withdraw(int d)
        {
            Contract.Requires(d >=0 );
            Contract.Ensures(Contract.OldValue(amount) - d == amount);
            Contract.EnsuresOnThrow<Exception>(Contract.OldValue(amount) == amount);

            if (d > amount) throw new Exception();

            amount = amount - d;
        }
    }
    
}
