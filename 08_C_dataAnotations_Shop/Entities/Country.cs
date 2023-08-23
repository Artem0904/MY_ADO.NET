namespace _08_C_dataAnotations_Shop
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<City> Cites { get; set; } = new HashSet<City>();
    }
}
