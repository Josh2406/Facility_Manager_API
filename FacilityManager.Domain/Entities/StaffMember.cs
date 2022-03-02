using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class StaffMember
    {
        public int Id { get; set; }

        public long UserId { get; set; }

        public int? CreatedById { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, StringLength(100)]
        public string EmailAddress { get; set; }

        [Required, StringLength(14)]
        public string PhoneNumber { get; set; }

        public DateTime Created { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("CreatedById")]
        public virtual StaffMember CreatedBy { get; set; }
    }
}
