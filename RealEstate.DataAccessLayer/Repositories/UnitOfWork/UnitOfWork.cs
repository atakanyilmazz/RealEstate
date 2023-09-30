using RealEstate.DataAccessLayer.DbContexts;
using RealEstate.DataAccessLayer.Repositories.Abstracts;
using RealEstate.DataAccessLayer.Repositories.UnitOfWork.Abstracts;

namespace RealEstate.DataAccessLayer.Repositories.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private bool _disposed;
    private readonly RealEstateContext _context;

    public UnitOfWork(RealEstateContext context,
        ICountryRepository countryRepository,
        ICityRepository cityRepository,
        IDistrictRepository districtRepository,
        IPropertyRepository propertyRepository,
        IPropertyFeatureRepository propertyFeatureRepository,
        IRoomRepository roomRepository)
    {
        _context = context;
        CountryRepository = countryRepository;
        CityRepository = cityRepository;
        DistrictRepository = districtRepository;
        PropertyRepository = propertyRepository;
        PropertyFeatureRepository = propertyFeatureRepository;
        RoomRepository = roomRepository;
    }

    public ICountryRepository CountryRepository { get; }
    public ICityRepository CityRepository { get; }
    public IDistrictRepository DistrictRepository { get; }
    public IPropertyRepository PropertyRepository { get; }
    public IPropertyFeatureRepository PropertyFeatureRepository { get; }
    public IRoomRepository RoomRepository { get; }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed && disposing)
        {
            _context.Dispose();
        }
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

}