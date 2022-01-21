/*
Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
*/
using System;
namespace Exercicio6
{
    class Exercicio6
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine()); 
            C = double.Parse(Console.ReadLine());

            //area = (base * altura) / 2
            triangulo = (A * C) / 2;

            //area = π * raio2
            //π = 3.14159
            circulo = 3.14159 * C * C;

            //area = ((Base + base) * altura) / 2
            trapezio = ((A + B) * C) / 2;

            //A = L * L
            quadrado = B * B;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPÉZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
        }
    }
}