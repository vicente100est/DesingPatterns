using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace IntroDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVoladr> aves = new List<IVoladr>();

            var pato1 = new Pato();
            var pato2 = new Pato();
            var pato3 = new Pato();

            var gallina1 = new Gallina();

            aves.Add(pato1);
            aves.Add(pato2);
            aves.Add(pato3);
            aves.Add(gallina1);

            AVolar(aves);
            //SportyPerson vicente = new SportyPerson("Vicente", 23, "Mexican");
            //Console.WriteLine(vicente.ShowData());
            //Console.WriteLine(vicente.Run());
        }

        static void AVolar(List<IVoladr> aves)
        {
            foreach (var ave in aves)
            {
                Console.WriteLine(ave.Vuela());
            }
        }

        interface IVoladr
        {
            public bool Vuela();
        }

        interface ICaminador
        {
            public bool Camina();
        }

        public class Pato : IVoladr, ICaminador
        {
            public bool Vuela()
            {
                return true;
            }

            public bool Camina()
            {
                return true;
            }
        }

        public class Gallina : IVoladr
        {
            public bool Vuela()
            {
                return true;
            }
        }
    }

    //abstract class Person
    //{
    //    public string name;
    //    public int age;
    //    public string nationality;

    //    public Person(string name, int age, string nationality)
    //    {
    //        this.name = name;
    //        this.age = age;
    //        this.nationality = nationality;
    //    }

    //    public string ShowData()
    //    {
    //        return name + ", " + age + ", " + nationality;
    //    }
    //}

    //class SportyPerson : Person
    //{
    //    public SportyPerson(string name, int age, string nationality) : base (name, age, nationality)
    //    {   }

    //    public string Run()
    //    {
    //        return "Is running";
    //    }
    //}
}
