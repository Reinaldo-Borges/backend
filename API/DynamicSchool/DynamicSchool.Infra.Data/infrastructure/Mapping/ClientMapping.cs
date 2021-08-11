using DynamicSchool.Domain.Entities.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicSchool.Infra.Data.infrastructure.Mapping
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {    

        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
               .HasOne(c => c.ClientType)
               .WithMany(c => c.Clients)
               .HasForeignKey(c => c.ClientTypeId);           
             

            builder.Property(p => p.StatusEntity).HasColumnName("Status");
            builder.Property(p => p.Document).HasColumnName("ClientDocument");          
                
            builder.ToTable("Client");
        }
    }
}
