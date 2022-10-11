using SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repository
{
    public interface IStudent
    {
        Task<ServiceResponse<object>> InsertStudent(StudentModel student);
        Task<ServiceResponse<object>> UpdateStudent(PartialModel model);
        Task<ServiceResponse<string>> GetStudentById(string studenId);
        Task<ServiceResponse<object>> InsertCategory(string name, string percent, string type);
        Task<ServiceResponse<string>> ViewCategory(string type);
    }
}
