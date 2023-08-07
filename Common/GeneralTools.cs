using System.Net;
using System.Net.Mail;
using System.Text;

namespace FinanceApp.Common
{
    public class GeneralTools
    {
        public static void MailGoder(string kime, string konu,string mesaj)
        {
            SmtpClient smtpClient = new();
            smtpClient.Host= "mail.biltekno.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl= false;
            smtpClient.UseDefaultCredentials= false;
            smtpClient.Credentials = new NetworkCredential("test@biltekno.com", "t123e");
            MailMessage mailMessage = new();
            mailMessage.From = new MailAddress("test@biltekno.com");
            mailMessage.To.Add(kime);
            mailMessage.Subject = konu;
            mailMessage.Body = mesaj;
            mailMessage.IsBodyHtml= true;
            mailMessage.BodyEncoding = Encoding.UTF8;
            smtpClient.Send(mailMessage);
        }
    }
}
