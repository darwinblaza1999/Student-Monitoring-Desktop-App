using Microsoft.Extensions.Configuration;
using SMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Class.Adapter
{
    public class AdapterClass : IAdapter
    {
        public IUser user { get; }
        public AdapterClass(IConfiguration config)
        {
            //user = new User(config);
        }
    }
}
