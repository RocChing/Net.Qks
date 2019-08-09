using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using Net.Qks.Authorization;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace Net.Qks.Develop
{
    public class TableAppService : QksAppServiceBase, ITableAppService
    {
        private readonly IRepository<Table> _tableRep;
        public TableAppService(IRepository<Table> tableRep)
        {
            _tableRep = tableRep;
        }

        /// <summary>
        /// 查询实体
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<TableDto>> GetList(GetTablesInput input)
        {
            var query = _tableRep.GetAll().WhereIf(!input.Filter.IsNullOrWhiteSpace(), m => m.Name.Contains(input.Filter) || m.Namespace.Contains(input.Filter));

            var count = await query.CountAsync();

            var list = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var listDtos = ObjectMapper.Map<List<TableDto>>(list);

            return new PagedResultDto<TableDto>(count, listDtos);
        }

        public async Task<TableDto> Get(NullableIdDto<int> input)
        {
            Table model;
            if (input.Id.HasValue)
            {
                model = await _tableRep.GetAsync(input.Id.Value);
            }
            else
            {
                model = new Table();
            }
            return ObjectMapper.Map<TableDto>(model);
        }

        /// <summary>
        /// 创建或修改实体
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(AppPermissions.Develop.Tables_Create, AppPermissions.Develop.Tables_Edit)]
        public async Task CreateOrUpdate(TableDto input)
        {
            bool addFlag = input.Id < 1;
            Table model = null;
            if (addFlag) model = ObjectMapper.Map<Table>(input);
            else
            {
                model = await _tableRep.GetAsync(input.Id);
                model = ObjectMapper.Map(input, model);
            }

            await _tableRep.InsertOrUpdateAsync(model);
        }


        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(AppPermissions.Develop.Tables_Delete)]
        public async Task Delete(EntityDto<int> input)
        {
            await _tableRep.DeleteAsync(input.Id);
        }
    }
}
