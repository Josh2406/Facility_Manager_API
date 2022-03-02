using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class RequestRating
    {
        public long Id { get; set; }

        public long RequestId { get; set; }

        public int Value { get; set; }

        [StringLength(150)]
        public string Comment { get; set; }

        public DateTime Created { get; set; }

        [ForeignKey("RequestId")]
        public virtual Request Request { get; set; }
    }
}
