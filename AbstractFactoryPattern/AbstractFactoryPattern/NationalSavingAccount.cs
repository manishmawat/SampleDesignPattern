using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class NationalSavingAccount:ISavingAccount
    {
        public NationalSavingAccount()
        {
            Console.WriteLine("It is National Saving account");
        }
    }
}
