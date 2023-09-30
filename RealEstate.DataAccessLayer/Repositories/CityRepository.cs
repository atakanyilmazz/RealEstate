using RealEstate.DataAccessLayer.Repositories.Abstracts;
using RealEstate.DataAccessLayer.DbContexts;
using RealEstate.DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace RealEstate.DataAccessLayer.Repositories;

public class CityRepository : GenericRepository<City>, ICityRepository
{
    public CityRepository(RealEstateContext context) : base(context)
    {
        
    }
}