using System;
using System.ComponentModel;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input("n= ");
            int[] mas = new int[n];
            Mas(n,mas);
            End(mas);
            Console.Read();
        }
        static int Input(string mes)
        {
            Console.WriteLine(mes);
            return int.Parse(Console.ReadLine());
        }
        static void Mas (int n, int[]mas)
        {
            int i;
            for (i = 0; i < mas.Length; i++)
            {
                Console.Write($"массив[{i}]=");
                mas[i] = int.Parse(Console.ReadLine());
            }
        }
        static void End(int[]mas)
        {
            int i;
            for (i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"массив[{i}]= {mas[i]}");
            }
        }
    }
}
