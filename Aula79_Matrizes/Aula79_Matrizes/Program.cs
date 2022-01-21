using System;

namespace Aula79_Matrizes
{
    class Program
    {

        static void Main(string[] args)
        {

            double[,] mat = new double[2, 3];

            //Mostra o tamanho da matriz no total
            Console.WriteLine(mat.Length);

            //Mostra a quantidade de linha da matriz
            Console.WriteLine(mat.Rank);

            //Mostra quantos elementos tem na primeira dimenção
            Console.WriteLine(mat.GetLength(0));

            //Mostra quantos elementos tem na segunda dimenção
            Console.WriteLine(mat.GetLength(1));
        }

    }

}
