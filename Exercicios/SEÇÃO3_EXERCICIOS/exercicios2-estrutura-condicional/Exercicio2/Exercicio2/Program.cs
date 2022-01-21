//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

using System;
namespace Exercicio2
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            int n1 = 0;

            Console.Write("Digite um número inteiro: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
