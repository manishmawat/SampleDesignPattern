using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //by default access modifier for class is internal. And for class members it is private.
    class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }
        public override string GetDescription() => Description;
        public override double GetCarPrice() => 10000.00;
    }
}
