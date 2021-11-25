using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project.COMMON
{
    public class MailSender
    {
        public static void SendEmail(string email, string subject, string message)
        {
            MailMessage sender = new MailMessage();
            sender.From = new MailAddress("ba.yzl3148@gmail.com", "BİTİRME PROJESİ");
            sender.To.Add(email);
            sender.Subject = subject;
            sender.Body = message;

            SmtpClient smtpcli = new SmtpClient();
            smtpcli.Credentials = new NetworkCredential("ba.yzl3148@gmail.com", "Yzl3148!!--");
            smtpcli.Port = 587;
            smtpcli.Host = "smtp.gmail.com";
            smtpcli.EnableSsl = true;

            smtpcli.Send(sender);

        }
    }

}
