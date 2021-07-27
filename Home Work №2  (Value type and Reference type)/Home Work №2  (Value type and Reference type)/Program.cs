using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__2___Value_type_and_Reference_type_
{
    class Program
    {
       static void Main(string[] args)
        {
            Kvadrat kvadrat1 = new Kvadrat() { KolvoGraney = 4, DlinaGraney = 7, Square = 15};
            Kvadrat kvadrat2 = kvadrat1;

            kvadrat1.DlinaGraney = 4;

            Kvadrat calc = CalcKvadrat(kvadrat1);
            kvadrat1.Display();
            kvadrat2.Display();
            calc.Display();

            Figura figura1 = new Figura() { KolvoGraney = 4, DlinaGraney = 7, Square = 15 };
            Figura figura2 = figura1;

            figura1.DlinaGraney = 16;
            Figura calc1 = CalcFigura(figura1);
            figura1.Display();
            figura2.Display();
            calc1.Display();
        }
        
        public static Kvadrat CalcKvadrat(Kvadrat kvadrat3)
        {
            
            kvadrat3 = new Kvadrat() {KolvoGraney= kvadrat3.KolvoGraney ,DlinaGraney = kvadrat3.DlinaGraney ,Square = kvadrat3.DlinaGraney * kvadrat3.KolvoGraney / 2 };
            return kvadrat3;
        }
        public static Figura CalcFigura(Figura figura3)
        {

           figura3 = new Figura() { KolvoGraney = figura3.KolvoGraney, DlinaGraney = figura3.DlinaGraney, Square = figura3.DlinaGraney * figura3.KolvoGraney / 2 };
            return figura3;
        }
    }
}
