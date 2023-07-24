using Bank_AppConsoleProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AppConsoleProject.Services
{
    public class AccountService
    {
        public List<Account> Accounts;
        //private object accounts;

        public AccountService(List<Account> accounts)
        {
            Accounts = accounts;
        }
        public Account CreateNewAccount()
        {
            Console.WriteLine("Enter Your FirstName:");
            string firstName = Console.ReadLine().Trim();

            Console.WriteLine("Enter Your LastName:");
            string lastName = Console.ReadLine().Trim();
            Console.WriteLine("Enter Your PhoneNumber:");
            string PhoneNumber = Console.ReadLine().Trim();
            Console.WriteLine("Enter Your Email:");
            string Email = Console.ReadLine().Trim();
            Console.WriteLine("Enter Your AccountType:");
            string accountType = Console.ReadLine().Trim();


            Account account = new Account();
            account.FirstName = firstName;
            account.LastName = lastName;
            account.PhoneNumber = PhoneNumber;
            account.Email = Email;
            //account.AccountType = accountType;

            Accounts.Add(account);
            return account;


        }

        public void DepositFunds(string accountNumber)
        {
            Account account = Accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
            Console.WriteLine("Please enter a depositorName");
            string depositorName = Console.ReadLine();
            Console.WriteLine("Enter Amount to transfer");
            bool depositAmount = decimal.TryParse(Console.ReadLine(), out decimal amount);
            if (depositAmount)
            {
                if (amount < 50)
                {
                    Console.WriteLine("deposit amount cannot be less than 50 naira");
                }
                else
                {
                    account.Balance += amount;
                    Account account1 = new Account();
                    account1.AccountNumber = accountNumber;

                    Console.WriteLine($" Dear Customer, Your transfer of {amount} has been successfully added");

                }

            }
            else
            {
                Console.WriteLine("Invalid amount entered");
            }
        }

        public void WithDrawal(string accountNumber)
        {
            Account account = Accounts.Where(x => x.AccountNumber == accountNumber).FirstOrDefault();
            Console.WriteLine("Enter the Amount to withdraw");
            bool WithdrawAmount = decimal.TryParse(Console.ReadLine(), out decimal amount);
            if (WithdrawAmount)
            {
                account.Balance += amount;
                if (account.Balance - amount < 1000)
                {
                    Console.WriteLine("Sorry, you have insufficient balance");
                }
                else
                {
                    Console.WriteLine("Enter Password");
                    string passWord = Console.ReadLine();
                    if (passWord == account.Password)
                    {
                        Console.WriteLine($"Congratulations you have successfully withdraw {amount} naire from your account\nNew balance is\n{account.Balance += amount}");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password Entered");
                    
                    }
                }
            
            }
            else
            {
                Console.WriteLine("Invalid amount entered");
            }


        }



    }
}
