using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work__4._2__модификация_практики_
{
    public class Dollar : Currency
    {
        public override double rate { get; set; } = 1;

        public override string currencyPrefix { get; set; } = "DOL";
    }
}
