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

        public static void SendMail(Email email)
        {
            var smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false, // uncomment if you don't want to use the network credentials
                Credentials = new System.Net.NetworkCredential(Config.EmailUsername, Config.EmailPassword),
                EnableSsl = true
                //DeliveryMethod = SmtpDeliveryMethod.Network;
            };

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage
            {
                From = new System.Net.Mail.MailAddress(Config.EmailUsername, "noreply@counterpoint.com"),
                Subject = email.Subject,
                Body = email.Body,
                IsBodyHtml = true
            };
            mail.To.Add(new System.Net.Mail.MailAddress(email.Destinations[0]));

            //var contentType = new System.Net.Mime.ContentType(System.Net.Mime.MediaTypeNames.Application.Pdf);
            //foreach (var attachment in email.Attachments)
            //{
            //    Attachment attach = new Attachment(attachment.Stream, contentType);
            //    attach.ContentDisposition.FileName = attachment.Name;
            //    mail.Attachments.Add(attach);
            //}

            smtpClient.Send(mail);
        }
    }

    public class Email
    {
        public List<string> Destinations { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
