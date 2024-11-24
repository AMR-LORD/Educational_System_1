using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalSystem.DAL.Models.Config
{
    public class Course_EnrollmentsConfiguration : IEntityTypeConfiguration<Course_Enrollments>
    {
        public void Configure(EntityTypeBuilder<Course_Enrollments> builder)
        {
            builder.Property(x => x.EnrollmentDate)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");
            builder.HasKey(x => x.ID);

        }

    }
}
