using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace polosa
{
    class Program
    {
        class MyThread
        {
            Thread thread;
            public MyThread()
            {
                thread = new Thread(Po);
            }
            public void StartThread()
            {
                thread.Start();
            }
            public void Po()
            {
                Thread.Sleep(2000);
                for (int i = 0; i < 100; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("=");
                    Thread.Sleep(3000);
                }
            }
        }
        static void Main(string[] args)
        {
            MyThread t1 = new MyThread();
            t1.StartThread();
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
                Thread.Sleep(1000);
            }

        }
    }
}