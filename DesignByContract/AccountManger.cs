using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignByContract
{
    class AccountManger
    {


        public Dictionary < string, Account> accountCollection;

        public AccountManger()
        {
            accountCollection = CreateAccount();
        }

        public static Dictionary<string, Account> CreateAccount()
        {
            Dictionary<string, Account> Collection;
            Collection = new Dictionary<string, Account>();
            Collection.Add("MAH",new Account("MAH" , 1000));
            Collection.Add("SI",new Account("SI", 1000));
            Collection.Add("IU", new Account("IU", 1000)); 
            Collection.Add("OOP",new Account("OOP",  1000));
            Collection.Add("Divd",new Account("Divd", 1000));

            return Collection;
        }
        public Dictionary<string, Account> getDrugsCollection()
        {
            return accountCollection;
        }
    }
}
