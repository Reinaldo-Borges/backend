using DynamicSchool.Domain.Entities.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicSchool.Infra.Data.infrastructure.Mapping
{
    public class StudentMapping : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(p => p.ClientId).HasColumnName("ClientOrigin");
            builder.Property(p => p.StatusEntity).HasColumnName("Status");        
            builder.ToTable("Student");
        }
    }
}
