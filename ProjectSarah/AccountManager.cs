using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSarah
{
    public static class AccountManager
    {
        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="accountName"></param>
        /// <param name="accountPassword"></param>
        /// <param name="email"></param>
        /// <param name="city"></param>
        /// <param name="typeOfAccount"></param>
        /// <returns></returns>

        public static Account CreateAccount(string accountName, string accountPassword,
            string email, string city, AccountType typeOfAccount)
        {
            var account = new Account
            {
                AccountName = accountName,
                AccountPassword = accountPassword,
                Email = email,
                City = city,
                TypeOfAccount = typeOfAccount
            };
            return account;
        }

        public static Account AssociateItinerary(string itineraryDate, string itineraryTime,
            string itineraryLocation)
        {
            var itinerary = new Itinerary
            {
                ItineraryDate = itineraryDate,
                ItineraryTime = itineraryTime,
                ItineraryLocation = itineraryLocation
            };
            return Account;

            /* I'm not sure what should go here or if this is how to 
            associate itineraries to accounts*/            
        }
    }
}
