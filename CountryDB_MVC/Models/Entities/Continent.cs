namespace CountryDB_MVC.Models.Entities
{
    public class Continent:BaseEntity
    {
        public string ContinentName { get; set; }
        public List<Country> Countries { get; set; }
    }
}
