using System;

namespace StatePattern.Sample3
{
    public class InputPinState : ITransactionState
    {
        public void Handle(TransactionContext context)
        {
            Console.WriteLine("PIN has been entered. Preparing to dispense cash.");
            context.SetState(new CashDrawState());
        }
    }
}