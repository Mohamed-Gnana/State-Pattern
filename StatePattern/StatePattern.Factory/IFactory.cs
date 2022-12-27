using StatePattern.Pattern.Context;
using StatePattern.Pattern.State;

namespace StatePattern.Factory
{
    public interface IFactory
    {
        IState Create(dynamic condition, IContext context);
    }
}
