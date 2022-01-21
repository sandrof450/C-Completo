using System;
using System.Globalization;


namespace Aula73_Modificadores_De_Parametros_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int triple;

            Calculator.Triple(a, out triple);

            Console.WriteLine(triple);

        }
    }
}