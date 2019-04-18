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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        MySqlConnection conn = CONN.Myconn();
        MySqlCommand cmd;
        MySqlDataReader sdr;
        

        private void button2_Click(object sender, EventArgs e)
        {
            string t1 = this.textBox1.Text.Trim();
            string t2 = this.textBox2.Text.Trim();
            string t3 = this.textBox3.Text.Trim();
            if (t1 == "")
            {
                MessageBox.Show("用户名不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                conn = CONN.Myconn();
                conn.Open();
                cmd = new MySqlCommand("select * from USERS where USERS_LOGINNAME='" + t1 + "'", conn);
                sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    MessageBox.Show("该用户已存在");
                    sdr.Close();
                }
                else if(string.Compare(t2, t3)==0)
                {
                    string os = "";
                    MD5 md5 = MD5.Create();
                    string pwd = "";
                    byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(t2));
                    for (int i = 0; i < s.Length; i++)
                    {
                        // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                        pwd = pwd + s[i].ToString("X");
                    }
                    cmd.Clone();
                    if (radioButton1.Checked)
                    {
                        os = "windows";

                    }
                    else if (radioButton2.Checked)
                    {
                        os = "linux";
                    }
                    else if (radioButton2.Checked)
                    {
                        os = "android";
                    }
                    else
                    {
                        os = "ios";
                    }
                    cmd = new MySqlCommand("insert USERS values('" + t1 + "','" + pwd + "','" + os + "','" + 1000000 + "')", conn);
                    sdr.Close();
                    cmd.ExecuteScalar();
                    MessageBox.Show("注册成功，请返回登录");
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("两次输入的密码不一致","提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //this.textBox1.Text = "";
                this.textBox1.Focus();
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
