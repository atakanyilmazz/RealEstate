using AutoMapper;
using RealEstate.Common.Dto;
using RealEstate.DataAccessLayer.Repositories.UnitOfWork.Abstracts;
using RealEstate.Service.Abstracts;

namespace RealEstate.Service
{
    public class PropertyFeatureService : IPropertyFeatureService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _db;

        public PropertyFeatureService(IMapper mapper, IUnitOfWork db)
        {
            _mapper = mapper;
            _db = db;
        }

        public IEnumerable<PropertyFeatureDto> Get()
        {
            return _mapper.Map<IEnumerable<PropertyFeatureDto>>(_db.PropertyFeatureRepository.Get());
        }
    }
}
