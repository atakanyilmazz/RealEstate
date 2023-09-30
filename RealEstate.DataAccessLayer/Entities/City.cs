using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.DataAccessLayer.Entities
{
    [Table("Cities")]
    public class City : BaseValueEntity
    {

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; } = null!;

        public virtual ICollection<District> Districts { get; set; } = null!;
    }
}
