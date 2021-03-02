using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        
        // Data ve mesaj ver
        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }
         //Sadece data ver
         public SuccessDataResult(T data) :base(data,true)
        {

        }
        //Sadece mesaj ver
        public SuccessDataResult(string message):base(default,true,message)
        {

        }
        //Hiçbir şey verme
        public SuccessDataResult() :base(default,true)
        {
                
        }

       }
    }

