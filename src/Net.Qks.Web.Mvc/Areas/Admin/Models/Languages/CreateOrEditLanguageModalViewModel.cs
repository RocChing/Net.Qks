using Abp.AutoMapper;
using Net.Qks.Localization.Dto;

namespace Net.Qks.Web.Areas.Admin.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;

        public CreateOrEditLanguageModalViewModel(/*GetLanguageForEditOutput output*/)
        {
            //output.MapTo(this);
        }
    }
}