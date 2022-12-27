using StatePattern.Console.ConcreteState;
using StatePattern.Console.Factory;
using StatePattern.Console.State;
using StatePattern.Pattern.Context;

namespace StatePattern.Console.Context
{
    public class BankAccount : IContext
    {
        public int Balance { get => ((BankAccountState)State).Balance; }
        public BankAccount()
        {
            SetState(BankAccountStateFactory.GetState(200, this));
        }

        public override void Request()
        {
            State.Handle();
        }

        public void Deposit(int balance)
        {
            ((BankAccountState) State).Deposit(balance);
        }

        public void Withdraw(int balance)
        {
            ((BankAccountState)State).WithDraw(balance);
        }
    }
}
