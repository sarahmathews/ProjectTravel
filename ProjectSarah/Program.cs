using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSarah
{
    class Program  
    {
        static void Main(string[] args)
        {
            /* create a class called AccountManager that stores the current Account */
            /* create a method / property in AccountManager to set current account*/

            /* create an instance of AccountManager */

            var accountmanager1 = new AccountManager();

            /* create accounts! -DONE  */
            //creating an instance of account; a new object
            var account1 = new Account();
            account1.AccountName = "Sarah's Travel Itineraries";
            account1.AccountPassword = "password1234";
            account1.Email = "s.marie.mathews@gmail.com";
            account1.City = "Seattle";
            account1.TypeOfAccount = AccountType.Free;

            account1.AddAccountToAccountManager(accountmanager1);

            //creating another instance of account
            var account2 = new Account();
            account2.AccountName = "Dan's Travel Itineraries";
            account2.AccountPassword = "password5678";
            account2.Email = "danielmacd@gmail.com";
            account2.City = "Bozeman";
            account2.TypeOfAccount = AccountType.Premium;


            account2.AddAccountToAccountManager(accountmanager1);
            Console.WriteLine(account1.AccountName);
        }
    }
}
