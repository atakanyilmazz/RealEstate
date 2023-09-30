using RealEstate.DataAccessLayer.Repositories.Abstracts;

namespace RealEstate.DataAccessLayer.Repositories.UnitOfWork.Abstracts;

public interface IUnitOfWork : IDisposable
{
    int Complete();
    ICountryRepository CountryRepository { get; }
    ICityRepository CityRepository { get; }
    IDistrictRepository DistrictRepository { get; }
    IPropertyRepository PropertyRepository { get; }
    IPropertyFeatureRepository PropertyFeatureRepository { get; }
    IRoomRepository RoomRepository { get; }
}