namespace StatePattern.Sample3
{
    public interface ITransactionState
    {
        void Handle(TransactionContext context);
    }
}