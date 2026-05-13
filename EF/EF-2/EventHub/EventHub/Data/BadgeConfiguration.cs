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
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.ToTable("Badges");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.BadgeNumber)
                   .IsRequired()
                   .HasMaxLength(200);
            builder.HasIndex(b => b.BadgeNumber).IsUnique();

            builder.HasOne(b => b.Attendee)
                   .WithOne(b => b.Badge)
                   .HasForeignKey<Badge>(b => b.AttendeeId);


        }
    }
}
