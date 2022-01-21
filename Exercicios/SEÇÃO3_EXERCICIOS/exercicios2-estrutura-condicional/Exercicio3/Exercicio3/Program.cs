/*Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.
*/

using System;

namespace Exercicio3
{
    class Exercicio3
    {
        static void Main(string[] args)
        {

            int n1, n2, res;
            n1 = n2 = 0;

            Console.Write("Digite dois valores inteiros: ");
            string[] vet = Console.ReadLine().Split(' ');
            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);

            if (n1 >= n2)
            {
                res = n1 % n2;
            }
            else
            {
                res = n2 % n1;
            }

            if (res == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }

        }
    }
}