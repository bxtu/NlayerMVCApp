using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nlayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Repository.Seeds
{
    internal class ProductSeeds : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product {
                    Id = 1 ,
                    Name = "Kalem1",
                    CategoryId = 1,
                    Price = 100, 
                    Stock=20, 
                    CreatedDate=DateTime.Now
                
                },
                new Product
                {
                    Id = 2,
                    Name = "Kalem2",
                    CategoryId = 1,
                    Price = 130,
                    Stock = 30,
                    CreatedDate = DateTime.Now

                },
                new Product
                {
                    Id = 3,
                    Name = "Silgi 1",
                    CategoryId = 2,
                    Price = 100,
                    Stock = 20,
                    CreatedDate = DateTime.Now

                },
                new Product
                {
                    Id = 4,
                    Name = "Silgi 2",
                    CategoryId = 2,
                    Price = 100,
                    Stock = 20,
                    CreatedDate = DateTime.Now

                });
        }
    }
}
