using System;

namespace Aula68_Nullable
{


    class Program
    {

        static void Main(string[] args)
        {
            //Nullable<double>
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }

            else
            {
                Console.WriteLine(y.Value);
            }

            double? z = null;
            double b = x ?? 6;

            Console.WriteLine(b);

            



        }

    }
}