using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    /// <summary>
    /// Class representing a bank client.
    /// </summary>
    public class ClientModel
    {
        /// <summary>
        /// Client's unique identifier
        /// </summary>
        public int ClientID { get; set; }

        /// <summary>
        /// Client's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Client's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Client's date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Number of the client's ID card
        /// </summary>
        public string PersonalID { get; set; }

        /// <summary>
        /// Client's phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Client's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Street that the client lives on
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Client's Postal Code
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// City which the client lives in
        /// </summary>
        public string City { get; set; }
    }
}
