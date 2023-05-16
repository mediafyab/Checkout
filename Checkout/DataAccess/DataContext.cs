using Checkout.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Checkout.DataAccess
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            var cnn = new SqliteConnection("Filename=:memory:");
            cnn.Open();
            optionsBuilder.UseSqlite(cnn);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Offer>()
                .ToTable("Offers");

            modelBuilder.Entity<Offer>().HasData(
                new Offer
                {
                    Id = 1,
                    Price = 169,
                    Name = "10 nr 169 kr, spara 57%",
                    Country = Country.Sweden,
                    ProductId = 2
                },
                new Offer
                {
                    Id = 3,
                    Price = 99,
                    Name = "13 nr 399 kr, spar 53%",
                    Country = Country.Norway,
                    ProductId = 4
                },
                new Offer
                {
                    Id = 5,
                    Price = 39,
                    Name = "24 nro 39 €, säästä 46%",
                    Country = Country.Finland,
                    ProductId = 6
                });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Allers",
                Description = "Sveriges största veckotidning ger dig glädje och inspiration, varje vecka.",
                ImageUrl = "https://bilder.tidningskungen.se/upl/normal500/allers-16-2023.jpg"
            }, new Product
            {
                Id = 4,
                Name = "Donald Duck & Co",
                Description = "Donald Duck er Norges mest kjente tegneserieutgivelse som kommer ut en gang i uken.",
                ImageUrl = "https://bilder.bladkongen.no/upl/normal500/donald-duck--co-9-2022.jpg"
            }, new Product
            {
                Id = 6,
                Name = "Kotiliesi",
                Description = "Kotiliesi on rakastettu naistenlehti, joka tuo iloa ja väriä arkeen.",
                ImageUrl = "https://kuvat.lehtiapaja.fi/upl/normal500/kotiliesi-10-2023.jpg"
            });
        }
    }
}
