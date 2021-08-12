using HospitalSystem.Common;
using HospitalSystem.IService;
using HospitalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseModuleController : ControllerBase
    {
        private readonly IBaseModuleService _baseModuleService;

        public BaseModuleController(IBaseModuleService baseModuleService) 
        {
            _baseModuleService = baseModuleService;
        }
        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseModel> GetModlueList() 
        {
            return await _baseModuleService.GetModlueList();
        }
        /// <summary>
        /// 根据模块id获取功能名称
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseModel> ByMidGetFunctionList(FunctionResultModel model) 
        {
            return await _baseModuleService.ByMidGetFunctionList(model);
        }


    }
}
