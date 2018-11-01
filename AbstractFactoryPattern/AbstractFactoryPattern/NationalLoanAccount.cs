using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class NationalLoanAccount:ILoanAccount
    {
        public NationalLoanAccount()
        {
            Console.WriteLine("It is National Loan account");
        }
    }
}
