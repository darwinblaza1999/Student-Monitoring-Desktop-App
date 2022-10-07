using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class ServiceResponse<T>
    {
        public int ResponseCode { get; set; }
        public  T Data { get; set; }
        public string ResponseMessage { get; set; }
    }
}
