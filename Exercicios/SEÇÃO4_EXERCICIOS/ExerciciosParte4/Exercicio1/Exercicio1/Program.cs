using System.Globalization;

namespace Exercicio1 {

    class Program {

        static void Main(string[] args) {

            ContaBanco contaBanco;


            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havérá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 's')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBanco = new ContaBanco(conta, titular, saldo);                
            }

            else
            {
                contaBanco = new ContaBanco(conta, titular);
            }

            Console.WriteLine("Dados da conta:\n" + contaBanco);

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBanco.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:\n" + contaBanco);

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBanco.Saque(saque);
            Console.WriteLine("Dados atualizados:\n" + contaBanco);

        }
    
    }

}

