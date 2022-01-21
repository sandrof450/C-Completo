/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
 * código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
 */

using System;
using System.Globalization;

namespace Exercicio5
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            int cdPeca1, npeca1;
            double precoPeca1, precoTotalPeca1;

            int cdPeca2, npeca2;
            double precoPeca2, precoTotalPeca2;

            int nPecas;
            double precoTotalPecas;

            string[] valores = Console.ReadLine().Split(' ');
            cdPeca1 = int.Parse(valores[0]);
            npeca1 = int.Parse(valores[1]);
            precoPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cdPeca2 = int.Parse(valores[0]);
            npeca2 = int.Parse(valores[1]);
            precoPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            precoTotalPecas = npeca1 * precoPeca1 + npeca2 * precoPeca2;

            Console.WriteLine("VALOR A PAGAR: {0:F}", precoTotalPecas);
        }
    }
}
