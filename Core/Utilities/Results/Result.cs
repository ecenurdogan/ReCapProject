using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
     
        public Result(bool success, string messages):this(success)
        {
            Messages = messages;
        }
        public Result(bool success) 
        {
            Success = success;
        }

        public bool Success { get;  }

        public string Messages { get;  }
    }
}
