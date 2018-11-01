using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CitiLoanAccount:ILoanAccount
    {
        public CitiLoanAccount()
        {
            Console.WriteLine("It is Citi Loan account");
        }
    }
}
