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
    public partial class Updatesercert : Form
    {
        public string sb;
        MySqlConnection conn = CONN.Myconn();
        MySqlCommand cmd;
        public Updatesercert()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (this.textBox1.Text == "")
            {
                MessageBox.Show("请设置密码");
                this.textBox1.Focus();
            }
            else
            {
                if (this.textBox1.Text != this.textBox2.Text)
                {
                    MessageBox.Show("两次密码不一致");
                    this.textBox2.Focus();
                }
                else
                {
                    conn.Open();
                    MD5 md5 = MD5.Create();
                    string pwd = "";
                    byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(this.textBox1.Text));
                    for (int i = 0; i < s.Length; i++)
                    {
                        // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                        pwd = pwd + s[i].ToString("X");
                    }
                    cmd = new MySqlCommand("update USERS set USERS_PASSWORDS='" + pwd + "' where USERS_LOGINNAME='" + sb + "'", conn);
                    cmd.ExecuteScalar();
                    if (MessageBox.Show("密码修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        this.Close();
                    }
                    conn.Close();
                }
            }

        }

        private void Updatesercert_Load(object sender, EventArgs e)
        {

        }
    }
}
