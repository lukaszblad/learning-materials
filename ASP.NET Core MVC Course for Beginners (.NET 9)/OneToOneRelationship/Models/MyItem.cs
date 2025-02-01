﻿namespace OneToOneRelationship.Models
{
    public class MyItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public int? SerialNumberId { get; set; }
        public SerialNumber? SerialNumber { get; set; }
    }
}
