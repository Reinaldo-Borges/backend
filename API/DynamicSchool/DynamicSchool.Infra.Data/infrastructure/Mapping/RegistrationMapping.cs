using DynamicSchool.Domain.Entities.Registrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicSchool.Infra.Data.infrastructure.Mapping
{
    public class RegistrationMapping : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasOne(r => r.Course)
                .WithMany(r => r.Registrations)
                .HasForeignKey(r => r.CourseId);

            builder.HasOne(r => r.Student)
                .WithMany(r => r.Registrations)
                .HasForeignKey(r => r.StudentId);
                
            builder.Ignore("StatusEntity");
            builder.ToTable("Registration");
        }
    }
}
