using System;
using System.ComponentModel.DataAnnotations;

namespace FacilityManager.Domain.Entities
{
    public class RequestMode
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Mode { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public DateTime Created { get; set; }
    }
}
