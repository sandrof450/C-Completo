using System;

namespace Exercicio
{
    class Exercicio
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem sua cas? ");
            string quartos = Console.ReadLine();

            Console.Write("Entre com o preço de um produto: ");
            string precoProduto = Console.ReadLine();

            Console.Write("Entre com seu ultimo nom, idade e altura(mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);


            Console.WriteLine("SAÍDA ESPERADA(NÚMEROS REAIS COM DUAS CASAS DECIMAIS): ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos); 
            Console.WriteLine($"{precoProduto:F2}");
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine($"{altura:F2}");
            

        }
    }
}
