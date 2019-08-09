using System.ComponentModel.DataAnnotations;

namespace Net.Qks.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
