using StatePattern.Pattern.Context;

namespace StatePattern.Pattern.State
{
    public abstract class IState
    {
        private IContext _context;

        public IContext Context
        {
            get => _context;
            set => _context = value;
        }

        public abstract void Handle();
    }
}
