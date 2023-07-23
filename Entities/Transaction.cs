using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AppConsoleProject.Entities
{
    public class Transaction
    {
        
            public int TransactionId { get; set; }
            public string AccountNumber { get; set; }
            public string TransactionType { get; set; }
            public decimal Amount { get; set; }
            public DateTime TransactionDate { get; set; }

            // Navigation property to link Transaction to its Account
            public Account Account { get; set; }
        

    }
}
