using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__1_OOP
{
    class Sport_car : Passenger_car
    {
        public override void Display()
        {
            Console.WriteLine($"\tСпортивный автомобиль\nМарка авто - {Name} \nМаксимальная скорость - {MaxSpeed}км/ч \nТип авто - {Type}\n");
            Console.ReadLine();
        }
    }
}
