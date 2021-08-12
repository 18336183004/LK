using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSystem.Models
{
    public class Base_User
    {
        [SugarColumn(IsPrimaryKey = true)]
        [Key]
        public int User_Id { get; set; }//用户主键id

        public string User_Name { get; set; }//用户账号
      
        public string Password { get; set; }//用户密码

        public string Cname { get; set; }//用户姓名

        public string Sex { get; set; }//用户性别

        public int Dept_Id { get; set; }//部门id

        public int Post_Id { get; set; }//岗位id

    }

    /// <summary>
    /// 用户登录
    /// </summary>
    public class UsersLogin 
    {
        public string User_Name { get; set; }//用户账号

        public string Password { get; set; }//用户密码
    }
}
