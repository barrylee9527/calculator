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
    public partial class Transfer : Form
    {
        MySqlConnection conn = CONN.Myconn();
        MySqlCommand cmd1;
        MySqlCommand cmd2;
        public float money = 0;
        
        MySqlDataReader sdr;
        
        public Transfer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.label3.Text = money.ToString();

            User users = new User();
            string t1 = users.get_user();
            conn.Open();
            
            cmd1 = new MySqlCommand("select money from USERS where USERS_LOGINNAME='" + t1 + "'", conn);
            sdr = cmd1.ExecuteReader();
            if (sdr.Read())
            {
                this.label3.Text = sdr[0].ToString();
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox2.Text=="" || this.textBox1.Text=="")
            {
                MessageBox.Show("请输入对方账户或者转账金额！！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string user_account = textBox2.Text;
                float user_money = float.Parse(textBox1.Text);
                float my_new_money = float.Parse(this.label3.Text) - user_money;
                conn.Open();
                cmd1 = new MySqlCommand("select money from users where USERS_LOGINNAME='" + user_account + "'", conn);
                sdr = cmd1.ExecuteReader();
                if (sdr.Read())
                {
                    string tt = sdr[0].ToString();
                    conn.Close();
                    if (my_new_money >= 0)
                    {
                        float your_new_money = float.Parse(tt) + user_money;                        
                        User users = new User();
                        string t1 = users.get_user();
                        conn.Open();
                        cmd2 = new MySqlCommand("update users set money='" + my_new_money + "' where USERS_LOGINNAME='" + t1 + "'", conn);
                        cmd2.ExecuteScalar();
                        conn.Close();
                        conn.Open();
                        new MySqlCommand("update users set money='" + your_new_money + "' where USERS_LOGINNAME='" + user_account + "'", conn).ExecuteScalar();
                        MessageBox.Show(string.Format("转账成功，您的余额为" + my_new_money), "转账提示", MessageBoxButtons.OK);
                        this.label3.Text = my_new_money.ToString();
                        this.textBox2.Text = "";
                        this.textBox1.Text = "";
                        conn.Close();
                    }
                    else
                    {

                        MessageBox.Show("您的余额不足！！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.textBox1.Text = "";
                        this.textBox1.Focus();
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("对方账户不存在！！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBox2.Text = "";
                    this.textBox2.Focus();
                }                                      
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }
    }
}
