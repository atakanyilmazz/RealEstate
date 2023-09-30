using RealEstate.DataAccessLayer.Repositories.Abstracts;
using RealEstate.DataAccessLayer.DbContexts;
using RealEstate.DataAccessLayer.Entities;

namespace RealEstate.DataAccessLayer.Repositories;

public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
{
    public PropertyRepository(RealEstateContext context) : base(context)
    {

    }
}