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
            Console.WriteLine("Welcome to Project Travel!");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Create an itinerary");
            Console.WriteLine("0. Exit");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Write("What is your user name?");
                    var accountName = Console.ReadLine();

                    var account1 = AccountManager.CreateAccount(accountName, accountPassword,
                        email, city, AccountType.Free);
                    Console.WriteLine("Account Name: {0}, Account Password: {1}, Email: {2}, City: {3}, Type of Account: {4}", 
                        account1.AccountName,
                    account1.AccountPassword, account1.Email, account1.City, account1.TypeOfAccount);
                    break;

                case "2":
                    break;

                case "0":
                    Console.WriteLine("Good bye!");
                    return;

                default:
                    break;
            }

         }
    }
}
