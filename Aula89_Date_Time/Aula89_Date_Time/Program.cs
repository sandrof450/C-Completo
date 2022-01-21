using System;
using System.Globalization;

namespace Aula89_Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pega a hora atual do sistema
            DateTime d1 = DateTime.Now;

            //Pega o parametro no datetime Ano/Mês/Dia
            DateTime d2 = new DateTime(2022, 11, 25);

            //Pega o parametro no datetime Ano/Mês/Dia/hor/min/seg
            DateTime d3 = new DateTime(2022, 11, 25, 20, 45, 03);

            //Pega o parametro no datetime Ano/Mês/Dia/hor/min/seg/Mileseg
            DateTime d4 = new DateTime(2022, 11, 25, 20, 45, 03, 500);

            DateTime d5 = DateTime.Now;

            //Mostra a data atual, só que com o ohorario zerado
            DateTime d6 = DateTime.Today;

            //Mostra o horario universal
            DateTime d7 = DateTime.UtcNow;

            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d10 = DateTime.Parse("15-08-2000");
            DateTime d11 = DateTime.Parse("15-08-2000 13:05:58");

            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
            Console.WriteLine(d13);
        }
    }
}
