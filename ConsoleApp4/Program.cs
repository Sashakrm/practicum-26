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
            Func();
            Console.Read();
        }
        static void Func()
        {
            int[] mas = new int[5] { 12, 34, 25, 3, 45 };
            int i;
            for(i=0;i<mas.Length;i++)
            {
                Console.WriteLine($"mas[{i}]= {mas[i]}");
            }
        }
    }
}
