using System;

namespace StatePattern.Sample3
{
    public class CashDrawState : ITransactionState
    {
        public void Handle(TransactionContext context)
        {
            Console.WriteLine("Cash is being dispensed. Please take your cash.");
            context.SetState(new CompleteState());
        }
    }
}