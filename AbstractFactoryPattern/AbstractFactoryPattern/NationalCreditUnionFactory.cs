using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public ILoanAccount CreateLoanAccount()
        {
            return new NationalLoanAccount();
        }

        public ISavingAccount CreateSavingAccount()
        {
            return new NationalSavingAccount();
        }
    }
}
