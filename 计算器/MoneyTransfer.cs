using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace 计算器
{
    public partial class Transfer2 : Form
    {
        private float money = 1000;
        public Transfer2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Connect(String server, Int32 port, String message)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                //Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                //Console.WriteLine("Sent: {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[1024];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.UTF8.GetString(data, 0, bytes);
                //Console.WriteLine("Received: {0}", responseData);
                MessageBox.Show(responseData, "交易信息");
                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            //Console.WriteLine("\n Press Enter to continue...");
            //Console.Read();
        }

        public string check_Connect(String server, Int32 port, String message)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                //Int32 port = 13000;
                TcpClient client = new TcpClient(server, port);

                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();

                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                //Console.WriteLine("Sent: {0}", message);

                // Receive the TcpServer.response.

                // Buffer to store the response bytes.
                data = new Byte[1024];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.UTF8.GetString(data, 0, bytes);
                //Console.WriteLine("Received: {0}", responseData);
                string[] retrun_msgs = responseData.Split(' ');
                if(retrun_msgs[0] != "交易成功")
                    MessageBox.Show(retrun_msgs[0], "交易信息");
                // Close everything.
                stream.Close();
                client.Close();
                return retrun_msgs[1];
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            //Console.WriteLine("\n Press Enter to continue...");
            //Console.Read();
            return "查询出错";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String server = textBox2.Text.Trim();
            Int32 port = Int32.Parse(textBox3.Text.Trim());
            //client.send("20180415 1133 20180417 2000".encode())
            string msg = textBox4.Text.Trim() + " ";
            msg += textBox6.Text.Trim() + " ";
            msg += textBox5.Text.Trim() + " ";
            msg += textBox1.Text.Trim();
            string check_msg = textBox4.Text + " ";
            check_msg += textBox6.Text;

            Connect(server, port, msg);
            string result = check_Connect(server, port, check_msg);
            label3.Text = result;
            //MessageBox.Show(string.Format("转账成功，您的余额为" + money.ToString()),"转账提示",MessageBoxButtons.OK);
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String server = textBox2.Text.Trim();
            Int32 port = Int32.Parse(textBox3.Text.Trim());
            //client.send("20180415 1133 20180417 2000".encode())
            string msg = textBox4.Text.Trim() + " ";
            msg += textBox6.Text.Trim();

            string result = check_Connect(server, port, msg);
            label3.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox1.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //string count = textBox4.Text;
            //String server = textBox2.Text;
            //Int32 port = Int32.Parse(textBox3.Text);
            ////client.send("20180415 1133 20180417 2000".encode())
            ////string msg = textBox4.Text;
            //Connect(server, port, count.Trim());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transfer2_Load(object sender, EventArgs e)
        {

        }
    }
}
