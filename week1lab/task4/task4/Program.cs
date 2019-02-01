using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            b = int.Parse(Console.ReadLine());
            int[] a = new int[b];
            for (int i = 0; i <= b; i++)
            {
                for (int t = 1; t <= i; t++)
                    Console.Write("[*]");
                Console.WriteLine();
            }
        }
    }
}