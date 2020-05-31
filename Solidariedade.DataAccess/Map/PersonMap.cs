using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.ValueObjects;


namespace Solidariedade.DataAccess.Map
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(pk => pk.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(n => n.Email)
                .HasColumnName("tx_email")
                .HasColumnType<string>("varchar(80)")
                .IsRequired();

            builder
                .Property(n => n.Name)
                .HasColumnName("tx_nome")
                .HasColumnType<string>("varchar(200)")
                .IsRequired();

            builder
                .Property(n => n.Address)
                .HasColumnName("tx_endereco")
                .HasColumnType<string>("varchar(200)");
            
            builder
                .Property(n => n.City)
                .HasColumnName("tx_cidade")
                .HasColumnType<string>("varchar(100)");

            builder
                .HasOne<State>(n => n.State);
        }
    }
}
