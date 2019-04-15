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
    public partial class FrmMain : Form
    {

        public static List<char> inputStr=new List<char>(1000);    //用户的输入
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            inputStr.Add('0');
            textBox1.AppendText("0");
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            inputStr.Add('.');
            textBox1.AppendText(".");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            inputStr.Add('1');
            textBox1.AppendText("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            inputStr.Add('2');
            textBox1.AppendText("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            inputStr.Add('3');
            textBox1.AppendText("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            inputStr.Add('4');
            textBox1.AppendText("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            inputStr.Add('5');
            textBox1.AppendText("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            inputStr.Add('6');
            textBox1.AppendText("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            inputStr.Add('7');
            textBox1.AppendText("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            inputStr.Add('8');
            textBox1.AppendText("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            inputStr.Add('9');
            textBox1.AppendText("9");
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            inputStr.Add('(');
            textBox1.AppendText("(");
        }

        private void BtnRig_Click(object sender, EventArgs e)
        {
            inputStr.Add(')');
            textBox1.AppendText(")");
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            //等号代码
            textBox1.AppendText("=");
            textBox2.Text = textBox1.Text;
            textBox1.Text = DataOp.DataMain();

            string temp= DataOp.DataMain();
            inputStr.Clear();
            for(int i = 0; i < temp.Length; i++)
            {
                inputStr.Add(temp[i]);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            inputStr.Add('+');
            textBox1.AppendText("+");
        }

        private void BtnSubt_Click(object sender, EventArgs e)
        {
            inputStr.Add('-');
            textBox1.AppendText("-");
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            inputStr.Add('*');
            textBox1.AppendText("*");
        }

        private void BtnDivi_Click(object sender, EventArgs e)
        {
            inputStr.Add('/');
            textBox1.AppendText("/");
        }

        private void BtnCe_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            inputStr.Clear();       //清空链表的所有元素
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            //界面撤销
            if (inputStr.Count != 0)
            {
                inputStr.RemoveAt(inputStr.Count - 1);
            }
            textBox1.Text = "";
            for (int i=0;i<inputStr.Count;i++)
            {
                textBox1.Text += inputStr[i];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 程序员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 科学ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 科学ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void 版本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version version = new Version();
            version.Show();
        }

        private void 转账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.ShowDialog();
        }

        private void 历史记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }
    }
}
