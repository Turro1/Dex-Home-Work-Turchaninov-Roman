using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__3._2__List__Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client() { fullName = "Sergiu", passportNumber = 5, check = 500 };
            Client client2 = new Client() { fullName = "Roman", passportNumber = 67, check = 200 };
            Client client3 = new Client() { fullName = "Vasiliy", passportNumber = 59, check = 50 };
            client1.Display();
            client2.Display();
            client3.Display();
            List<Client> clients = new List<Client>();
            clients.Add(client1);
            clients.AddRange(new Client[] { client2, client3 });
            IEnumerator ie = clients.GetEnumerator();
            while (ie.MoveNext())
            {
                int item = (int)ie.Current;
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
    }
}

