using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSarah
{
    public enum AccountType
    {
        Free,
        Premium
    }

    class Account
    {
        #region Properties
        public string AccountName { get; set; }
        public string AccountPassword { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string ListOfFavorites { get; set; }
        public AccountType TypeOfAccount { get; set; }

        #endregion

        #region Methods

        
        public void AddAccountToAccountManager(AccountManager accountmanager)
        {
            accountmanager.UpdateCurrentAccount(this);
        }

        public void UpdateAccount
        #endregion

    }
}