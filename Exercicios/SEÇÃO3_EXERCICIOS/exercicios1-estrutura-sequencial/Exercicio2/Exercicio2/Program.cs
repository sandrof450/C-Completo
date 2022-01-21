/*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π.raio2
Considere o valor de π = 3.14159
*/

using System;
using System.Globalization;

namespace Exercicio2
{
    class Exercicio2
    {
        static void Main()
        {
            double raio, area;
            double tt;
            area = 0;
            raio = 0;
            tt = 3.14159;

            Console.Write("Digite o valor do Raio: ");
            raio = double.Parse(Console.ReadLine());

            area = tt * raio * raio;

            Console.WriteLine("A = {0}", area.ToString("F4"));
            
        }
    }
}