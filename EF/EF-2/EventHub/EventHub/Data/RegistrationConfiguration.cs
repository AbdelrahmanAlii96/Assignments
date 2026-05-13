using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Data
{
    internal class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.ToTable("Registrations");
            builder.HasKey(r => new { r.AttendeeId, r.EventId });
            builder.Property(r => r.Note).HasMaxLength(500);
            builder.Property(r => r.RegistrationDate).HasDefaultValueSql("GETDATE()");

            //================
            builder.HasOne(r => r.Attendee)
                   .WithMany(r => r.Registrations)
                   .HasForeignKey(r => r.AttendeeId);
            //================
            builder.HasOne(r=>r.Event)
                   .WithMany(r=>r.Registrations)
                   .HasForeignKey(r => r.EventId);
        }
    }
}
