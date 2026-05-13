using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    internal class OrganizerProfile
    {
        [Key]
        [ForeignKey(nameof(Organizer))]
        public int OrganizerId { get; set; }
        [MaxLength(200)]
        public string? Biography { get; set; }
        [Url]
        public string? WebsiteUrl {  get; set; }
        public string? LogoPath { get; set; }
        public Organizer Organizer { get; set; } = default!;

    }
}
