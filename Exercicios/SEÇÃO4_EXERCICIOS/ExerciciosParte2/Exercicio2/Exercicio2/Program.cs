using System;
using System.Globalization;
namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Slário Bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionário: " + F);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(porcent);

            Console.WriteLine("Dados atualizados: " + F);


        }
    }
}
