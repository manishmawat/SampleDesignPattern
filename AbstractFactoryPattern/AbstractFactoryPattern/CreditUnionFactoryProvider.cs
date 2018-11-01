using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("Citi"))
                return new CitiCreditUnionFactory();
            else
             if (accountNo.Contains("National"))
                return new NationalCreditUnionFactory();
            else return null;
        }
    }
}
