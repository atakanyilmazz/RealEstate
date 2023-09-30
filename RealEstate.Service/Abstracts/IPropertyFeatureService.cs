using RealEstate.Common.Dto;
using RealEstate.DataAccessLayer.Entities;

namespace RealEstate.Service.Abstracts
{
    public interface IPropertyFeatureService
    {
        IEnumerable<PropertyFeatureDto> Get();
    }
}
