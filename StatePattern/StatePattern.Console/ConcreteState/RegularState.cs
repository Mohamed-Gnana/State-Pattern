using StatePattern.Console.Factory;
using StatePattern.Console.State;
using StatePattern.Pattern.Context;

namespace StatePattern.Console.ConcreteState
{
    public class RegularState : BankAccountState
    {
        public RegularState(int balance, IContext bankAccount)
        {
            System.Console.WriteLine("Regular");
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
            if (withdrawnBalance > 2000)
            {
                System.Console.WriteLine("Value exceeded the allowed amount");
                return;
            }
            Balance -= withdrawnBalance;
            Handle();
        }
    }
}
