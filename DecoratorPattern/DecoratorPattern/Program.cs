using DecoratorPattern.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new CompactCar();
            myCar = new LeatherSeats(myCar);
            myCar = new Navigation(myCar);
            myCar = new Sunroof(myCar);

            Console.WriteLine("Description of the car is {0}", myCar.GetDescription());
            Console.WriteLine("The price of the car is {0}", myCar.GetCarPrice());
        }
    }
}
