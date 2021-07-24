using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тема: автомашины
            Passenger_car passenger_car = new Passenger_car() {Name = "Renault", MaxSpeed = 160, Type = "Универсал"};
            passenger_car.Display();

            Sport_car sport_car = new Sport_car() {Name = "Honda", MaxSpeed = 320, Type = "Трековый автомобиль" };
            sport_car.Display();

            Cargo_car cargo_car = new Cargo_car() { Name = "Volvo", MaxSpeed = 180, Type = "Пасажирский " };
            cargo_car.Display();

            Passenger_car[] cars = new Passenger_car[] { passenger_car, sport_car, cargo_car };

            foreach (var item in cars)
            {
                item.Display();
            }
        }
    }
}
