using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Home_Work__4._1__List__Dictionary_stopwatch_
{
    class Program
    {

        static void Main(string[] args)
        {
            int count1 = 1;
            int count2 = 1;
            Random random = new Random();
            Stopwatch stopWatchList = new Stopwatch();
            Stopwatch stopWatchDict = new Stopwatch();
            Figure figure1 = new Figure() { SideCount = 18, SideLenght = 50 };

            List<Figure> figuresList = new List<Figure>();
            
            for (int i = 0; i < 1000; i++)
            {
                figuresList.Add(new Figure() { SideCount = random.Next(3, 50), SideLenght = random.Next(1, 100) });
            }
            stopWatchList.Start();
            foreach (var item in figuresList)
            {
                figuresList.Contains(figure1);
            }
            stopWatchList.Stop();
            foreach (var item in figuresList)
            {
                Console.WriteLine($"Фигура №{count1++}");
                item.Display();
            }

            Dictionary<Figure, int> figuresDict = new Dictionary<Figure, int>();

            for (int i = 0; i < 1000; i++)
            {
                if (!figuresDict.ContainsKey(figure1))
                {
                    figuresDict.Add(new Figure() {SideCount = random.Next(3,1000), SideLenght = random.Next(1,1000) },count2++);
                }
            }
            stopWatchDict.Start();
            foreach (var item in figuresDict) 
            {
               figuresDict.ContainsKey(figure1);
            }
            stopWatchDict.Stop();
            foreach (var item in figuresDict)
            {
                Console.WriteLine($"Фигура №{item.Value}");
                Console.WriteLine($"\nКоличество сторон: {item.Key.SideCount}\nДлина стороны: {item.Key.SideLenght}\n");
            }
            Console.WriteLine($"Время выполнения операции поиска для листа: {stopWatchList.ElapsedTicks / 1000}");
            Console.WriteLine($"Время выполнения операции поиска для словаря: {stopWatchDict.ElapsedTicks / 1000}");
            Console.ReadLine();

        }
    }
}
