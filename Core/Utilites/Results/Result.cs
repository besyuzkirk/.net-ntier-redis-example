﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Results
{
    public class Result : IResult
    {
        private bool v1;
        private string v2;

        public Result(bool success , string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
        
            Success = success;
        }

        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
