using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationalSystem.DAL.Models.Config
{
    public class ChoicesConfiguration : IEntityTypeConfiguration<Choices>
    {
        public void Configure(EntityTypeBuilder<Choices> builder)
        {
            builder.Property(x => x.IsCorrect).IsRequired();
            builder.Property(x => x.ChoiceText).IsRequired();
            builder.HasKey(x => x.ID);

        }
    }
}
