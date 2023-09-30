using AutoMapper;
using RealEstate.Common.Dto;
using RealEstate.DataAccessLayer.Entities;

namespace RealEstate.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PropertyFeatureDto, PropertyFeature>().ReverseMap();
            CreateMap<PropertyDto, Property>().ReverseMap();
            CreateMap<CreatePropertyDto, Property>().ReverseMap();
            CreateMap<CountryDto, Country>().ReverseMap();
            CreateMap<CityDto, City>().ReverseMap();
            CreateMap<DistrictDto, District>().ReverseMap();
            CreateMap<RoomDto, Room>().ReverseMap();
        }
    }
}
