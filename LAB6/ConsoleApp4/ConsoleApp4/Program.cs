using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread thread1 = new Thread(mythread1);
            Thread thread2 = new Thread(mythread2);
            Thread thread3 = new Thread(mythread3);
         
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        static void mythread2()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Thread 2 deduce " + i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Thread 2 = end");
        }
        static void mythread1()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" Thread 1 deduce " + i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Thread 1 = end ");
        }

        static void mythread3()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Thread 3 deduce " + i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Thread 3 = end");
        }
    }
}