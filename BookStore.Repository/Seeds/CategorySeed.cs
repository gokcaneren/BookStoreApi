using BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Tarih-Araştırma",
                },
                new Category
                {
                    Id = 2,
                    Name = "Bilim Kurgu",
                },
                new Category
                {
                    Id = 3,
                    Name = "Fantastik",
                },
                new Category
                {
                    Id = 4,
                    Name = "Polisiye",
                },
                new Category
                {
                    Id = 5,
                    Name = "Korku-Gerilim",
                },
                new Category
                {
                    Id = 6,
                    Name = "Gizem",
                },
                new Category
                {
                    Id = 7,
                    Name = "Eğitim",
                }
                );
        }
    }
}
