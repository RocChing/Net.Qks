using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Net.Qks.Common.Dto;
using Net.Qks.Editions.Dto;

namespace Net.Qks.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}