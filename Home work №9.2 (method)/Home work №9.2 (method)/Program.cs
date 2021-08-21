using System;
using System.IO;

namespace Home_work__9._2__method_
{
    class Program
    {
        static void Main(string[] args)
        {
		}
		public static string TextFromFile(string text)
		{
			string path =  Path.Combine(@"E:\\","Курсы Dex","Dex-Home-Work-Turchaninov-Roman","Home work №9.1 (Reflection)","Files");
			DirectoryInfo directoryInfo = new DirectoryInfo(path);

			if (!directoryInfo.Exists)
			{
				directoryInfo.Create();
			}
			File.WriteAllText($"{path}\\properties.txt", text);
			var prop = File.ReadAllText($"{path}\\properties.txt");
			return $"Текст из файла -  {prop}";
		}
	}
}
