using System;

namespace RailwayOP
{
    public static class TeeFunction
    {
        /// <summary>
        /// Adapter Block
        /// Takes a dead-end function
        /// Turns it into a one-track
        /// </summary>
        /// <param name="input"></param>
        /// <param name="deadEndFunction"></param>
        /// <typeparam name="TData"></typeparam>
        /// <returns></returns>
        public static Result<TData> Tee<TData>(
            this Result<TData> input,
            Action<TData> deadEndFunction
        )
        {
            if (input.IsSuccess())
                deadEndFunction(input.Data);

            return input;
        }
    }
}