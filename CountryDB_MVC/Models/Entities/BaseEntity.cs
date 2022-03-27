namespace CountryDB_MVC.Models.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime? CreateDate { get; set; }
        public string CreatedIpAddress { get; set; }
        public string CreatedMachineName { get; set; }

        public DateTime? UpdateDate { get; set; }
        public string UpdatedIpAddress { get; set; }
        public string UpdatedMachineName { get; set; }

        public DateTime? DeleteDate { get; set; }
        public string DeletedIpAddress { get; set; }
        public string DeletedMachineName { get; set; }
    }
}
