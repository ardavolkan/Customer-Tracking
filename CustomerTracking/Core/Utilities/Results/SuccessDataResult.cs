using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DateResult<T>
    {
        public SuccessDataResult(T data, string message):base (data,true,message)
        {
           
        }
       
        public SuccessDataResult(T data ):base(data,true)
        {
            
        }

        public SuccessDataResult(string mesaage): base(default,true,mesaage)
        {
            
        }

        public SuccessDataResult():base(default,true)
        {
            
        }
    }
}
