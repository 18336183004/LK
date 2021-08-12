using HospitalSystem.Common;
using HospitalSystem.IService;
using HospitalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HospitalSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseUserController : ControllerBase
    {
        private readonly IBaseUserService _iBase_User;
       
        public BaseUserController(IBaseUserService base_User) 
        {
            _iBase_User = base_User;

        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="User_Name"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseModel> UserLogin([FromBody] UsersLogin usersLogin) 
        {
            return await _iBase_User.UserLogin(usersLogin);
        }

    }
}
