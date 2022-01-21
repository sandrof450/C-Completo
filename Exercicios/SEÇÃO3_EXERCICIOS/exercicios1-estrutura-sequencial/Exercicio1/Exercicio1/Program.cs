// See https://aka.ms/new-console-template for more information
using System;

//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
//mensagem explicativa, conforme exemplos.
namespace Exercicio1
{
    class Exercicio1 { 
        static void Main(string[] args)
        {

            int n1, n2, soma;
            n1 = n2 = soma = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite um número: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Digite um número: ");
                n2 = int.Parse(Console.ReadLine());

                soma = n1 + n2;

                Console.WriteLine("SOMA: {0}", soma);
                Console.WriteLine("------------------------------\n\n");
            }

        }
    
    }

}
