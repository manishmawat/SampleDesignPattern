using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    class FullSizeCar:Car
    {
        public FullSizeCar()
        {
            Description = "Full Size Car";
        }
        public override string GetDescription() => Description;
        public override double GetCarPrice() => 12000.00;
    }
}
