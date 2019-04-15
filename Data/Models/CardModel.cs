using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// A representation of a bank card
    /// </summary>
    public class CardModel
    {
        /// <summary>
        /// Card's number - a unique identifier of the card
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// Card's PIN code - for testing purposes, it is used here, but otherwise, it's hashed version would be placed here
        /// </summary>
        public string PIN { get; set; }

        /// <summary>
        /// Date and time of the card's issue
        /// </summary>
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// Date and time until the card remains valid
        /// </summary>
        public DateTime ValidUntil { get; set; }

        /// <summary>
        /// A value showing whether the card has been blocked
        /// </summary>
        public bool Blocked { get; set; }

        /// <summary>
        /// A string representation of the account's ID to which the card belongs
        /// </summary>
        public string AccountID { get; set; }
    }
}
