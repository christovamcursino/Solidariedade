using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Seed
{
    public class StateSeed : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasData(
                new State { UF = "AC", Name = "Acre" },
                new State { UF = "AL", Name = "Alagoas" },
                new State { UF = "AP", Name = "Amapá" },
                new State { UF = "AM", Name = "Amazonas" },
                new State { UF = "BA", Name = "Bahia" },
                new State { UF = "CE", Name = "Ceará" },
                new State { UF = "DF", Name = "Distrito Federal" },
                new State { UF = "ES", Name = "Espírito Santo" },
                new State { UF = "GO", Name = "Goiás" },
                new State { UF = "MA", Name = "Maranhão" },
                new State { UF = "MT", Name = "Mato Grosso" },
                new State { UF = "MS", Name = "Mato Grosso do Sul" },
                new State { UF = "MG", Name = "Minas Gerais" },
                new State { UF = "PA", Name = "Pará" },
                new State { UF = "PB", Name = "Paraíba" },
                new State { UF = "PR", Name = "Paraná" },
                new State { UF = "PE", Name = "Pernambuco" },
                new State { UF = "PI", Name = "Piauí" },
                new State { UF = "RJ", Name = "Rio de Janeiro" },
                new State { UF = "RN", Name = "Rio Grande do Norte" },
                new State { UF = "RS", Name = "Rio Grande do Sul" },
                new State { UF = "RO", Name = "Rondônia" },
                new State { UF = "RR", Name = "Roraima" },
                new State { UF = "SC", Name = "Santa Catarina" },
                new State { UF = "SP", Name = "São Paulo" },
                new State { UF = "SE", Name = "Sergipe" },
                new State { UF = "TO", Name = "Tocantins" }
                );
        }
    }
}
