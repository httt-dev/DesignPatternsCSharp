using System;

namespace RailwayOP
{
    public static class FailFunction
    {
        public static Result<TOutData> Fail<TInData, TOutData>(
            this Result<TInData> input,
            Func<TInData, TOutData> singleTrackFunction)
        {
            singleTrackFunction(input.Data);
            return Result<TOutData>.Fail(Error.Fail);
        }
        
    }
}