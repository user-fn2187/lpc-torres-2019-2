﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using contasLuz.Models;

namespace contasLuz.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("contasLuz.Models.Conta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataLeitura");

                    b.Property<DateTime>("dataPagamento");

                    b.Property<int>("kwGasto");

                    b.Property<double>("mediaConsumo");

                    b.Property<int>("numeroLeitura");

                    b.Property<double>("valorPagar");

                    b.HasKey("id");

                    b.ToTable("contaLuz");
                });
#pragma warning restore 612, 618
        }
    }
}
