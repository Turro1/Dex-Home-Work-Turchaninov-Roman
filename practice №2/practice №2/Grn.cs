using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic_1
{
    public class Grn : Currency
    {
        public override double rate { get; set; } = 95;

        public override string currencyPrefix { get; set; } = "GRN";
    }
}
