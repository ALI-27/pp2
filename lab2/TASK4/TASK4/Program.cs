using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string OIL = "100%";

            string path2 = @"C:\Users\HP\Desktop\KKINA\task4\test.txt";
            StreamWriter file = new StreamWriter(@"C:\Users\HP\Desktop\KKINA\tttt\Test.txt");
            file.Write(OIL);
            file.Close();
            string path = @"C:\Users\HP\Desktop\KKINA\tttt\Test.txt";
            if (File.Exists(path2))
            
            {
                File.Delete(path2);    
                File.Move(path, path2);    
                                           

            }
        }
    }
}
