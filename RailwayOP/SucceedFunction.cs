using System;

namespace RailwayOP
{
    public static class SucceedFunction
    {
        /// <summary>
        /// A constrcutor
        /// Always on the success track
        /// one-track, two-track
        /// </summary>
        /// <param name="input"></param>
        /// <param name="singleTrackFunction"></param>
        /// <typeparam name="TInData"></typeparam>
        /// <typeparam name="TOutData"></typeparam>
        /// <returns></returns>
        public static Result<TOutData> Succeed<TInData, TOutData>(
            this Result<TInData> input,
            Func<TInData, TOutData> singleTrackFunction)
        {
            return Result<TOutData>.Success(
                singleTrackFunction(input.Data)
            );
        }
    }
}