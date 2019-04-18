using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Forget : Form
    {
        public int ima;
        public string user;
        public Forget()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void findsec_Click(object sender, EventArgs e)
        {
            Sendmail sendm = new Sendmail();
            string mail_add = mail.Text;
            
            if (mail_add.Length != 0)
            {
                ima = sendm.sendmail(mail_add);
                MessageBox.Show("邮件发送成功，请登录邮箱注意查收");
            }
            else
            {
                MessageBox.Show("邮箱不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (assertcode.Text != "")
            {
                if (int.Parse(assertcode.Text) == ima)
                {
                    this.Hide();
                    Updatesercert updatesercert = new Updatesercert();
                    updatesercert.sb = user_id.Text;
                    updatesercert.ShowDialog();
                }
                else
                {
                    MessageBox.Show("验证码输入错误");
                }
            }
            else
            {
                MessageBox.Show("验证码为空");
            }
            
            

           
        }

        private void Forget_Load(object sender, EventArgs e)
        {

        }
    }
}
