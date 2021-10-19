using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;//объявление переменной
            Console.Write("Введите x = ");//Принлашение к вводу
            x = Convert.ToInt32(Console.ReadLine());//Присваивание значений
            if (x % 4 == 0)
                Console.WriteLine("y=" + x / 4);

            else
                Console.WriteLine("Введеное число не делится нацело");
            Console.ReadKey();
        }
    }
}
