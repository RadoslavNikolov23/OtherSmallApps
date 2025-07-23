namespace DEA_Program.Common.Helper
{
    using System.Net;
    using System.Net.Mail;
    using System.IO;
    using System;

    public class BugReporter
    {
        public static void SendBugReport(string userMessage, string logFilePath)
        {
            try
            {
                //TODO FIX THIS and in the app.config also check
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("youremail@example.com");
                mail.To.Add("yourtargetemail@example.com");
                mail.Subject = "Bug Report";
                mail.Body = "User message:\n" + userMessage;

                if (File.Exists(logFilePath))
                {
                    Attachment logAttachment = new Attachment(logFilePath);
                    mail.Attachments.Add(logAttachment);
                }

                SmtpClient smtp = new SmtpClient("localhost"); // or 127.0.0.1
                smtp.Port = 25;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(mail);

                Logger.ClearLog(); // Clear log after sending
            }
            catch (Exception ex)
            {
                Logger.Log(ex, "Failed to send bug report.");
                throw;
            }
        }
    }
}
