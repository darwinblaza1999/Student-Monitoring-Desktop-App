using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Class
{
    public class Connection
    {
        public static string Connect()
        {
            return ConfigurationManager.ConnectionStrings["SMS"].ConnectionString;
        }
    }
}
