using Bank_AppConsoleProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_AppConsoleProject.Services
{
    public class TransactionService
    {
         
        public List<Account> Accounts;
        private string zero;
        private readonly string accountType;

        //private object accounts;

        public TransactionService(List<TransactionService> Transactions)
        {
            Transactions = Transactions;
        }

        public TransactionService()
        {
        }

       
        public void DepositFunds()
        {
            //Account account = Accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
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
                    //account.Balance += amount;
                    Account account1 = new Account();
                    //account1.AccountNumber = accountNumber;

                    Console.WriteLine($" Dear Customer, Your transfer of {amount} has been successfully added");

                }

            }
            else
            {
                Console.WriteLine("Invalid amount entered");
            }
            
        }

        public string WithDrawal(string accountNumber)
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

            return zero;
        }
        public string TransferFunds(string accountNumber)
        {
            Account account = Accounts.Where(x => x.AccountNumber == accountNumber).FirstOrDefault();
            Console.WriteLine("Enter the receiver account number");
            string receiverAccountNum = Console.ReadLine();
            Console.WriteLine("enter description");
            string description = Console.ReadLine();
            Console.WriteLine("enter Receiver name");
            string[] receiverName = Console.ReadLine().Trim().Split(' ');
            Console.WriteLine("Enter the amount to transfer");
            bool transferAmount = decimal.TryParse(Console.ReadLine(), out decimal amount);
            decimal MinimumBal = 1000;
            if (transferAmount)
            {
                if (amount < 50)
                {
                    Console.WriteLine("Cannot transfer less tha 50 naira");
                }
                else if (account.Balance - amount < MinimumBal)
                {
                    Console.WriteLine("insufficient funds");
                }
                else
                {
                    Console.WriteLine("Enter Password");
                    string passWord = Console.ReadLine();
                    if (account.Password == passWord)
                    {
                        Console.WriteLine($"Congratulation you have successfully sent {amount} to {receiverName}");
                    }
                }
            }
            return zero;

        }

        
    }
}
