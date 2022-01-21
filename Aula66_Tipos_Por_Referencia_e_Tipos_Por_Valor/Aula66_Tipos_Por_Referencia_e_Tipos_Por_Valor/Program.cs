using System;

namespace Aula66_Tipos_Por_Referencia_e_Tipos_Por_Valor { 

    class Program
    {
        static void Main(string[] args)
        {

            Point p;

            p.X = 10;
            p.Y = 10;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
        }
    }
}

