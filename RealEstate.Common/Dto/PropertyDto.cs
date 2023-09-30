using RealEstate.Common.Enum;

namespace RealEstate.Common.Dto
{
    public class PropertyDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int DistrictId { get; set; }
        public decimal Price { get; set; }
        public PropertyType PropertyType { get; set; }
        public int RoomId { get; set; }
        public DistrictDto District { get; set; } = null!;
        public ICollection<PropertyFeatureDto> PropertyFeatures { get; set; } = null!;
        public RoomDto Room { get; set; } = null!;
    }
}
