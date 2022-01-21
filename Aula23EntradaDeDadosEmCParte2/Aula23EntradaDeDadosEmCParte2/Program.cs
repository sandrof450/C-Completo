using System;

namespace Aula23
{
    class Aula23
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split(' ');
            string nome = s[0];
            char sexo = char.Parse(s[1]);
            int idade = int.Parse(s[2]);
            double altura = double.Parse(s[3]);
        
            Console.WriteLine("Você digitou ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        }


    }
}
