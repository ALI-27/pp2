using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool PrimeString(string s)
        {
            return Prime(int.Parse(s));
        }
        static bool Prime(int x)
        {
            if (x == 1) return false;        
            if (x == 2) return true;       
            bool level = true;    

            for (int i = 2; i < x; ++i)
            {
                if (x % i == 0)     
                {
                    level = false;
                    break;
                }
            }
            return level;   
        }

        

        static void Main(string[] args)
        {

            List<string> res = new List<string>();
            
            FileStream fs = new FileStream(@"C:\Users\HP\Desktop\KKINA\INPUT\input.txt", FileMode.Open, FileAccess.Read);
            
            StreamReader sr = new StreamReader(fs);
            

            string line = sr.ReadLine();
            
            string[] nums = line.Split(' ');
           

            foreach (var x in nums)  
            {
                if (PrimeString(x))    
                {
                    res.Add(x);  
                }
            }

            sr.Close();     
            fs.Close();



            FileStream fs2 = new FileStream(@"C:\Users\HP\Desktop\KKINA\output.txt", FileMode.Create, FileAccess.Write);
           
            StreamWriter sw = new StreamWriter(fs2); 

            foreach (var x in res)
            {
                sw.Write(x + " ");      
                Console.Write(x + " "); 
            }

            sw.Close();    
            fs2.Close();

        }
       
    }
}