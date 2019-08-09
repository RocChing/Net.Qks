﻿using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Net.Qks.MultiTenancy.Accounting.Dto;

namespace Net.Qks.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
