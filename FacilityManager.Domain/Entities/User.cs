using System;
using System.ComponentModel.DataAnnotations;

namespace FacilityManager.Domain.Entities
{
    public class User
    {
        public long Id { get; set; }

        [Required, StringLength(100)]
        public string Username { get; set; }

        [Required, StringLength(150)]
        public string PasswordHash { get; set; }

        public bool IsActive { get; set; }

        public DateTime Created { get; set; }
    }
}
