using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            Random random = new Random();
            int [] mas = new int[10];
            int i;
            int value2 = 0;
            int value1 = 0;
            for(i=0;i<mas.Length;i++)
            {             
                mas[i] = random.Next(-10, 10);
                if (mas[i]%2==0)
                {
                    value1++;
                }
                else
                {
                    value2++;
                }
            }
            for(i=0;i<mas.Length;i++)
            {
                Console.WriteLine($"массив[{i}]= {mas[i]}");
            }
            Console.WriteLine($"четных: {value1}");
            Console.WriteLine($"нечетных: {value2}");
        }
    }
}
