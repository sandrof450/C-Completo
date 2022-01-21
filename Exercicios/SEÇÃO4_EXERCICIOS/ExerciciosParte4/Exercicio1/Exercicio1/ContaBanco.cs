using System.Globalization;
namespace Exercicio1
{
    public class ContaBanco
    {

        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBanco (int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
            Saldo = 0.0;
        }

        public ContaBanco (int conta, string titular, double depositoInicial) :this(conta, titular)
        {
            Deposito(depositoInicial);
        }
        

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo =  Saldo - saque - 5.00;
        }

        public override string ToString()
        {
            return "Conta " + Conta +
                ", Titular: " + Titular +
                ", Saldo: " + "$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
