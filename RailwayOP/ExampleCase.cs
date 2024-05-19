using System;
using Microsoft.AspNetCore.Mvc;

namespace RailwayOP
{
    public static class ExampleCase
    {
        public static ActionResult Handle<TData>(this Result<TData> result, ControllerBase controller)
        {
            if (result.IsSuccess())
                return controller.Ok(result.Data);

            switch (result.Error)
            {
                case Error.InvalidAmount:
                    case Error.AccountInvalid:
                    case Error.CreditCardInvalid:
                        return controller.BadRequest(controller.ObjectValidator);
                
                case Error.PaymentFailed:
                    return controller.UnprocessableEntity();
                
                case Error.OutOfFunds:
                case Error.CardExpired:
                case Error.AccountSuspended:
                    return controller.Unauthorized();
                default:
                    return new StatusCodeResult(500);
            }
        }
        public static Result<TOutData> TryCatchSwitch<TInData, TOutData>(
            this Result<TInData> input,
            Func<TInData, TOutData> singleTrackFunction)
        {
            try
            {
                return input.IsSuccess()
                    ? Result<TOutData>.Success(singleTrackFunction(input.Data))
                    : Result<TOutData>.Fail(input.Error);
            }
            catch
            {
                return Result<TOutData>.Fail(Error.ExceptionRaised);
            }
        }

        public static Result<bool> BooleanSwitch<TInData>(
            this Result<TInData> input,
            Func<TInData, bool> singleTrackFunction)
        {
            if (input.IsSuccess())
                return singleTrackFunction(input.Data)
                    ? Result<bool>.Success(true)
                    : Result<bool>.Fail(Error.ReturnedFalse);

            return Result<bool>.Fail(input.Error);
        }
        
        
    }
}