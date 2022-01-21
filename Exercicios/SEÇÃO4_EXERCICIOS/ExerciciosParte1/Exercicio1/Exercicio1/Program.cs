using System;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pVelha;

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                pVelha = pessoa1.Nome;
            }
            else
            {
                pVelha = pessoa2.Nome;
            }

            Console.WriteLine($"Pessoa mais velha: {pVelha}");
        }
    }
}
