using HospitalSystem.Common;
using HospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.IService
{
    public interface IBaseUserService
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="User_Name"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        Task<ResponseModel> UserLogin(UsersLogin usersLogin);
    }
}
