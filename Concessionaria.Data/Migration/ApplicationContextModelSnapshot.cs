﻿// <auto-generated />
namespace Concessionaria.API.Infrastructure.Data.Migrations;

using Concessionaria.API.Infrastructure.Data.AppData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

[DbContext(typeof(ApplicationContext))]
partial class ApplicationContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.8")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("Concessionaria.Produtos.Domain.Entities.CategoriaEntity", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(10)");

            OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<string>("Descricao")
                .IsRequired()
                .HasColumnType("NVARCHAR2(2000)");

            b.Property<string>("Nome")
                .IsRequired()
                .HasColumnType("NVARCHAR2(2000)");

            b.HasKey("Id");

            b.ToTable("tb_prod_categoria");
        });

        modelBuilder.Entity("Concessionaria.Produtos.Domain.Entities.ProdutoEntity", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER(10)");

            OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

            b.Property<int>("CategoriaId")
                .HasColumnType("NUMBER(10)");

            b.Property<string>("Descricao")
                .IsRequired()
                .HasColumnType("NVARCHAR2(2000)");

            b.Property<string>("Nome")
                .IsRequired()
                .HasColumnType("NVARCHAR2(2000)");

            b.Property<int>("Quantidade")
                .HasColumnType("NUMBER(10)");

            b.HasKey("Id");

            b.HasIndex("CategoriaId");

            b.ToTable("tb_prod_produto");
        });

        modelBuilder.Entity("Concessionaria.Produtos.Domain.Entities.ProdutoEntity", b =>
        {
            b.HasOne("Concessionaria.Produtos.Domain.Entities.CategoriaEntity", "Categoria")
                .WithMany()
                .HasForeignKey("CategoriaId")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            b.Navigation("Categoria");
        });
#pragma warning restore 612, 618
    }
}
