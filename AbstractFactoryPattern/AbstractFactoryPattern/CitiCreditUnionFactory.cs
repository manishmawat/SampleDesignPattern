using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public ILoanAccount CreateLoanAccount()
        {
            return new CitiLoanAccount();
        }

        public ISavingAccount CreateSavingAccount()
        {
            return new CitiSavingAccount();
        }
    }
}
