using System.ComponentModel.DataAnnotations;

namespace VCM.MIT.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}