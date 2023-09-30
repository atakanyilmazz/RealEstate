using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.DataAccessLayer.Entities
{
    [Table("Districts")]
    public class District : BaseValueEntity
    {
        [ForeignKey("City")]
        public int CityId { get; set; }
        public virtual City City { get; set; } = null!;

        public virtual ICollection<Property> Properties { get; set; } = null!;
    }
}
