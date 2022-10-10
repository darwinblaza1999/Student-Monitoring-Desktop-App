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
    public class Account : IAccount
    {
        private SqlConnection con = new SqlConnection(Connection.Connect());
        public async Task<ServiceResponse<string>> Login(string username, string password)
        {
            var service = new ServiceResponse<string>();
            try
            {
                var param = new DynamicParameters();
                param.Add("username", username);
                param.Add("password", password);
                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);
                var result = await con.QueryAsync("sp_Login", param, commandType: CommandType.StoredProcedure);
                var ret = param.Get<int>("@retval");
                if (ret == 100)
                {
                    service.Data = JsonConvert.SerializeObject(result.ToList());
                    service.ResponseCode = 200;
                    service.ResponseMessage = "Success";
                }
                else
                {
                    service.Data = null;
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
    }
}
