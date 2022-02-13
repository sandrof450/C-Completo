namespace Aula129_Classes_e_Metodos_Selados.Entities
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

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
