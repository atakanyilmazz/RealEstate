using RealEstate.Common.Enum;

namespace RealEstate.Common.Dto
{
    public class SearchPropertyDto
    {
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public PropertyType PropertyType { get; set; }
        public decimal? AmountMin { get; set; }
        public decimal? AmountMax { get; set; }
        public List<int> PropertyFeatures { get; set; } = null!;
    }
}
