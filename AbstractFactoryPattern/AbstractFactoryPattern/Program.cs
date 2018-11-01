using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Abstract factory pattern is a factory of factory.
/// Here we will return a factory which in turn provide you a factory to 
/// create a product under specific typ of class (or company).
/// </summary>
namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfAccounts = new string[] { "Citi-001", "National-100", "No-002" };

            foreach(var acc in arrayOfAccounts)
            {
                ICreditUnionFactory anAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(acc.ToString());
                if (anAbstractFactory == null)
                    Console.WriteLine("Sorry, account number entered is not accurate");
                else
                {
                    ILoanAccount loanAccount = anAbstractFactory.CreateLoanAccount();
                    ISavingAccount savingAccount = anAbstractFactory.CreateSavingAccount();
                }
            }
            Console.ReadLine();
        }
    }
}
