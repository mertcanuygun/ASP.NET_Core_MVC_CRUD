namespace CountryDB_MVC.Models.Entities
{
    public class Country:BaseEntity
    {
        public string CountryName { get; set; }
        public List<Country_Language> Country_Languages { get; set; }
        public int ContinentID { get; set; }
        public Continent Continent { get; set; }
        public List<CountryDetail> CountryDetails { get; set; }
    }
}
