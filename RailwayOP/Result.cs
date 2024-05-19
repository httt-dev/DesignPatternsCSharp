using System;

namespace RailwayOP
{
    //https://youtu.be/45yk2nuRjj8
    public  class Result<TData>
    {
        public TData Data { get; }
        public Error Error { get; }

        private readonly bool _isSuccess;

        private Result(TData data)
        {
            Data = data;
            _isSuccess = true;
        }

        private Result(Error error)
        {
            Error = error;
            _isSuccess = false;
        }

        public bool IsSuccess() => _isSuccess;

        public static Result<TData> Success(TData data)
        {
            return new Result<TData>(data);
        }

        public static Result<TData> Fail(Error error)
        {
            return new Result<TData>(error);
        }
        
        // /// <summary>
        // /// Adapter Block
        // /// Two-track in , Two track out
        // /// Only executes on the Success track
        // /// </summary>
        // /// <param name="???"></param>
        // /// <param name="???"></param>
        // /// <returns></returns>
        // public static Result<TOutData> Bind<TInData, TOutData>(this Result<TInData> input ,
        //     Func<TInData , Result<TOutData>> switchFunction){
        //     return input.IsSuccess()
        //         ? switchFunction(input.Data)
        //         : Result<TOutData>.Failed(input.Error);
        // }
        
    }
}