using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Map
{
    public class DonationItemMap : IEntityTypeConfiguration<DonationItem>
    {
        public void Configure(EntityTypeBuilder<DonationItem> builder)
        {
            builder.ToTable("item_doacao");
            builder.HasKey(pk => pk.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(n => n.Amount)
                .HasColumnName("nu_quantidade")
                .HasColumnType<int>("Integer");

            builder
                .HasOne(o => o.Product);
        }
    }
}
