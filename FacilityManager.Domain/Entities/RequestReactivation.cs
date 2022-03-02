using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FacilityManager.Domain.Entities
{
    public class RequestReactivation
    {
        public long Id { get; set; }

        public long RequestId { get; set; }

        public int ArtisanId { get; set; }

        [Required, StringLength(150)]
        public string Comment { get; set; }

        public DateTime LoggedOn { get; set; }

        public bool Resolved { get; set; }

        public DateTime? ResolvedOn { get; set; }

        [ForeignKey("RequestId")]
        public virtual Request Request { get; set; }

        [ForeignKey("ArtisanId")]
        public virtual StaffMember Artisan { get; set; }

    }
}
