using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Map
{
    public class RequestedProductMap : IEntityTypeConfiguration<RequestedProduct>
    {
        public void Configure(EntityTypeBuilder<RequestedProduct> builder)
        {
            builder.ToTable("produto_solicitado");
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
