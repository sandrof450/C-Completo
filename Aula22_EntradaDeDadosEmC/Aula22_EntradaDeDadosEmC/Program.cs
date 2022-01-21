using System;

namespace Aula22
{
    class Aula22
    {
        static void Main(string[] args)
        {

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();
            
            
            string[] s = Console.ReadLine().Split(' ');
            string p1 = s[0];
            string p2 = s[1];
            string p3 = s[2];



            Console.WriteLine($"Você digitou");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            Console.WriteLine($"{p1}, {p2}, {p3}");



        }
    }
}