using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSarah
{
    class AccountManager
    {
        private Account CurrentAccount { get; set; }
        public void UpdateCurrentAccount(Account NewAccount)
        {
            this.CurrentAccount = NewAccount;
        }
    }
}
