using System;
namespace Moneymattersbank.Models
{
  public  class AccountDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IcNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public int AccountType { get; set; }
        public string AccountNumber { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public decimal Balance { get; set; }
        public int BranchCode { get; set; }
        public long CounterNumber { get; set; }
    }
}
