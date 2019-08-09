using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

namespace Net.Qks.Develop
{
    public interface ITableAppService : IApplicationService
    {
        Task<PagedResultDto<TableDto>> GetList(GetTablesInput input);

        Task<TableDto> Get(NullableIdDto<int> input);

        Task CreateOrUpdate(TableDto input);

        Task Delete(EntityDto<int> input);
    }
}
