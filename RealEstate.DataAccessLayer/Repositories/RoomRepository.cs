using RealEstate.DataAccessLayer.Repositories.Abstracts;
using RealEstate.DataAccessLayer.DbContexts;
using RealEstate.DataAccessLayer.Entities;

namespace RealEstate.DataAccessLayer.Repositories;

public class RoomRepository : GenericRepository<Room>, IRoomRepository
{
    public RoomRepository(RealEstateContext context) : base(context)
    {
        
    }
}