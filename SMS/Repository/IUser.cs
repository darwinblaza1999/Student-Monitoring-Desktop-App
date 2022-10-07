using SMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repository
{
    public interface IUser
    {
       Task<ServiceResponse<object>> InsertUser(UserModel user);
       Task<ServiceResponse<string>> GetUser();
       Task<ServiceResponse<string>> GetPosition();
       Task<ServiceResponse<string>> GetUserId();
       Task<ServiceResponse<string>> GetUserByUserId(string userid);
       Task<ServiceResponse<object>> UpdatePassword(UserDetail userdet);
       Task<ServiceResponse<object>> UpdateStatus(UserDetail1 cred);
    }
}
