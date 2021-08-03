using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client1 = new Client() { FIO = "Roman", acaunt = "RAS", ID = 8, passportNumber = 455 };
            Client client2 = new Client() { FIO = "Vasiliy", acaunt = "VPD", ID = 6, passportNumber = 320 };
            Client client3 = new Client() { FIO = "Alexandr", acaunt = "APD", ID = 3, passportNumber = 870 };

            Account account1 = new Account() { typeMoney = new Grn(), moneyCount = 790 };
            Account account2 = new Account() { typeMoney = new Dollar(), moneyCount = 450 };
            Account account3 = new Account() { typeMoney = new Rub(), moneyCount = 1800 };
            Dictionary<Client, Account> clients = new Dictionary<Client, Account>()
            {
                {client1, account1},
            { client2, account2},
            { client3, account3}
        };


            foreach (var item in clients)
            {

                string fio = item.Key.FIO;
                int Id = item.Key.ID;
                double moneyCount = item.Value.moneyCount;
                string moneyPrefix = item.Value.typeMoney.currencyPrefix;
                double MoneyInDollars = item.Value.CalcInDollar();

                Console.WriteLine($"{fio} ({Id}) - {moneyCount} {moneyPrefix}  ({MoneyInDollars} $)");
            }

            double res = ConvertMoney(1000, new Grn(), new Rub());
            Console.WriteLine(res);
            Console.ReadLine();
        }
        
        public static double ConvertMoney(double money, Currency originalCurrency, Currency converingCurrency)
        {
            double result = (money / originalCurrency.rate) * converingCurrency.rate;
            return result;
        }
    }
}
