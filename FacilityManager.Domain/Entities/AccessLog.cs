using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacilityManager.Domain.Entities
{
    public class AccessLog
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime FirstLogin { get; set; }
        public DateTime LastLogin { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
