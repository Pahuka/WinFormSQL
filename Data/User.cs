using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormSQL.Data;

namespace DBase
{
    public class User
    {
        public string firstname { get; set; }
        public string lastName { get; set; }
        public string Login { get; set; }
        public string Id { get; set; }
        public bool Administrator { get; set; }

        public User(SqlDataReader userData)
        {
            while (userData.Read())
            {
                this.Id = (string)userData.GetValue(0);
                firstname = (string)userData.GetValue(1);
                lastName = (string)userData.GetValue(2);
                Login = (string)userData.GetValue(3);
                Administrator = (string)userData.GetValue(5) == "true" ? true : false;
            }
            DataBase.CloseConnection();
        }
    }
}
