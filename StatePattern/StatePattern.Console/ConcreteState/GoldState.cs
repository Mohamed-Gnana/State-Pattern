using StatePattern.Console.Factory;
using StatePattern.Console.State;
using StatePattern.Pattern.Context;

namespace StatePattern.Console.ConcreteState
{
    public class GoldState : BankAccountState
    {
        public GoldState(int balance, IContext bankAccount)
        {
            System.Console.WriteLine("Gold");
            Balance = balance;
            Context = bankAccount;
        }
        public override void Deposit(int deposit)
        {
            Balance += deposit;
            Handle();
        }

        public override void Handle()
        {
            Context.SetState(BankAccountStateFactory.GetState(Balance, Context));
        }

        public override void WithDraw(int withdrawnBalance)
        {
            if (withdrawnBalance > 5000)
            {
                System.Console.WriteLine("Value exceeded the allowed amount");
                return;
            }
            Balance -= withdrawnBalance;
            Handle();
        }
    }
}
