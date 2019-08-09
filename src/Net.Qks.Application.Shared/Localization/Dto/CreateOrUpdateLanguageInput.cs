using System.ComponentModel.DataAnnotations;

namespace Net.Qks.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}