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
    public partial class 登录界面 : Form
    {
        public static string name = "";
        public 登录界面()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = this.textBox1.Text.Trim();
            string t2 = this.textBox2.Text.Trim();
            name = textBox1.Text;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MySqlConnection conn = CONN.Myconn();
                conn.Open();
                
                MD5 md5 = MD5.Create();
                string pwd = "";

                byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(t2));
                for (int i = 0; i < s.Length; i++)
                {
                    // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
                    pwd = pwd + s[i].ToString("X");
                }
               
                MySqlCommand cmd = new MySqlCommand("select * from USERS where USERS_LOGINNAME='" + t1 + "' and USERS_PASSWORDS='" + pwd + "'", conn);
                MySqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    this.Hide();
                    FrmMain frm2 = new FrmMain();
                    //frm2.authorization = sdr["USERS_AUTHORIZATIONS"].ToString().Trim();
                    frm2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox2.Text = "";
                    this.textBox2.Focus();
                }

            }
            else
            {
                MessageBox.Show("用户名或密码不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget forget = new Forget();
            forget.ShowDialog();          
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.TransparencyKey = Color.Red;
            this.Opacity = 0.8;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
    class User:登录界面
    {
        
        public string get_user()
        {
            return name;
        }
    }
}
