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
    internal class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    UserName = "goky",
                    Password = "1995",
                    Email = "gokk@yahoo.com",
                    Role = "admin"
                },
                new User
                {
                    Id = 2,
                    UserName = "burcu",
                    Password = "1996",
                    Email = "burcuu@yahoo.com",
                    Role = "editor"
                }
                );
        }
    }
}
