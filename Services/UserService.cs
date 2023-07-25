using Bank_AppConsoleProject.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AppConsoleProject.Services
{
    public class UserService
    {
        public List<User> Users;
        public UserService(List<User> users)
        {
            Users = users;
        }


        public User CreateNewUser(List<User> users)
        {
            Console.WriteLine("Welcome to Apex Bank ");
            Console.WriteLine("Enter Your FirstName:");
            string firstName = Console.ReadLine().Trim();

            Console.WriteLine("Enter Your LastName:");
            string lastName = Console.ReadLine().Trim();
            Console.WriteLine("Enter Your PhoneNumber:");
            string PhoneNumber = Console.ReadLine().Trim();
            Console.WriteLine("Enter Your Email:");
            string Email = Console.ReadLine().Trim();
            Console.WriteLine("Enter Your Password:");
            string Password = Console.ReadLine().Trim();
            Console.WriteLine("your account created successfully");
            User user = new User();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.PhoneNumber = PhoneNumber;
            user.Email = Email;
            user.Password = Password;
            Users.Add(user);
            return user;






        }
    }
}


