using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Net.Qks.Editions.Dto;
using Net.Qks.Web.Areas.Admin.Models.Common;

namespace Net.Qks.Web.Areas.Admin.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class EditEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public bool IsEditMode => Edition.Id.HasValue;

        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }

        public EditEditionModalViewModel(/*GetEditionEditOutput output, IReadOnlyList<ComboboxItemDto> editionItems, IReadOnlyList<ComboboxItemDto> freeEditionItems*/)
        {
            //EditionItems = editionItems;
            //FreeEditionItems = freeEditionItems;
            //output.MapTo(this);
        }
    }
}