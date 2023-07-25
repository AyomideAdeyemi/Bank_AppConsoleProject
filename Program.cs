
using Bank_AppConsoleProject.Entities;
using Bank_AppConsoleProject.Services;

User user = new User();
AccountService accountService1 = new AccountService();
List<User> users = new List<User>();
List<AccountService> accountService = new List<AccountService>();
Transaction transaction1 = new Transaction();
TransactionService transactionService= new TransactionService();

Console.WriteLine("Welcome to Apex Bank \n1.Create an Account\n2.Log In to your exsisting account");

bool Input = byte.TryParse(Console.ReadLine(), out byte Num);
if (Num == 1)
{
    accountService1.CreateNewAccount();
}
else if (Num == 2)

{
    Console.WriteLine("1.Deposit\n2.Transfer\n3.Withdrawal");

    bool result = byte.TryParse(Console.ReadLine(), out byte Result);
    if (Result == 1)
    {
        transactionService.DepositFunds();
    }
    else if (Result == 2) 
    {
        transactionService.TransferFunds();
    }
    else if (Result == 3)
    {
        transactionService.WithDrawal();
    }
}
