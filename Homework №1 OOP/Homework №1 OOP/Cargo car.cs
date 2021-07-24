using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__1_OOP
{
    class Cargo_car : Passenger_car
    {
        public override void Display()
        {
            Console.WriteLine($"\tГрузовой автомобиль\nМарка авто - {Name} \nМаксимальная скорость - {MaxSpeed}км/ч \nТип кузова - {Type}\n");
            Console.ReadLine();
        }
    }
}
