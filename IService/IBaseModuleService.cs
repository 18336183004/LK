using HospitalSystem.Common;
using HospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.IService
{
    public interface IBaseModuleService
    {
        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <returns></returns>
        Task<ResponseModel> GetModlueList();


        Task<ResponseModel> ByMidGetFunctionList(FunctionResultModel model);
    }
}
