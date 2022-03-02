using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class PendingPayment
    {
        public int Id { get; set; }

        public long CustomerId { get; set; }

        [Required, StringLength(50)]
        public string OrderId { get; set; }

        [Required, StringLength(50)]
        public string Type { get; set; }

        [Required, StringLength(50)]
        public string RetrievalRef { get; set; }

        public DateTime Made { get; set; }

        public decimal Amount { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
