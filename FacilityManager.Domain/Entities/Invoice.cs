using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class Invoice
    {
        public long Id { get; set; }

        [Required, StringLength(30)]
        public string InvNumber { get; set; }

        public long RequestId { get; set; }

        public decimal Amount { get; set; }

        public bool Accepted { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? PaidOn { get; set; }

        [StringLength(250)]
        public string Comment { get; set; }

        [ForeignKey("RequestId")]
        public virtual Request Request { get; set; }
    }
}
