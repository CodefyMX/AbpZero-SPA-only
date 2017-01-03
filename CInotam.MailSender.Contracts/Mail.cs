using Abp.Domain.Entities.Auditing;
using System.Net.Mail;

namespace CInotam.MailSender.Contracts
{
    public class Mail : FullAuditedEntity, IMail
    {
        public string From { get; set; }
        public string To { get; set; }

        public string Data { get; set; }
        public MailMessage MailMessage { get; set; }
        public string HtmlView { get; set; }
        public string Body { get; set; }
        public string EncodeType { get; set; }
        public dynamic ExtraParams { get; set; }
        public bool Sent { get; set; }

    }
}
