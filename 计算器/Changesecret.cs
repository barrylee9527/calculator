using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
namespace 计算器
{
    public partial class Changesecret : Form
    {
        public static bool flag;
        public Changesecret()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(DialogResult.OK==MessageBox.Show("您确认要修改密码吗", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                
                if (textBox1.Text == textBox2.Text)
                {
                    MessageBox.Show("原密码于新密码一致", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else if(textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("两次输入的密码不一致", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    MySqlConnection conn = CONN.Myconn();
                    conn.Open();
                    MD5 md5 = MD5.Create();
                    string pwd = "";
                    string t2 = this.textBox2.Text.Trim();
                    byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(t2));
                    User users = new User();
                    string usr = users.get_user();
                    for (int i = 0; i < s.Length; i++)
                    {
                        // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                        pwd = pwd + s[i].ToString("X");
                    }

                    MySqlCommand cmd = new MySqlCommand("update users set USERS_PASSWORDS='" + pwd + "' where  USERS_LOGINNAME ='" + usr + "'", conn);
                    MySqlDataReader sdr = cmd.ExecuteReader();
                    MessageBox.Show("密码修改成功");
                    this.Close();
                    conn.Close();
                    flag = true;
                }
                
            }
            else
            {
                flag = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            flag = false;
        }

        private void Changesecret_Load(object sender, EventArgs e)
        {

        }
        
    }
    class Closedd : Changesecret
    {
        public bool closed()
        {
            return flag;
        }
    }
}
