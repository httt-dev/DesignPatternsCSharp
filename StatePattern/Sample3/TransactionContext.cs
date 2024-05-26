using System;

namespace StatePattern.Sample3
{
    public class TransactionContext
    {
        private ITransactionState _state;

        public TransactionContext(ITransactionState state)
        {
            SetState(state);
        }

        public void SetState(ITransactionState state)
        {
            _state = state;
            Console.WriteLine($"State changed to: {state.GetType().Name}");
        }

        public void Request()
        {
            _state.Handle(this);
        }
        
    }
}