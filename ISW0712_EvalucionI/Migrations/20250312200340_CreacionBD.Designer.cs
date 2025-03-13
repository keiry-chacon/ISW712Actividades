﻿// <auto-generated />
using System;
using ISW0712_EvalucionI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ISW0712_EvalucionI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250312200340_CreacionBD")]
    partial class CreacionBD
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ISW0712_EvalucionI.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido1")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("apellido1");

                    b.Property<string>("Apellido2")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("apellido2");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("cedula");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("estado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nombre");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sexo");

                    b.HasKey("Id")
                        .HasName("pk_estudiante");

                    b.ToTable("estudiante", "evaluacion1");
                });

            modelBuilder.Entity("ISW0712_EvalucionI.Models.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EstudianteId")
                        .HasColumnType("integer")
                        .HasColumnName("estudiante_id");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("fecha");

                    b.HasKey("Id")
                        .HasName("pk_matricula");

                    b.HasIndex("EstudianteId");

                    b.ToTable("matricula", "evaluacion1");
                });

            modelBuilder.Entity("ISW0712_EvalucionI.Models.Matricula", b =>
                {
                    b.HasOne("ISW0712_EvalucionI.Models.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_matricula_estudiante");

                    b.Navigation("Estudiante");
                });
#pragma warning restore 612, 618
        }
    }
}
