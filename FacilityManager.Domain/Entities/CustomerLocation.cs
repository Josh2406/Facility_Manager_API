using FacilityManager.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class CustomerLocation: Location
    {
        public long CustomerId { get; set; }
       
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
