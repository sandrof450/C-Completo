/*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.
*/
using System;
using System.Globalization;
namespace Exercicio5{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            int cod, quant;
            double res = 0.0;

            Console.Write("Digite o código e a quantidade do item: ");
            string[] vet = Console.ReadLine().Split(' ');
            cod = int.Parse(vet[0]);
            quant = int.Parse(vet[1]);


            if (cod == 1)
            {
                res = quant * 4.0;
            }
            else if(cod == 2)
            {
                res = quant * 4.5;
            }
            else if (cod == 3)
            {
                res = quant * 5.0;
            }
            else if (cod == 4)
            {
                res = quant * 4.5;
                Console.WriteLine($"TOTAL: ${res:F2}");
            }
            else if (cod == 5)
            {
                res = quant * 4.5;
            }
            Console.WriteLine("Total: R$ " + res.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}