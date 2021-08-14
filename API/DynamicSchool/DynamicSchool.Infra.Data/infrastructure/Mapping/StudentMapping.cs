using DynamicSchool.Domain.Entities.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
