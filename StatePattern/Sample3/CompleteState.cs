using System;

namespace StatePattern.Sample3
{
    public class CompleteState : ITransactionState
    {
        public void Handle(TransactionContext context)
        {
            Console.WriteLine("Transaction complete. Thank you!");
            // No transition to another state
        }
    }
}