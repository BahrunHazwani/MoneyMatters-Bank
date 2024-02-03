using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneymattersbank.Models
{
   public class TransactionModel
    {
        public string TransactionType { get; set; }
        public string Amount { get; set; }
        public DateTime CollectionDate { get; set; }
        public string StaffName { get; set; }
    }
}
