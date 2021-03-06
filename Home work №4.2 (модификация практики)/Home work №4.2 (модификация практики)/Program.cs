using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work__4._2__модификация_практики_
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client1 = new Client() { FIO = "Roman", ID = 8, passportNumber = 455 };
            Client client2 = new Client() { FIO = "Vasiliy", ID = 6, passportNumber = 320 };
            Client client3 = new Client() { FIO = "Alexandr", ID = 3, passportNumber = 870 };
            Client client4 = new Client() { FIO = "Ivan", ID = 7, passportNumber = 810 };

            Deposit deposit1 = new Deposit() { typeMoney = new Rub(), moneyCount = 1800, typeMon = new Dollar(), moneyCou = 800 };
            Deposit deposit2 = new Deposit() { typeMoney = new Grn(), moneyCount = 1400, typeMon = new Rub(), moneyCou = 1500 };
            Deposit deposit3 = new Deposit() { typeMoney = new Dollar(), moneyCount = 600, typeMon = new Grn(), moneyCou = 0 };

            Account account1 = new Account() { typeMoney = new Grn(), moneyCount = 790 };
            Account account2 = new Account() { typeMoney = new Dollar(), moneyCount = 450 };
            Account account3 = new Account() { typeMoney = new Rub(), moneyCount = 1800 };
            Dictionary < Client, Deposit> clients1 = new Dictionary<Client, Deposit>()
            {
 {client1, deposit1},
 { client2, deposit2}
            };
            Dictionary<Client, Account> clients2 = new Dictionary<Client, Account>()
            {
                { client3, account3},
                {client4, account2 }
            };


            foreach (var item in clients1)
            {

                string fio = item.Key.FIO;
                int Id = item.Key.ID;
                double moneyCount = item.Value.moneyCount;
                string moneyPrefix = item.Value.typeMoney.currencyPrefix;
                double moneyCou = item.Value.moneyCou;
                string moneyPref = item.Value.typeMon.currencyPrefix;
                double MoneyInDollars = item.Value.CalcInDollar();

                Console.WriteLine($"{fio} ({Id}) - {moneyCount} {moneyPrefix}, {moneyCou} {moneyPref}  ({MoneyInDollars} $)");
            }
            foreach (var item in clients2)
            {

                string fio = item.Key.FIO;
                int Id = item.Key.ID;
                double moneyCount = item.Value.moneyCount;
                string moneyPrefix = item.Value.typeMoney.currencyPrefix;
                double MoneyInDollars = item.Value.CalcInDollar();

                Console.WriteLine($"{fio} ({Id}) - {moneyCount} {moneyPrefix}, ({MoneyInDollars} $)");
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
