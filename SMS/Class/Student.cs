using Dapper;
using Newtonsoft.Json;
using SMS.Models;
using SMS.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Class
{
    public class Student : IStudent
    {
        private SqlConnection con = new SqlConnection(Connection.Connect());
        public async Task<ServiceResponse<object>> InsertStudent(StudentModel student)
        {
            var service = new ServiceResponse<object>();
            try
            {
                var param = new DynamicParameters();
                var property = student.GetType().GetProperties();
                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);
                foreach (var item in property)
                {
                    var name = item.Name;
                    var value = item.GetValue(student);
                    param.Add(name, value);
                }

                var result = await con.QueryAsync("usp_InsertStudent", param, commandType: CommandType.StoredProcedure);
                var ret = param.Get<int>("@retval");
                if (ret == 100)
                {
                    service.Data = ret;
                    service.ResponseCode = 200;
                    service.ResponseMessage = "Success";
                }
                else
                {
                    service.Data = ret;
                    service.ResponseCode = 300;
                    service.ResponseMessage = "Failed";
                }
            }
            catch (Exception ex)
            {

                service.Data = null;
                service.ResponseCode = 500;
                service.ResponseMessage = ex.Message;
            }
            return service;
        }
        public async Task<ServiceResponse<object>> UpdateStudent(PartialModel model)
        {
            var service = new ServiceResponse<object>();
            try
            {
                var param = new DynamicParameters();
                var property = model.GetType().GetProperties();
                foreach (var item in property)
                {
                    var name = item.Name;
                    var value = item.GetValue(model);
                    param.Add(name, value);
                }
                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);

                var result = await con.QueryAsync("usp_UpdateStudent", param, commandType: CommandType.StoredProcedure);
                var ret = param.Get<int>("retval");
                if(ret == 100)
                {
                    service.Data = ret;
                    service.ResponseCode = 200;
                    service.ResponseMessage = "Success";  
                }
                else
                {
                    service.Data = ret;
                    service.ResponseCode = 300;
                    service.ResponseMessage = "Failed";
                }
            }
            catch (Exception ex)
            {

                service.Data = null;
                service.ResponseCode = 500;
                service.ResponseMessage = ex.Message;
            }
            return service;
        }

        public async Task<ServiceResponse<object>> InsertCategory(string name, string percent, string type)
        {
            var service = new ServiceResponse<object>();
            var ret = 0;
            try
            {
                var param = new DynamicParameters();
                if (type == "section")
                {
                    param.Add("@secname", name);
                    param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    var result = await con.QueryAsync("usp_InsertSection", param, commandType: CommandType.StoredProcedure);
                    ret = param.Get<int>("@retval");
                }
                else if(type == "subject")
                {
                    param.Add("@subname", name);
                    param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    var result = await con.QueryAsync("usp_InsertSubject", param, commandType: CommandType.StoredProcedure);
                    ret = param.Get<int>("@retval");
                }
                else if(type == "component")
                {
                    param.Add("@comname", name);
                    param.Add("@percent", percent);
                    param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    var result = await con.QueryAsync("usp_InsertComponent", param, commandType: CommandType.StoredProcedure);
                    ret = param.Get<int>("@retval");
                }
                else if(type == "grade")
                {
                    param.Add("@gradename", name);
                    param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);

                    var result = await con.QueryAsync("usp_InsertGrade", param, commandType: CommandType.StoredProcedure);
                    ret = param.Get<int>("@retval");
                }

                if(ret == 100)
                {
                    service.ResponseCode = 200;
                    service.Data = ret;
                    service.ResponseMessage = "Success";
                }
                else
                {
                    service.ResponseCode = 300;
                    service.Data = ret;
                    service.ResponseMessage = "Failed";
                }


            }
            catch (Exception ex)
            {

                service.ResponseCode = 500;
                service.Data = null;
                service.ResponseMessage = ex.Message;
            }
            return service;
        }
        public async Task<ServiceResponse<string>>ViewCategory(string type)
        {
            var service = new ServiceResponse<string>();
            try
            {
                var param = new DynamicParameters();
                param.Add("@type", type);
                var result = await con.QueryAsync("usp_ViewCategory", param, commandType: CommandType.StoredProcedure);
                if (result.Count() > 0)
                {
                    service.Data = JsonConvert.SerializeObject(result);
                    service.ResponseCode = 200;
                    service.ResponseMessage = "Record found";
                }
                else
                {
                    service.Data = null;
                    service.ResponseCode = 300;
                    service.ResponseMessage =  "No record found";
                }

            }
            catch (Exception ex)
            {

                service.Data = null;
                service.ResponseCode = 500;
                service.ResponseMessage = ex.Message;
            }
            return service;
        }

        public async Task<ServiceResponse<string>> GetStudentById(string studenId)
        {
            var service = new ServiceResponse<string>();
            try
            {
                var param = new DynamicParameters();
                param.Add("@studentId", studenId);

                var result = await con.QueryAsync("usp_GetStudentByID", param, commandType: CommandType.StoredProcedure);
                if(result.Count() > 0)
                {
                    service.ResponseCode = 200;
                    service.Data = JsonConvert.SerializeObject(result);
                    service.ResponseMessage = "Record found";
                }
                else
                {
                    service.ResponseCode = 300;
                    service.Data = null;
                    service.ResponseMessage = "No record found";
                }
            }
            catch (Exception ex)
            {

                service.ResponseCode = 500;
                service.Data = null;
                service.ResponseMessage = ex.Message;
            }
            return service;
        }
    }
}
