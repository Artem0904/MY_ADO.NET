using _08_C_dataAnotations_Shop.Entities;

namespace _08_C_dataAnotations_Shop
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Discount { get; set; }
        public int Quantity { get; set; }
        public bool IsInStock { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<Shop> Shops { get; set; } = new HashSet<Shop>();

    }
}
