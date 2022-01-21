/*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

using System;

namespace Exercicio3
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
            int A, B, C, D, dif;
            A = B = C = D = dif = 0;

            Console.Write("Digite um valor: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor: ");
            C = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor: ");
            D = int.Parse(Console.ReadLine());

            dif = (A * B - C * D);

            Console.WriteLine("DIFERENÇA: {0}", dif);
        }
    }
}
