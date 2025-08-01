using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SampleStore.Domain.Entities;
using System.Text.Json;

namespace SampleStore.DataAccess
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Province> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CartItem> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string citiesJson = File.ReadAllText("Cities.json");
            var cities = JsonSerializer.Deserialize<List<City>>(citiesJson);
            foreach (var city in cities!)
                builder.Entity<City>().HasData(city);

            string provincesJson = File.ReadAllText("Provinces.json");
            var provinces = JsonSerializer.Deserialize<List<Province>>(provincesJson);
            foreach (var province in provinces!)
                builder.Entity<Province>().HasData(province);

            string countriesJson = File.ReadAllText("Countries.json");
            var countries = JsonSerializer.Deserialize<List<Country>>(countriesJson);
            foreach (var country in countries!)
                builder.Entity<Country>().HasData(country);

            string categoriesJson = File.ReadAllText("Categories.json");
            var categories = JsonSerializer.Deserialize<List<Category>>(categoriesJson);
            foreach (var category in categories!)
                builder.Entity<Category>().HasData(category);

            string writersJson = File.ReadAllText("Writers.json");
            var writers = JsonSerializer.Deserialize<List<Writer>>(writersJson);
            foreach (var writer in writers!)
                builder.Entity<Writer>().HasData(writer);

            string booksJson = File.ReadAllText("Books.json");
            var books = JsonSerializer.Deserialize<List<Book>>(booksJson);
            foreach (var book in books!)
                builder.Entity<Book>().HasData(book);
        }
    }
}
