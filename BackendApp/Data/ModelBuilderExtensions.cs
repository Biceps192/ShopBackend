using BackendApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApp.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {Id = 1, NameOfCategory = "Laptops, Tablets & PCs"},
                new Category { Id = 2, NameOfCategory = "Computer & Office" },
                new Category { Id = 3, NameOfCategory = "Hardware & Components" },
                new Category { Id = 4, NameOfCategory = "Smartphones, Radio & GPS" },
                new Category { Id = 5, NameOfCategory = "Photo / Video" },
                new Category { Id = 6, NameOfCategory = "TV / HiFi / Video" }
                );

            modelBuilder.Entity<Subcategory>().HasData(
                new Subcategory { Id = 1, Name = "Laptops / Notebooks", CategoryId = 1},
                new Subcategory { Id = 2, Name = "Apple MacBook", CategoryId = 1 },
                new Subcategory {Id = 3, Name = "Monitors" , CategoryId = 2},
                new Subcategory { Id = 4, Name = "All-in-One Printers" , CategoryId = 2},
                new Subcategory {Id = 5, Name = "Processors (CPUs)" , CategoryId = 3},
                new Subcategory {Id = 6, Name = "AMD Graphics cards" , CategoryId = 3},
                new Subcategory { Id = 7, Name = "Smartphones & Cell Phones" , CategoryId = 4},
                new Subcategory {Id = 8, Name = "Apple iPhones" , CategoryId = 4},
                new Subcategory { Id = 9, Name = "Digital Cameras" , CategoryId = 5},
                new Subcategory {Id = 10, Name = "Instant Cameras" , CategoryId = 5},
                new Subcategory { Id = 11, Name = "LED TV / LCD TV", CategoryId = 6},
                new Subcategory { Id = 12, Name = "OLED TV" , CategoryId = 6}
                );
        }
    }
}
