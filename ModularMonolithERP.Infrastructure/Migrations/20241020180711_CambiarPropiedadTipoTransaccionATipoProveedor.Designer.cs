﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModularMonolithERP.Infrastructure.DataAccess;

#nullable disable

namespace ModularMonolithERP.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241020180711_CambiarPropiedadTipoTransaccionATipoProveedor")]
    partial class CambiarPropiedadTipoTransaccionATipoProveedor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ModularMonolithERP.Core.Entidades.SuministradorModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CIF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CapacidadProduccion")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaProveedor")
                        .HasColumnType("int");

                    b.Property<string>("CertificacionesLegales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CondicionesPago")
                        .HasColumnType("int");

                    b.Property<string>("ContratoVigente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CostosLogisticos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descuentos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DeudaActual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DiasEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("DireccionFiscal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentosLegales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailContacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUltimaAuditoria")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormasPago")
                        .HasColumnType("int");

                    b.Property<int>("FrecuenciaCompra")
                        .HasColumnType("int");

                    b.Property<decimal>("GastosEnvio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("HorarioAtencion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MetodosTransporte")
                        .HasColumnType("int");

                    b.Property<int>("MonedaPreferida")
                        .HasColumnType("int");

                    b.Property<int>("PaisOrigen")
                        .HasColumnType("int");

                    b.Property<string>("PersonaContacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlazosEntrega")
                        .HasColumnType("int");

                    b.Property<string>("PoliticasDevolucion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioProducto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequisitosRegulatorios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RiesgoProveedor")
                        .HasColumnType("int");

                    b.Property<string>("SitioWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockMinimo")
                        .HasColumnType("int");

                    b.Property<string>("TelefonoContacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoProveedor")
                        .HasColumnType("int");

                    b.Property<string>("UnidadMedida")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Suministradores");
                });

            modelBuilder.Entity("ModularMonolithERP.Core.Entidades.TransaccionModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Concepto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaTransaccion")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Importe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TipoGasto")
                        .HasColumnType("int");

                    b.Property<int?>("TipoIngreso")
                        .HasColumnType("int");

                    b.Property<int>("TipoTransaccion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Transacciones");
                });
#pragma warning restore 612, 618
        }
    }
}