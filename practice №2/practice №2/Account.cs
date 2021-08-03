using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic_1
{
    public class Account

    {
        public Currency typeMoney { get; set; }
        public double moneyCount { get; set; }

        public double CalcInDollar()
        {
            return moneyCount / typeMoney.rate;
        }
    }
}
