﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial.Data;

namespace Parcial.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("Parcial.Models.Inscripcion", b =>
                {
                    b.Property<int>("InscripcionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dispoibles")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Limite")
                        .HasColumnType("TEXT");

                    b.Property<string>("Semestre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tomados")
                        .HasColumnType("TEXT");

                    b.HasKey("InscripcionId");

                    b.ToTable("Inscripcion");
                });
#pragma warning restore 612, 618
        }
    }
}
