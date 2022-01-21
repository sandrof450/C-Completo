using System;
using System.Globalization;

namespace Exercicio1
{
    internal class Retangulo
    {

        public double Largura;
        public double Altura;

        public double Area()
        {
            // A = b·h
            return (Largura * Altura);
        }

        public double Perimetro()
        {
            //2(b + h)
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            //h2=a2+b2
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

    }
}
