using System;
using System.Globalization;

namespace Aula42_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Ente os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade do Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);


            Console.WriteLine("Dados do Produto: " + p);


            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adiconados no estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);
            Console.WriteLine("\nDados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removaido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados" + p);
        }
    }
}

