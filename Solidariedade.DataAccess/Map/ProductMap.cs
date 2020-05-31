using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.ValueObjects;


namespace Solidariedade.DataAccess.Map
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(pk => pk.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(n => n.Name)
                .HasColumnName("tx_nome")
                .HasColumnType<string>("varchar(200)")
                .IsRequired();
        }
    }
}
