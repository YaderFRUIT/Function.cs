using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DVB(a, b));
            Console.ReadLine();
        }
        static int DVB(int a, int b)
        {
            if (a > b)
            {
                Console.Write(b);
                Console.WriteLine(" - наименьшее");
                return b;
            }
            else if (a < b)
            {
                Console.Write(a);
                Console.WriteLine(" - наименьшее");
                return a;
            }
            return a;
        }
    }
}
