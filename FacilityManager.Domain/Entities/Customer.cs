using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class Customer
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public char Gender { get; set; }

        [Required, StringLength(100)]
        public string EmailAddress { get; set; }

        [StringLength(100)]
        public string EmailAddress2 { get; set; }

        [Required, StringLength(14)]
        public string PhoneNumber { get; set; }

        [StringLength(14)]
        public string PhoneNumber2 { get; set; }

        public bool IsACompany { get; set; }

        public string CompanyName { get; set; }

        public DateTime Created { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
