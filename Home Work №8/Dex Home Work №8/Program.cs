using System;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dex_Home_Work__8
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Figure> ListFigure = new List<Figure>();
            Random random = new Random();
            string[] nameFigure = { "Triangle", "Square", "Octagon", "Rhombus", "Parallelepiped" };
            for (int i =0;i<10;i++)
            {
               var figure = new Figure() { Name = nameFigure[random.Next(0, nameFigure.Length)], SideCount = random.Next(2,8), SideLenght = random.Next(1,20)};
                ListFigure.Add(figure);
            }

            var serList = JsonConvert.SerializeObject(ListFigure);

            Console.WriteLine(serList.ToString());

            var desTriangle = JsonConvert.DeserializeObject<List<Figure>>(serList);
            var triangle = new Figure() { Name = "Triangle", SideCount = 3, SideLenght = 5 };

            var triangle1 = triangle.figure = triangle;
            ListFigure.Add(triangle);
            var serTriangle = JsonConvert.SerializeObject(ListFigure);  //Если сериализовать объект который имеет ссылку сам на себя - программа выдаст исключение

            Console.WriteLine(serTriangle.ToString());

            var deSer = JsonConvert.DeserializeObject<List<Figure>>(serTriangle);
            Console.ReadLine();
        }
    }
}
