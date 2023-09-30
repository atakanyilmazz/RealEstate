using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.DataAccessLayer.Entities
{
    [Table("RoomTypes")]
    public class Room : BaseValueEntity
    {
        public virtual ICollection<Property> Properties { get; set; } = null!;
    }
}
