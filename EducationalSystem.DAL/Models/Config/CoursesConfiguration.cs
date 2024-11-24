using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalSystem.DAL.Models.Config
{
    public class CoursesConfiguration : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            builder.Property(x => x.CourseTitle).HasMaxLength(50);
            builder.Property(x => x.ThumbnailURL).HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.CreatedDate)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.TotalAmount).HasPrecision(10, 2).IsRequired();
            builder.HasKey(x => x.ID);

        }
    }
}
