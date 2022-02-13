using System.Globalization;
namespace Exercicio2.Entities
{
    class ImportProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportProduct()
        {
        }

        public ImportProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }



        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return
                Name +
                " $ " +
                TotalPrice().ToString("F2", CultureInfo.InvariantCulture) +
                "(Customs fee: $ " +
                CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        
    }
}
