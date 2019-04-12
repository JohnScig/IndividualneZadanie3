using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class AccountModel
    {
        public string IBAN { get; set; }
        public decimal Balance { get; set; }
        public decimal DebtLimit { get; set; }
        public int OwnerID { get; set; }
        public string BankID { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
    }
}
