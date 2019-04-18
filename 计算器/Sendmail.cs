using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace 计算器
{

    class Sendmail
    {
       public int sendmail(string send_address)
        {
            //实例化一个发送邮件类。
            MailMessage mailMessage = new MailMessage();
            //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
            mailMessage.From = new MailAddress("329103586@qq.com");  
            //收件人邮箱地址。
            mailMessage.To.Add(new MailAddress(send_address));
            //邮件标题。
            mailMessage.Subject = "验证码接受";
            //邮件内容。
            Random random = new Random();
            int a = random.Next(1000, 2000);
            mailMessage.Body = a.ToString();
            
            //实例化一个SmtpClient类。
            SmtpClient client = new SmtpClient();
            //在这里我使用的是qq邮箱，所以是smtp.qq.com，如果你使用的是126邮箱，那么就是smtp.126.com。
            client.Host = "smtp.qq.com";
            //使用安全加密连接。
            client.EnableSsl = true;
            //不和请求一块发送。
            client.UseDefaultCredentials = false;
            //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
            
            client.Credentials = new NetworkCredential("329103586@qq.com", "xxxxxxxxxxx");//
            //发送
            client.Send(mailMessage);
            //Context.Response.Write("发送成功");
            return a;
            
        }
    }
}
