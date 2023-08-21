namespace _08_C_dataAnotations_Shop.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Product { get; set; } = new HashSet<Product>();
    }
}
