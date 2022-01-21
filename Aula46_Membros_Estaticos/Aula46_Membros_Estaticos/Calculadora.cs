﻿namespace Aula46_Membros_Estaticos
{
    internal class Calculadora
    {

        public static double Pi = 3.14;

        public static double Circuferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }

    }
}
