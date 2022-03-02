using System.ComponentModel.DataAnnotations;

namespace FacilityManager.Domain.Entities
{
    public class ReceiptType
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Type { get; set; }

        [StringLength(150)]
        public string Description { get; set; }
    }
}
