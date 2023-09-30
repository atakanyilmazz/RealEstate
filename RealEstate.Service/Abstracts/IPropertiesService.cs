using RealEstate.Common.Dto;

namespace RealEstate.Service.Abstracts;
public interface IPropertiesService
{
    IEnumerable<PropertyDto> Get(SearchPropertyDto model);
    IEnumerable<RoomDto> GetRooms();
    bool Create(CreatePropertyDto model);
}
