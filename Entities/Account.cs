using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AppConsoleProject.Entities
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public int UserId { get; set; }
        public string AccountType  { get; set; }
        public decimal Balance { get; set; }

        // Navigation property to link Account to its Customer
        public User Customer { get; set; }

        // Navigation property to link Account to its Transactions
        public ICollection<Transaction> Transactions { get; set; }
    }

}
