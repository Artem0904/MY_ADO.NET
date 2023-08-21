namespace _08_C_dataAnotations_Shop.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<Shop> Shops { get; set; } = new HashSet<Shop>();
    }
}
