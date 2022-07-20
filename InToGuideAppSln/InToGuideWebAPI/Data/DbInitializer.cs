using InToGuideWebAPI.Models;
using System.Linq;

namespace InToGuideWebAPI.Data
{
    public class DbInitializer
    {

        private readonly InToGuideContext _context;

        public DbInitializer(InToGuideContext context)
        {
            _context = context;
        }

        public void Run()
        {
            if (!_context.Users.Any())
            {

                var user = new User();
                user.FirstName = "Captain";
                user.LastName = "Marvel";
                user.Qualification = "";
                user.EmailAddress = "me@computer.com";
                user.Institution = "4432125032086";
                user.City = "1428 Elm Street";

                var userAccount = new Authentication();
                userAccount.EmailAddress = "me@computer.com";
                userAccount.Password = "12345";
                userAccount.Enabled = true;

                /* var bankAccount = new Match();
                 bankAccount.AccountNumber = "53435434543";
                 bankAccount.BankAccountTypeId = 1;
                 bankAccount.AccountBalance = 10000;




                 user.BankAccounts = new List<BankAccount>();
                 user.BankAccounts.Add(bankAccount);

                 user.Authentication = userAccount;

                 var transaction = new Transaction();
                 transaction.TransactionDate = DateTime.Now;
                 transaction.TransactionTypeId = 1;
                 transaction.BankAccount = bankAccount;
                 transaction.Amount = 50;
                 transaction.Description = "Salary deposit";
                 transaction.Reference = "FUT123";

                 bankAccount.Transactions = new List<Transaction>();

                 bankAccount.Transactions.Add(transaction);

                 _context.Transactions.Add(transaction);

                 transaction = new Transaction();
                 transaction.TransactionDate = DateTime.Now;
                 transaction.TransactionTypeId = 2;
                 transaction.BankAccount = bankAccount;
                 transaction.Amount = 200;
                 transaction.Description = "Lunch Money";
                 transaction.Reference = "LUNCH";

                 bankAccount.Transactions.Add(transaction);

                 _context.Transactions.Add(transaction);

                 _context.Customers.Add(customer);
                 _context.BankAccounts.Add(bankAccount);
                 _context.Authentications.Add(userAccount);
                 _context.SaveChanges();*/
            }

        }
    }
}
