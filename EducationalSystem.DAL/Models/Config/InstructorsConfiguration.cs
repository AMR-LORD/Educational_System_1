﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalSystem.DAL.Models.Config
{
    public class InstructorsConfiguration : IEntityTypeConfiguration<Instructors>
    {
        public void Configure(EntityTypeBuilder<Instructors> builder)
        {
            builder.Property(x => x.PhoneNumber).HasMaxLength(11).IsRequired();
            builder.Property(x => x.BIO).HasMaxLength(100).IsRequired(false); // Optional field
            builder.HasKey(x => x.ID);

            // Configure the relationship with the many-to-many table (User_Instructor)
            builder.HasMany(i => i.User_Instructors)
                .WithOne(ui => ui.Instructors)  // Each User_Instructor belongs to one Instructor
                .HasForeignKey(ui => ui.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascading delete if needed

            // Configure the relationship with Courses (One-to-many relationship)
            builder.HasMany(i => i.Course_Instructors)  // An Instructor can have many Courses
                .WithOne(c => c.Instructors)  // Each Course has one Instructor
                .HasForeignKey(c => c.InstructorID)
                .OnDelete(DeleteBehavior.Cascade);  // Cascade delete behavior if needed
        }
    }
}
