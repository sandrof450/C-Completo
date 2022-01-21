using System;
using System.Globalization;


namespace Aula72_Modificador_De_Parametros_Params
{
    class Program
    {
        static void Main(string[] args)
        {

            int s1 = Calculator.Sum(2, 3 );
            int s2 = Calculator.Sum( 2, 4, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}