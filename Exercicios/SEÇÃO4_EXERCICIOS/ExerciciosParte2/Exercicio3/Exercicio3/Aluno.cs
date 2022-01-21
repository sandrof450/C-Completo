using System.Globalization;

namespace Exercicio3
{
    public class Aluno
    {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Resultado()
        {
            if (NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO\n" + 
                    "FALTARAM " + Restante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }

        private double Restante()
        {
            return 60 - NotaFinal();
        }

    }
}
