using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Pilot kalem",
                    CategoryId = 1,
                    Price = 100,
                    Stock = 50,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 2,
                    Name = "Dolma kalem",
                    CategoryId = 1,
                    Price = 150,
                    Stock = 65,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 3,
                    Name = "Tükenmez kalem",
                    CategoryId = 1,
                    Price = 200,
                    Stock = 55,
                    CreatedDate = DateTime.Now
                },
                new Product()
                {
                    Id = 4,
                    Name = "Kareli defter",
                    CategoryId = 3,
                    Price = 120,
                    Stock = 8
                },
                new Product()
                {
                    Id = 5,
                    Name = "Çizgili defter",
                    CategoryId = 3,
                    Price = 140,
                    Stock = 25
                },
                new Product()
                {
                    Id = 6,
                    Name = "Düz defter",
                    CategoryId = 3,
                    Price = 260,
                    Stock = 35
                },
                new Product()
                {
                    Id = 7,
                    Name = "Çizgi roman",
                    CategoryId = 2,
                    Price = 180,
                    Stock = 10
                },
                new Product()
                {
                    Id = 8,
                    Name = "Hikaye kitabı",
                    CategoryId = 2,
                    Price = 90,
                    Stock = 80
                },
                new Product()
                {
                    Id = 9,
                    Name = "Polisiye roman",
                    CategoryId = 2,
                    Price = 120,
                    Stock = 15
                }
            );
        }
    }
}
