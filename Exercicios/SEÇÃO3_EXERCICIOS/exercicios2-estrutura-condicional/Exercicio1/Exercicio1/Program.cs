//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

using System;
namespace Exercicio1
{
    class Exercicio1
    {
        static void Main(string[] args)

        {
            int n1 = 0;


            Console.Write("Digite um número inteiro: ");
            n1 = int.Parse(Console.ReadLine());

            if(n1 >= 0)
            {
                Console.WriteLine("Você digitou um número positivo!");
            }
            else
            {
                Console.WriteLine("Você digitou um numero negativo!");
            }

        }
    }
}
