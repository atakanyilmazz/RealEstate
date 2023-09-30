using RealEstate.DataAccessLayer.Repositories.Abstracts;
using RealEstate.DataAccessLayer.DbContexts;
using RealEstate.DataAccessLayer.Entities;

namespace RealEstate.DataAccessLayer.Repositories;

public class PropertyFeatureRepository : GenericRepository<PropertyFeature>, IPropertyFeatureRepository
{
    public PropertyFeatureRepository(RealEstateContext context) : base(context)
    {

    }
}