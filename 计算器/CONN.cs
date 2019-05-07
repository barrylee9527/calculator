using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace 计算器
{
    class CONN
    {
        public static MySqlConnection Myconn()
        {
            return new MySqlConnection("server=127.0.0.1;port=3306;user=database_userId;password=database_password; database=root;");
        }
    }
}
