namespace _08_C_dataAnotations_Shop
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int? ParkingArea { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
        public virtual ICollection<Worker> Workers { get; set; } = new HashSet<Worker>();

    }
}
