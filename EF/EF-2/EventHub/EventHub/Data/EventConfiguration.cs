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
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Title).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Description).HasMaxLength(2000);
            builder.Property(e => e.MaxAttendees).IsRequired();
            builder.Property(e => e.StartDate).HasDefaultValueSql("GETDATE()");

            //one to many - organizer and events
            builder.HasOne(e => e.Organizer).WithMany(o => o.Events).HasForeignKey(e => e.OrganizerId);

            //self relationship - one to many - event and sessions 
            builder.HasOne(e => e.ParentEvent)
                   .WithMany(e => e.Sessions)
                   .HasForeignKey(e=>e.ParentEventId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
