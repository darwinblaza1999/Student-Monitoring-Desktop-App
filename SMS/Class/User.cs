using Dapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SMS.Models;
using SMS.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Class
{
    public class User : IUser
    {
        //private readonly IConfiguration config;
    
        private SqlConnection con = new SqlConnection(Connection.Connect());
        public async Task<ServiceResponse<object>> InsertUser(UserModel user)
        {
            var service = new ServiceResponse<object>();
            try
            {
                var param = new DynamicParameters();
                var property = user.GetType().GetProperties();
                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);
                foreach (var item in property)
                {
                    var name = item.Name;
                    var value = item.GetValue(user);
                    param.Add(name, value);
                }

                var result = await con.QueryAsync("usp_AddUserAccount", param, commandType: CommandType.StoredProcedure);
                var ret = param.Get<int>("retval");
                if(ret == 100)
                {
                    service.ResponseCode = 200;
                    service.Data = null;
                    service.ResponseMessage = "Success";
                }
                else if(ret == 300)
                {
                    service.ResponseCode = 404;
                    service.Data = null;
                    service.ResponseMessage = "Email is already exists.";
                }
                else
                {
                    service.ResponseCode = 300;
                    service.Data = null;
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
        public async Task<ServiceResponse<string>> GetUser()
        {
            var service = new ServiceResponse<string>();
            try
            {
                var result = await con.QueryAsync("usp_ViewUsers", commandType: CommandType.StoredProcedure);
                if(result.Count() > 0)
                {
                    service.Data = JsonConvert.SerializeObject(result.ToList());
                    service.ResponseCode = 200;
                    service.ResponseMessage = "Record found";
                }
                else
                {
                    service.Data = null;
                    service.ResponseCode = 300;
                    service.ResponseMessage = "No record found";
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

        public async Task<ServiceResponse<string>> GetPosition()
        {
            var service = new ServiceResponse<string>();
            try
            {
                var result = await con.QueryAsync("usp_GetPosition", commandType: CommandType.StoredProcedure);
                if(result.Count() > 0)
                {
                    service.Data = JsonConvert.SerializeObject(result.ToList());
                    service.ResponseCode = 200;
                    service.ResponseMessage = "Record found";
                }
                else
                {
                    service.Data = JsonConvert.SerializeObject(result.ToList());
                    service.ResponseCode = 300;
                    service.ResponseMessage = "No record found";
                }
            }
            catch (Exception ex)
            {
                service.Data = null;
                service.ResponseCode = 500;
                service.ResponseMessage = "No record found";
            }
            return service;
        }
    }
}
