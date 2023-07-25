
using Bank_AppConsoleProject.Entities;
using Bank_AppConsoleProject.Services;

User user = new User();
AccountService accountService1 = new AccountService();
List<User> users = new List<User>();
List<AccountService> accountService = new List<AccountService>();
Transaction transaction1 = new Transaction();
TransactionService transactionService= new TransactionService();
transactionService.DepositFunds();

accountService1.CreateNewAccount();
accountService1.GenerateAccountNumber();