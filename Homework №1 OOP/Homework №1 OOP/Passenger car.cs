using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__1_OOP
{
    public class Passenger_car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"\tЛегковой автомобиль\nМарка авто - {Name} \nМаксимальная скорость - {MaxSpeed}км/ч \nТип - {Type}\n");
            Console.ReadLine();
        }
    }
}
