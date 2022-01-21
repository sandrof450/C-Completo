using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many rooms will be rented? ");
            int nRoom = int.Parse(Console.ReadLine());

            Alugueis[] vect = new Alugueis[9];

            for(int i = 0; i < nRoom; i++)
            {
                Console.WriteLine($"Rent #{i + 1}:");

                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Alugueis { Name = nome, Email = email, Room = quarto };

                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms: ");

            for(int i = 0; i < 9; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{vect[i].Room}: {vect[i].Name}, {vect[i].Email}");
                }
            }
        }
    }
}