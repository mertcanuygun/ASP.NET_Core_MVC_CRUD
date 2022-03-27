using System.ComponentModel.DataAnnotations;

namespace CountryDB_MVC.Models.DTOs
{
    public class LanguageCreateDTO
    {
        [Required(ErrorMessage = "Must type a language")]
        [MinLength(3, ErrorMessage = "Minimum length is 3")]
        public string LanguageName { get; set; }
    }
}
