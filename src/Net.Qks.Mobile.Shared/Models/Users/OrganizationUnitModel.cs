using Abp.AutoMapper;
using Net.Qks.Organizations.Dto;

namespace Net.Qks.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}