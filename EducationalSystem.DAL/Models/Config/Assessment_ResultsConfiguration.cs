using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalSystem.DAL.Models.Config
{
    public class Assessment_ResultsConfiguration : IEntityTypeConfiguration<Assessment_Results>
    {
        public void Configure(EntityTypeBuilder<Assessment_Results> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.AttemptDate)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

        }
    }
}
