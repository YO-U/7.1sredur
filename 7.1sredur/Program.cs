using System;
using System.Text;
namespace _7._2sredur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                if ((short)str[i] >= 65 && (short)str[i] <= 122) continue;
                res += str[i];
            }
            Console.WriteLine(res);



        }
    }
}
