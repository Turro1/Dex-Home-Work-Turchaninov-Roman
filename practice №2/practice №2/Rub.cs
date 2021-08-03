using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic_1
{
   public class Rub : Currency
    {
        public override double rate { get; set; } = 75;
        public override string currencyPrefix { get; set; } = "RUB";
    }
}
