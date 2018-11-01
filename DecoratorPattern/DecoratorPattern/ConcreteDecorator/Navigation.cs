using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Navigation : Decorator.CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation System";
        }
        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
        public override double GetCarPrice() => _car.GetCarPrice() + 1500;
    }
}
