using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Solidariedade.DataAccess.Map;
using Solidariedade.DataAccess.Seed;
using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Context
{
    public class SolidariedadeContext : DbContext
    {
        public DbSet<State> States { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            String connectionString = Properties.Resources.db_connection_string;
            optionsBuilder
                .UseMySql(connectionString,
                             sql => sql.ServerVersion(new Version(8, 0, 19), ServerType.MySql));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonatorPerson>();
            modelBuilder.Entity<DoneePerson>();

            //Map
            modelBuilder.ApplyConfiguration(new StateMap());
            modelBuilder.ApplyConfiguration(new PersonMap());
            modelBuilder.ApplyConfiguration(new DonatorPersonMap());
            modelBuilder.ApplyConfiguration(new DoneePersonMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new DonationProductMap());
            modelBuilder.ApplyConfiguration(new RequestedProductMap());
            modelBuilder.ApplyConfiguration(new DonationMap());
            modelBuilder.ApplyConfiguration(new DonationItemMap());

            //Seed Value Objects
            modelBuilder.ApplyConfiguration(new StateSeed());

            base.OnModelCreating(modelBuilder);
        }
    }
}
