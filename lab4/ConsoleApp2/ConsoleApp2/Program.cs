using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace task2
{
    public class Program
    {
        public class Marks
        {
            public string letter;
            public int points;
            public Marks()
            {

            }
            public void GetLetter(int points)
            {
                if (points <= 100 && points >= 95)
                {
                    letter = "A";
                }
                else if (points <= 94 && points >= 90)
                {
                    letter = "A-";
                }
                else if (points <= 89 && points >= 85)
                {
                    letter = "B+";
                }
                else if (points <= 84 && points >= 80)
                {
                    letter = "B";
                }
                else if (points <= 79 && points >= 75)
                {
                    letter = "B-";
                }
                else if (points <= 74 && points >= 70)
                {
                    letter = "C+";
                }
                else if (points <= 69 && points >= 65)
                {
                    letter = "C";
                }
                else if (points <= 64 && points >= 60)
                {
                    letter = "C-";
                }
                else if (points <= 59 && points >= 55)
                {
                    letter = "D+";
                }
                else if (points <= 54 && points >= 50)
                {
                    letter = "D-";
                }
                else if (points <= 49 && points >= 0)
                {
                    letter = "F";
                }
            }
            
            public void PrintInfo()
            {
                Console.WriteLine(letter + " " + points);
            }
            public override string ToString()
            {
                return letter + " " + points;
            }
        }
        static void Main(string[] args)
        {
            Serializer();
            Deserialize();

        }
              public static void Deserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Marks>));
           
            using (FileStream fs = new FileStream("tttt.txt", FileMode.Open))   //открываем файл для чтения
            {
                List<Marks> res = (List<Marks>)xs.Deserialize(fs);   //Десеривализуем то чо в файле тхт в лист рес
                foreach (var el in res)
                {
                    Console.WriteLine("Marks: {0}", el.ToString()); //показываем в консоле преоброзовывая ее в стринг методом toString()
                }
            }
        }
        public static void Serializer()
        {

            List<Marks> Point = new List<Marks>();  //Объявляем лист 
            Marks Student = new Marks();    //Записываем новый марк
            Student.points = int.Parse(Console.ReadLine());    //У студента есть определенное кол. баллов , вводим сами

            if (Student.points > 100)
            {
                Student.points = 100;
            }
            else if (Student.points < 0)
            {
                Student.points = 0;
            }

            Student.GetLetter(Student.points);              //С помощью GetLetter мы определяем какая оценка по буквам у студента
            Point.Add(Student);             //     И то что имееться в Студенте мы добовляем в лист Пойнт
            Student.PrintInfo();              //   Показываем что есть в Студенте на консоле

            XmlSerializer xs = new XmlSerializer(typeof(List<Marks>));    //Объявляем что серилизуем лист Марк
            FileStream fs = new FileStream("tttt.txt", FileMode.Create, FileAccess.Write);    // Создаем тхт файл и пишем в нее то что будем среиализовать  
            xs.Serialize(fs, Point);  //в файл сериализуем то что в Поинте
            fs.Close();   //закрываем 
        }
    }
}