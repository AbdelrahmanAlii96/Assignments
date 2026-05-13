using EventHub.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    internal class Organizer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = default!;
        [MaxLength(200)]
        public string CompanyName { get; set; }
        public VerificationStatus VerificationStatus { get; set; }
        public OrganizerProfile Profile { get; set; } = default!;

        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
