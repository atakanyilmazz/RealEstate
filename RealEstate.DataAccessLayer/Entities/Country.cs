using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.DataAccessLayer.Entities
{
    [Table("Countries")]
    public class Country : BaseValueEntity
    {
        public virtual ICollection<City>? Cities { get; set; }
    }
}
