using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work__4._2__модификация_практики_
{
    public class Client
    {
        public string FIO { get; set; }
        public int ID { get; set; }

        public int passportNumber { get; set; }

        public string acaunt { get; set; }


        public void Display()
        {
            Console.WriteLine($"Клиент №{ID}\nФ.И.О клиента:{FIO},\n Аккаунт клиента: {acaunt}");
            Console.ReadLine();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Client))
            {
                return false;
            }
            Client result = (Client)obj;
            return result.ID == ID;
        }
        public override int GetHashCode()
        {
            return ID + passportNumber;
        }
    }

}
