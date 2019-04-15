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
    public partial class Transfer : Form
    {
        private float money = 1000;
        public Transfer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("转账成功，您的余额为" + money.ToString()),"转账提示",MessageBoxButtons.OK);
            this.Hide();
        }
    }
}
