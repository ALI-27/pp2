using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AAAAAAAAAAAAAAAAA
{
    class Program
    {
        static void Main(string[] args)
        {
            int startposx = 20;
            int startposy = 20;

            Console.ForegroundColor = ConsoleColor.Red;
            for (int x = 0; x < 10; x++)
            {
                int y = (x + 2) * -1;//считаем уравнение
                Console.SetCursorPosition(startposx + x, startposy + y);
                Console.Write("*");
                Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
    }
}
