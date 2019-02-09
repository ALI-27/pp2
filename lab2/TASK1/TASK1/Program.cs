using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
       public static void Main(string[] args)
        {
            string VALUE = File.ReadAllText(@"C:\Users\HP\Desktop\KKINA\INPUT\input.txt");
           
            string newpath = new string(VALUE.ToCharArray().Reverse().ToArray());
            
            string TEXT = "Yes";
            string TEXT2 = "No";
            if ( VALUE == newpath)  
            {
                File.WriteAllText(@"C:\Users\HP\Desktop\KKINA\output.txt", TEXT);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Yes");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                File.WriteAllText(@"C:\Users\HP\Desktop\KKINA\output.txt", TEXT2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}