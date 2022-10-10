using SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repository
{
    public interface IAccount
    {
        Task<ServiceResponse<string>> Login(string username, string password);
    }
}
