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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MySqlConnection conn = CONN.Myconn();
            conn.Open();
            User users = new User();
            string usr = users.get_user();
            MySqlCommand cmd = new MySqlCommand("select * from calculate_history where username='" + usr + "'", conn);
            MySqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 1; i <= 2; i++)
                {
                    this.richTextBox1.Text = this.richTextBox1.Text + sdr[i].ToString() + "  ";
                }
                this.richTextBox1.Text += "\n";
            }
            sdr.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("确定要清空历史记录吗，一旦清空，无法恢复", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MySqlConnection conn = CONN.Myconn();
                conn.Open();
                User users = new User();
                string usr = users.get_user();
                MySqlCommand cmd = new MySqlCommand("delete from calculate_history where username='" + usr + "'", conn);
                MySqlDataReader sdr = cmd.ExecuteReader();
                sdr.Close();
                this.richTextBox1.Text = "";
            }
        }

        private void History_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
