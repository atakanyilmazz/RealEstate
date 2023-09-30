namespace RealEstate.Service.Abstracts
{
    public interface ILocationService
    {
        IEnumerable<KeyValuePair<int, string>> GetCountries();
        IEnumerable<KeyValuePair<int, string>> GetCities(int countryId);
        IEnumerable<KeyValuePair<int, string>> GetDistricts(int cityId);
    }
}
