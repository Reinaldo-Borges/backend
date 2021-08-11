using DynamicSchool.Domain.Entities.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicSchool.Infra.Data.infrastructure.Mapping
{
    public class TeacherMapping : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(p => p.StatusEntity).HasColumnName("Status");
            builder.Property(p => p.Document).HasColumnName("TeacherDocument");
            builder.ToTable("Teacher");           
            
        }
    }
}
