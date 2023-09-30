using System.ComponentModel.DataAnnotations;

namespace RealEstate.DataAccessLayer.Entities
{
    public class BaseValueEntity : BaseEntity
    {
        [MaxLength(50)]
        public string Value { get; set; } = null!;
    }
}
