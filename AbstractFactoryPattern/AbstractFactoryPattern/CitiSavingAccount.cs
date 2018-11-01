using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CitiSavingAccount:ISavingAccount
    {
        public CitiSavingAccount()
        {
            Console.WriteLine("It is Citi Saving Account");
        }
    }
}
