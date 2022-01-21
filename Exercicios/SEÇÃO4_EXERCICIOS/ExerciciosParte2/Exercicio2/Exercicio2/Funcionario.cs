namespace Exercicio2
{
    public class Funcionario
    {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcent)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * 0.1);
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido(); 
        }

    }
}
