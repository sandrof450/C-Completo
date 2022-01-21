namespace Exercicio1
{
    public class ConversorDeMoeda
    {

        public static double CotacaoDollar;
        public static double CompraDollar;

        public static double Conversor()
        {
            return (CompraDollar + IOF()) * CotacaoDollar;
        }


        public static double IOF()
        {
            return CompraDollar * 0.06;
        }

        

    }
}
