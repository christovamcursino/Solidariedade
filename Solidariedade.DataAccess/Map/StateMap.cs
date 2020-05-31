using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.ValueObjects;

namespace Solidariedade.DataAccess.Map
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("Estado");
            builder.HasKey(pk => pk.UF);

            builder
                .Property(n => n.UF)
                .HasColumnName("tx_uf")
                .HasColumnType<string>("varchar(2)")
                .IsRequired();

            builder
                .Property(n => n.Name)
                .HasColumnName("tx_nome")
                .HasColumnType<string>("varchar(40)")
                .IsRequired();
        }
    }
}
