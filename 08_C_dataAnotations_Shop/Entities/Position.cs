namespace _08_C_dataAnotations_Shop
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Worker> Workers { get; set; } = new HashSet<Worker>();
    }
}
