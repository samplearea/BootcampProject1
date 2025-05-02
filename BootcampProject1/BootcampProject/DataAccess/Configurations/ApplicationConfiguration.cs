using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).IsRequired();
            builder.Property(a => a.ApplicantId).IsRequired();
            builder.Property(a => a.BootcampId).IsRequired();
            builder.Property(a => a.ApplicationState)
                   .HasConversion<string>()  // Enum'ları string olarak sakla
                   .IsRequired();
        }
    }
}
