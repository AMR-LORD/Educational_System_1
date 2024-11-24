using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalSystem.DAL.Models.Config
{
    public class Lesson_CompletionsConfiguration : IEntityTypeConfiguration<Lesson_Completions>
    {
        public void Configure(EntityTypeBuilder<Lesson_Completions> builder)
        {
            builder.Property(x => x.CompletionDate)
                .HasColumnType("datetime2")
                .HasPrecision(0)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");
            builder.HasKey(x => x.ID);

        }
    }
}
