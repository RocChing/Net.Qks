using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Net.Qks.Authorization.Permissions.Dto;

namespace Net.Qks.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
