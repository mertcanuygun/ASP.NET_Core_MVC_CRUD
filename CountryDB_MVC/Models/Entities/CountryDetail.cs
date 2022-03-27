using System.ComponentModel.DataAnnotations.Schema;

namespace CountryDB_MVC.Models.Entities
{
    public class CountryDetail:BaseEntity
    {
        public int Year { get; set; }
        public int Population { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal GDP { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
