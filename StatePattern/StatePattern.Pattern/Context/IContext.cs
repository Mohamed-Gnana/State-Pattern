using StatePattern.Pattern.State;

namespace StatePattern.Pattern.Context
{
    public abstract class IContext
    {
        public IState _state;

        public IState State
        {
            get => _state;
            private set => _state = value;
        }


        public void SetState(IState state)
        {
            _state = state;
        }

        public abstract void Request();
    }
}
