using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__3._1__Equals__GetHashCode_
{
    public class Person
    {
        //2. Реализовать свой класс Person(ФИО, Дата рождения, Место рождения, Номер паспорта), переопределить в нём методы. GetHashCode и Equals
        public string fullName { get; set; }
        public int dateBirth { get; set; }

        public string placeBirth { get; set; }

        public int passportNumber { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Person))
            {
                return false;
            }
            Person result = (Person)obj;
            return result.placeBirth == placeBirth && result.dateBirth == dateBirth && result.fullName == fullName && result.passportNumber == passportNumber;

        }
        public override int GetHashCode()
        {
            return dateBirth + passportNumber;
        }

        public void Display()
        {
            Console.WriteLine($"\tПерсона \nПолное имя:{fullName}\nДата рождения:{dateBirth}\nМесто рождения:{placeBirth}\nНомер пасспорта:{passportNumber}");
            Console.ReadLine();
        }
    }
}
