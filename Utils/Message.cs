using MimeKit;

namespace ADHD.Utils
{
    public class Message
    {
            public List<MailboxAddress> To { get; set; }
            public string Subject { get; set; }
            public string Content { get; set; }
            public MailboxAddress From { get; set; }
            public Message(string from ,IEnumerable<string> to, string subject, string content)
            {
            From = new MailboxAddress("email", from);
                To = new List<MailboxAddress>();

                To.AddRange(to.Select(x => new MailboxAddress("email" , x)));
                Subject = subject;
                Content = content;
            }
    }
}
