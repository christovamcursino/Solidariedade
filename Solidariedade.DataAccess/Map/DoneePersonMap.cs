using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;

namespace Solidariedade.DataAccess.Map
{
    public class DoneePersonMap : IEntityTypeConfiguration<DoneePerson>
    {
        public void Configure(EntityTypeBuilder<DoneePerson> builder)
        {
            builder.HasMany<RequestedProduct>(
                n => n.RequestedProducts
                );

            builder.HasMany<Donation>(
                n => n.Donations
                );
        }
    }
}
