using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    class Trafficlight
    {
        public string s = "OOOOO";
        public ConsoleColor[] color = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green };
        public int cursor;
        public void Show()
        {
            cursor = 0;

        }
        public void Color(int i)
        {
            if (cursor == i)
            {
                Console.ForegroundColor = color[i];
            }
            else { Console.ForegroundColor = ConsoleColor.White; }
        }
        public void Move()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                ShowMenu();
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor < 0) cursor = 2;
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor > 2) cursor = 0;
                }
            }
        }
        public void ShowMenu()
        {
            Console.Clear();
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                Color(index);
                Console.WriteLine(s);
                index++;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Trafficlight trafficlight = new Trafficlight();
            trafficlight.Move();
        }
    }
}
