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
                client.Display();
                Console.ReadKey();
            }

            //Реализовать метод подсчитывающий сумму денег у всех клиентов банка.
            double totalCheck = clients.Sum(pkg => pkg.check);
            Console.WriteLine($"Сумма всех денег в банке {totalCheck}$\n");

            // Реализовать метод поиска клиента с минимальной суммой на счете.
            double MinCheck = clients.Min(pkg => pkg.check);
            Console.WriteLine($"Минимальный счёт в банке {MinCheck}$\n");

            


            

            //Используя методы расширения реализовать метод поиска клиента по номеру паспорта или по имени
            IEnumerable<string> names = from client in clients 
                                            where client.fullName.Contains("Sergiu") 
                                            select client.fullName;

            foreach (string str in names)
            {
                Console.WriteLine($"Поиск клиента с именем: {str}");
                Console.ReadLine();
            }

        }
    }
}

