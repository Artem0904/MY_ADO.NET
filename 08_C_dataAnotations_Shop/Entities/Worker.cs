namespace _08_C_dataAnotations_Shop.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Gmail { get; set; }
        public string PhoneNumber { get; set; }
        public int PositionId { get; set; }
        public int ShopId { get; set; }

        public Position Position { get; set; }
        public Shop Shop { get; set; }

    }
}
