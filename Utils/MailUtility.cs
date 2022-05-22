using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace Utils
{
    public class MailUtility
    {
        public static void SendEmail(Email email)
        {
            var destinations = new List<MailboxAddress>();
            foreach (var destination in email.Destinations)
            {
                destinations.Add(MailboxAddress.Parse(destination));
            }

            // create email message
            var emailDetails = new MimeMessage();
            emailDetails.From.Add(new MailboxAddress(Config.EmailDisplayName, Config.EmailUsername));
            emailDetails.To.AddRange(destinations);
            emailDetails.Subject = email.Subject;
            emailDetails.Body = new TextPart(TextFormat.Html) { Text = email.Body };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect(Config.EmailServer, Config.EmailPort, SecureSocketOptions.StartTls);
            smtp.Authenticate(Config.EmailUsername, Config.EmailPassword);
            smtp.Send(emailDetails);
            smtp.Disconnect(true);
        }
    }

    public class Email
    {
        public List<string> Destinations { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
