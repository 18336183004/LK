using SqlSugar;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Models
{
    public class Base_Function
    {
        [SugarColumn(IsPrimaryKey = true)]
        [Key]
        public int Fid { get; set; }//功能Id

        public string Fname { get; set; }//功能名称

        public int Mid { get; set; }//模块Id

        public string Url { get; set; }//Url地址

    }
}
