using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Threading;

namespace LamdaTest
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Круг маленький и похож на овал
             Action<int, int> write = (xp, yp) => { Console.SetCursorPosition(xp, yp); Console.Write("*"); };
            int centerX = 30, centerY = 10, radius = 8, x = -radius;
            while (x < radius)
            {
                var y = (int)Math.Floor(Math.Sqrt(radius * radius - x * x));
                write(x + centerX, y + centerY);
                y = -y;
                write(x + centerX, y + centerY);
                x++;
                Thread.Sleep(3000);
            }
            Console.ReadLine();
            */








            /*Круг большой но более похож на круг
             *int r = 30;
             int x = 0;
             for (int y = 0; y < r; ++y)
             {
                 x = (int)Math.Round(2 * Math.Sqrt((Math.Pow(r, 2) - Math.Pow(y, 2))));
                 Console.SetCursorPosition(x + r, y + r);
                 Console.Write('*');
                 Console.SetCursorPosition(x + r, -y + r);
                 Console.Write('*');
                 Console.SetCursorPosition(-x + 2 * r, -y + r);
                 Console.Write('*');
                 Console.SetCursorPosition(-x + 2 * r, y + r);
                 Console.Write('*');
                 Thread.Sleep(3000);
             }
             Console.SetCursorPosition(0, r * 2 + 2);
             */








            /*Console.CursorVisible = false;
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);            //Квадрат
            for (int i = 0; i < 10; ++i)
            {
                Console.Write('.');
                Thread.Sleep(500);
            }
            
            for (int i = 0; i < 10; ++i)
            {
                Console.SetCursorPosition(10, i);
                Console.Write('.');
                Thread.Sleep(500);
            }
            
            for (int i = 10; i >= 0; --i)
            {
                Console.SetCursorPosition(i, 10);
                Console.Write('.');
                Thread.Sleep(500);
            }
            
            for (int i = 10; i >= 0; --i)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('.');
                Thread.Sleep(500);
            }
            Thread.Sleep(10000);
            */








            /*
             *const int distanceBetween = 10;
             for (int i = 0; i < 5; i++)               //Приметивный синус
             {
                 for (int j = 0; j < 5 * distanceBetween; j++)
                 {
                     if (j % distanceBetween == distanceBetween - i || j % distanceBetween == i)
                         Console.Write("*");
                     else
                         Console.Write(" ");
                 }
                 Console.WriteLine();
                Thread.Sleep(500);
            }
             */
             





            /* double a = 0, da = Math.PI * 2 / 79;            //Синус хороший код
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.White;
              for (int y = 0; y < 25; y++)
              {
                  Console.SetCursorPosition(0, y);
                  Console.Write('|');
              }
              for (int x = 0; x < 80; x++)
              {
                  Console.SetCursorPosition(x, 12);
                  Console.Write('_');
              }
              for (int x = 1; x < 80; x++, a += da)
              {
                  Console.SetCursorPosition(x, 12 - (int)(Math.Sin(a) * 13));
                  Console.Write('*');
                 Thread.Sleep(1000);
              }
              Console.ReadKey();
              */





            /*  Console.CursorVisible = false; 
              int x = 15;
              int y = 15;
              ConsoleKeyInfo k;                    //код для реализации движение ввиде змейки
              do
              {
                  Console.SetCursorPosition(x, y);
                  Console.ForegroundColor = ConsoleColor.Red;
                  Console.Write("*");
                  Console.ForegroundColor = ConsoleColor.White;
                  k = Console.ReadKey(true);
                  if (k.Key == ConsoleKey.UpArrow)
                      y--;
                  else if (k.Key == ConsoleKey.DownArrow)
                      y++;
                  else if (k.Key == ConsoleKey.LeftArrow)
                      x--;
                  else if (k.Key == ConsoleKey.RightArrow)
                      x++;
                  Console.Clear();
              } while (k.Key != ConsoleKey.Escape); // выходим из цикла по нажатию Esc
              */



            /*             //Движение игрока анимеция и вместе с ним флаг при достижении которого победа
            Console.CursorVisible = false; // гасим курсор
            ConsoleKeyInfo k;
            // Координаты игрока
            int playerX = 15;
            int playerY = 15;
            char playerChar = 'X';
            // Координаты флага
            int flagX = 25;
            int flagY = 5;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(flagX, flagY);
                Console.Write("F"); // флаг
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(playerChar);
                // Анимация движения игрока
                playerChar = playerChar == 'X' ? 'Y' : 'X';
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.UpArrow)
                    playerY--;
                else if (k.Key == ConsoleKey.DownArrow)
                    playerY++;
                else if (k.Key == ConsoleKey.LeftArrow)
                    playerX--;
                else if (k.Key == ConsoleKey.RightArrow)
                    playerX++;
                if (playerX == flagX && playerY == flagY)
                {
                    Console.Clear();
                    Console.WriteLine("EPIC WIN!");
                    break; // выходим из цикла do - while
                }
            } while (k.Key != ConsoleKey.Escape); // выходим из цикла по нажатию Esc
            Console.CursorVisible = true;
            */
        }
    }
}
