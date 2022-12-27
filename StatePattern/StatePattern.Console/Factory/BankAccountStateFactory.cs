using StatePattern.Console.ConcreteState;
using StatePattern.Factory;
using StatePattern.Pattern.Context;
using StatePattern.Pattern.State;

namespace StatePattern.Console.Factory
{
    public class BankAccountStateFactory : IFactory
    {
        private static readonly BankAccountStateFactory factory = new BankAccountStateFactory();

        public static IState GetState(dynamic condition, IContext context)
        {
            return factory.Create(condition, context);
        }
        public IState Create(dynamic condition, IContext context)
        {
            int balance = (int)condition;
            if (balance < 0)
                return new OverwithdrawnState(balance, context);
            if (balance > 0 && balance < 10000)
                return new RegularState(balance, context);
            else
                return new GoldState(balance, context);
        }
    }
}
