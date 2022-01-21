/*Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
*/

using System;
namespace Exercicio4
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            int hInicial, hFinal, res;

            Console.Write("Digite a hora inicial e final do jogo: ");
            string[] vet = Console.ReadLine().Split(' ');
            hInicial = int.Parse(vet[0]);
            hFinal = int.Parse(vet[1]);

            if (hInicial >= hFinal)
            {
                hFinal += 24;
                res = hFinal - hInicial;
                if (res < 0)
                {
                    res *= -1;
                }
                Console.WriteLine($"O JOGO DUROU {res} HORA(S)");
            }
            else
            {
                res = hFinal - hInicial;
                Console.WriteLine($"O JOGO DUROU {res} HORA(S)");
            }
        }
    }
}
