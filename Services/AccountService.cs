using Bank_AppConsoleProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bank_AppConsoleProject.Services
{
    public class AccountService
    {
        public List<Account> Accounts;
        private string zero;
        private readonly string accountType;

        //private object accounts;

        public AccountService(List<Account> accounts)
        {
            Accounts = accounts;
        }

        public AccountService()
        {
        }

        public Account CreateNewAccount()
        {
            Console.WriteLine("Enter Your FirstName:");
            string firstName = Console.ReadLine().Trim();

            Console.WriteLine("Enter Your LastName:");
            string lastName = Console.ReadLine().Trim();
           PhoneNumber: Console.WriteLine("Enter Your PhoneNumber:");
            Console.Write("+234");
            string PhoneNumber = Console.ReadLine().Trim();
            // Ensure the phone number has the Nigeria international code +234
            if (PhoneNumber.StartsWith("0"))
            {
                Console.WriteLine("Incorrect phonenumber or format");
                goto PhoneNumber;
            }
            string fullName = $"{firstName.ToUpper()} {lastName.ToUpper()}";
        email: Console.WriteLine("Enter Your Email:");
            string email = Console.ReadLine().Trim();
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";


            // Use the Regex class to match the email against the pattern.
            if (!Regex.IsMatch(email, emailPattern))
            {
            // Throw an exception when the email format is incorrect.
            Console.WriteLine("Invalid email format.");
                goto email;
            }
            else
            {
                Console.WriteLine("Enter a number for Your AccountType below\n1.Saving\t2.Current:");
                bool accountType = byte.TryParse(Console.ReadLine(), out byte number);
                if (number is 1)
                {
                    Console.WriteLine($"Your Savings Account has been successfully created\n\nFULLNAME\tACCOUNTNUMBER\tACCOUNT TYPE\n{fullName}\t{GenerateAccountNumber()}\tSavings");
                    
                }
                else if (number is 2) 
                {
                    Console.WriteLine($"Your Current Account has been successfully created\n\nFULLNAME\tACCOUNTNUMBER\tACCOUNT TYPE\n{fullName}\t{GenerateAccountNumber()}\tCurrent");
                }
            }


            Account account = new Account();
            account.FirstName = firstName;
            account.LastName = lastName;
            account.PhoneNumber = PhoneNumber;
            account.Email = email;
            account.AccountType = accountType;
            return account;


        }

       
        private static readonly Random random = new Random();

        public string GenerateAccountNumber()
        {
            // We'll generate a random 10-digit number as a string
            StringBuilder accountNumber = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                int digit = random.Next(0, 10); // Generate a random digit (0 to 9)
                accountNumber.Append(digit);
            }
            
            return accountNumber.ToString();
        }
    }
}
    









