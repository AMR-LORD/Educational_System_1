using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalSystem.DAL.Models.Config
{
    public class AssessmentConfiguration : IEntityTypeConfiguration<Assessments>
    {
        public void Configure(EntityTypeBuilder<Assessments> builder)
        {
            builder.Property(x => x.AssessmentType).HasMaxLength(100);
            builder.Property(x => x.CreatedDate)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            // Configure the foreign key for Courses with NO ACTION to avoid cascading delete/update
            builder
                .HasOne(a => a.Courses)
                .WithMany(c => c.Assessments)
                .HasForeignKey(a => a.CourseID)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascading delete/update for CourseID

            // Configure the foreign key for Lessons with NO ACTION to avoid cascading delete/update
            builder
                .HasOne(a => a.Lessons)
                .WithMany(l => l.Assessments)
                .HasForeignKey(a => a.LessonID)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascading delete/update for LessonID
        }
    }
}
