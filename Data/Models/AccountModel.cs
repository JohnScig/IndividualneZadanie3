using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// A model of a bank account.
    /// </summary>
    public class AccountModel
    {
        /// <summary>
        /// IBAN number representing a unique identifier of a bank account.
        /// </summary>
        public string IBAN { get; set; }

        /// <summary>
        /// Current balance on the account
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// A debit limit - amount to which the client is allowed to overdraw his account
        /// </summary>
        public decimal DebtLimit { get; set; }

        /// <summary>
        /// ID of the account's owner
        /// </summary>
        public int OwnerID { get; set; }

        /// <summary>
        /// ID of the bank
        /// </summary>
        public string BankID { get; set; }

        /// <summary>
        /// Date and time of the account's opening
        /// </summary>
        public DateTime OpenDate { get; set; }

        /// <summary>
        /// Date and time of the account's closing
        /// </summary>
        public DateTime CloseDate { get; set; }
    }
}
