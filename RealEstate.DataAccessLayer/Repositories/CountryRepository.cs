using RealEstate.DataAccessLayer.Repositories.Abstracts;
using RealEstate.DataAccessLayer.DbContexts;
using RealEstate.DataAccessLayer.Entities;

namespace RealEstate.DataAccessLayer.Repositories;

public class CountryRepository : GenericRepository<Country>, ICountryRepository
{
    public CountryRepository(RealEstateContext context) : base(context)
    {
        
    }
}