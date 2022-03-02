using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class Material
    {
        public int Id { get; set; }

        [Required, StringLength(250)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public decimal Cost { get; set; }

        public DateTime Created { get; set; }

        public int? CreatedById { get; set; }

        [ForeignKey("CreatedById")]
        public virtual StaffMember CreatedBy { get; set; }
    }
}
