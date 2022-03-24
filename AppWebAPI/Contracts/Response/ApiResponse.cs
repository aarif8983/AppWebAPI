using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebAPI.Contracts.Response
{
    public class ApiResponse
    {
        public int status { get; set; }
        public int Status { get; internal set; }
        public bool Ok { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }
        
        public string Token { get; set; }
    }
}
