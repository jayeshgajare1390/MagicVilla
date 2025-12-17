using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "This is the Royal Villa",
                    Rate = 200.0,
                    Sqft = 550,
                    Occupancy = 4,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8B54qX_P4gtYm1bY9U0cCdUVMy7-HEBKF3g&s",
                    Amenity = "",
                    CreatedDate = new DateTime(2024, 1, 1),
                    UpdatedDate = new DateTime(2024, 1, 1)
                },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Pool Villa",
                    Details = "This is the Premium Pool Villa",
                    Rate = 300.0,
                    Sqft = 550,
                    Occupancy = 4,
                    ImageUrl = "https://assets.cntraveller.in/photos/682d9d2b926cedc77ed0792f/1:1/w_1816,h_1816,c_limit/Malibu%20Villa.png",
                    Amenity = "",
                    CreatedDate = new DateTime(2024, 1, 1),
                    UpdatedDate = new DateTime(2024, 1, 1)
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Pool Villa",
                    Details = "This is the Luxury Pool Villa",
                    Rate = 400.0,
                    Sqft = 750,
                    Occupancy = 4,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvZb4UP2KexL_WesW7MhPk01OxXRl4qvsVIA&s",
                    Amenity = "",
                    CreatedDate = new DateTime(2024, 1, 1),
                    UpdatedDate = new DateTime(2024, 1, 1)
                },
                new Villa
                {
                    Id = 4,
                    Name = "Diamond Villa",
                    Details = "This is the Diamond Villa",
                    Rate = 550.0,
                    Sqft = 900,
                    Occupancy = 4,
                    ImageUrl = "https://www.shutterstock.com/image-illustration/3d-illustration-newly-built-luxury-260nw-2066280914.jpg",
                    Amenity = "",
                    CreatedDate = new DateTime(2024, 1, 1),
                    UpdatedDate = new DateTime(2024, 1, 1)
                }
            );
        }   
    }
}
