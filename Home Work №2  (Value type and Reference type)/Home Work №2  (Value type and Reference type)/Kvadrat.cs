using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__2___Value_type_and_Reference_type_
{
    public class Kvadrat
    {
        public int KolvoGraney { get; set; }
        public int DlinaGraney { get; set; }
        
        public int Square { get; set; }

        public void Display() 
        {
            Console.WriteLine($"\t(Класс) Квадрат\nколичество граней:{KolvoGraney}\nдлина граней:{DlinaGraney}\nплощадь:{Square}");
            Console.ReadLine();
        }
    }
}
