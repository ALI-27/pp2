using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            b = int.Parse(Console.ReadLine());
            int[] a = new int[b];
            for (int i = 0; i < b; ++i)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < b; ++i)
            {
                Console.Write(a[i] + " " + a[i] + " ");
            }
        }
    }
}