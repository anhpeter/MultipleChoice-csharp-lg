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
        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential(Constant.EMAIL,Constant.PASSWORD);

        public void send(string sendTo, string subject, string body, Attachment attachment = null)
        {
            //setup SMTP Host Here
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = smtpCreds;
            client.EnableSsl = true;

            //converte string to MailAdress

            MailAddress to = new MailAddress(sendTo);
            MailAddress from = new MailAddress(Constant.EMAIL);

            //set up message settings

            msg.Subject = subject;
            msg.Body = body;
            msg.From = from;
            msg.To.Add(to);
            if (attachment != null) msg.Attachments.Add(attachment);

            // Enviar E-mail

            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

        }
    }

}
