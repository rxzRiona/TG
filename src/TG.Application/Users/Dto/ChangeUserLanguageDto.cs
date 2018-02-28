using System.ComponentModel.DataAnnotations;

namespace TG.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}