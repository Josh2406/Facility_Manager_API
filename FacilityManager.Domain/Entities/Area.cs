using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class Area
    {
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string AreaName { get; set; }

        public int StateId { get; set; }

        public bool IsActive { get; set; }

        public decimal CalloutFee { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }
    }
}
