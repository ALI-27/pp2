using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DataTime22
{
    class MyThreads
    {
        Thread timeThread = new Thread(() => { while (true) { Console.WriteLine(DateTime.Now); Thread.Sleep(1000); } });
        public void StartThread()
        {
            timeThread.Start();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            MyThreads t1 = new MyThreads();
            s = Console.ReadLine();
            t1.StartThread();
            string sbs = "";
            foreach (char c in s)
            {
                sbs += c;
                Console.WriteLine(sbs);
                Thread.Sleep(1000);
            }
        }
    }
}