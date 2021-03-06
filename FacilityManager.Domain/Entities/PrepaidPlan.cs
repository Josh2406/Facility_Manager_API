using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class PrepaidPlan
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Plan { get; set; }

        [Required, StringLength(250)]
        public string Description { get; set; }

        [StringLength(50)]
        public string PlanIcon { get; set; }

        public decimal Cost { get; set; }

        public DateTime Created { get; set; }

        public int? CreatedById { get; set; }

        [ForeignKey("CreatedById")]
        public virtual StaffMember CreatedBy { get; set; }
    }
}
