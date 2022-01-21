using System;
using System.Globalization;

namespace Aula42_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.getNome());
            p.setNome("T");
            Console.WriteLine(p.getNome());
            Console.WriteLine(p.getPreco());
            Console.WriteLine(p.getQuantidade());
        }
    }
}

