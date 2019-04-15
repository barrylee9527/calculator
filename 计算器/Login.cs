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

namespace 计算器
{
    public partial class Login : Form
    {
        public Login()
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
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                MySqlConnection conn = CONN.Myconn();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from USERS where USERS_LOGINNAME='" + t1 + "' and USERS_PASSWORDS='" + t2 + "'", conn);
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

        }
    }
}
