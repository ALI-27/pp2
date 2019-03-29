using System;
using System.Threading;


public class Program
{
    static void Main(string[] args)
    {

        Console.BackgroundColor = ConsoleColor.Magenta;
        Console.ForegroundColor = ConsoleColor.Black;
        new Thread(changeBackground).Start();
        string someString = "Is this a real life, or is this just fantasy?";

        for (int i = 0; i <= someString.Length; i++)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(someString.Substring(0, i));
            Thread.Sleep(100);
            Console.Clear();
        }
    }
    static void changeBackground()
    {

        while (true)
        {
            if (Console.BackgroundColor == ConsoleColor.Magenta)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            Thread.Sleep(200);
        }
    }

}