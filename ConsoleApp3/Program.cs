using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            int[] mas = new int[8];
            int i;
            for(i=0;i<mas.Length;i++)
            {
                mas[i] = i;
            }
            foreach(int element in mas)
            {
                Console.Write($"{element}\t");
            }
        }
    }
}
