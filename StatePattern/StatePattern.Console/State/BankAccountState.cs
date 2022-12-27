using StatePattern.Pattern.State;

namespace StatePattern.Console.State
{
    public abstract class BankAccountState: IState
    {
        private int _balance;

        public int Balance
        {
            get => _balance;
            set => _balance = value;
        }

        public abstract void Deposit(int deposit);
        public abstract void WithDraw(int withdrawnBalance);
    }
}
