using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneymattersbank.Models
{
  public  class CreateTransactionModel
    {
        public long AccountNumber { get; set; }
        public int TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime CollectionDate { get; set; }
        public string StaffName { get; set; }
    }
}
