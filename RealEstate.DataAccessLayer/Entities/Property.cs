using Microsoft.EntityFrameworkCore;
using RealEstate.Common.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.DataAccessLayer.Entities
{
    [Table("Properties")]
    public class Property : BaseEntity
    {
        [MaxLength(50)]
        public string Title { get; set; } = null!;

        [ForeignKey("District")]
        public int DistrictId { get; set; }

        [Precision(18, 2)]
        public decimal Price { get; set; }

        public PropertyType PropertyType { get; set; }

        [ForeignKey("Room")]
        public int RoomId { get; set; }


        public virtual Room Room { get; set; } = null!;
        public virtual District District { get; set; } = null!;

        public virtual ICollection<PropertyFeature> PropertyFeatures { get; set; } = null!;
    }
}
