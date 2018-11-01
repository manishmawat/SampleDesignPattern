using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new AccountFactory();
            var citiAccount = factory.GetSavingAccount("Citi-007");
            var nationalAccount = factory.GetSavingAccount("National-100");

            Console.WriteLine("Account balance for citi bank customer is {0} and for National bank is {1}", 
                citiAccount.Balance, nationalAccount.Balance);

            Console.ReadKey();
        }


        //Product (or Action)
        public abstract class ASavingAccount
        {
            public decimal Balance { get; set; }
        }


        //Concrete Product (or concrete Action)
        public class CitiCreditUnion : ASavingAccount
        {
            public CitiCreditUnion()
            {
                Balance = 5000;
            }
        }


        //Concrete Product (or Concrete Action)
        public class NationalCreditUnion : ASavingAccount
        {
            public NationalCreditUnion()
            {
                Balance = 2000;
            }
        }

        //Creator

        /// <summary>
        /// You can create factory class without having this interface but this interface will 
        /// help you in giving flecxibility of adding new functions in concrete factory class.
        /// </summary>
        interface IAccountFactory
        {
            ASavingAccount GetSavingAccount(string accountNo);
        }

        //Concrete creator

        public class AccountFactory : IAccountFactory
        {
            public ASavingAccount GetSavingAccount(string accNo)
            {
                if (accNo.Contains("Citi"))
                {
                    return new CitiCreditUnion();
                }
                else if (accNo.Contains("National"))
                {
                    return new NationalCreditUnion();
                }
                else
                {
                    throw new ArgumentException("Invalid account number");
                }
            }
        }
    }
}
