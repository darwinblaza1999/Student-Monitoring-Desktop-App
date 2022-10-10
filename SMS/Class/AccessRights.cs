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
    public class AccessRights:IAccess
    {
        private SqlConnection con = new SqlConnection(Connection.Connect());
        public async Task<ServiceResponse<string>> ViewAccessRights(int sysID, string type)
        {
            var service = new ServiceResponse<string>();
            try
            {
                var param = new DynamicParameters();
                param.Add("@type", type);
                param.Add("@SystemId", sysID);

                var result = await con.QueryAsync("usp_GetSystemName", param, commandType: CommandType.StoredProcedure);
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
        public async Task<ServiceResponse<object>>InsertSystemName(int sysID, string name, string type)
        {
            var service = new ServiceResponse<object>();
            try
            {
                var param = new DynamicParameters();
                param.Add("@moduleName", name);
                param.Add("@systemID", sysID);
                param.Add("@type", type);
                param.Add("@retval", dbType: DbType.Int32, direction: ParameterDirection.Output);

                var result = await con.QueryAsync("usp_InsertSystem", param, commandType: CommandType.StoredProcedure);
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

    }
}
