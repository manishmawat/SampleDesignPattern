using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    interface ICreditUnionFactory
    {
        ILoanAccount CreateLoanAccount();
        ISavingAccount CreateSavingAccount();
    }
}
