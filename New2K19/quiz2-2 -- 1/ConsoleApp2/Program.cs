using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;
using System.IO;

namespace ErzhQ2
{
    class Program
    {
        public class Person
        {
            public string name;
            public string massage;
            public void PrintInfo()
            {
                Console.WriteLine(name + ":" + massage);
            }
            public override string ToString()
            {
                return name + ":" + massage;
            }
        }
        static void Main(string[] args)
        {
            List<Person> sms = new List<Person>();
            Person Erzhan = new Person();
            Erzhan.name = "Erzhan";
            Erzhan.massage = "Hello!";
            Person Esdaulet = new Person();
            Esdaulet.name = "Esdaulet";
            Esdaulet.massage = "Hello! How are you&";
            sms.Add(Erzhan);
            sms.Add(Esdaulet);
            Erzhan.PrintInfo();
            Esdaulet.PrintInfo();
            XmlSerializer xs = new XmlSerializer(typeof(List<Person>));    //Îáúÿâëÿåì ÷òî ñåðèëèçóåì ëèñò Ìàðê
            FileStream fs = new FileStream("tttt.txt", FileMode.Create, FileAccess.Write);    // Ñîçäàåì òõò ôàéë è ïèøåì â íåå òî ÷òî áóäåì ñðåèàëèçîâàòü  
            xs.Serialize(fs, sms);  //â ôàéë ñåðèàëèçóåì òî ÷òî â Ïîèíòå
            fs.Close();
            using (FileStream fs1 = new FileStream("tttt.txt", FileMode.Open))   //îòêðûâàåì ôàéë äëÿ ÷òåíèÿ
            {
                List<Person> res = (List<Person>)xs.Deserialize(fs1);   //Äåñåðèâàëèçóåì òî ÷î â ôàéëå òõò â ëèñò ðåñ
                foreach (var el in res)
                {
                    Console.WriteLine("Marks: {0}", el.ToString()); //ïîêàçûâàåì â êîíñîëå ïðåîáðîçîâûâàÿ åå â ñòðèíã ìåòîäîì toString()
                }
            }

        }

    }
}