using CInotam.MailSender.Contracts;

namespace Cinotam.ModuleZero.MailSender.CinotamMailSender.Outputs
{
    public class EmailSentResult : IMailServiceResult
    {
        public EmailSentResult()
        {
            SentWithHttp = false;
            SentWithSmtp = false;
        }
        public bool SentWithSmtp { get; set; }
        public bool SentWithHttp { get; set; }
        public bool MailSent { get; set; }
    }
}
