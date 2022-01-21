using System;

namespace Aula20
{
    class Aula20
    {
        static void Main(string[] args)
        {
            //É possivel converter implicitamente de float para double
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            //Não é possivel converter implicitamente de doble para float
            double a = 4.5000;
            float b = (float)a;

            Console.WriteLine(b);
            
        }
    }
}
