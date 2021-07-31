using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__3._1__Equals__GetHashCode_
{
   public class Account 
    {
        public string login { get; set; }
        public string password { get; set; }

        public void Display()
        {
            Console.WriteLine($"\tАккаунт \nЛогин:{login}\nПароль:{password}");
            Console.ReadLine();
        }
    }
}
