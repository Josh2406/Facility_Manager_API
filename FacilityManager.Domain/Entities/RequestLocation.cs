using FacilityManager.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class RequestLocation: Location
    {
        public long RequestId { get; set; }

        [ForeignKey("RequestId")]
        public virtual Request Request { get; set; }
    }
}
