using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            Console.WriteLine("Сколько n элементов? ");
            int n = int.Parse(Console.ReadLine());
            Input(n);
        }
        static void Input(int n)
        {
            int[] mas = new int[n];
            int i;
            for (i = 0; i < mas.Length; i++)
            {
                Console.Write($"массив[{i}]=");
                mas[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
            for (i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"массив[{i}]= {mas[i]}");
            }
        }
    }
}
