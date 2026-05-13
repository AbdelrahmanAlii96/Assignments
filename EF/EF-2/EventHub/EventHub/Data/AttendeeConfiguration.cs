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
    internal class AttendeeConfiguration : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.ToTable("Attendees");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FullName)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.Property(a => a.Email)
                   .IsRequired()
                   .HasMaxLength(200);
        }
    }
}
