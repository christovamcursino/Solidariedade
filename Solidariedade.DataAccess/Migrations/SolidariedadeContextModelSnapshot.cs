﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solidariedade.DataAccess.Context;

namespace Solidariedade.DataAccess.Migrations
{
    [DbContext(typeof(SolidariedadeContext))]
    partial class SolidariedadeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donator.Donation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DonationDate")
                        .HasColumnName("dt_doacao")
                        .HasColumnType("Date");

                    b.Property<int>("DonationDeliveryType")
                        .HasColumnType("int");

                    b.Property<Guid?>("DonatorPersonId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DoneePersonId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("DonatorPersonId");

                    b.HasIndex("DoneePersonId");

                    b.ToTable("doacao");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donator.DonationItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Amount")
                        .HasColumnName("nu_quantidade")
                        .HasColumnType("Integer");

                    b.Property<Guid?>("DonationId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("DonationId");

                    b.HasIndex("ProductId");

                    b.ToTable("item_doacao");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donator.DonationProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Amount")
                        .HasColumnName("nu_quantidade")
                        .HasColumnType("integer");

                    b.Property<Guid?>("DonatorPersonId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("DonatorPersonId");

                    b.HasIndex("ProductId");

                    b.ToTable("produto_para_doacao");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donee.RequestedProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Amount")
                        .HasColumnName("nu_quantidade")
                        .HasColumnType("integer");

                    b.Property<Guid?>("DoneePersonId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("DoneePersonId");

                    b.HasIndex("ProductId");

                    b.ToTable("produto_solicitado");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnName("tx_endereco")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("City")
                        .HasColumnName("tx_cidade")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("tx_email")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("tx_nome")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("StateUF")
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.HasIndex("StateUF");

                    b.ToTable("Pessoa");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("tx_nome")
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Solidariedade.Domain.ValueObjects.State", b =>
                {
                    b.Property<string>("UF")
                        .HasColumnName("tx_uf")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("tx_nome")
                        .HasColumnType("varchar(40)");

                    b.HasKey("UF");

                    b.ToTable("Estado");

                    b.HasData(
                        new
                        {
                            UF = "AC",
                            Name = "Acre"
                        },
                        new
                        {
                            UF = "AL",
                            Name = "Alagoas"
                        },
                        new
                        {
                            UF = "AP",
                            Name = "Amapá"
                        },
                        new
                        {
                            UF = "AM",
                            Name = "Amazonas"
                        },
                        new
                        {
                            UF = "BA",
                            Name = "Bahia"
                        },
                        new
                        {
                            UF = "CE",
                            Name = "Ceará"
                        },
                        new
                        {
                            UF = "DF",
                            Name = "Distrito Federal"
                        },
                        new
                        {
                            UF = "ES",
                            Name = "Espírito Santo"
                        },
                        new
                        {
                            UF = "GO",
                            Name = "Goiás"
                        },
                        new
                        {
                            UF = "MA",
                            Name = "Maranhão"
                        },
                        new
                        {
                            UF = "MT",
                            Name = "Mato Grosso"
                        },
                        new
                        {
                            UF = "MS",
                            Name = "Mato Grosso do Sul"
                        },
                        new
                        {
                            UF = "MG",
                            Name = "Minas Gerais"
                        },
                        new
                        {
                            UF = "PA",
                            Name = "Pará"
                        },
                        new
                        {
                            UF = "PB",
                            Name = "Paraíba"
                        },
                        new
                        {
                            UF = "PR",
                            Name = "Paraná"
                        },
                        new
                        {
                            UF = "PE",
                            Name = "Pernambuco"
                        },
                        new
                        {
                            UF = "PI",
                            Name = "Piauí"
                        },
                        new
                        {
                            UF = "RJ",
                            Name = "Rio de Janeiro"
                        },
                        new
                        {
                            UF = "RN",
                            Name = "Rio Grande do Norte"
                        },
                        new
                        {
                            UF = "RS",
                            Name = "Rio Grande do Sul"
                        },
                        new
                        {
                            UF = "RO",
                            Name = "Rondônia"
                        },
                        new
                        {
                            UF = "RR",
                            Name = "Roraima"
                        },
                        new
                        {
                            UF = "SC",
                            Name = "Santa Catarina"
                        },
                        new
                        {
                            UF = "SP",
                            Name = "São Paulo"
                        },
                        new
                        {
                            UF = "SE",
                            Name = "Sergipe"
                        },
                        new
                        {
                            UF = "TO",
                            Name = "Tocantins"
                        });
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donator.DonatorPerson", b =>
                {
                    b.HasBaseType("Solidariedade.Domain.Entities.Person");

                    b.HasDiscriminator().HasValue("DonatorPerson");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donee.DoneePerson", b =>
                {
                    b.HasBaseType("Solidariedade.Domain.Entities.Person");

                    b.HasDiscriminator().HasValue("DoneePerson");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donator.Donation", b =>
                {
                    b.HasOne("Solidariedade.Domain.Entities.Donator.DonatorPerson", null)
                        .WithMany("Donations")
                        .HasForeignKey("DonatorPersonId");

                    b.HasOne("Solidariedade.Domain.Entities.Donee.DoneePerson", null)
                        .WithMany("Donations")
                        .HasForeignKey("DoneePersonId");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donator.DonationItem", b =>
                {
                    b.HasOne("Solidariedade.Domain.Entities.Donator.Donation", "Donation")
                        .WithMany("Items")
                        .HasForeignKey("DonationId");

                    b.HasOne("Solidariedade.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donator.DonationProduct", b =>
                {
                    b.HasOne("Solidariedade.Domain.Entities.Donator.DonatorPerson", "DonatorPerson")
                        .WithMany("DonationProducts")
                        .HasForeignKey("DonatorPersonId");

                    b.HasOne("Solidariedade.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Donee.RequestedProduct", b =>
                {
                    b.HasOne("Solidariedade.Domain.Entities.Donee.DoneePerson", "DoneePerson")
                        .WithMany("RequestedProducts")
                        .HasForeignKey("DoneePersonId");

                    b.HasOne("Solidariedade.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Solidariedade.Domain.Entities.Person", b =>
                {
                    b.HasOne("Solidariedade.Domain.ValueObjects.State", "State")
                        .WithMany()
                        .HasForeignKey("StateUF");
                });
#pragma warning restore 612, 618
        }
    }
}
