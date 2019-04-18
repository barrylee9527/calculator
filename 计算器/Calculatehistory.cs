using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 计算器
{
    class Calculatehistory
    {
        MySqlConnection conn = CONN.Myconn();
        MySqlCommand cmd;
        MySqlDataReader sdr;
        public string username = "";
        
        
        public void calculate_history(string history)
        {      
            string datetime = DateTime.Now.ToString();
            conn = CONN.Myconn();
            conn.Open();
            cmd = new MySqlCommand("insert calculate_history values('" + username + "','" + datetime + "','"+history+"')", conn);
            sdr = cmd.ExecuteReader();

        }

    }
}
