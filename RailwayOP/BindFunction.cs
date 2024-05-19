using System;

namespace RailwayOP
{
    public static class BindFunction
    {
        /// <summary>
        /// Adapter Block
        /// Two-track in , Two track out
        /// Only executes on the Success track
        /// </summary>
        /// <param name="input"></param>
        /// <param name="switchFunction"></param>
        /// <returns></returns>
        public static Result<TOutData> Bind<TInData, TOutData>(this Result<TInData> input ,
            Func<TInData , Result<TOutData>> switchFunction){
            return input.IsSuccess()
                ? switchFunction(input.Data)
                : Result<TOutData>.Fail(input.Error);
        }
    }
}