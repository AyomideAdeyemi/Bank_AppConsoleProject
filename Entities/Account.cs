using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AppConsoleProject.Entities
{
    public class Account : User
    {
        public string AccountNumber { get; set; }
        [ForeignKey(nameof(User))]

        //public int UserId { get; set; }
        public string AccountType { get; set; }

        public decimal Balance { get; set; }

        // Navigation property to link Account to its Customer
        public User Customer { get; set; }

        // Navigation property to link Account to its Transactions
        public ICollection<Transaction> Transactions { get; set; }

        

       

       
    }
}



