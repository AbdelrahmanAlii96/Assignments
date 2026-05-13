using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    //junction table from many to many relationship between Attendee and event
    internal class Registration
    {
        public DateTime RegistrationDate;
        public string? Note;
    //===================================//
        public Attendee Attendee { get; set; } = default!;
        public int AttendeeId { get; set; }

        public Event Event { get; set; }=default!;
        public int EventId { get; set; }

    }
}
