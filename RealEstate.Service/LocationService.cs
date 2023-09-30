using RealEstate.DataAccessLayer.Repositories.UnitOfWork.Abstracts;
using RealEstate.Service.Abstracts;

namespace RealEstate.Service
{
    public class LocationService : ILocationService
    {

        private readonly IUnitOfWork _db;

        public LocationService(IUnitOfWork db)
        {
            _db = db;
        }

        public IEnumerable<KeyValuePair<int, string>> GetCountries()
        {
            return _db.CountryRepository.Get().Select(c => new KeyValuePair<int, string>(c.Id, c.Value));
        }

        public IEnumerable<KeyValuePair<int, string>> GetCities(int countryId)
        {
            return _db.CityRepository.Get(c => c.CountryId == countryId).Select(c => new KeyValuePair<int, string>(c.Id, c.Value));
        }

        public IEnumerable<KeyValuePair<int, string>> GetDistricts(int cityId)
        {
            return _db.DistrictRepository.Get(d => d.CityId == cityId).Select(c => new KeyValuePair<int, string>(c.Id, c.Value));
        }
    }
}
