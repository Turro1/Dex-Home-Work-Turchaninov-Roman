using System;
using System.IO;
using System.Reflection;

namespace Home_work__9._1__Reflection_
{
    class Program
    {
        public string path = Path.Combine(@"E:\\", "Курсы Dex", "Dex-Home-Work-Turchaninov-Roman", "Home work №9.1 (Reflection)", "Files");
        static void Main(string[] args)
        {
            var figure = new Figure("Triangle", 3, 10);
            FiguereProperties(figure);
            MethodFromProjectTwo(figure);
        }

        static void FiguereProperties(object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                Console.WriteLine($"Имя свойства = {property.Name}, Содержимое свойства = {property.GetValue(obj)}");
            }
        }

        static void MethodFromProjectTwo(Figure figure)
        {
            string path = @"E:\Курсы Dex\Dex-Home-Work-Turchaninov-Roman\Home work №9.2 (method)\Home work №9.2 (method)\bin\Debug\netcoreapp3.1\Home work №9.2 (method).dll";
            Assembly assembly = Assembly.LoadFrom(path);
            var type = assembly.GetType($"Home_work__9._2__method_.Program", true, true);

            object obj = Activator.CreateInstance(type);
            MethodInfo methodInfo = type.GetMethod("TextFromFile");
            object res = methodInfo.Invoke(obj, new object[] { $"Figure name: {figure.Name}, Side Lenght: {figure.SideLenght}" });
            Console.Write(res.ToString());
        }

    }
}
