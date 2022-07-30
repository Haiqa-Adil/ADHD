using ADHD.Configuration;
using ADHD.UtilService;
using MailKit.Net.Smtp;
using MimeKit;

namespace ADHD.Utils
{
    public class MailService : IMailService
    {
        private readonly EmailConfig _emailConfig;
        public MailService(EmailConfig emailConfig)
        {
            _emailConfig = emailConfig;
        }
        public bool SendEmail(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(message.From);
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message.Content };

            Send(emailMessage);
            
            return true;
        }

        private void Send(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_emailConfig.UserName, _emailConfig.Password);

                    client.Send(mailMessage);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }
    }
}
