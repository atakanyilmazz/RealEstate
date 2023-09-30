using Microsoft.EntityFrameworkCore;
using RealEstate.Common.Enum;
using RealEstate.DataAccessLayer.Entities;

namespace RealEstate.DataAccessLayer.DbContexts;

public class RealEstateContext : DbContext
{

    public RealEstateContext(DbContextOptions<RealEstateContext> options)
        : base(options) { }

    public DbSet<Country> Country { get; set; }
    public DbSet<City> City { get; set; }
    public DbSet<District> District { get; set; }
    public DbSet<PropertyFeature> PropertyFeature { get; set; }
    public DbSet<Room> Room { get; set; }
    public DbSet<Property> Property { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Value = "Türkiye",
                CreateTime = DateTime.Now
            }, new Country
            {
                Id = 2,
                Value = "Holland",
                CreateTime = DateTime.Now
            }, new Country
            {
                Id = 3,
                Value = "France",
                CreateTime = DateTime.Now
            });

        modelBuilder.Entity<City>().HasData(
            new City()
            {
                Id = 1,
                CreateTime = DateTime.Now,
                Value = "İstanbul",
                CountryId = 1
            }, new City()
            {
                Id = 2,
                CreateTime = DateTime.Now,
                Value = "İzmir",
                CountryId = 1
            }, new City()
            {
                Id = 3,
                CreateTime = DateTime.Now,
                Value = "Antalya",
                CountryId = 1
            }, new City()
            {
                Id = 4,
                CreateTime = DateTime.Now,
                Value = "Utrecht",
                CountryId = 2
            }, new City()
            {
                Id = 5,
                CreateTime = DateTime.Now,
                Value = "Lyon",
                CountryId = 3
            });

        modelBuilder.Entity<District>().HasData(
            new District()
            {
                Id = 1,
                CreateTime = DateTime.Now,
                Value = "Sarıyer",
                CityId = 1
            }, new District()
            {
                Id = 2,
                CreateTime = DateTime.Now,
                Value = "Beşiktaş",
                CityId = 1
            }, new District()
            {
                Id = 3,
                CreateTime = DateTime.Now,
                Value = "Levent",
                CityId = 1
            }, new District()
            {
                Id = 4,
                CreateTime = DateTime.Now,
                Value = "Aliağa",
                CityId = 2
            }, new District()
            {
                Id = 5,
                CreateTime = DateTime.Now,
                Value = "Balçova",
                CityId = 2
            }, new District()
            {
                Id = 6,
                CreateTime = DateTime.Now,
                Value = "Bayındır",
                CityId = 2
            }, new District()
            {
                Id = 7,
                CreateTime = DateTime.Now,
                Value = "Alanya",
                CityId = 3
            }, new District()
            {
                Id = 8,
                CreateTime = DateTime.Now,
                Value = "Korkuteli",
                CityId = 3
            }, new District()
            {
                Id = 9,
                CreateTime = DateTime.Now,
                Value = "Muratpaşa",
                CityId = 3
            }, new District()
            {
                Id = 10,
                CreateTime = DateTime.Now,
                Value = "Amersfoort",
                CityId = 4
            }, new District()
            {
                Id = 11,
                CreateTime = DateTime.Now,
                Value = "Corse",
                CityId = 5
            });

        modelBuilder.Entity<Room>().HasData(
            new Room
            {
                Id = 1,
                CreateTime = DateTime.Now,
                Value = "1+0"
            }, new Room
            {
                Id = 2,
                CreateTime = DateTime.Now,
                Value = "1+1"
            }, new Room
            {
                Id = 3,
                CreateTime = DateTime.Now,
                Value = "2+1"
            }, new Room
            {
                Id = 4,
                CreateTime = DateTime.Now,
                Value = "3+1"
            });

        var features = new List<PropertyFeature>() {
            new PropertyFeature{
                Id = 1,
                CreateTime = DateTime.Now,
                Value = "Kombi"
            }, new PropertyFeature{
                Id = 2,
                CreateTime = DateTime.Now,
                Value = "Parke"
            }, new PropertyFeature{
                Id = 3,
                CreateTime = DateTime.Now,
                Value = "Eşyalı"
            }
        };

        modelBuilder.Entity<PropertyFeature>().HasData(features.ToArray());


        modelBuilder.Entity<Property>().HasData(
            new Property
            {
                Id = 1,
                CreateTime = DateTime.Now,
                DistrictId = 1,
                Price = 12000,
                PropertyType = PropertyType.Rent,
                Title = "Test 1",
                RoomId = 3,
            }, new Property
            {
                Id = 2,
                CreateTime = DateTime.Now,
                DistrictId = 8,
                Price = 5000,
                PropertyType = PropertyType.Rent,
                Title = "Test 2",
                RoomId = 1,
            }, new Property
            {
                Id = 3,
                CreateTime = DateTime.Now,
                DistrictId = 10,
                Price = 3000000,
                PropertyType = PropertyType.Sale,
                Title = "Test 3",
                RoomId = 1,
            }, new Property
            {
                Id = 4,
                CreateTime = DateTime.Now,
                DistrictId = 1,
                Price = 1000000,
                PropertyType = PropertyType.Sale,
                Title = "Test 4",
                RoomId = 2,
            });

        modelBuilder.Entity<Property>().HasMany(p => p.PropertyFeatures).WithMany(x => x.Properties).UsingEntity(j => j.HasData(
            new[]
            {
               new { PropertiesId = 1, PropertyFeaturesId = 1 },
               new { PropertiesId = 1, PropertyFeaturesId = 2 },
               new { PropertiesId = 1, PropertyFeaturesId = 3 },
               new { PropertiesId = 2, PropertyFeaturesId = 3 },
               new { PropertiesId = 2, PropertyFeaturesId = 2 },
               new { PropertiesId = 3, PropertyFeaturesId = 1 },
               new { PropertiesId = 3, PropertyFeaturesId = 2 },
               new { PropertiesId = 3, PropertyFeaturesId = 3 },
               new { PropertiesId = 4, PropertyFeaturesId = 1 },
            }
            ));
    }
}

