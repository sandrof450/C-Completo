/*Escreva um programa para ler as coordenadas (X, Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/

using System;

namespace Exercicio1
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Digite as cordenadas X e Y: ");
            string[] xy = Console.ReadLine().Split(' ');
            x = int.Parse(xy[0]);
            y = int.Parse(xy[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("PRIMEIRO");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("SEGUNDO");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("TERCEIRO");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("QUARTO");
                }
                Console.Write("Digite as cordenadas X e Y: ");
                xy = Console.ReadLine().Split(' ');
                x = int.Parse(xy[0]);
                y = int.Parse(xy[1]);
            }


        }
    }
}