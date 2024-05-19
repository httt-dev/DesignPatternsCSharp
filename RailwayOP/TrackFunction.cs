namespace RailwayOP
{
    public class TrackFunction
    {
        /// <summary>
        /// Single track function is just a function which returns a value
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool IsAmountValid(decimal amount)
        {
            return amount >= 0;
        }

        /// <summary>
        /// Two track function <br/>
        /// is a function which returns a result type
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public Result<decimal> ValidateAmount(decimal amount)
        {
            return (amount >= 0)
                ? Result<decimal>.Success(amount)
                : Result<decimal>.Fail(Error.AccountValidationFailed);
        }
    }
}