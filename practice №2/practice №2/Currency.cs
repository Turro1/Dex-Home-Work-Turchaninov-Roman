using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktic_1
{
    public class Currency
    {
        public virtual double rate { get; set; }

        public virtual string currencyPrefix { get; set; }
    }
}
