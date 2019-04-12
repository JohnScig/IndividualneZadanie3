using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class CardModel
    {
        public string CardNumber { get; set; }
        public string PIN { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public bool Blocked { get; set; }
        public string AccountID { get; set; }
    }
}
