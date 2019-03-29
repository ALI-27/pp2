using System;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Movie FavouriteMovie { get; set; }

    public Person()
    { }

    public Person(string name, int age, Movie movie)
    {
        Name = name;
        Age = age;
        FavouriteMovie = movie;
    }
}



[Serializable]
public class Movie
{

    public string Title { get; set; }
    public int ReleaseYear { get; set; }

    public Movie() { }

    public Movie(string title, int releaseYear)
    {
        Title = title;
        ReleaseYear = releaseYear;
    }



}
class Program
{
    static void Main(string[] args)
    {


        Movie firstMovie = new Movie("Emoji movie", 2017);
        Movie secondMovie = new Movie("50 shades of gray", 2015);
        Movie thirdMovie = new Movie("Shrek", 1999);
        Movie fourthMovie = new Movie("NinjaCop", 1987);

        Person akbar = new Person("Akbar", 29, secondMovie);
        Person ramesh = new Person("Ramesh", 20, firstMovie);
        Person durga = new Person("Durga", 43, fourthMovie);
        Person daler = new Person("Daler", 38, thirdMovie);



        var array = new Person[] { akbar, ramesh, durga, daler };
        // foreach (var item in array)
        // {
        //     System.Console.WriteLine(item.Age.ToString() + item.Name);
        // }


        XmlSerializer formatter = new XmlSerializer(typeof(Person[]));

        using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, array);
        }

        using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
        {
            Person[] newPerson = (Person[])formatter.Deserialize(fs);


            foreach (var item in array)
            {
                System.Console.WriteLine(item.Age.ToString() + item.Name);
            }

        }

        Console.ReadLine();
    }
}