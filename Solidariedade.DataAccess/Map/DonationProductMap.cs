using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Map
{
    public class DonationProductMap : IEntityTypeConfiguration<DonationProduct>
    {
        public void Configure(EntityTypeBuilder<DonationProduct> builder)
        {
            builder.ToTable("produto_para_doacao");
            builder.HasKey(pk => pk.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(n => n.Amount)
                .HasColumnName("nu_quantidade")
                .HasColumnType<int>("integer");
        }
    }
}
