using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AppConsoleProject.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
        public string Password { get; set; }
        [Phone(ErrorMessage ="Invalid phoneNumber format")]
        public string PhoneNumber { get; set; }

        // Navigation property to link Accounts to its User
        public IList<Account> Accounts { get; set; }

    }
}
