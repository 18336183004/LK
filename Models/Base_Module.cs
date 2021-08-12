using SqlSugar;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Models
{
    public class Base_Module
    {
        [SugarColumn(IsPrimaryKey = true)]
        [Key]
        public int Mid { get; set; }//模块ID

        public string Mname { get; set; }//模块名称
    }
}
