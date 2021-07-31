using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__3._1__Equals__GetHashCode_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Выяснить как работает оператор == у типа string.
            Account account1 = new Account { login = "Turro", password = "123Turro" };
            Account account2 = new Account { login = "Turro", password = "123Turro" };
            Account account3 = account1;

            bool statusAcc1 = account1 == account2; // false.
            bool statusAcc2 = account1 == account3; // true.

            account1.Display();
            account2.Display();
            account3.Display();
            //Вывод: Оператор == для типа string работает так же как и для типов значений - сравнивает ссылки на объекты 
            //что бы сравнить равны ли объекты(поля, свойства) друг другу, оператор == можно переопредилить в классе "Account".

            //2. Реализовать свой класс Person(ФИО, Дата рождения, Место рождения, Номер паспорта), переопределить в нём методы. GetHashCode и Equals.
            Person person1 = new Person {fullName = "Алла Пугачёва", dateBirth = 1949, passportNumber = 135, placeBirth = "Россия" };
            Person person2 = new Person { fullName = "Алла Пугачёва", dateBirth = 1949, passportNumber = 135, placeBirth = "Россия" };
            Person person3 = new Person {fullName = "Николай Басков", dateBirth = 1976, passportNumber = 114, placeBirth = "Белорусь" };

            bool statusPer1 = person1.Equals(person2); // true.
            bool statusPer2 = person1.Equals(person3); // false.
            bool statusPer3 = person2.Equals(person3); // false.

            if (statusPer1 == true)
            {
                person1.Display();
                person2.Display();

                Console.WriteLine("true");
                
            }
            else 
            {
                person1.Display();
                person2.Display();
                Console.WriteLine("false"); 
            }
            if (statusPer2 == true)
            {
                person1.Display();
                person3.Display();

                Console.WriteLine("true");
            }
            else 
            {
                person1.Display();
                person3.Display();

                Console.WriteLine("false"); 
            }
            if (statusPer3 == true)
            {
                person2.Display();
                person3.Display();

                Console.WriteLine("true");
            }
            else 
            {
                person2.Display();
                person3.Display();
                Console.WriteLine("false");
                Console.ReadLine();
            }
        }
    }
}
