using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public long amount { get; set; }
        public string transactionNo { get; set; }
        public BankAccount bankAccount { get; set; }
        public DateTime paymentDate { get; set; }
    }
}