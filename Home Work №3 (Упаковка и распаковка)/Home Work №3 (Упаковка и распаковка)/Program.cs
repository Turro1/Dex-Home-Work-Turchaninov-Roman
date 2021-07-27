using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Home_Work__3__Упаковка_и_распаковка_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatchbox = new Stopwatch();
            Stopwatch stopwatchunbox = new Stopwatch();
            int i = 123;
            stopwatchbox.Start();
            object o = i; // упаковка
            stopwatchbox.Stop();
            stopwatchunbox.Start();
            i = (int)o; // распаковка
            stopwatchunbox.Stop();

            Console.WriteLine($"Время упаковки: {stopwatchbox.Elapsed}\nВремя распаковки: {stopwatchunbox.Elapsed}");
            Console.ReadLine();
        }

    }
}
