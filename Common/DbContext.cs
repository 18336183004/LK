using SqlSugar;

namespace HospitalSystem.Common
{
    public class DbContext
    {
        public SqlSugarClient _db { get; set; }

        public SqlSugarClient Db
        {
            get { return _db; }
            private set { _db = value; }
        }


        //创建SqlSugarClient 
        public DbContext()
        {
            //创建数据库对象
            _db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "Server=localhost;Database=his;UID=root;password=root;connect timeout=700;charset=utf8;pooling=true;Port=3306;AllowLoadLocalInfile=true;",
                DbType = DbType.MySql,//设置数据库类型
                IsAutoCloseConnection = true
            });
        }
    }
}
