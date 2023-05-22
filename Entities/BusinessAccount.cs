namespace InheritanceAccount.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; protected set; }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(LoanLimit >= amount)
            {
                Balance += amount;
                LoanLimit -= amount;
            }
        }
    }
}
