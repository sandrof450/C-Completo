using System;
using Exercicio2.Entities;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Coment c1 = new Coment("Have a nice trip");
            Coment c2 = new Coment("HaveWow that´s awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling New Zeland",
                "I'm going to visit this wonderful coutry",
                12);

            p1.AddComent(c1);
            p1.AddComent(c2);

            Coment c3 = new Coment("Good night");
            Coment c4 = new Coment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("21/06/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComent(c3);
            p2.AddComent(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}