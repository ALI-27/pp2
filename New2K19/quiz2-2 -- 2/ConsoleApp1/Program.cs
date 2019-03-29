using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ErzhQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Thread thread1 = new Thread(mythread1);
            Thread thread2 = new Thread(mythread2);


            thread1.Start();
            thread2.Start();
        }

        
        static void mythread1()
        {
            int h = 20;
            int j = 1;
            
            for (int i = 1; i < h; i++)
            {
                j = j * i;
            }
            Console.WriteLine("I dont know :" + j);
        }
        static void mythread2()
        {
            int h = 20;
            int j = 0;
            
            for (int i = 0; i < h; i++)
            {
                j = j + i;
            }
            Console.WriteLine("I know :" + j);
        }
    }
}
