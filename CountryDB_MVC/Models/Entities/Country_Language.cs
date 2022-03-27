namespace CountryDB_MVC.Models.Entities
{
    public class Country_Language:BaseEntity
    {
        public int LanguageID { get; set; }
        public Language Language { get; set; }

        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
