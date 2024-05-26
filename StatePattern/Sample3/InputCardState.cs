using System;

namespace StatePattern.Sample3
{
    public class InputCardState : ITransactionState
    {
        public void Handle(TransactionContext context)
        {
            Console.WriteLine("Card has been input. Please enter your PIN.");
            context.SetState(new InputPinState());
        }
    }
}