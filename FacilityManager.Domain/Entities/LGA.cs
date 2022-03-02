using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class LGA
    {
        public int Id { get; set; }

        public int StateId { get; set; }

        [Required, StringLength(50)]
        public string LgaName { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("StateId")]
        public virtual State State { get; set; }
    }
}
