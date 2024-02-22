using System;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.ComponentModel;

namespace INVENTORY_MANAGEMENT_SYSTEM
{
    class Email
    {
        private NetworkCredential login;
        private SmtpClient client;
        private MailMessage msg;

        public void Email_Send(string to, string subject, string body)
        {
            try
            {
                login = new NetworkCredential("Email", "jPassword");
                client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress("Email", "Inventory system development team", Encoding.UTF8) };
                msg.To.Add(new MailAddress(to));
                if (!string.IsNullOrEmpty(""))
                    msg.To.Add(new MailAddress(""));
                msg.Subject = subject;
                msg.Body = body;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";
                client.SendAsync(msg, userstate);

            }
            catch (Exception)
            {
                MessageBox.Show("Your Data Connection Is Lost Cann't Send Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("E-mail Has been Successfully sent.", "Email Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }







    }
}
