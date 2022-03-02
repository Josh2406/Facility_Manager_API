using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities.Base
{
    public class Location
    {
        public long Id { get; set; }

        [Required, StringLength(100)]
        public string Address { get; set; }

        public int AreaId { get; set; }

        public int LGAId { get; set; }

        public int StateId { get; set; }

        [Required, StringLength(20)]
        public string Telephone { get; set; }

        [Required, StringLength(100)]
        public string BusStop { get; set; }

        [ForeignKey("AreaId")]
        public virtual Area Area { get; set; }

        [ForeignKey("LGAId")]
        public virtual LGA LGA { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }
    }
}
