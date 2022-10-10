using SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repository
{
    public interface IAccess
    {
        Task<ServiceResponse<string>> ViewAccessRights( int sysID, string type);
        Task<ServiceResponse<object>> InsertSystemName(int sysID, string name, string type);
    }
}
