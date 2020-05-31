using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Map
{
    public class DonatorPersonMap : IEntityTypeConfiguration<DonatorPerson>
    {
        public void Configure(EntityTypeBuilder<DonatorPerson> builder)
        {

            builder.HasMany<DonationProduct>(
                n => n.DonationProducts
                );

            builder.HasMany<Donation>(
                n => n.Donations
                );
        }
    }
}
