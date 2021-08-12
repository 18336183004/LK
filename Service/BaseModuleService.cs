using HospitalSystem.Common;
using HospitalSystem.IService;
using HospitalSystem.Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Service
{
    public class BaseModuleService : IBaseModuleService
    {
        DbContext dbContext = new DbContext();
        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <returns></returns>
        public async Task<ResponseModel> GetModlueList()
        {
            ResponseModel response = ResponseModel.Error(msg: "获取模块列表失败！");
            try
            {
                var model = await dbContext.Db.Queryable<Base_Module>().ToListAsync();
                if (model != null) 
                {
                    response = ResponseModel.Success();
                    response.Data = model;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        /// <summary>
        /// 根据Mid获取Function名称
        /// </summary>
        /// <returns></returns>
        public async Task<ResponseModel> ByMidGetFunctionList(FunctionResultModel model) 
        {
            ResponseModel response = ResponseModel.Error(msg: "获取模块列表失败！");
            var result = await dbContext.Db.Queryable<Base_Module, Base_Function>((bm, bf) => new JoinQueryInfos(
                   JoinType.Left,bf.Mid == bm.Mid))
                .Where(bm => bm.Mid == model.Mid)
                .Select((bm, bf) => new { Mid = bf.Mid, Fname = bf.Fname, Url = bf.Url })
                .ToListAsync();
            if (result?.Count > 0)
            {
                response = ResponseModel.Success();
                response.Message = "获取成功";
                response.Data = result;

            }
            return response;

        }
    }
}
