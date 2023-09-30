using AutoMapper;
using RealEstate.Common.Dto;
using RealEstate.DataAccessLayer.Entities;
using RealEstate.DataAccessLayer.Repositories.UnitOfWork.Abstracts;
using RealEstate.Service.Abstracts;
using System.Linq.Expressions;

namespace RealEstate.Service;
public class PropertiesService : IPropertiesService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _db;

    public PropertiesService(IMapper mapper, IUnitOfWork db)
    {
        _mapper = mapper;
        _db = db;
    }

    public IEnumerable<PropertyDto> Get(SearchPropertyDto model)
    {
        List<Expression<Func<Property, bool>>> filters = new List<Expression<Func<Property, bool>>>
        {
            (x) => x.PropertyType == model.PropertyType
        };

        if (model.AmountMin.HasValue)
            filters.Add(x => x.Price >= model.AmountMin);
        if (model.AmountMax.HasValue)
            filters.Add(x => x.Price <= model.AmountMax);

        if (model.DistrictId.HasValue)
            filters.Add(x => x.DistrictId == model.DistrictId);
        else if (model.CityId.HasValue)
            filters.Add(x => x.District.CityId == model.CityId);
        else if (model.CountryId.HasValue)
            filters.Add(x => x.District.City.CountryId == model.CountryId);

        if (model.PropertyFeatures.Any())
            foreach (var feature in model.PropertyFeatures)
                filters.Add(x => x.PropertyFeatures.Any(f => f.Id == feature));

        return _mapper.Map<IEnumerable<PropertyDto>>(_db.PropertyRepository.Get(filters, includeProperties: "District,District.City,District.City.Country,PropertyFeatures,Room"));
    }

    public IEnumerable<RoomDto> GetRooms()
    {
        return _mapper.Map<IEnumerable<RoomDto>>(_db.RoomRepository.Get());
    }

    public bool Create(CreatePropertyDto model)
    {
        try
        {
            var toEntity = _mapper.Map<Property>(model);
            toEntity.PropertyFeatures = _db.PropertyFeatureRepository.Get(x => model.PropertyFeatures.Select(f=>f.Id).Contains(x.Id)).ToList();
            _db.PropertyRepository.Insert(toEntity);
            _db.Complete();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
