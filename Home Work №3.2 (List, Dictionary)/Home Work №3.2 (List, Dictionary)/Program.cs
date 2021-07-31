using System;
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
            var client1 = new Client() { fullName = "Sergiu", passportNumber = 5, check = 500 };
            Client client2 = new Client() { fullName = "Roman", passportNumber = 67, check = 200 };
            Client client3 = new Client() { fullName = "Vasiliy", passportNumber = 59, check = 50 };
            List<Client> clients = new List<Client>();
            clients.Add(client1);
            clients.AddRange(new Client[] { client2, client3 });
            foreach (Client client in clients)
            {

                int sum = client.check;
                Console.WriteLine(sum);
                client.Display();
                Console.ReadKey();
            }

          
                IEnumerable<string> names = from client in clients
                                            where client.fullName.Contains("Sergiu")
                                            select client.fullName;

            foreach (string str in names)
            {
                Console.WriteLine($"Клиент с именем: {str}");
                Console.ReadLine();
            }

            
            foreach (string str in names)
            {
                Console.WriteLine($"Клиент с именем: {str}");
                Console.ReadLine();
            }
        }
    }
}

