using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Helpers
{
    class MailHelper
    {
        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();
        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("peteranh.testmail@gmail.com", "Peteranhhsu*");

        public void send(string sendTo, string sendFrom, string subject, string body)
        {
            //setup SMTP Host Here
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = smtpCreds;
            client.EnableSsl = true;

            //converte string to MailAdress

            MailAddress to = new MailAddress(sendTo);
            MailAddress from = new MailAddress(sendFrom);

            //set up message settings

            msg.Subject = subject;
            msg.Body = body;
            msg.From = from;
            msg.To.Add(to);

            // Enviar E-mail

            client.Send(msg);

        }
    }

}
