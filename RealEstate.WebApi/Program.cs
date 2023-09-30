using Microsoft.EntityFrameworkCore;
using RealEstate.DataAccessLayer.DbContexts;
using RealEstate.DataAccessLayer.Repositories;
using RealEstate.DataAccessLayer.Repositories.Abstracts;
using RealEstate.DataAccessLayer.Repositories.UnitOfWork;
using RealEstate.DataAccessLayer.Repositories.UnitOfWork.Abstracts;
using RealEstate.Service;
using RealEstate.Service.Abstracts;
using RealEstate.Service.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RealEstateContext>(options =>
              options.UseSqlServer(connectionString,
        x => x.MigrationsHistoryTable("MigrationsHistory", "RealEstate")));

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<IDistrictRepository, DistrictRepository>();
builder.Services.AddScoped<IPropertyRepository, PropertyRepository>();
builder.Services.AddScoped<IPropertyFeatureRepository, PropertyFeatureRepository>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<IPropertiesService, PropertiesService>();
builder.Services.AddTransient<ILocationService, LocationService>();
builder.Services.AddTransient<IPropertyFeatureService, PropertyFeatureService>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy => policy
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()
       );
});

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
