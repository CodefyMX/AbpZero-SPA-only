using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Organizations;

namespace Cinotam.ModuleZero.AppModule.OrganizationUnits.Dto
{
    [AutoMap(typeof(OrganizationUnit))]
    public class OrganizationUnitInput : EntityDto<long>
    {
        public virtual long? ParentId { get; set; }
        public virtual string Code { get; set; }
        public virtual string DisplayName { get; set; }
    }
}
