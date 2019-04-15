using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 计算器
{
    //表达式存在inputStr中
    class DataOp : FrmMain
    {
       static Stack<double> m = new Stack<double>();//数字栈
       static Stack<char> s = new Stack<char>();//符号栈
        public static void Read()   //Read()从inputStr输入流中读值
        {
            for (int i = 0; i < inputStr.Count; i++)    
            {
                if (!IsOperator(inputStr[i]))   //数字和小数点
                {
                    string s = null;
                    while (i < inputStr.Count && !IsOperator(inputStr[i]))
                    {
                        s += inputStr[i];
                        i++;
                    }
                    i--;
                    double mm = Convert.ToDouble(s);
                    m.Push(mm);
                }
                else if (IsOper(inputStr[i]))   //+ - * / 
                {
                    if (s.Count.Equals(0) || s.Peek().Equals('('))
                    {
                        s.Push(inputStr[i]);
                    }
                    else if (OperatorPrecedence(inputStr[i]) > OperatorPrecedence(s.Peek()))
                    {
                        s.Push(inputStr[i]);
                    }
                    else
                    {
                        double n1, n2;
                        char s1;
                        n2 = m.Pop();
                        n1 = m.Pop();
                        s1 = s.Pop();
                        double sum = Operat(n1, n2, s1);
                        m.Push(sum);
                        s.Push(inputStr[i]);
                    }
                }
                else                    //（和）
                {
                    if (inputStr[i].Equals('('))
                    {
                        s.Push(inputStr[i]);
                    }
                    else if (inputStr[i].Equals(')'))
                    {
                        while (!s.Peek().Equals('('))
                        {
                            double n1, n2;
                            char s1;
                            n2 = m.Pop();
                            n1 = m.Pop();
                            s1 = s.Pop();
                            double sum = Operat(n1, n2, s1);
                            m.Push(sum);
                        }
                        s.Pop();
                    }
                }
            }
        }
        public static double PopStack()
        {
            double sum = 0;
            while (s.Count != 0)
            {
                double n1, n2;
                char s1;
                n2 = m.Pop();
                n1 = m.Pop();
                s1 = s.Pop();
                sum = Operat(n1, n2, s1);
                m.Push(sum);
            }
            return sum;
        }
        public static bool IsOperator(char c)   //是否是操作符
        {
            if (c.Equals('+') || c.Equals('-') || c.Equals('*') || c.Equals('/') || c.Equals('(') || c.Equals(')'))
                return true;
            return false;
        }
        public static bool IsOper(char c)   //是否是运算符符
        {
            if (c.Equals('+') || c.Equals('-') || c.Equals('*') || c.Equals('/'))
                return true;
            return false;
        }
        public static int OperatorPrecedence(char a)    //操作符优先级
        {
            int i = 0;
            switch (a)
            {
                case '+': i = 3; break;
                case '-': i = 3; break;
                case '*': i = 4; break;
                case '/': i = 4; break;
            }
            return i;
        }
        public static double Operat(double n1, double n2, char s1)
        {
            double sum = 0;
            switch (s1)
            {
                case '+': sum = n1 + n2; break;
                case '-': sum = n1 - n2; break;
                case '*': sum = n1 * n2; break;
                case '/': sum = n1 / n2; break;
            }
            return sum;
        }
        public static string DataMain()
        {
            Read();
            return PopStack().ToString();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DataOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(580, 454);
            this.Name = "DataOp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
