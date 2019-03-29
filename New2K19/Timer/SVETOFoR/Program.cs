
using System;
using System.Threading; //Именно это пространство имен поддерживает многопоточность
using System.IO;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(Func); //Создаем новый объект потока (Thread)

            myThread.Start(); //запускаем поток

        }
        static void Func()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= s; i++)
            {
                Console.Clear();
                Console.WriteLine(i.ToString());
                Thread.Sleep(1000);
            }
        }
    }
}