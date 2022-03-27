namespace CountryDB_MVC.Models.Entities
{
    public class Language:BaseEntity
    {
        public string LanguageName { get; set; }
        public List<Country_Language> Country_Languages { get; set; }
    }
}
