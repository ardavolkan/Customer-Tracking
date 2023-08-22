using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DateResult<T> : Result, IDataResult<T>
    {
        public DateResult(T data, bool succes , string message):base(succes,message)
        {
            Data = data;
        }

        public DateResult(T data, bool succes) : base(succes) 
        {
            Data = data;        
        }
         
        public T Data { get; }


    }
}
