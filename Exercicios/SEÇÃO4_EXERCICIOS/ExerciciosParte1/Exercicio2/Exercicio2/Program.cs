using System;
using System.Globalization;

namespace Exercicio2
{
    class Program { 
        
        static void Main(string[] args)
        {
            double media = 0;

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("NOME: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("SALÁRIO: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("NOME: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("SALÁRIO: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            media = (funcionario1.Salario + funcionario2.Salario) / 2;


            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));


        }

    }

}

