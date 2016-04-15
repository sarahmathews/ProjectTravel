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
    /// <summary>
    /// This is about a travel account where you should be able to create travel itineraries
    /// </summary>
    public class Account
    {
        #region Variables
        /*Not sure how to add this without assigning account numbers?*/
        #endregion

        #region Properties
            /// <summary>
            /// The user's screen name
            /// </summary>
        public string AccountName { get; set; }
        /// <summary>
        /// The user's password 
        /// </summary>
        public string AccountPassword { get; set; }
        /// <summary>
        /// User's email address
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// City where the user currently resides
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Account type enum; Free account or Premium account which is paid
        /// </summary>
        public AccountType TypeOfAccount { get; set; }
        #endregion

        #region Methods
        }
    //not sure how to add a method for
        }
        #endregion

    }
}