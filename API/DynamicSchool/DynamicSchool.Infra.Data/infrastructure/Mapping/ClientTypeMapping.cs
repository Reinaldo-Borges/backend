using DynamicSchool.Domain.Entities.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicSchool.Infra.Data.infrastructure.Mapping
{
    public class ClientTypeMapping : IEntityTypeConfiguration<ClientType>
    {
        public void Configure(EntityTypeBuilder<ClientType> builder)
        {
            builder.HasMany(c => c.Clients)
                .WithOne(t => t.ClientType);

            builder.ToTable("ClientType");
        }
    }
}
