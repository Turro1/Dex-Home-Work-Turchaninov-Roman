using System;
using System.Collections.Generic;
using System.Text;

namespace Home_work__9._1__Reflection_
{
    public class Figure
    {
        public string Name { get; set; }
        public int SideCount { get; set; }
        public double SideLenght { get; set; }

        public Figure(string Name, int SideCount, double SideLenght)
        {
            this.Name = Name;
            this.SideCount = SideCount;
            this.SideLenght = SideLenght;
        }
    }
}
