using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Persistence.Context
{
    public class CarBookContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=UdemyCarBookDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<AppRole> AppRole { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarDescription> CarDescription { get; set; }
        public DbSet<CarFeature> CarFeature { get; set; }
        public DbSet<CarPricing> CarPricing { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<FooterAddress> FooterAddress { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<RentACar> RentACar { get; set; }
        public DbSet<RentACarProcess> RentACarProcess { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<TagCloud> TagCloud { get; set; }
        public DbSet<Testimonial> Testimonial { get; set; }

    }
}
