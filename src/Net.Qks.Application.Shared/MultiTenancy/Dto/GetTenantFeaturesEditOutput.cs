using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Net.Qks.Editions.Dto;

namespace Net.Qks.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}