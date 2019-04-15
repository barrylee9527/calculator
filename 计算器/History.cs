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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定要清空历史记录吗，一旦清空，无法恢复","提示",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
