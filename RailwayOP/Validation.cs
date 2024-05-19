namespace RailwayOP
{
    public class Validation
    {
        public Result<decimal> ValidateAmount(decimal amount)
        {
            return (amount >= 0)
                ? Result<decimal>.Success(amount)
                : Result<decimal>.Fail(Error.AccountValidationFailed);
        }
        
        public Result<decimal> ValidateAmountNumber(decimal amount)
        {
            return (amount >= 0)
                ? Result<decimal>.Success(amount)
                : Result<decimal>.Fail(Error.AccountValidationFailed);
        }
        
        
    }
}