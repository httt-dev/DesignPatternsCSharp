namespace RailwayOP
{
    /// <summary>
    /// Store all the bussiness errors an enumeration
    /// Forces you to handle all errors
    /// Keeps all the errors togetger
    /// Could be a big ugly in size
    /// </summary>
    public enum Error
    {
        // 
        Fail,
        ReturnedFalse,
        ExceptionRaised,
        
        //Validation
        InvalidAmount ,
        AccountInvalid,
        CreditCardInvalid,
        AccountValidationFailed,
        //Payment 
        PaymentFailed,
        OutOfFunds,
        
        //Account
        CardExpired,
        AccountSuspended
    }
}