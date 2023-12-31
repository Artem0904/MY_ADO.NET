﻿namespace data_access
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{Id} - {Name} - {Surname}";
        }
    }
}