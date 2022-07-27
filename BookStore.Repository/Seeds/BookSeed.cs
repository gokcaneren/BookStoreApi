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
    internal class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Name = "Haliç'te Yaşayan Simonlar",
                    AuthorName = "Hanefi Avcı",
                    CategoryId = 1,
                    Stock = 25
                },
                new Book
                {
                    Id = 2,
                    Name = "Silmarillion",
                    AuthorName = "J.R.R Tolkien",
                    CategoryId = 3,
                    Stock = 35
                },
                new Book
                {
                    Id = 3,
                    Name = "Hayvan Çiftliği",
                    AuthorName = "Stephen King",
                    CategoryId = 5,
                    Stock = 12
                }
                );
        }
    }
}
