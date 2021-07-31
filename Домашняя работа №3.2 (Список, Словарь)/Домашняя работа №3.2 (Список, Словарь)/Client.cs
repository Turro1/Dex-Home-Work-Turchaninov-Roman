using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__3._2__List__Dictionary_
{
    public class Client   
    {
        public string fullName { get; set; }
        public int passportNumber { get; set; }
        public int check { get; set; }

        public void Display()
        {
            Console.WriteLine($"Клиент: {fullName}\nНомер пасспорта: {passportNumber}\nБалланс: {check} $");
            Console.ReadLine();
        }
  
    }
}

