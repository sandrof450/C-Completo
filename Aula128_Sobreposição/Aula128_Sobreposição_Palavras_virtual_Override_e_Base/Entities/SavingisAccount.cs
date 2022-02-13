namespace Aula128_Sobreposição_Palavras_virtual_Override_e_Base.Entities
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

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
