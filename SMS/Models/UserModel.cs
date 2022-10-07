using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class UserModel
    {
        public string fname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string ConNo { get; set; }
        public string email { get; set; }
        public string position { get; set; }
        public int status { get; set; }
    }
    public class UserCred:UserModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        public DateTime UDT { get; set; }
        public string UserId { get; set; }
    }
}
