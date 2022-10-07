using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
    public class UserModel: UserDetail1
    {
        public string fname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string ConNo { get; set; }
        public string email { get; set; }
    }
    public class UserDetail : UserCred
    {
        public string username { get; set; }
        public string password { get; set; }
        public string type { get; set; }
        
    }
    public class UserCred
    {
        public DateTime UDT { get; set; }
        public string UserId { get; set; }
    }
    public class UserDetail1 : UserCred
    {
        public int position { get; set; }
        public int status { get; set; }
    }
}
