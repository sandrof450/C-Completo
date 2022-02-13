namespace Aula127_Upcasting_e_Downcasting.Entities
{
    class SavingisAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingisAccount()
        {
        }

        public SavingisAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
