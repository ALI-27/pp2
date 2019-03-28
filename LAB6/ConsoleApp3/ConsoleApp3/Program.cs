using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread1
{                                      //Решение может быть неправильным
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Thread[] threads1 = new Thread[n];
            Thread thread1 = new Thread(DoIt);
            Thread thread2 = new Thread(DoIt1);
            Thread thread3 = new Thread(DoIt2);
            for (int i = 0; i < n; i++)
            {
                thread1.Start();
                thread2.Start();
                thread3.Start();
            }


        }

        private static void DoIt()
        {
            Thread.CurrentThread.Name = "Tortay";
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }

        private static void DoIt1()
        {
            Thread.CurrentThread.Name = "Alikhan";
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(Thread.CurrentThread.Name);
            }

        }
        private static void DoIt2()
        {
            Thread.CurrentThread.Name = "Bakytzhanuly";
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(Thread.CurrentThread.Name);
            }

        }
    }
}