﻿using System;
namespace reportesApi.Models
{
    public class DataResponse
    {
        public int StatusCode { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
       // public ErrorResponse error { get; set; }
        public object response { get; set; }
        public object data { get; set; } 


               



    }

   /* public class ErrorResponse
    {
        public int code { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }*/
}