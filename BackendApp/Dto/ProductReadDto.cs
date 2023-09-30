﻿using BackendApp.Models;

namespace BackendApp.Dto
{
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubcategoryId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}
