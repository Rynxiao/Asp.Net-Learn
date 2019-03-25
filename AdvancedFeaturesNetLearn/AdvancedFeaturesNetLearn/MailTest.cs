using System.Net.Mail;

namespace AdvancedFeaturesNetLearn
{
    public class MailTest
    {
        public void send()
        {
            MailAddress from = new MailAddress("yuzhongzi91@163.com");
            MailAddress to = new MailAddress("yuzhongzi91@sina.com");
            MailMessage mailMessage = new MailMessage(from, to);
            mailMessage.Subject = "Subject";
            mailMessage.Body = "Body";
        }
    }
}