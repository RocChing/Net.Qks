using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Net.Qks.Editions.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}