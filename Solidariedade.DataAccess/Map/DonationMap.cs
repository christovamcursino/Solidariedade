using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Map
{
    public class DonationMap : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable("doacao");
            builder.HasKey(pk => pk.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(n => n.DonationDate)
                .HasColumnName("dt_doacao")
                .HasColumnType<DateTime>("Date");

            builder.HasMany<DonationItem>();
        }
    }
}
