using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string bankAccountName { get; set; }
        public string bankAccountNo { get; set; }
        public string bankName { get; set; }
    }
}