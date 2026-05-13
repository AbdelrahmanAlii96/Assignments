using EventHub.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    internal class Badge
    {
        public int Id { get; set; }
        public string BadgeNumber { get; set; } = default!;
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }
        public Attendee Attendee { get; set; } = default!;
        public int AttendeeId { get; set; }
    }
}
