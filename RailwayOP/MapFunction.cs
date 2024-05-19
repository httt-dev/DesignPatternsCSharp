using System;

namespace RailwayOP
{
    public static class MapFunction
    {
        /// <summary>
        /// Adapter block
        /// One-track in, two track out
        /// Only executes on the success track
        /// </summary>
        /// <param name="input"></param>
        /// <param name="singleTrackFunction"></param>
        /// <typeparam name="TInData"></typeparam>
        /// <typeparam name="TOutData"></typeparam>
        /// <returns></returns>
        public static Result<TOutData> Map<TInData, TOutData>(
            this Result<TInData> input,
            Func<TInData, TOutData> singleTrackFunction)
        {
            return input.IsSuccess()
                ? Result<TOutData>.Success(singleTrackFunction(input.Data))
                : Result<TOutData>.Fail(input.Error);
        }
        /// <summary>
        /// Executes on two track
        /// </summary>
        /// <param name="input"></param>
        /// <param name="successSingleTrackFunction"></param>
        /// <param name="failureSingleTrackFunction"></param>
        /// <typeparam name="TInData"></typeparam>
        /// <typeparam name="TOutData"></typeparam>
        /// <returns></returns>
        public static Result<TOutData> DoubleMap<TInData, TOutData>(
            this Result<TInData> input,
            Func<TInData, TOutData> successSingleTrackFunction,
            Func<TInData, TOutData> failureSingleTrackFunction)
        {
            if (input.IsSuccess())
                return Result<TOutData>.Success(successSingleTrackFunction(input.Data));
            failureSingleTrackFunction(input.Data);
            return Result<TOutData>.Fail(input.Error);
        }
        
    }
}