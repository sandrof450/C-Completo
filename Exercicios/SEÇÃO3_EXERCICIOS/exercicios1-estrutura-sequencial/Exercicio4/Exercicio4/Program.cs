/*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.*/
using System;
using System.Globalization;

namespace Exercicio4
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            int n, hrs;
            double salariohrs, totalSalario;

            n = hrs = 0;
            salariohrs = totalSalario = 0;

            Console.Write("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhada: ");
            hrs = int.Parse(Console.ReadLine());

            Console.Write("Digite quanto recebe por hora: ");
            salariohrs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalSalario = hrs * salariohrs;

            Console.WriteLine("NUMBER: {0}", n);
            Console.WriteLine("SALARY: U${0:F2}", totalSalario);

        }
    }
}