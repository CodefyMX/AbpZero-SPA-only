using Abp.Modules;
using RestApiHelpers;
using System.Reflection;

namespace Cinotam.MailSender.SendGrid
{
    [DependsOn(typeof(RestApiHelpersModule))]
    public class CinotamMailSenderSendGrid : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
