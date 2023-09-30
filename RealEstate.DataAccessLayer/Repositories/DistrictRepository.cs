using RealEstate.DataAccessLayer.Repositories.Abstracts;
using RealEstate.DataAccessLayer.DbContexts;
using RealEstate.DataAccessLayer.Entities;

namespace RealEstate.DataAccessLayer.Repositories;

public class DistrictRepository : GenericRepository<District>, IDistrictRepository
{
    public DistrictRepository(RealEstateContext context) : base(context)
    {
        
    }
}