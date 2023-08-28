﻿namespace Hotel.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
