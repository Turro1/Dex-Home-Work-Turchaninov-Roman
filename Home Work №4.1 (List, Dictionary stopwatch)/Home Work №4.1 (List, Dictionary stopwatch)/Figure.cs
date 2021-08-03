using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__4._1__List__Dictionary_stopwatch_
{
    public class Figure
    {
        public int SideCount { get; set; }
        public int SideLenght { get; set; }

        public void Display()
        {
            Console.WriteLine($"\nКоличество сторон: {SideCount}\nДлина стороны: {SideLenght}\n");
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            return false;
            if (!(obj is Figure))
            return false;
            var result = (Figure)obj;
            return result.SideCount == SideCount && result.SideLenght == SideLenght;
        }

        public override int GetHashCode()
        {
            return SideCount + SideLenght;
        }
    }
}
