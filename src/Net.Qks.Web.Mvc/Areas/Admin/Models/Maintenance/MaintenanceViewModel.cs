using System.Collections.Generic;
using Net.Qks.Caching.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}