﻿// <auto-generated />
using MasterDataArmazens.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DDDNetCore.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MasterDataArmazens.Domain.Armazens.Armazem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Armazens");
                });

            modelBuilder.Entity("MasterDataArmazens.Domain.Entregas.Entrega", b =>
                {
                    b.Property<string>("IdentificadorEntrega")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Active")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Armazem_ID")
                        .HasColumnType("longtext");

                    b.Property<string>("DataEntrega")
                        .HasColumnType("longtext");

                    b.Property<string>("Id")
                        .HasColumnType("longtext");

                    b.HasKey("IdentificadorEntrega");

                    b.ToTable("Entregas");
                });

            modelBuilder.Entity("MasterDataArmazens.Domain.Armazens.Armazem", b =>
                {
                    b.OwnsOne("MasterDataArmazens.Domain.Armazens.CoordenadasArmazem", "CoordenadasArmazem", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<double>("Altitude")
                                .HasColumnType("double");

                            b1.Property<double>("Latitude")
                                .HasColumnType("double");

                            b1.Property<double>("Longitude")
                                .HasColumnType("double");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("MasterDataArmazens.Domain.Armazens.DesignacaoArmazem", "DesignacaoArmazem", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("Designacao")
                                .HasColumnType("longtext");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("MasterDataArmazens.Domain.Armazens.EnderecoArmazem", "EnderecoArmazem", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("varchar(255)");

                            b1.Property<string>("Cidade")
                                .HasColumnType("longtext");

                            b1.Property<string>("Codigopostal")
                                .HasColumnType("longtext");

                            b1.Property<string>("Pais")
                                .HasColumnType("longtext");

                            b1.Property<string>("Porta")
                                .HasColumnType("longtext");

                            b1.Property<string>("Rua")
                                .HasColumnType("longtext");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.Navigation("CoordenadasArmazem");

                    b.Navigation("DesignacaoArmazem");

                    b.Navigation("EnderecoArmazem");
                });

            modelBuilder.Entity("MasterDataArmazens.Domain.Entregas.Entrega", b =>
                {
                    b.OwnsOne("MasterDataArmazens.Domain.Entregas.TempoEntrega", "TempoCarga", b1 =>
                        {
                            b1.Property<string>("EntregaIdentificadorEntrega")
                                .HasColumnType("varchar(255)");

                            b1.Property<double>("Minutos")
                                .HasColumnType("double");

                            b1.HasKey("EntregaIdentificadorEntrega");

                            b1.ToTable("Entregas");

                            b1.WithOwner()
                                .HasForeignKey("EntregaIdentificadorEntrega");
                        });

                    b.OwnsOne("MasterDataArmazens.Domain.Entregas.TempoEntrega", "TempoDescarga", b1 =>
                        {
                            b1.Property<string>("EntregaIdentificadorEntrega")
                                .HasColumnType("varchar(255)");

                            b1.Property<double>("Minutos")
                                .HasColumnType("double");

                            b1.HasKey("EntregaIdentificadorEntrega");

                            b1.ToTable("Entregas");

                            b1.WithOwner()
                                .HasForeignKey("EntregaIdentificadorEntrega");
                        });

                    b.OwnsOne("MasterDataArmazens.Domain.Entregas.MassaEntrega", "MassaEntrega", b1 =>
                        {
                            b1.Property<string>("EntregaIdentificadorEntrega")
                                .HasColumnType("varchar(255)");

                            b1.Property<double>("Valor")
                                .HasColumnType("double");

                            b1.HasKey("EntregaIdentificadorEntrega");

                            b1.ToTable("Entregas");

                            b1.WithOwner()
                                .HasForeignKey("EntregaIdentificadorEntrega");
                        });

                    b.Navigation("MassaEntrega");

                    b.Navigation("TempoCarga");

                    b.Navigation("TempoDescarga");
                });
#pragma warning restore 612, 618
        }
    }
}
