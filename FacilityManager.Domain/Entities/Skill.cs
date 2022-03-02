using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class Skill
    {
        public int Id { get; set; }

        [Required, StringLength(60)]
        public string SkillName { get; set; }

        public int? SkillCategoryId { get; set; }

        public int? CreatedById { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public DateTime Created { get; set; }


        [ForeignKey("SkillCategoryId")]
        public virtual ServiceCategory ServiceCategory { get; set; }

        [ForeignKey("CreatedById")]
        public virtual StaffMember CreatedBy { get; set; }
    }
}
