using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.DataAccessLayer.Entities
{
    [Table("PropertyFeatures")]
    public class PropertyFeature : BaseValueEntity
    {
        public virtual ICollection<Property> Properties { get; set; } = null!;
    }
}
