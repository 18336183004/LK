using HospitalSystem.Common;
using HospitalSystem.IService;
using HospitalSystem.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Service
{
    public class BaseUserService : IBaseUserService
    {
        DbContext dbContext = new DbContext();

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="User_Name"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public async Task<ResponseModel> UserLogin(UsersLogin usersLogin)
        {
            ResponseModel response =  ResponseModel.Error(msg:"账号或密码错误！");
            //32位大写，MD5加密
            using (var md5 = MD5.Create())
            {
                try
                {
                    var pwd = md5.ComputeHash(Encoding.UTF8.GetBytes(usersLogin.Password));
                    var pwd1 = BitConverter.ToString(pwd);
                    string result1 = pwd1.Replace("-", "");
                    var user = await dbContext.Db.Queryable<Base_User>()
                        .Where(a => a.User_Name == usersLogin.User_Name && a.Password == result1).ToListAsync();
                    //user = null;
                    if (user != null && user?.Count > 0)
                    {
                        response = ResponseModel.Success();
                        response.Message = "登录成功";
                        response.Data = user;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return response;
        }
    }
}
