using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class ServiceCategory
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string CategoryName { get; set; }

        [Required, StringLength(150)]
        public string Description { get; set; }

        [StringLength(50)]
        public string IconName { get; set; }

        public int? CreatedById { get; set; }

        public DateTime Created { get; set; }


        [ForeignKey("CreatedById")]
        public virtual StaffMember CreateBy { get; set; }
    }
}
