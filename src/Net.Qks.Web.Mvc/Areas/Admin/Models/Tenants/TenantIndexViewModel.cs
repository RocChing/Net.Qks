using System.Collections.Generic;
using Net.Qks.Editions.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}