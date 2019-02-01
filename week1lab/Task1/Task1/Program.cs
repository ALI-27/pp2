using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            b = int.Parse(Console.ReadLine());   // это сin
            int[] a = new int[b];                // обьявление массива int a[ ] = b ;

            for (int i = 0; i < b; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int kbtu = 0;      // 
            bool value = false;     



            for (int i = 0; i < b; i++)
            {
                value = false;
                if (a[i] <= 1) continue;    
                else
                    for (int t = 2; t < a[i]; t++)
                        if (a[i] % t == 0) value = true;     
                if (!value) kbtu++;                    
            }

            Console.WriteLine(kbtu);

            for (int i = 0; i < b; i++)
            {
                value = false;
                if (a[i] <= 1) continue;
                else
                    for (int t = 2; t < a[i]; t++)
                        if (a[i] % t == 0) value = true;
                if (!value) Console.Write(a[i] + " ");     
            }
          }
    }
}