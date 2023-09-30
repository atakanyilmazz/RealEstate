using RealEstate.Common.Enum;

namespace RealEstate.Common.Dto;
public class CreatePropertyDto
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int DistrictId { get; set; }
    public decimal Price { get; set; }
    public PropertyType PropertyType { get; set; }
    public int RoomId { get; set; }
    public ICollection<PropertyFeatureDto> PropertyFeatures { get; set; } = null!;
}
