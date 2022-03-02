using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class Receipt
    {
        public long Id { get; set; }

        public long RequestId { get; set; }

        [Required, StringLength(30)]
        public string PayRetrievalReference { get; set; }

        public int ReceiptTypeId { get; set; }

        public DateTime PayDay { get; set; }

        public decimal Amount { get; set; }

        [ForeignKey("RequestId")]
        public virtual Request Request { get; set; }

        [ForeignKey("ReceiptTypeId")]
        public virtual ReceiptType ReceiptType { get; set; }
    }
}
