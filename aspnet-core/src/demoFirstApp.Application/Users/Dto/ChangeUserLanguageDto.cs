using System.ComponentModel.DataAnnotations;

namespace demoFirstApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}