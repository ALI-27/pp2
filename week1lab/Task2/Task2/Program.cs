using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string imya;
        public string ID;
        public int study;
        public void Output()
        {
            Console.Write(imya + " " + ID + " " + (study + 1));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student man = new Student();
            man.imya = Convert.ToString(Console.ReadLine());
            man.ID = Convert.ToString(Console.ReadLine());
            man.study = int.Parse(Console.ReadLine());
            man.Output();
        }
    }
}
